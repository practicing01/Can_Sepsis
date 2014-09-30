function Class_Can_Sepsis_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

SceneWindow_Can_Sepsis.setCameraZoom(SceneWindow_Can_Sepsis.getCameraZoom()+$pref::Can_Sepsis::cameraMouseZoomRate);

}

function Class_Can_Sepsis_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

SceneWindow_Can_Sepsis.setCameraZoom(SceneWindow_Can_Sepsis.getCameraZoom()-$pref::Can_Sepsis::cameraMouseZoomRate);

}
