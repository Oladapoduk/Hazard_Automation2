using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazard_Automation.RVT_GUI;
using Autodesk.Revit.DB;
using Hazard_Automation.Business;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hazard_Automation.LogicBusiness
{
    internal class Method_allRisk
    { //IList<Element> lstWindow = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Windows).WhereElementIsNotElementType().ToElements();

        public static void GetWindow(Document doc)
        {

            var lstWindow = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Windows).WhereElementIsNotElementType().ToElements();
            //if (lstWindow == null)
            //{
            //    Execution executionf = new Execution(doc);
            //}

            Element lstWindows = lstWindow.First<Element>();

            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(lstWindows);

        }

        public static void GetDoor(Document doc)
        {
            var doors = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Doors).WhereElementIsNotElementType().ToElements();
         
            Element doorss = doors.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(doorss);

        }

  
        public static void Pilefoundations(Document doc)
        {

            var pile = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                        .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                        .Cast<FamilyInstance>()
                                                        .Where(m => m.Symbol.Family.Name.Contains("Pile"));

            //IList<Element> pileElement = new List<Element>();
            //foreach (Element e in pile)
            //{
            //    pileElement.Add(e);
            //}

            //Element piles = pileElement.First<Element>();
            Element piles = pile.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(piles);

        }

        public static void InternalDoors(Document doc)
        {

            var indoors = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                         .OfCategory(BuiltInCategory.OST_Doors)
                                                         .Cast<FamilyInstance>()
                                                         .Where(m => m.Symbol.Family.Name.Contains("IN"));

            Element indoorss = indoors.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(indoorss);

        }

        public static void ExternalDoors(Document doc)
        {

            var exdoors = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Doors)
                                                     .Cast<FamilyInstance>()
                                                     .Where(m => m.Symbol.Family.Name.Contains("Ext"));

            Element exdoorss = exdoors.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(exdoorss);
        }
        public static void Electricequip(Document doc)
        {

            var Electricequip = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_ElectricalEquipment)
                                                     .Cast<FamilyInstance>();
            // .Where(m => m.Symbol.Family.Name.Contains("Ext"));
            Element Electricequips = Electricequip.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Electricequips);
        }
        public static void Disposal(Document doc)
        {

            var Disposal_eurobin = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Site)
                                                     .Cast<FamilyInstance>()
                                                     .Where(m => m.Symbol.Family.Name.Contains("Eurobin"));
            Element Disposal_eurobins = Disposal_eurobin.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Disposal_eurobins);

        }
        public static void Sanitary_appliance(Document doc)
        {

            var Sanitary_appliance = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_PlumbingFixtures)
                                                     .Cast<FamilyInstance>();
            Element Sanitary_appliances = Sanitary_appliance.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Sanitary_appliances);


        }
        public static void WaterInstallations(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var WaterInstallations_DHWS = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_MechanicalEquipment)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("DHWS"));
            Element WaterInstallations_DHWSs = WaterInstallations_DHWS.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(WaterInstallations_DHWSs);


        }
        public static void Furniture_chair(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_chair = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Chair"));
            Element Furniture_chairs = Furniture_chair.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Furniture_chairs);



        }
        public static void Furniture_6241_GEIC_Training_Room(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_6241_GEIC_Training_Room = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("6241_GEIC_"));
            Element Furniture_6241_GEIC_Training_Rooms = Furniture_6241_GEIC_Training_Room.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Furniture_6241_GEIC_Training_Rooms);


        }

        public static void Furniture_6241_GEIC_Toilet_Cubicle(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_6241_GEIC_Toilet_Cubicle = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Toilet"));
            Element Furniture_6241_GEIC_Toilet_Cubicles = Furniture_6241_GEIC_Toilet_Cubicle.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Furniture_6241_GEIC_Toilet_Cubicles);



        }
        public static void Furniture_RoundTable(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_RoundTable = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Round"));
            Element Furniture_RoundTables = Furniture_RoundTable.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Furniture_RoundTables);

        }
        public static void Furniture_Work_Stations_x3(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_Work_Stations_x3 = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Work Stations_x3"));
            Element Furniture_Work_Stations_x3s = Furniture_Work_Stations_x3.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Furniture_Work_Stations_x3s);


        }
        public static void Furniture_Work_Stations(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_Work_Stations = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Work Stations"));
            Element Furniture_Work_Stationss = Furniture_Work_Stations.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Furniture_Work_Stationss);


        }
        public static void Furniture_Work_Chair_Task(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_Work_Chair_Task = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("6241_GEIC_Office Chair"));
            Element Furniture_Work_Chair_Taskss = Furniture_Work_Chair_Task.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(Furniture_Work_Chair_Taskss);


        }


        public static void Structuralfoundation_Task(Document doc)
        {
            var structuralfound = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                 .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                 .Cast<FamilyInstance>();
            Element structuralfounds = structuralfound.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacement_single_placement(structuralfounds);


        }
        public static void foundationslab_Task(Document doc)
        {
            var foundationslab = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                                      .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                      .Cast<HostObject>(); //2001
            HostObject foundationslabs = foundationslab.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(foundationslabs);
        }
        public static void roofcovering(Document doc)
        {
            var roofcovering = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                                .OfCategory(BuiltInCategory.OST_Roofs)
                                                .Cast<HostObject>()
                                                .Where(m => m.Name.Contains("Covering"));
            HostObject foundationslabs = roofcovering.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(foundationslabs);
        }
        public static void floorconcrete(Document doc)
        {
            var floorconcrete = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                               .OfCategory(BuiltInCategory.OST_Floors)
                                               .Cast<HostObject>()
                                               .Where(m => m.Name.Contains("Concrete"));
            HostObject floorconcretes = floorconcrete.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(floorconcretes);
        }
        public static void floortimber(Document doc)
        {
            var floortimber = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                          .OfCategory(BuiltInCategory.OST_Floors)
                                          .Cast<HostObject>()
                                          .Where(m => m.Name.Contains("Timber"));
            HostObject floortimbers = floortimber.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(floortimbers);
        }
        public static void floorfinish(Document doc)
        {
            var floortimber = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                          .OfCategory(BuiltInCategory.OST_Floors)
                                          .Cast<HostObject>()
                                          .Where(m => m.Name.Contains("finish"));
            HostObject floortimbers = floortimber.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(floortimbers);
        }

        public static void Wallinterior(Document doc)
        {
            var Wallinterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                .OfCategory(BuiltInCategory.OST_Walls)
                                .Cast<HostObject>()
                                .Where(m => m.Name.Contains("Interior"));
            HostObject Wallinteriors = Wallinterior.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(Wallinteriors);
        }

        public static void WallExterior(Document doc)
        {
            var WallExterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                              .OfCategory(BuiltInCategory.OST_Walls)
                              .Cast<HostObject>()
                              .Where(m => m.Name.Contains("Exterior"));
            HostObject WallExteriors = WallExterior.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(WallExteriors);
        }
        public static void Wallfinishes(Document doc)
        {
            var WallFinishes = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                              .OfCategory(BuiltInCategory.OST_Walls)
                              .Cast<HostObject>()
                              .Where(m => m.Name.Contains("Finish"));
            HostObject WallFinishess = WallFinishes.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(WallFinishess);
        }

        public static void WallExteriorb(Document doc)
        {
            var WallExterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                              .OfCategory(BuiltInCategory.OST_Walls)
                              .Cast<HostObject>()
                              .Where(m => m.Name.Contains("Wall-Ext_"));
            HostObject WallExteriors = WallExterior.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(WallExteriors);
        }
        public static void retainingwalls(Document doc)
        {
            var retainingwalls = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                           .OfCategory(BuiltInCategory.OST_Walls)
                           .Cast<HostObject>()
                           .Where(m => m.Name.Contains("Retaining"));

            HostObject retainingwallss = retainingwalls.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(retainingwallss);
        }
        public static void RoofMetal(Document doc)
        {
            var RoofMetal = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                         .OfCategory(BuiltInCategory.OST_Roofs)
                         .Cast<HostObject>()
                         .Where(m => m.Name.Contains("Metal"));
            HostObject RoofMetals = RoofMetal.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(RoofMetals);
        }

        public static void Roof(Document doc)
        {
            var RoofMetal = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                         .OfCategory(BuiltInCategory.OST_Roofs)
                         .Cast<HostObject>();
                        // .Where(m => m.Name.Contains("Metal"));
            HostObject RoofMetals = RoofMetal.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(RoofMetals);
        }

        public static void Rooftimber(Document doc)
        {
            var Rooftimber = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                       .OfCategory(BuiltInCategory.OST_Roofs)
                       .Cast<HostObject>()
                       .Where(m => m.Name.Contains("Timber"));
            HostObject Rooftimbers = Rooftimber.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(Rooftimbers);
        }
        public static void floorFINISH_TIMBER(Document doc)
        {
            var floorFINISH_TIMBER = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Floors)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("Timber"));
            HostObject floorFINISH_TIMBERs = floorFINISH_TIMBER.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(floorFINISH_TIMBERs);
        }
        public static void GLAZEROOF(Document doc)
        {
            var GLAZEROOF = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Roofs)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("Glazing"));
            HostObject GLAZEROOFs = GLAZEROOF.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(GLAZEROOFs);
        }
        public static void Roofdrainage(Document doc)
        {
            var Roofdrainage = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                       .OfCategory(BuiltInCategory.OST_Gutter)
                                       .Cast<HostObject>()
                                       .Where(m => m.Name.Contains("Gutter"));
            HostObject Roofdrainages = Roofdrainage.First<HostObject>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementflatsingle(Roofdrainages);

        }
        public static void filtstairs(Document doc)
        {
            var filtstairs = new FilteredElementCollector(doc)
                                                    .WhereElementIsNotElementType()
                                                    .OfCategory(BuiltInCategory.OST_Stairs)
                                                    .ToElementIds();
            ElementId filtstairss = filtstairs.First<ElementId>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementstairs(filtstairss);
        }

        public static void frametimber(Document doc)
        {
            var Timber = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                   .OfCategory(BuiltInCategory.OST_StructuralFraming)
                                                   .Cast<FamilyInstance>()
                                                    .Where(m => m.Symbol.Family.Name.Contains("Timber"));
            Element Timbers = Timber.First<Element>();
            Executionall execution = new Executionall(doc);
            execution.HazardPlacementFrame(Timbers);

                    

        }



    }

}



