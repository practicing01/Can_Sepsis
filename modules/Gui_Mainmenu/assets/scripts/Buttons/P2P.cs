function Module_Gui_Main_Menu::P2P(%this,%GuiButtonCtrl)
{

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

setNetPort(9003);//OVER NINE THOUSAND

Can_Sepsis.GameConnection_Client_Connection=new GameConnection();

Can_Sepsis.GameConnection_Client_Connection.setConnectArgs
(

$pref::Can_Sepsis::Player_Name,//Connector Name

"Client"//Connector Type

);

echo("Connecting to P2P server:" SPC $pref::Can_Sepsis::P2P_IP);

Can_Sepsis.GameConnection_Client_Connection.connect($pref::Can_Sepsis::P2P_IP);

}
