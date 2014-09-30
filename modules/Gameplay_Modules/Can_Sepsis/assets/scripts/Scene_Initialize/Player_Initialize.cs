function Module_Can_Sepsis::Player_Initialize(%this)
{

%Sprite_Object=new Sprite()
{

Class="Class_Player";

SceneLayer=16;

Position="0 0";

Animation="Module_Can_Sepsis:Animation_Sara_Stand_Down";

Size=%this.Vector_2D_Sara_Tile_Size;

CollisionCallback="true";

Collision_Shape_Index=-1;

FixedAngle=true;

Bool_Is_Moving=false;

SimSet_Followers=0;

LinearDamping="0.5 0.5";

SceneGroup=1;

Int_Rescue_Count=0;

};

%Sprite_Object.setCollisionGroups(0);

%Sprite_Object.SimSet_Followers=new SimSet();

%Sprite_Object.Collision_Shape_Index=%Sprite_Object.createPolygonBoxCollisionShape(%Sprite_Object.Size);

//%Sprite_Object.setCollisionShapeIsSensor(%Sprite_Object.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%Sprite_Object);

SceneWindow_Can_Sepsis.mount(%Sprite_Object,"0 0",0,true,false);

%this.Sprite_Player=%Sprite_Object;

}
