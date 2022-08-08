using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Hazard_Automation.LogicBusiness;

namespace Hazard_Automation.LogicBusiness
{
    public class EventHandlerWithStringArg : RevitEventWrapper<string>
    {
        /// <summary>
        /// The Execute override void must be present in all methods wrapped by the RevitEventWrapper.
        /// This defines what the method will do when raised externally.
        /// </summary>
        public override void Execute(UIApplication uiApp, string args)
        {
            // Do your processing here with "args"
            TaskDialog.Show("External Event", args);
        }
    }






    public class EventHandlerWithWpfArgd : RevitEventWrapper<Ui>
    {
        public override void Execute(UIApplication uiApp, Ui ui)
        {
            // SETUP

            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;
        }


    }

    public class EventHandlerWithWpfArgb : RevitEventWrapper<Ui>
    {
  
    
        public List<FamilyInstance> GetHazardModel(Document doc)
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            var GHazard = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                          .OfCategory(BuiltInCategory.OST_GenericModel)
                                                          .Cast<FamilyInstance>()
                                                          .Where(m => m.Symbol.Family.Name.Contains("BB_"));

            List<FamilyInstance> List_Hzmodel = new List<FamilyInstance>();
            foreach (var w in GHazard)
            {
                List_Hzmodel.Add(w);
            }

            return List_Hzmodel;
        }
        public void DeleteElementsHazard(Document doc)
        {
            List<FamilyInstance> Ghazard = GetHazardModel(doc);

            List<ElementId> idSelection = new List<ElementId>();

            foreach (FamilyInstance w in Ghazard)
            {
                Element e = w as Element;

                idSelection.Add(e.Id);
            }

            using (Transaction t = new Transaction(doc, "Delete element"))
            {
                t.Start();
                doc.Delete(idSelection);
                t.Commit();
            }
        }

