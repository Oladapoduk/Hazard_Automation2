using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Hazard_Automation.LogicBusiness;

namespace Hazard_Automation.LogicBusiness
{
    public class EventHandlerWithWpfArgc : RevitEventWrapper<Ui>
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

            bool cWallFinishesIsChecked = false;
            ui.Dispatcher.Invoke(() => cWallFinishesIsChecked = ui.Wallfinishes.IsSelected);
            bool cfloorfinishIsChecked = false;
            ui.Dispatcher.Invoke(() => cfloorfinishIsChecked = ui.floorfinish.IsSelected);


            bool cROOFIsChecked = false;
            ui.Dispatcher.Invoke(() => cROOFIsChecked = ui.Roof.IsSelected);


 



            if (cbWindowDataIsChecked)
            {
                //Methods_Risks.Getwindowsrisk(ui, doc);
                Methods_Risks.GetwindowsriskTable(ui, doc);
            }

            if (cPilefoundationsDataIsChecked)
            {
                Methods_Risks.Pilefoundations_riskTable(ui, doc);
            }
            if (cInternalDoorsDataIsChecked)
            {
                Methods_Risks.InternalDoors_riskTable(ui, doc);
            }
            if (cExternalDoorsDataIsChecked)
            {
                Methods_Risks.ExternalDoors_riskTable(ui, doc);
            }
            if (cElectricequipIsChecked)
            {
                Methods_Risks.Electricequip_riskTable(ui, doc);
            }
            if (cDisposalIsChecked)
            {
                Methods_Risks.Disposal_riskTable(ui, doc);
            }
            if (cSanitary_applianceIsChecked)
            {
                Methods_Risks.Sanitary_appliance_riskTable(ui, doc);
            }
            if (cSanitary_applianceIsChecked)
            {
                Methods_Risks.WaterInstallations_riskTable(ui, doc);
            }
            if (cSanitary_applianceIsChecked)
            {
                Methods_Risks.Furniture_chair_riskTable(ui, doc);
            }
            if (cFurniture_6241_GEIC_Training_RoomIsChecked)
            {
                Methods_Risks.Furniture_6241_GEIC_Training_Room_riskTable(ui, doc);
            }
            if (cFurniture_6241_GEIC_Toilet_CubicleIsChecked)
            {
                Methods_Risks.Furniture_6241_GEIC_Toilet_Cubicle_riskTable(ui, doc);
            }
            if (cFurniture_RoundTableIsChecked)
            {
                Methods_Risks.Furniture_RoundTable_riskTable(ui, doc);
            }
            if (cFurniture_Work_Stations_x3IsChecked)
            {
                Methods_Risks.Furniture_Work_Stations_x3_riskTable(ui, doc);
            }
            if (cFurniture_Work_StationsIsChecked)
            {
                Methods_Risks.Furniture_Work_Stations_riskTable(ui, doc);
            }
            if (cFurniture_Work_Chair_TaskIsChecked)
            {
                Methods_Risks.Furniture_Work_Chair_Task_riskTable(ui, doc);
            }
            if (cStructuralfoundationIsChecked)
            {
                Methods_Risks.GetStructuralfoundationTable(ui, doc);
            }
            if (cfoundationslabIsChecked)
            {
                Methods_Risks.foundationslab_riskTable(ui, doc);
            }

            if (croofcoveringIsChecked)
            {
                Methods_Risks.roofcovering_Task_riskTable(ui, doc);
            }
            if (cfloorconcreteIsChecked)
            {
                Methods_Risks.floorconcrete(ui, doc);
            }
            if (cWallinteriorIsChecked)
            {
                Methods_Risks.Wallinterior_Task_riskTable(ui, doc);
            }
            if (cWallExteriorIsChecked)
            {
                Methods_Risks.Wallexterior_Task_riskTable(ui, doc);
            }

            if (cWallExteriorbIsChecked)
            {
                Methods_Risks.Wallexterior_Task_riskTable(ui, doc);
               // Methods.WallExteriorb(doc);
            }


            if (cretainingwallsIsChecked)
            {
                Methods_Risks.Retaining_walls_riskTable(ui, doc);

            }
         
            if (cfloorFINISH_TIMBERIsChecked)
            {
                Methods_Risks.floorFINISH_TIMBER_Task_riskTable(ui, doc);
            }
            if (cGLAZEROOFIsChecked)
            {
                Methods_Risks.GLAZEROOF_Task_riskTable(ui, doc);
            }

            if (cROOFIsChecked)
            {
                Methods_Risks.ROOF_Task_riskTable(ui, doc);
            }



            if (cRoofdrainageIsChecked)
            {
                Methods_Risks.Roof_drainage_Task_riskTable(ui, doc);
            }

            if (cStairsIsChecked)
            {
                Methods_Risks.Stairs_Task_riskTable(ui, doc);
            }


            if (cRooofMetalIsChecked)
            {
                Methods_Risks.roofmetal_Task_riskTable(ui, doc);
            }
            if (cRooftimberIsChecked)
            {
                Methods_Risks.rooftimber_Task_riskTable(ui, doc);
            }
            if (cFrametimberIsChecked)
            {
                Methods_Risks.frametimber_Task_riskTable(ui, doc);
            }

            if (cWallFinishesIsChecked)
            {
                Methods_Risks.WallFinishesIsChecked_Task_riskTable(ui, doc);
            }

            if (cfloorfinishIsChecked)
            {
                Methods_Risks.floorfinish_Task_riskTable_Task_riskTable(ui, doc);
            }






        }


    }


}

        

