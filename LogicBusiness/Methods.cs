using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Hazard_Automation.RVT;
using Hazard_Automation.Business;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using System.Windows;
using Hazard_Automation.RVT_GUI;

namespace Hazard_Automation.LogicBusiness
{
    internal class Methods
    {

        public static void GetWindow(Document doc, Ui ui)
        {

       
              //  Util.LogThreadInfo("Sheet placement Transaction");
            var lstWindow = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Windows).WhereElementIsNotElementType().ToElements();
            Execution execution = new Execution(doc);
            execution.HazardPlacement(lstWindow);
        
        }
   


        public static void GetDoor(Document doc)
        {
            var doors = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Doors).WhereElementIsNotElementType().ToElements();
            Execution execution = new Execution(doc);
            execution.HazardPlacement(doors);
        }
        public static void Pilefoundations(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();
         
            var pile = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Pile"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(pile);


        }

        public static void InternalDoors(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var indoors = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                         .OfCategory(BuiltInCategory.OST_Doors)
                                                         .Cast<FamilyInstance>()
                                                         .Where(m => m.Symbol.Family.Name.Contains("IN"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(indoors);


        }

        public static void ExternalDoors(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var exdoors = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Doors)
                                                     .Cast<FamilyInstance>()
                                                     .Where(m => m.Symbol.Family.Name.Contains("Ext"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(exdoors);


        }
        public static void Electricequip(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Electricequip = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_ElectricalEquipment)
                                                     .Cast<FamilyInstance>();
                                                    // .Where(m => m.Symbol.Family.Name.Contains("Ext"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Electricequip);


        }
        public static void Disposal(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Disposal_eurobin = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Site)
                                                     .Cast<FamilyInstance>()
                                                     .Where(m => m.Symbol.Family.Name.Contains("Eurobin"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Disposal_eurobin);


        }
        public static void Sanitary_appliance(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Sanitary_appliance = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_PlumbingFixtures)
                                                     .Cast<FamilyInstance>();
                                                     //.Where(m => m.Symbol.Family.Name.Contains("Eurobin"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Sanitary_appliance);


        }
        public static void WaterInstallations(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var WaterInstallations_DHWS = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_MechanicalEquipment)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("DHWS"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(WaterInstallations_DHWS);


        }
        public static void Furniture_chair(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_chair = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Chair"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Furniture_chair);


        }
        public static void Furniture_6241_GEIC_Training_Room(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_6241_GEIC_Training_Room = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("6241_GEIC_"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Furniture_6241_GEIC_Training_Room);


        }

        public static void Furniture_6241_GEIC_Toilet_Cubicle(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_6241_GEIC_Toilet_Cubicle = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Toilet"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Furniture_6241_GEIC_Toilet_Cubicle);


        }
        public static void Furniture_RoundTable(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_RoundTable = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Round"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Furniture_RoundTable);


        }
        public static void Furniture_Work_Stations_x3(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_Work_Stations_x3 = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Work Stations_x3"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Furniture_Work_Stations_x3);


        }
        public static void Furniture_Work_Stations(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_Work_Stations = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Work Stations"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Furniture_Work_Stations);


        }
        public static void Furniture_Work_Chair_Task(Document doc)
        {
            //var Pilefoundations = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_StructuralFoundation).WhereElementIsNotElementType().ToElements();

            var Furniture_Work_Chair_Task = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("6241_GEIC_Office Chair"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(Furniture_Work_Chair_Task);


        }


        public static void Structuralfoundation_Task(Document doc)
        {
            var structuralfound = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                 .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                 .Cast<FamilyInstance>();
                                                 // .Where(m => m.Symbol.Family.Name.Contains("6241_GEIC_Office Chair"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementb(structuralfound);

        }
        public static void foundationslab_Task(Document doc)
        {
            var foundationslab = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                                      .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                      .Cast<HostObject>(); //2001
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(foundationslab);
        }
        public static void roofcovering(Document doc)
        {
            var roofcovering = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                                .OfCategory(BuiltInCategory.OST_Roofs)
                                                .Cast<HostObject>()
                                                .Where(m => m.Name.Contains("Covering"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(roofcovering);
        }
        public static void floorconcrete(Document doc)
        {
            var floorconcrete = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                               .OfCategory(BuiltInCategory.OST_Floors)
                                               .Cast<HostObject>()
                                               .Where(m => m.Name.Contains("Concrete"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(floorconcrete);
        }
        public static void floortimber(Document doc)
        {
            var floortimber = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                          .OfCategory(BuiltInCategory.OST_Floors)
                                          .Cast<HostObject>()
                                          .Where(m => m.Name.Contains("Timber"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(floortimber);
        }
        public static void Wallinterior(Document doc)
        {
            var Wallinterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                .OfCategory(BuiltInCategory.OST_Walls)
                                .Cast<HostObject>()
                                .Where(m => m.Name.Contains("Interior"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(Wallinterior);
        }

        public static void Wallfinishes(Document doc)
        {
            var Wallinterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                .OfCategory(BuiltInCategory.OST_Walls)
                                .Cast<HostObject>()
                                .Where(m => m.Name.Contains("Finish"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(Wallinterior);
        }



        public static void WallExterior(Document doc)
        {
            var WallExterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                              .OfCategory(BuiltInCategory.OST_Walls)
                              .Cast<HostObject>()
                              .Where(m => m.Name.Contains("Exterior"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(WallExterior);
        }
        public static void WallExteriorb(Document doc)
        {
            var WallExterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                              .OfCategory(BuiltInCategory.OST_Walls)
                              .Cast<HostObject>()
                              .Where(m => m.Name.Contains("Wall-Ext_"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(WallExterior);
        }
        public static void retainingwalls(Document doc)
        {
            var retainingwalls = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                           .OfCategory(BuiltInCategory.OST_Walls)
                           .Cast<HostObject>()
                           .Where(m => m.Name.Contains("Retaining"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(retainingwalls);
        }
        public static void RoofMetal(Document doc)
        {
            var RoofMetal = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                         .OfCategory(BuiltInCategory.OST_Roofs)
                         .Cast<HostObject>()
                         .Where(m => m.Name.Contains("Metal"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(RoofMetal);
        }
        public static void Rooftimber(Document doc)
        {
            var Rooftimber = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                       .OfCategory(BuiltInCategory.OST_Roofs)
                       .Cast<HostObject>()
                       .Where(m => m.Name.Contains("Timber"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(Rooftimber);
        }
        public static void floorFINISH_TIMBER(Document doc)
        {
            var floorFINISH_TIMBER = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Floors)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("Timber"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(floorFINISH_TIMBER);
        }
        public static void floorFINISH(Document doc)
        {
            var floorFINISH_TIMBER = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Floors)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("finish"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(floorFINISH_TIMBER);
            //arch16_a319
        }
        public static void GLAZEROOF(Document doc)
        {
            var GLAZEROOF = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Roofs)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("Glazing"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(GLAZEROOF);
        }
        public static void ROOF(Document doc)
        {
            var GLAZEROOF = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Roofs)
                                           .Cast<HostObject>();
                                           //.Where(m => m.Name.Contains("Glazing"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(GLAZEROOF);
        }

        public static void Roofdrainage(Document doc)
        {
            var Roofdrainage = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                       .OfCategory(BuiltInCategory.OST_Gutter)
                                       .Cast<HostObject>()
                                       .Where(m => m.Name.Contains("Gutter"));
            Execution execution = new Execution(doc);
            execution.HazardPlacementslab(Roofdrainage);
        }
        public static void filtstairs(Document doc)
        {
            var filtstairs = new FilteredElementCollector(doc)
                                                    .WhereElementIsNotElementType()
                                                    .OfCategory(BuiltInCategory.OST_Stairs)
                                                    .ToElementIds();
            Execution execution = new Execution(doc);
            execution.HazardPlacementstairs(filtstairs);
        }
        public static void timberframe(Document doc)
        {
            var Timber = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                       .OfCategory(BuiltInCategory.OST_StructuralFraming)
                                                       .Cast<FamilyInstance>()
                                                        .Where(m => m.Symbol.Family.Name.Contains("Timber"));
            Execution execution = new Execution(doc);
        execution.HazardPlacementFrame(Timber);


        }




    }


}
