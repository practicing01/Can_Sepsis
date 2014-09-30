function Module_Can_Sepsis::Room_Initialize(%this)
{

%this.CompositeSprite_Room=new CompositeSprite()
{

SceneLayer=29;

BodyType="static";

PickingAllowed=false;

};

%this.CompositeSprite_Room.SetBatchLayout("off");
%this.CompositeSprite_Room.SetBatchSortMode("z");
%this.CompositeSprite_Room.SetBatchIsolated(true);

%Vector_2D_Floor_Offset=Vector2Mult("3 3",%this.Vector_2D_Floor_Tile_Size);

%Vector_2D_Floor_Offset_Half=Vector2Mult("0.5 0.5",%Vector_2D_Floor_Offset);

%Vector_2D_Sreen_Tile_Count="2 2";

%Vector_2D_World_Size=Vector2Mult(%Vector_2D_Sreen_Tile_Count,Can_Sepsis.Resolution);

%Vector_2D_World_Size_Half=Vector2Mult(%Vector_2D_World_Size,"0.5 0.5");

for (%v=%Vector_2D_Floor_Offset.Y;%v<(Can_Sepsis.Resolution.Y*%Vector_2D_Sreen_Tile_Count.Y)-%Vector_2D_Floor_Offset.Y;%v+=%this.Vector_2D_Room_Tile_Size.Y+%Vector_2D_Floor_Offset.Y)
{

for (%u=%Vector_2D_Floor_Offset.X;%u<(Can_Sepsis.Resolution.X*%Vector_2D_Sreen_Tile_Count.X)-%Vector_2D_Floor_Offset.X;%u+=%this.Vector_2D_Room_Tile_Size.X+%Vector_2D_Floor_Offset.X)
{

%Vector_2D_Position=Vector2Sub(%u SPC %v,%Vector_2D_World_Size_Half);

%Vector_2D_Position=Vector2Add(%Vector_2D_Position,%Vector_2D_Floor_Offset_Half);

%Vector_2D_Position=Vector2Sub(%Vector_2D_Position,%this.Vector_2D_Room_Tile_Size_Half);

%Vector_2D_Position=Vector2Mult(%Vector_2D_Position,%this.Vector_2D_World_Scale);

%this.CompositeSprite_Room.addSprite();

%this.CompositeSprite_Room.setSpriteLocalPosition(%Vector_2D_Position);

%this.CompositeSprite_Room.setSpriteSize(%this.Vector_2D_Room_Tile_Size_Scaled);

%this.CompositeSprite_Room.setSpriteImage("Module_Can_Sepsis:image_Room");

/**************************************************************************************************************/

%ScriptObject_Position=new ScriptObject()
{

Vector_2D_Position=%Vector_2D_Position;

};

%this.SimSet_Room_Positions.add(%ScriptObject_Position);

/**************************************************************************************************************/

//Collision Shapes

//Top

%SceneObject_Wall=new SceneObject()
{

BodyType="static";

Position=%Vector_2D_Position.X SPC (%Vector_2D_Position.Y+%this.Vector_2D_Room_Tile_Size_Half_Scaled.Y)-%this.Vector_2D_Floor_Tile_Size_Half_Scaled.Y;

Size=%this.Vector_2D_Room_Tile_Size_Scaled.X SPC %this.Vector_2D_Floor_Tile_Size_Scaled.Y;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

//%SceneObject_Wall.setCollisionShapeIsSensor(%SceneObject_Wall.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%SceneObject_Wall);

/**************************************************************************************************************/

//Collision Shapes

//Left

%SceneObject_Wall=new SceneObject()
{

BodyType="static";

Position=(%Vector_2D_Position.X-%this.Vector_2D_Room_Tile_Size_Half_Scaled.X)+(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X*0.5) SPC %Vector_2D_Position.Y;

Size=%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X SPC %this.Vector_2D_Room_Tile_Size_Scaled.Y;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

//%SceneObject_Wall.setCollisionShapeIsSensor(%SceneObject_Wall.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%SceneObject_Wall);

/**************************************************************************************************************/

//Collision Shapes

//Right

%SceneObject_Wall=new SceneObject()
{

BodyType="static";

Position=(%Vector_2D_Position.X+%this.Vector_2D_Room_Tile_Size_Half_Scaled.X)-(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X*0.5) SPC %Vector_2D_Position.Y;

Size=%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X SPC %this.Vector_2D_Room_Tile_Size_Scaled.Y;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

//%SceneObject_Wall.setCollisionShapeIsSensor(%SceneObject_Wall.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%SceneObject_Wall);

/**************************************************************************************************************/

//Collision Shapes

//Bottom Left

%SceneObject_Wall=new SceneObject()
{

BodyType="static";

Position=%Vector_2D_Position.X-(%this.Vector_2D_Room_Tile_Size_Half_Scaled.X*0.6) SPC (%Vector_2D_Position.Y-%this.Vector_2D_Room_Tile_Size_Half_Scaled.Y)+(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.Y*0.5);

Size=%this.Vector_2D_Room_Tile_Size_Half_Scaled.X*0.75 SPC %this.Vector_2D_Floor_Tile_Size_Half_Scaled.Y;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

//%SceneObject_Wall.setCollisionShapeIsSensor(%SceneObject_Wall.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%SceneObject_Wall);

/**************************************************************************************************************/

//Collision Shapes

//Bottom Right

%SceneObject_Wall=new SceneObject()
{

BodyType="static";

Position=%Vector_2D_Position.X+(%this.Vector_2D_Room_Tile_Size_Half_Scaled.X*0.6) SPC (%Vector_2D_Position.Y-%this.Vector_2D_Room_Tile_Size_Half_Scaled.Y)+(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.Y*0.5);

Size=%this.Vector_2D_Room_Tile_Size_Half_Scaled.X*0.75 SPC %this.Vector_2D_Floor_Tile_Size_Half_Scaled.Y;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

//%SceneObject_Wall.setCollisionShapeIsSensor(%SceneObject_Wall.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%SceneObject_Wall);

/**************************************************************************************************************/

}

}

Scene_Can_Sepsis.add(%this.CompositeSprite_Room);

}
