function Module_Can_Sepsis::Scene_Initialize(%this)
{

exec("./Scene_Initialize/Floor_Initialize.cs");

exec("./Scene_Initialize/Room_Initialize.cs");

exec("./Scene_Initialize/Fog_Initialize.cs");

exec("./Scene_Initialize/Object_Initialize.cs");

exec("./Scene_Initialize/Player_Initialize.cs");

%this.Floor_Initialize();

%this.Room_Initialize();

%this.Fog_Initialize();

%this.Object_Initialize();

%this.Player_Initialize();

SceneWindow_Can_Sepsis.setCameraZoom(2.5);

}
