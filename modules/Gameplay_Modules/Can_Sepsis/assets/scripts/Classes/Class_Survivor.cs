function Class_Survivor::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Player")
{

if (!%Colliding_Object.SimSet_Followers.isMember(%this))
{

%Colliding_Object.SimSet_Followers.add(%this);

%Colliding_Object.Int_Rescue_Count++;

%this.SceneGroup=1;

%this.setCollisionGroups(0);

%this.clearCollisionShapes();

%this.Collision_Shape_Index=%this.createPolygonBoxCollisionShape(%this.Size);

}

}

}

function Class_Survivor::Animate(%this,%Float_Angle,%Int_Animation_Type)
{

//Animation types:
//0=stand
//1=run
//2=melee
//3=ranged

%this.Float_Angle=%Float_Angle;

%this.Int_Animation_Type=%Int_Animation_Type;

if (%Float_Angle>=45&&%Float_Angle<135)//Up
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Stand_Up";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Run_Up";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Attack_Up";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Cast_Up";

}

}
else if (%Float_Angle<=-45&&%Float_Angle>-135)//Down
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Stand_Down";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Run_Down";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Attack_Down";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Cast_Down";

}

}
else if (%Float_Angle>=135||%Float_Angle<-135)//Left
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Stand_Left";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Run_Left";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Attack_Left";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Cast_Left";

}

}
else if (%Float_Angle<45||%Float_Angle>-45)//Right
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Stand_Right";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Run_Right";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Attack_Right";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_"@%this.String_Hatred_Hack@"_Cast_Right";

}

}

}

function Class_Survivor::onMoveToComplete(%this)
{

%this.setLinearDamping("0.5 0.5");

%this.Bool_Is_Moving=false;

%this.Animate(%this.Float_Angle,0);

}

function Class_Survivor::onAnimationEnd(%this)
{

if (%this.Bool_Is_Moving)
{

%this.Animate(%this.Float_Angle,1);

}
else
{

%this.Animate(%this.Float_Angle,0);

}

}
