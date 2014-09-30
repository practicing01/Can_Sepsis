function Module_Can_Sepsis::Floor_Initialize(%this)
{

%this.CompositeSprite_Floor=new CompositeSprite()
{

SceneLayer=30;

BodyType="static";

PickingAllowed=false;

};

%this.CompositeSprite_Floor.SetBatchLayout("off");
%this.CompositeSprite_Floor.SetBatchSortMode("z");
%this.CompositeSprite_Floor.SetBatchIsolated(true);

%Vector_2D_Sreen_Tile_Count="2 2";

%Vector_2D_World_Size=Vector2Mult(%Vector_2D_Sreen_Tile_Count,Can_Sepsis.Resolution);

%Vector_2D_World_Size_Half=Vector2Mult(%Vector_2D_World_Size,"0.5 0.5");

for (%v=0;%v<Can_Sepsis.Resolution.Y*%Vector_2D_Sreen_Tile_Count.Y;%v+=%this.Vector_2D_Floor_Tile_Size.Y)
{

for (%u=0;%u<Can_Sepsis.Resolution.X*%Vector_2D_Sreen_Tile_Count.X;%u+=%this.Vector_2D_Floor_Tile_Size.X)
{

%Vector_2D_Position=Vector2Sub(%u SPC %v,%Vector_2D_World_Size_Half);

%Vector_2D_Position=Vector2Sub(%Vector_2D_Position,%this.Vector_2D_Floor_Tile_Size_Half);

%Vector_2D_Position=Vector2Mult(%Vector_2D_Position,%this.Vector_2D_World_Scale);

%this.CompositeSprite_Floor.addSprite();

%this.CompositeSprite_Floor.setSpriteLocalPosition(%Vector_2D_Position);

%this.CompositeSprite_Floor.setSpriteSize(%this.Vector_2D_Floor_Tile_Size_Scaled);

%this.CompositeSprite_Floor.setSpriteImage("Module_Can_Sepsis:image_floor");

}

}

Scene_Can_Sepsis.add(%this.CompositeSprite_Floor);

/**************************************************************************************************************/

%Vector_2D_World_Size_Scaled=Vector2Mult(%Vector_2D_World_Size,%this.Vector_2D_World_Scale);

%Vector_2D_World_Size_Half_Scaled=Vector2Mult(%Vector_2D_World_Size_Half,%this.Vector_2D_World_Scale);

/**************************************************************************************************************/

//Collision Shapes

//Top

%SceneObject_Wall=new SceneObject()
{

BodyType="static";

Position=0-(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X*2) SPC (0+%Vector_2D_World_Size_Half_Scaled.Y)/*-%this.Vector_2D_Floor_Tile_Size_Half_Scaled.Y*/;

Size=%Vector_2D_World_Size_Scaled.X SPC %this.Vector_2D_Floor_Tile_Size_Scaled.Y;

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

Position=(0-%Vector_2D_World_Size_Half_Scaled.X)-(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X*3) SPC 0-(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.Y);

Size=%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X SPC %Vector_2D_World_Size_Scaled.Y;

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

Position=(0+%Vector_2D_World_Size_Half_Scaled.X)-(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X) SPC 0-(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.Y);

Size=%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X SPC %Vector_2D_World_Size_Scaled.Y;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

//%SceneObject_Wall.setCollisionShapeIsSensor(%SceneObject_Wall.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%SceneObject_Wall);

/**************************************************************************************************************/

//Collision Shapes

//Bottom

%SceneObject_Wall=new SceneObject()
{

BodyType="static";

Position=0-(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.X*2) SPC (0-%Vector_2D_World_Size_Half_Scaled.Y)-(%this.Vector_2D_Floor_Tile_Size_Half_Scaled.Y*3);

Size=%Vector_2D_World_Size_Scaled.X SPC %this.Vector_2D_Floor_Tile_Size_Scaled.Y;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

//%SceneObject_Wall.setCollisionShapeIsSensor(%SceneObject_Wall.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%SceneObject_Wall);

/**************************************************************************************************************/

}