        public override void Execute(UIApplication uiApp, Ui ui)
        {
            // SETUP
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;
            EventHandlerWithWpfArgb dw = new EventHandlerWithWpfArgb();
            dw.DeleteElementsHazard(doc);




        }

    }
    public class EventHandlerWithWpfArg : RevitEventWrapper<Ui>
    {
        public override void Execute(UIApplication uiApp, Ui ui)
        {
            // SETUP
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            bool cbWindowDataIsChecked = false;
            ui.Dispatcher.Invoke(() => cbWindowDataIsChecked = ui.Window.IsSelected);

            bool cbDoorDataIsChecked = false;
            ui.Dispatcher.Invoke(() => cbDoorDataIsChecked = ui.Doors.IsSelected);

            bool cStairDataIsChecked = false;
            ui.Dispatcher.Invoke(() => cStairDataIsChecked = ui.Stairs.IsSelected);

            bool cPilefoundationsDataIsChecked = false;
            ui.Dispatcher.Invoke(() => cPilefoundationsDataIsChecked = ui.Pile_foundations.IsSelected);
            
            bool cInternalDoorsDataIsChecked = false;
            ui.Dispatcher.Invoke(() => cInternalDoorsDataIsChecked = ui.Internal_Doors.IsSelected);

            bool cElectricequipIsChecked = false;
            ui.Dispatcher.Invoke(() => cElectricequipIsChecked = ui.Electricequip.IsSelected);

            bool cDisposalIsChecked = false;
            ui.Dispatcher.Invoke(() => cDisposalIsChecked = ui.Disposal.IsSelected);

            bool cSanitary_applianceIsChecked = false;
            ui.Dispatcher.Invoke(() => cSanitary_applianceIsChecked = ui.Sanitary_appliance.IsSelected);

            bool cWaterInstallationsIsChecked = false;
            ui.Dispatcher.Invoke(() => cWaterInstallationsIsChecked = ui.WaterInstallations.IsSelected);

            bool cFurniture_chairIsChecked = false;
            ui.Dispatcher.Invoke(() => cFurniture_chairIsChecked = ui.Furniture_chair.IsSelected);

            bool cFurniture_6241_GEIC_Training_RoomIsChecked = false;
            ui.Dispatcher.Invoke(() => cFurniture_6241_GEIC_Training_RoomIsChecked = ui.Furniture_6241_GEIC_Training_Room.IsSelected);

            bool cFurniture_6241_GEIC_Toilet_CubicleIsChecked = false;
            ui.Dispatcher.Invoke(() => cFurniture_6241_GEIC_Toilet_CubicleIsChecked = ui.Furniture_6241_GEIC_Toilet_Cubicle.IsSelected);

            bool cFurniture_RoundTableIsChecked = false;
            ui.Dispatcher.Invoke(() => cFurniture_RoundTableIsChecked = ui.Furniture_RoundTable.IsSelected);

            bool cFurniture_Work_Stations_x3IsChecked = false;
            ui.Dispatcher.Invoke(() => cFurniture_Work_Stations_x3IsChecked = ui.Furniture_Work_Stations_x3.IsSelected);

            bool cFurniture_Work_StationsIsChecked = false;
            ui.Dispatcher.Invoke(() => cFurniture_Work_StationsIsChecked = ui.Furniture_Work_Stations.IsSelected);

            bool cFurniture_Work_Chair_TaskIsChecked = false;
            ui.Dispatcher.Invoke(() => cFurniture_Work_Chair_TaskIsChecked = ui.Furniture_Work_Chair_Task.IsSelected);


            bool cExternalDoorsDataIsChecked = false;
            ui.Dispatcher.Invoke(() => cExternalDoorsDataIsChecked = ui.External_Doors.IsSelected);

            bool cStructuralfoundationIsChecked = false;
            ui.Dispatcher.Invoke(() => cStructuralfoundationIsChecked = ui.Structural_foundation.IsSelected);

            bool cfoundationslabIsChecked = false;
            ui.Dispatcher.Invoke(() => cfoundationslabIsChecked = ui.foundationslab.IsSelected);

            bool croofcoveringIsChecked = false;
            ui.Dispatcher.Invoke(() => croofcoveringIsChecked = ui.roofcovering.IsSelected);

            bool cfloorconcreteIsChecked = false;
            ui.Dispatcher.Invoke(() => cfloorconcreteIsChecked = ui.floorconcrete.IsSelected);

            bool cWallinteriorIsChecked = false;
            ui.Dispatcher.Invoke(() => cWallinteriorIsChecked = ui.Wallinterior.IsSelected);
            
            bool cWallExteriorIsChecked = false;
            ui.Dispatcher.Invoke(() => cWallExteriorIsChecked = ui.WallExterior.IsSelected);

            bool cWallExteriorbIsChecked = false;
            ui.Dispatcher.Invoke(() => cWallExteriorbIsChecked = ui.WallExteriorb.IsSelected);


            bool cretainingwallsIsChecked = false;
            ui.Dispatcher.Invoke(() => cretainingwallsIsChecked = ui.retainingwalls.IsSelected);

            bool cRooofMetalIsChecked = false;
            ui.Dispatcher.Invoke(() => cRooofMetalIsChecked = ui.RoofMetal.IsSelected);
            bool cRooftimberIsChecked = false;
            ui.Dispatcher.Invoke(() => cRooftimberIsChecked = ui.Rooftimber.IsSelected);

            bool cfloorFINISH_TIMBERIsChecked = false;
            ui.Dispatcher.Invoke(() => cfloorFINISH_TIMBERIsChecked = ui.floorFINISH_TIMBER.IsSelected);
            bool cGLAZEROOFIsChecked = false;
            ui.Dispatcher.Invoke(() => cGLAZEROOFIsChecked = ui.GLAZEROOF.IsSelected);
            bool cRoofdrainageIsChecked = false;
            ui.Dispatcher.Invoke(() => cRoofdrainageIsChecked = ui.Roofdrainage.IsSelected);
            bool cStairsIsChecked = false;
            ui.Dispatcher.Invoke(() => cStairsIsChecked = ui.Stairs.IsSelected);
            bool cFrametimberIsChecked = false;
            ui.Dispatcher.Invoke(() => cFrametimberIsChecked = ui.Frametimber.IsSelected);

            bool cWallfinishesIsChecked = false;
            ui.Dispatcher.Invoke(() => cWallfinishesIsChecked = ui.Wallfinishes.IsSelected);


            bool cfloorfinishIsChecked = false;
            ui.Dispatcher.Invoke(() => cfloorfinishIsChecked = ui.floorfinish.IsSelected);

            bool cROOFIsChecked = false;
            ui.Dispatcher.Invoke(() => cROOFIsChecked = ui.Roof.IsSelected);


            







            // METHODS
            if (cbWindowDataIsChecked)
            {
                Methods.GetWindow(doc,ui);
            }

            if (cbDoorDataIsChecked)
            {
                Methods.GetDoor(doc);
            }

            if (cPilefoundationsDataIsChecked)
            {
                Methods.Pilefoundations(doc);
            }
            if (cInternalDoorsDataIsChecked)
            {
                Methods.InternalDoors(doc);
            }

            if (cExternalDoorsDataIsChecked)
            {
                Methods.ExternalDoors(doc);
            }

            if (cElectricequipIsChecked)
            {
                Methods.Electricequip(doc);
            }
            if (cDisposalIsChecked)
            {
                Methods.Disposal(doc);
            }
            if (cSanitary_applianceIsChecked)
            {
                Methods.Sanitary_appliance(doc);
            }
            if (cWaterInstallationsIsChecked)
            {
                Methods.WaterInstallations(doc);
            }
            if (cFurniture_chairIsChecked)
            {
                Methods.Furniture_chair(doc);
            }

            if (cFurniture_6241_GEIC_Training_RoomIsChecked)
            {
                Methods.Furniture_6241_GEIC_Training_Room(doc);
            }

            if (cFurniture_6241_GEIC_Toilet_CubicleIsChecked)
            {
                Methods.Furniture_6241_GEIC_Toilet_Cubicle(doc);
            }
            if (cFurniture_RoundTableIsChecked)
            {
                Methods.Furniture_RoundTable(doc);
            }
            if (cFurniture_Work_Stations_x3IsChecked)
            {
                Methods.Furniture_Work_Stations_x3(doc);
            }
            if (cFurniture_Work_StationsIsChecked)
            {
                Methods.Furniture_Work_Stations(doc);
            }
            if (cFurniture_Work_Chair_TaskIsChecked)
            {
                Methods.Furniture_Work_Chair_Task(doc);
            }

            if (cStructuralfoundationIsChecked)
            {
                Methods.Structuralfoundation_Task(doc);
            }
            if (cfoundationslabIsChecked)
            {
                Methods.foundationslab_Task(doc);
            }

            if (croofcoveringIsChecked)
            {
                Methods.roofcovering(doc);
            }

            if (cfloorconcreteIsChecked)
            {
                Methods.floorconcrete(doc);
            }

            if (cWallinteriorIsChecked)
            {
                Methods.Wallinterior(doc);
            }
            if (cWallfinishesIsChecked)
            {
                Methods.Wallfinishes(doc);
            }
            
            if (cWallExteriorIsChecked)
            {
                Methods.WallExterior(doc);
            }
            if (cWallExteriorbIsChecked)
            {
                Methods.WallExteriorb(doc);
            }


            if (cretainingwallsIsChecked)
            {
                Methods.retainingwalls(doc);

            }
            if (cRooofMetalIsChecked)
            {
                Methods.RoofMetal(doc);
            }
            if (cRooftimberIsChecked)
            {
                Methods.Rooftimber(doc);
            }
            if (cfloorFINISH_TIMBERIsChecked)
            {
                Methods.floorFINISH_TIMBER(doc);
            }

            if (cfloorfinishIsChecked)
            {
                Methods.floorFINISH(doc);
            }


            if (cGLAZEROOFIsChecked)
            {
                Methods.GLAZEROOF(doc);
            }
            if (cROOFIsChecked)
            {
                Methods.ROOF(doc);
            }

            if (cRoofdrainageIsChecked)
            {
                Methods.Roofdrainage(doc);
            }

            if (cStairsIsChecked)
            {
                Methods.filtstairs(doc);
            }
            if (cFrametimberIsChecked)
            {
                Methods.timberframe(doc);
            }


            





        }
     

    }
}
