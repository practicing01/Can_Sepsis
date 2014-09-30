function Module_Can_Sepsis::Unload(%this)
{

%this.Ass_Unload();

if (isObject(%this.Script_Object_Input_Controller)&&isObject(SceneWindow_Can_Sepsis))
{

SceneWindow_Can_Sepsis.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

}

if (isObject(%this.File_Top_Score))
{

%this.File_Top_Score.delete();

}

if (isObject(%this.SimSet_Room_Positions))
{

%this.SimSet_Room_Positions.deleteObjects();

%this.SimSet_Room_Positions.delete();

}

}
