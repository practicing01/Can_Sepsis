//client
function GameConnection::onConnectionAccepted(%this)
{

echo("GameConnection onConnectionAccepted. Handle:" SPC %this);

if (isObject(Can_Sepsis.GameConnection_Master_Server_Query)&&!Can_Sepsis.Bool_Local_Connection)//This is a query connection.
{

echo("Querying master server.");

if (isObject(Can_Sepsis.Simset_Server_List))
{

Can_Sepsis.Simset_Server_List.deleteObjects();

Module_Gui_Main_Menu.GuiControl_Main_Menu->GuiScrollCtrl_Main_Menu_Server_List->GuiListBoxCtrl_Main_Menu_Server_List.clearItems();

}

commandToServer('Master_Server_Query_Request');

}
else if (isObject(Can_Sepsis.GameConnection_Client_Connection)&&Can_Sepsis.Bool_Is_Client)//This is a client to server connection.
{

Module_Gui_Main_Menu.Scene_Unload();

Module_Lobby.Scene_Load();

}

}
