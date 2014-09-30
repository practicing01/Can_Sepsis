function Class_Object::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Player")
{

if (%this.String_Type$="Ladder"&&%Colliding_Object.Int_Rescue_Count==3)
{

//Game Over

schedule(0,0,"Module_Can_Sepsis::Unload",Module_Can_Sepsis);

schedule(1,0,"Module_Gui_Main_Menu::Scene_Load",Module_Gui_Main_Menu);

}
else if (%this.String_Type$="Potion")
{

%this.Visible=false;

%Colliding_Object.Int_Rescue_Count++;

}

}

}
