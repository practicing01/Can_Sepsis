function Can_Sepsis::Preferences_Save(%this)
{

%FileObject_File_Out=new FileObject();

%FileObject_File_Out.openForWrite("./../../../../preferences.cs");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::aabbOption =" SPC $pref::Can_Sepsis::aabbOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::cameraMouseZoomRate =" SPC $pref::Can_Sepsis::cameraMouseZoomRate @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::cameraTouchZoomRate =" SPC $pref::Can_Sepsis::cameraTouchZoomRate @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::collisionOption =" SPC $pref::Can_Sepsis::collisionOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::defaultBackgroundColor = \"" @ $pref::Can_Sepsis::defaultBackgroundColor @ "\";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::fpsmetricsOption =" SPC $pref::Can_Sepsis::fpsmetricsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::jointsOption =" SPC $pref::Can_Sepsis::jointsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::metricsOption =" SPC $pref::Can_Sepsis::metricsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::oobbOption =" SPC $pref::Can_Sepsis::oobbOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::positionOption =" SPC $pref::Can_Sepsis::positionOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::sleepOption =" SPC $pref::Can_Sepsis::sleepOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::sortOption =" SPC $pref::Can_Sepsis::sortOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::wireframeOption =" SPC $pref::Can_Sepsis::wireframeOption @ ";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::Player_Name = \"" @ $pref::Can_Sepsis::Player_Name @ "\";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::Master_IP = \"" @ $pref::Can_Sepsis::Master_IP @ "\";");

%FileObject_File_Out.writeLine("$pref::Can_Sepsis::P2P_IP = \"" @ $pref::Can_Sepsis::P2P_IP @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::allowOpenGL =" SPC $pref::Video::allowOpenGL @ ";");

%FileObject_File_Out.writeLine("$pref::Video::appliedPref =" SPC $pref::Video::appliedPref @ ";");

%FileObject_File_Out.writeLine("$pref::Video::clipHigh =" SPC $pref::Video::clipHigh @ ";");

%FileObject_File_Out.writeLine("$pref::Video::defaultResolution = \"" @ $pref::Video::defaultResolution @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::defaultsRenderer = \"" @ $pref::Video::defaultsRenderer @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::defaultsVendor = \"" @ $pref::Video::defaultsVendor @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::deleteContext =" SPC $pref::Video::deleteContext @ ";");

%FileObject_File_Out.writeLine("$pref::Video::disableVerticalSync =" SPC $pref::Video::disableVerticalSync @ ";");

%FileObject_File_Out.writeLine("$pref::Video::displayDevice = \"" @ $pref::Video::displayDevice @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::fullScreen =" SPC $pref::Video::fullScreen @ ";");

%FileObject_File_Out.writeLine("$pref::Video::only16 =" SPC $pref::Video::only16 @ ";");

%FileObject_File_Out.writeLine("$pref::Video::preferOpenGL =" SPC $pref::Video::preferOpenGL @ ";");

%FileObject_File_Out.writeLine("$pref::Video::profiledRenderer = \"" @ $pref::Video::profiledRenderer @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::profiledVendor = \"" @ $pref::Video::profiledVendor @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::safeModeOn =" SPC $pref::Video::safeModeOn @ ";");

%FileObject_File_Out.writeLine("$pref::Video::windowedRes = \"" @ $pref::Video::windowedRes @ "\";");

%FileObject_File_Out.writeLine("$pref::Audio::sfxVolume =" SPC $pref::Audio::sfxVolume @ ";");

%FileObject_File_Out.writeLine("$pref::Audio::musicVolume =" SPC $pref::Audio::musicVolume @ ";");

%FileObject_File_Out.writeLine("$pref::T2D::imageAssetGlobalFilterMode = \"" @ $pref::T2D::imageAssetGlobalFilterMode @ "\";");

%FileObject_File_Out.writeLine("");

%FileObject_File_Out.close();

}
