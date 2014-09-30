function Module_Gui_Config_Menu::Set_Master_Server_IP(%this,%GuiButtonCtrl)
{

$pref::Can_Sepsis::Master_IP=%this.GuiControl_Config_Menu->GuiTextEditCtrl_IP.getText();

Can_Sepsis.Preferences_Save();

}
