function Module_Gui_Config_Menu::Set_Player_Name(%this,%GuiButtonCtrl)
{

$pref::Can_Sepsis::Player_Name=%this.GuiControl_Config_Menu->GuiTextEditCtrl_Player_Name.getText();

Can_Sepsis.Preferences_Save();

}
