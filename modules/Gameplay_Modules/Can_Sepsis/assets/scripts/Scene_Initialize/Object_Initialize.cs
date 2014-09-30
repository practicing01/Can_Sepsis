function Module_Can_Sepsis::Object_Initialize(%this)
{

%Int_Index=getRandom(0,%this.SimSet_Room_Positions.getCount()-1);

%ScriptObject_Child_F_Position=%this.SimSet_Room_Positions.getObject(%Int_Index);

%this.SimSet_Room_Positions.remove(%ScriptObject_Child_F_Position);

%Sprite_Object=new Sprite()
{

Class="Class_Survivor";

SceneLayer=16;

Position=%ScriptObject_Child_F_Position.Vector_2D_Position;

Animation="Module_Can_Sepsis:Animation_Child_F_Stand_Down";

Size=%this.Vector_2D_Child_F_Tile_Size;

CollisionCallback="true";

Collision_Shape_Index=-1;

Bool_Is_Moving=false;

FixedAngle=true;

String_Hatred_Hack="Child_F";

LinearDamping="0.5 0.5";

Module_ID_Parent=%this;

};

%Sprite_Object.Collision_Shape_Index=%Sprite_Object.createPolygonBoxCollisionShape(%Sprite_Object.Size);

//%Sprite_Object.setCollisionShapeIsSensor(%Sprite_Object.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%Sprite_Object);

/**************************************************************************************************************/

%Int_Index=getRandom(0,%this.SimSet_Room_Positions.getCount()-1);

%ScriptObject_Male_0_Position=%this.SimSet_Room_Positions.getObject(%Int_Index);

%this.SimSet_Room_Positions.remove(%ScriptObject_Male_0_Position);

%Sprite_Object=new Sprite()
{

Class="Class_Survivor";

SceneLayer=16;

Position=%ScriptObject_Male_0_Position.Vector_2D_Position;

Animation="Module_Can_Sepsis:Animation_Male_0_Stand_Down";

Size=%this.Vector_2D_Male_0_Tile_Size;

CollisionCallback="true";

Collision_Shape_Index=-1;

Bool_Is_Moving=false;

FixedAngle=true;

String_Hatred_Hack="Male_0";

LinearDamping="0.5 0.5";

Module_ID_Parent=%this;

};

%Sprite_Object.Collision_Shape_Index=%Sprite_Object.createPolygonBoxCollisionShape(%Sprite_Object.Size);

//%Sprite_Object.setCollisionShapeIsSensor(%Sprite_Object.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%Sprite_Object);

/**************************************************************************************************************/

%Int_Index=getRandom(0,%this.SimSet_Room_Positions.getCount()-1);

%ScriptObject_Ladder_Position=%this.SimSet_Room_Positions.getObject(%Int_Index);

%this.SimSet_Room_Positions.remove(%ScriptObject_Ladder_Position);

%Sprite_Object=new Sprite()
{

Class="Class_Object";

String_Type="Ladder";

SceneLayer=16;

Position=%ScriptObject_Ladder_Position.Vector_2D_Position;

Image="Module_Can_Sepsis:image_ladder";

Size=%this.Vector_2D_Ladder_Tile_Size;

CollisionCallback="true";

Collision_Shape_Index=-1;

FixedAngle=true;

Module_ID_Parent=%this;

};

%Sprite_Object.Collision_Shape_Index=%Sprite_Object.createPolygonBoxCollisionShape(%Sprite_Object.Size);

%Sprite_Object.setCollisionShapeIsSensor(%Sprite_Object.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%Sprite_Object);

/**************************************************************************************************************/

%Int_Index=getRandom(0,%this.SimSet_Room_Positions.getCount()-1);

%ScriptObject_Potion_Position=%this.SimSet_Room_Positions.getObject(%Int_Index);

%this.SimSet_Room_Positions.remove(%ScriptObject_Potion_Position);

%Sprite_Object=new Sprite()
{

Class="Class_Object";

String_Type="Potion";

SceneLayer=16;

Position=%ScriptObject_Potion_Position.Vector_2D_Position;

Image="Module_Can_Sepsis:image_potion";

Size=%this.Vector_2D_Potion_Tile_Size;

CollisionCallback="true";

Collision_Shape_Index=-1;

Module_ID_Parent=%this;

};

%Sprite_Object.Collision_Shape_Index=%Sprite_Object.createPolygonBoxCollisionShape(%Sprite_Object.Size);

%Sprite_Object.setCollisionShapeIsSensor(%Sprite_Object.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%Sprite_Object);

/**************************************************************************************************************/

for (%x=0;%x<%this.SimSet_Room_Positions.getCount();%x++)
{

%Vector_2D_Position=%this.SimSet_Room_Positions.getObject(%x).Vector_2D_Position;

%Sprite_Object=new Sprite()
{

Class="Class_Zombie";

SceneLayer=16;

Position=%Vector_2D_Position;

Animation="Module_Can_Sepsis:Animation_Zombie_Stand_Down";

Size=%this.Vector_2D_Zombie_Tile_Size;

CollisionCallback="true";

Collision_Shape_Index=-1;

Collision_Shape_Index_Trigger=-1;

Bool_Is_Moving=false;

FixedAngle=true;

Float_Angle=-90;

LinearDamping="0.5 0.5";

Module_ID_Parent=%this;

};

%Sprite_Object.Collision_Shape_Index=%Sprite_Object.createPolygonBoxCollisionShape(%Sprite_Object.Size);

//%Sprite_Object.setCollisionShapeIsSensor(%Sprite_Object.Collision_Shape_Index,true);

%Sprite_Object.Collision_Shape_Index_Trigger=%Sprite_Object.createPolygonBoxCollisionShape(%this.Vector_2D_Room_Tile_Size_Scaled);

%Sprite_Object.setCollisionShapeIsSensor(%Sprite_Object.Collision_Shape_Index_Trigger,true);

Scene_Can_Sepsis.add(%Sprite_Object);

}

%this.SimSet_Room_Positions.add(%ScriptObject_Child_F_Position);

%this.SimSet_Room_Positions.add(%ScriptObject_Male_0_Position);

%this.SimSet_Room_Positions.add(%ScriptObject_Ladder_Position);

%this.SimSet_Room_Positions.add(%ScriptObject_Potion_Position);

}
