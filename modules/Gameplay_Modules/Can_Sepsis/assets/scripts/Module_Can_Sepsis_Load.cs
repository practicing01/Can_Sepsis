function Module_Can_Sepsis::Load(%this)
{

%this.Ass_Load();

Scene_Can_Sepsis.clear();

%this.Scene_Current=TamlRead("./../scenes/scene.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");

Scene_Set_Custom(%this.Scene_Current);

%this.Variables_Initialize();

%this.Scene_Initialize();

}
