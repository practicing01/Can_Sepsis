function Class_GuiPopUpMenuCtrl_Resolution_List::onSelect(%this,%GuiButtonCtrl)
{

%String_Resolution=%this.getText();

if(setRes(%String_Resolution.X,%String_Resolution.Y,%String_Resolution.Z))
{

$pref::Video::defaultResolution = %String_Resolution.X SPC %String_Resolution.Y;

$pref::Video::windowedRes = %String_Resolution;

Can_Sepsis.Preferences_Save();

Can_Sepsis.Resolution=%String_Resolution.X SPC %String_Resolution.Y;

%Y_Times_100=100*Can_Sepsis.Resolution.Y;
%Cam_Y=%Y_Times_100/Can_Sepsis.Resolution.X;

SceneWindow_Can_Sepsis.setCameraSize(100,%Cam_Y);

Gui_Can_Sepsis_Overlay.resize(0,0,Can_Sepsis.Resolution.X,Can_Sepsis.Resolution.Y);

}

}
