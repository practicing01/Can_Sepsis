function Module_Can_Sepsis::Variables_Initialize(%this)
{

%this.Vector_2D_World_Scale=SceneWindow_Can_Sepsis.getCameraWorldScale();

/**************************************************************************************************************/

%this.Vector_2D_Floor_Tile_Size=%this.Ass_Image_Floor.getCellWidth() SPC %this.Ass_Image_Floor.getCellHeight();

%this.Vector_2D_Floor_Tile_Size_Half=Vector2Mult(%this.Vector_2D_Floor_Tile_Size,"0.5 0.5");

%this.Vector_2D_Floor_Tile_Size_Scaled=Vector2Mult(%this.Vector_2D_Floor_Tile_Size,%this.Vector_2D_World_Scale);

%this.Vector_2D_Floor_Tile_Size_Half_Scaled=Vector2Mult(%this.Vector_2D_Floor_Tile_Size_Half,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

%this.Vector_2D_Room_Tile_Size=%this.Ass_Image_Room.getCellWidth() SPC %this.Ass_Image_Room.getCellHeight();

%this.Vector_2D_Room_Tile_Size_Half=Vector2Mult(%this.Vector_2D_Room_Tile_Size,"0.5 0.5");

%this.Vector_2D_Room_Tile_Size_Scaled=Vector2Mult(%this.Vector_2D_Room_Tile_Size,%this.Vector_2D_World_Scale);

%this.Vector_2D_Room_Tile_Size_Half_Scaled=Vector2Mult(%this.Vector_2D_Room_Tile_Size_Half,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

%this.Vector_2D_Fog_Tile_Size=%this.Ass_Image_Fog.getCellWidth() SPC %this.Ass_Image_Fog.getCellHeight();

%this.Vector_2D_Fog_Tile_Size_Half=Vector2Mult(%this.Vector_2D_Fog_Tile_Size,"0.5 0.5");

%this.Vector_2D_Fog_Tile_Size_Scaled=Vector2Mult(%this.Vector_2D_Fog_Tile_Size,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

%this.Vector_2D_Ladder_Tile_Size=%this.Ass_Image_Ladder.getCellWidth() SPC %this.Ass_Image_Ladder.getCellHeight();

%this.Vector_2D_Ladder_Tile_Size=Vector2Mult(%this.Vector_2D_Ladder_Tile_Size,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

//%this.Vector_2D_Potion_Tile_Size=%this.Ass_Image_Potion.getCellWidth() SPC %this.Ass_Image_Potion.getCellHeight();

%this.Vector_2D_Potion_Tile_Size="16 16";

%this.Vector_2D_Potion_Tile_Size=Vector2Mult(%this.Vector_2D_Potion_Tile_Size,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

%this.Vector_2D_Child_F_Tile_Size=%this.Ass_Image_Child_F.getCellWidth() SPC %this.Ass_Image_Child_F.getCellHeight();

%this.Vector_2D_Child_F_Tile_Size=Vector2Mult(%this.Vector_2D_Child_F_Tile_Size,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

%this.Vector_2D_Male_0_Tile_Size=%this.Ass_Image_Male_0.getCellWidth() SPC %this.Ass_Image_Male_0.getCellHeight();

%this.Vector_2D_Male_0_Tile_Size=Vector2Mult(%this.Vector_2D_Male_0_Tile_Size,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

%this.Vector_2D_Sara_Tile_Size=%this.Ass_Image_Sara.getCellWidth() SPC %this.Ass_Image_Sara.getCellHeight();

%this.Vector_2D_Sara_Tile_Size=Vector2Mult(%this.Vector_2D_Sara_Tile_Size,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

%this.Vector_2D_Zombie_Tile_Size=%this.Ass_Image_Zombie.getCellWidth() SPC %this.Ass_Image_Zombie.getCellHeight();

%this.Vector_2D_Zombie_Tile_Size=Vector2Mult(%this.Vector_2D_Zombie_Tile_Size,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

%this.SimSet_Room_Positions=new SimSet();

/**************************************************************************************************************/

%this.Vector_2D_Camera_Size=SceneWindow_Can_Sepsis.getCameraSize();

%this.Vector_2D_Camera_Size_Half=Vector2Mult(%this.Vector_2D_Camera_Size,"0.5 0.5");

/**************************************************************************************************************/

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Input_Controller";

Module_ID_Parent=%this;

};

SceneWindow_Can_Sepsis.addInputListener(%this.Script_Object_Input_Controller);

/**************************************************************************************************************/

%this.Sprite_Player=0;

/**************************************************************************************************************/
/*
%this.GuiTextCtrl_Score=new GuiTextCtrl()
{

Profile="Gui_Profile_Modalless_Text";

Text="Score: 0";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent="100 40";

MaxLength="21";

Module_ID_Parent=%this;

Int_Score=0;

};

Gui_Can_Sepsis_Overlay.addGuiControl(%this.GuiTextCtrl_Score);
*/
/**************************************************************************************************************/
/*
%this.File_Top_Score=new FileObject();

%this.File_Top_Score.OpenForRead("./Top_Score.txt");

%Int_Top_Score=%this.File_Top_Score.readline();

%this.File_Top_Score.close();

%this.GuiTextCtrl_High_Score=new GuiTextCtrl()
{

Profile="Gui_Profile_Modalless_Text";

Text="High Score:" SPC %Int_Top_Score;

HorizSizing="relative";

VertSizing="relative";

Position="600 0";

Extent="200 40";

MaxLength="21";

Module_ID_Parent=%this;

Int_Score=%Int_Top_Score;

};

Gui_Can_Sepsis_Overlay.addGuiControl(%this.GuiTextCtrl_High_Score);
*/
/**************************************************************************************************************/

//Return to Main Menu button.
/*
%this.GuiButtonCtrl_MainMenu=new GuiButtonCtrl()
{

class="Class_GuiButtonCtrl_Module_Can_Sepsis";

String_Action="Main_Menu";

Profile="Black_0ButtonProfile";

Text="X";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="760 0";

Extent="40 40";

Module_ID_Parent=%this;

};

Gui_Can_Sepsis_Overlay.add(%this.GuiButtonCtrl_MainMenu);
*/

}
