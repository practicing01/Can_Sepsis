function Module_Can_Sepsis::Fog_Initialize(%this)
{
//return;
for (%x=0;%x<%this.SimSet_Room_Positions.getCount();%x++)
{

%Vector_2D_Position=%this.SimSet_Room_Positions.getObject(%x).Vector_2D_Position;

%Sprite_Fog=new Sprite()
{

Class="Class_Fog";

SceneLayer=0;

Position=%Vector_2D_Position;

Image="Module_Can_Sepsis:image_fog";

Size=%this.Vector_2D_Fog_Tile_Size_Scaled;

CollisionCallback="true";

Collision_Shape_Index=-1;

};

%Sprite_Fog.Collision_Shape_Index=%Sprite_Fog.createPolygonBoxCollisionShape(%Sprite_Fog.Size);

%Sprite_Fog.setCollisionShapeIsSensor(%Sprite_Fog.Collision_Shape_Index,true);

Scene_Can_Sepsis.add(%Sprite_Fog);

}

}
