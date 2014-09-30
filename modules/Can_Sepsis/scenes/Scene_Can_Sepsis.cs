function Window_Create_Can_Sepsis()
{

if (!isObject(SceneWindow_Can_Sepsis))
{

new SceneWindow(SceneWindow_Can_Sepsis);   

SceneWindow_Can_Sepsis.Profile=Gui_Profile_SceneWindow_Can_Sepsis;

Canvas.setContent(SceneWindow_Can_Sepsis);                     

}

SceneWindow_Can_Sepsis.stopCameraMove();
SceneWindow_Can_Sepsis.dismount();
SceneWindow_Can_Sepsis.setViewLimitOff();
SceneWindow_Can_Sepsis.setRenderGroups(Can_Sepsis.All_Bits);
SceneWindow_Can_Sepsis.setRenderLayers(Can_Sepsis.All_Bits);
SceneWindow_Can_Sepsis.setObjectInputEventGroupFilter(Can_Sepsis.All_Bits);
SceneWindow_Can_Sepsis.setObjectInputEventLayerFilter(Can_Sepsis.All_Bits);
SceneWindow_Can_Sepsis.setUseObjectInputEvents(true);
SceneWindow_Can_Sepsis.setLockMouse(true);
SceneWindow_Can_Sepsis.setCameraPosition(0,0);
SceneWindow_Can_Sepsis.setCameraZoom(1);
SceneWindow_Can_Sepsis.setCameraAngle(0);

Can_Sepsis.Resolution=getRes();
%Y_Times_100=100*Can_Sepsis.Resolution.Y;
%Cam_Y=%Y_Times_100/Can_Sepsis.Resolution.X;

SceneWindow_Can_Sepsis.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Can_Sepsis_Overlay))
{

new GuiControl(Gui_Can_Sepsis_Overlay)
{

Position="0 0";

Extent=Can_Sepsis.Resolution;

Profile=gui_profile_modalless;

class="Class_Gui_Can_Sepsis_Overlay";

};   

SceneWindow_Can_Sepsis.addGuiControl(Gui_Can_Sepsis_Overlay);

Gui_Can_Sepsis_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Can_Sepsis()
{
    
if (isObject(SceneWindow_Can_Sepsis))
{

SceneWindow_Can_Sepsis.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Can_Sepsis()
{

if (isObject(Scene_Can_Sepsis))
{

Scene_Can_Sepsis.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Can_Sepsis))
{

error("Cannot set Can_Sepsis Scene to Window as the Scene is invalid.");
return;

}
    
SceneWindow_Can_Sepsis.setScene(Scene_Can_Sepsis);

SceneWindow_Can_Sepsis.stopCameraMove();
SceneWindow_Can_Sepsis.dismount();
SceneWindow_Can_Sepsis.setViewLimitOff();
SceneWindow_Can_Sepsis.setRenderGroups(Can_Sepsis.All_Bits);
SceneWindow_Can_Sepsis.setRenderLayers(Can_Sepsis.All_Bits);
SceneWindow_Can_Sepsis.setObjectInputEventGroupFilter(Can_Sepsis.All_Bits);
SceneWindow_Can_Sepsis.setObjectInputEventLayerFilter(Can_Sepsis.All_Bits);
SceneWindow_Can_Sepsis.setUseObjectInputEvents(true);
SceneWindow_Can_Sepsis.setLockMouse(true);
SceneWindow_Can_Sepsis.setCameraPosition(0,0);
SceneWindow_Can_Sepsis.setCameraZoom(1);
SceneWindow_Can_Sepsis.setCameraAngle(0);

Can_Sepsis.Resolution=getRes();
%Y_Times_100=100*Can_Sepsis.Resolution.Y;
%Cam_Y=%Y_Times_100/Can_Sepsis.Resolution.X;

SceneWindow_Can_Sepsis.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Can_Sepsis()
{

//Scene_Destroy_Can_Sepsis();

//new Scene(Scene_Can_Sepsis);

if (!isObject(SceneWindow_Can_Sepsis))
{

error("Can_Sepsis: did not create scene; no window available.");

//error("Can_Sepsis: Created scene but no window available.");

return;

}

Scene_Destroy_Can_Sepsis();

new Scene(Scene_Can_Sepsis);

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Can_Sepsis to use an invalid Scene.");
return;

}
   
Scene_Destroy_Can_Sepsis();

%Scene.setName("Scene_Can_Sepsis");

//%Scene.class="Class_Scene_Can_Sepsis";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
//%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Can_Sepsis::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/

function Class_Gui_Can_Sepsis_Overlay::onControlDropped(%this,%GuiControl_Target,%Vector_2D_Position)
{

%GuiControl_Target.onControlDropped(%Vector_2D_Position);

}
