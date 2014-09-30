function Module_Can_Sepsis::create(%this)
{

exec("./assets/scripts/scripts.cs");

%this.Load();

}

function Module_Can_Sepsis::destroy(%this)
{

%this.Unload();

}
