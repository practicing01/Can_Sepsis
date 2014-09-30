function Module_Gui_Config_Menu::Fullscreen_Toggle(%this,%GuiButtonCtrl)
{

$pref::Video::fullScreen=!$pref::Video::fullScreen;

toggleFullScreen();

Can_Sepsis.Preferences_Save();

}
