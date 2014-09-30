function Module_Gui_Main_Menu::Variables_Initialize(%this)
{

Can_Sepsis.Bool_Local_Connection=false;

/******************************/

%this.GuiControl_Main_Menu=TamlRead("./../../gui/GuiControl_Main_Menu.gui.taml");

%this.GuiControl_Main_Menu.resize(0,0,Gui_Can_Sepsis_Overlay.Extent.X,Gui_Can_Sepsis_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Main_Menu,%this);

Can_Sepsis.add(%this.GuiControl_Main_Menu);

Gui_Can_Sepsis_Overlay.add(%this.GuiControl_Main_Menu);

/******************************/

}
