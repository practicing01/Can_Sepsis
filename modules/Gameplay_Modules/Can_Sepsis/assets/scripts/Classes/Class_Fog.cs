function Class_Fog::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Player")
{

%this.Visible=false;

}

}

function Class_Fog::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Player")
{

%this.Visible=true;

}

}
