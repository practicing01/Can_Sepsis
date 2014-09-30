function Class_Player::Animate(%this,%Float_Angle,%Int_Animation_Type)
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

%this.Animation="Module_Can_Sepsis:Animation_Sara_Stand_Up";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Run_Up";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Attack_Up";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Cast_Up";

}

}
else if (%Float_Angle<=-45&&%Float_Angle>-135)//Down
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Stand_Down";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Run_Down";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Attack_Down";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Cast_Down";

}

}
else if (%Float_Angle>=135||%Float_Angle<-135)//Left
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Stand_Left";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Run_Left";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Attack_Left";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Cast_Left";

}

}
else if (%Float_Angle<45||%Float_Angle>-45)//Right
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Stand_Right";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Run_Right";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Attack_Right";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_Sara_Cast_Right";

}

}

}

function Class_Player::onCollision(%this,%Colliding_Object,%Collision_Details)
{

//echo("Class_Player onCollision");

}

function Class_Player::onMoveToComplete(%this)
{

%this.setLinearDamping("0.5 0.5");

%this.Bool_Is_Moving=false;

%this.Animate(%this.Float_Angle,0);

}

function Class_Player::onAnimationEnd(%this)
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

function Class_Player::onRemove(%this)
{

if (isObject(%this.SimSet_Followers))
{

%this.SimSet_Followers.delete();

}

}