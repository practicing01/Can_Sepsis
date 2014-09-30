function Can_Sepsis::create(%this)
{

/*Core Misc*/

exec("./scripts/Misc/Misc_Initialize.cs");

initializeCanvas("Can_Sepsis");

Canvas.BackgroundColor="black";

Canvas.UseBackgroundColor=true;

initializeOpenAL();

/*Gui Init*/
exec("./gui/guiProfiles.cs");

/*Global Variables*/

exec("./scripts/Variables_Initialize.cs");

%this.Variables_Initialize();

/*Global Functions*/
exec("./scripts/Functions_Initialize/Functions_Initialize.cs");

/*Core Scene*/
exec("./scenes/Scene_Can_Sepsis.cs");

/*Network*/
exec("./scripts/Network/Network.cs");

Window_Create_Can_Sepsis();

Scene_Create_Can_Sepsis();

Can_Sepsis.add(TamlRead("./gui/ConsoleDialog.gui.taml"));

GlobalActionMap.bind(keyboard,"tilde",toggleConsole);

new RenderProxy(CannotRenderProxy)
{

Image="Can_Sepsis:CannotRender";

};

Can_Sepsis.add(CannotRenderProxy);

Can_Sepsis.Camera_Size=SceneWindow_Can_Sepsis.getCameraSize();

%Local_Time=getLocalTime();

%Local_Time=stripChars(%Local_Time,":/");

%Local_Time=getWord(%Local_Time,0)+getWord(%Local_Time,1);

setRandomSeed(%Local_Time);

/*Load Play*/
exec("./scripts/Play_Load/Play_Load.cs");

%this.Play_Load();

}

function Can_Sepsis::destroy(%this)
{
Window_Destroy_Can_Sepsis();
}
