function Module_Gui_Main_Menu::Single_Player(%this,%GuiButtonCtrl)
{

Module_Gui_Main_Menu.Scene_Unload();

ModuleDatabase.LoadExplicit( "Module_Can_Sepsis" );

Module_Can_Sepsis.Load();

return;

if (Can_Sepsis.Bool_Hosting_Server||Can_Sepsis.Bool_Hosting_Master_Server)
{

return;

}

if (isObject(Can_Sepsis.GameConnection_Master_Server_Query))
{

Can_Sepsis.GameConnection_Master_Server_Query.delete("Stopping query, connecting to server.");

}

if (isObject(Can_Sepsis.GameConnection_Client_Connection))
{

Can_Sepsis.GameConnection_Client_Connection.delete("Connecting to a different server.");

}

setNetPort(9002);//OVER NINE THOUSAND

ClientGroup.deleteObjects();//Clear clients.

Can_Sepsis.Bool_Local_Connection=true;

Can_Sepsis.Bool_Hosting_Server=true;

Module_Server.Server_Load();

Can_Sepsis.GameConnection_Client_Connection=new GameConnection();

Can_Sepsis.GameConnection_Client_Connection.setConnectArgs
(

$pref::Can_Sepsis::Player_Name,//Connector Name

"Client"//Connector Type

);

Can_Sepsis.GameConnection_Client_Connection.connectLocal();

}
