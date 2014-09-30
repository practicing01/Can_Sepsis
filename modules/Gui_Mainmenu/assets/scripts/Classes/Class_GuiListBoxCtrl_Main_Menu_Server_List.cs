function Class_GuiListBoxCtrl_Main_Menu_Server_List::onDoubleClick(%this)
{

%Server_Name=%this.getItemText(%this.getSelectedItem());

%ScriptObject_Server=0;

for (%x=0;%x<Can_Sepsis.Simset_Server_List.getCount();%x++)
{

%ScriptObject=Can_Sepsis.Simset_Server_List.getObject(%x);

if (%ScriptObject.Connector_Name$=%Server_Name)
{

%ScriptObject_Server=%ScriptObject;

break;

}

}

if (%ScriptObject_Server==0){return;}

if (isObject(Can_Sepsis.GameConnection_Master_Server_Query))
{

Can_Sepsis.GameConnection_Master_Server_Query.delete("Stopping query, connecting to server.");

}

if (isObject(Can_Sepsis.GameConnection_Client_Connection))
{

Can_Sepsis.GameConnection_Client_Connection.delete("Connecting to a different server.");

}

Can_Sepsis.GameConnection_Client_Connection=new GameConnection();

Can_Sepsis.GameConnection_Client_Connection.setConnectArgs
(

$pref::Can_Sepsis::Player_Name,//Connector Name

"Client"//Connector Type

);

echo("Connecting to server:" SPC %ScriptObject_Server.Connector_Name SPC "at:" SPC %ScriptObject_Server.IP_Address);

Can_Sepsis.GameConnection_Client_Connection.connect(%ScriptObject_Server.IP_Address);

}
