function Module_Gui_Main_Menu::Server_Start(%this,%GuiButtonCtrl)
{

Can_Sepsis.Bool_Hosting_Server=!Can_Sepsis.Bool_Hosting_Server;

if (Can_Sepsis.Bool_Hosting_Server)
{

%GuiButtonCtrl.setText("Stop Server");

setNetPort(9002);//OVER NINE THOUSAND

Module_Server.Server_Load();

}
else
{

%GuiButtonCtrl.setText("Start Server");

Module_Server.Server_Unload();

}

}
