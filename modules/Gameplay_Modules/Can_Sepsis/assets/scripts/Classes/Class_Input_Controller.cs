function Class_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

if (isObject(%this.Module_ID_Parent.Sprite_Player))
{

%this.Module_ID_Parent.Sprite_Player.Animate(Vector2AngleToPoint(%this.Module_ID_Parent.Sprite_Player.Position,%Vector_2D_World_Position),1);

%this.Module_ID_Parent.Sprite_Player.Bool_Is_Moving=true;

%this.Module_ID_Parent.Sprite_Player.setLinearDamping("0 0");

%this.Module_ID_Parent.Sprite_Player.moveTo(%Vector_2D_World_Position,2.5,true,false);

%Float_Angle=Vector2AngleToPoint(%Vector_2D_World_Position,%this.Module_ID_Parent.Sprite_Player.Position);

%Float_Magnitude=%this.Module_ID_Parent.Sprite_Player.Size.X;

if (%this.Module_ID_Parent.Sprite_Player.Size.X<%this.Module_ID_Parent.Sprite_Player.Size.Y)
{

%Float_Magnitude=%this.Module_ID_Parent.Sprite_Player.Size.Y;

}

for (%x=0;%x<%this.Module_ID_Parent.Sprite_Player.SimSet_Followers.getCount();%x++)
{

%Object_Follower=%this.Module_ID_Parent.Sprite_Player.SimSet_Followers.getObject(%x);

%Normalized_Projection=Vector2Direction(%Float_Angle,%Float_Magnitude*(%x+1));

%Vector_2D_Projected_Position=Vector2Add(%Vector_2D_World_Position,%Normalized_Projection);

%Object_Follower.Animate(Vector2AngleToPoint(%Object_Follower.Position,%Vector_2D_Projected_Position),1);

%Object_Follower.Bool_Is_Moving=true;

%Object_Follower.setLinearDamping("0 0");

%Object_Follower.moveTo(%Vector_2D_Projected_Position,2.25,true,false);

}

}

}
