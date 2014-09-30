function Class_Zombie::Animate(%this,%Float_Angle,%Int_Animation_Type)
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

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Stand_Up";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Run_Up";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Attack_Up";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Cast_Up";

}

}
else if (%Float_Angle<=-45&&%Float_Angle>-135)//Down
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Stand_Down";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Run_Down";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Attack_Down";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Cast_Down";

}

}
else if (%Float_Angle>=135||%Float_Angle<-135)//Left
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Stand_Left";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Run_Left";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Attack_Left";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Cast_Left";

}

}
else if (%Float_Angle<45||%Float_Angle>-45)//Right
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Stand_Right";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Run_Right";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Attack_Right";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Can_Sepsis:Animation_Zombie_Cast_Right";

}

}

}

function Class_Zombie::onMoveToComplete(%this)
{
/*
%this.setLinearDamping("0.5 0.5");

%this.Bool_Is_Moving=false;

%this.Animate(%this.Float_Angle,0);
*/

%this.Animate(Vector2AngleToPoint(%this.Position,%this.Module_ID_Parent.Sprite_Player.Position),1);

%this.Bool_Is_Moving=true;

%this.setLinearDamping("0 0");

%this.moveTo(%this.Module_ID_Parent.Sprite_Player.Position,2.0,true,false);

}

function Class_Zombie::onAnimationEnd(%this)
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

function Class_Zombie::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%this.getCollisionShapeIsSensor(getWord(%Collision_Details,0)))
{

if (%Colliding_Object.class$="Class_Player")
{

%this.Animate(Vector2AngleToPoint(%this.Position,%Colliding_Object.Position),1);

%this.Bool_Is_Moving=true;

%this.setLinearDamping("0 0");

%this.moveTo(%Colliding_Object.Position,2.0,true,false);

}

}
else if (%Colliding_Object.class$="Class_Player"||%Colliding_Object.class$="Class_Survivor")
{

//Game Over

schedule(0,0,"Module_Can_Sepsis::Unload",Module_Can_Sepsis);

schedule(1,0,"Module_Gui_Main_Menu::Scene_Load",Module_Gui_Main_Menu);

}

}
