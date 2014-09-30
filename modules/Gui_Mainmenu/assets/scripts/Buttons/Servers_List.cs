function Module_Gui_Main_Menu::Servers_List(%this,%GuiButtonCtrl)
{

//queryLanServers(0,0,"","",0,0,0,0,0,0,0);return;

//querySingleServer("192.168.1.100:9001","");return;

if (Can_Sepsis.Bool_Hosting_Server||Can_Sepsis.Bool_Hosting_Master_Server)
{

return;

}

if (!isObject(Can_Sepsis.GameConnection_Master_Server_Query))
{

setNetPort(9003);//OVER NINE THOUSAND

Can_Sepsis.GameConnection_Master_Server_Query=new GameConnection();

Can_Sepsis.GameConnection_Master_Server_Query.setConnectArgs
(

$pref::Can_Sepsis::Player_Name,//Connector Name

"Client"//Connector Type

);

if (Can_Sepsis.Bool_Local_Connection)
{

echo("Can't query master server, this is a local connection.");

}
else
{

echo("Connecting to the master server for query.");

Can_Sepsis.GameConnection_Master_Server_Query.connect($pref::Can_Sepsis::Master_IP);

}

}

}
