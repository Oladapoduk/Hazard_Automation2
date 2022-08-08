using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Hazard_Automation.Business;


namespace Hazard_Automation.LogicBusiness
{
    public class EventHandlerWithWpfArge : RevitEventWrapper<Ui>
    {
        public override void Execute(UIApplication uiApp, Ui ui)
        {
            // SETUP

            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;
            //Method_allRisk.Add(doc);
            try {
                ///
                IList<Element> lstWindow = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Windows).WhereElementIsNotElementType().ToElements();
                IList<Element> lstWindows = new List<Element>();
                foreach (Element e in lstWindow)
                {
                    lstWindows.Add(e);

                }
                if (lstWindows.Count != 0)
                {
                    Method_allRisk.GetWindow(doc);
                }
                ///
                IList<Element> doors = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Doors).WhereElementIsNotElementType().ToElements();
                IList<Element> doorss = new List<Element>();
                foreach (Element e in doors)
                {
                    doorss.Add(e);

                }
                if (doorss.Count != 0)
                {
                    Method_allRisk.GetDoor(doc);
                }

                   


            }
            catch (Exception e)
            {
               
            }

            try
            {
                ////
                IEnumerable<FamilyInstance> pile = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                              .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                              .Cast<FamilyInstance>()
                                               .Where(m => m.Symbol.Family.Name.Contains("Pile"));
                IList<Element> piles = new List<Element>();
                foreach (Element e in pile)
                {
                    piles.Add(e);

                }
                if (piles.Count != 0)
                {
                    Method_allRisk.Pilefoundations(doc);
                }

                         
                IEnumerable<FamilyInstance> Electricequip = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                       .OfCategory(BuiltInCategory.OST_ElectricalEquipment)
                                                       .Cast<FamilyInstance>();
                IList<Element> Electricequips = new List<Element>();

                foreach (Element e in Electricequip)
                {
                    Electricequips.Add(e);

                }
                if (Electricequips.Count != 0)
                {
                    Method_allRisk.Electricequip(doc);
                }

                ////
                IEnumerable<FamilyInstance> indoors = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                        .OfCategory(BuiltInCategory.OST_Doors)
                                                        .Cast<FamilyInstance>()
                                                        .Where(m => m.Symbol.Family.Name.Contains("IN"));
                IList<Element> indoorss = new List<Element>();

                foreach (Element e in indoors)
                {
                    indoorss.Add(e);

                }
                if (indoorss.Count != 0)
                {
                    Method_allRisk.InternalDoors(doc);
                }


                ///
                IEnumerable<FamilyInstance> exdoors = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                             .OfCategory(BuiltInCategory.OST_Doors)
                                                             .Cast<FamilyInstance>()
                                                             .Where(m => m.Symbol.Family.Name.Contains("Ext"));
                IList<Element> exdoorss = new List<Element>();

                foreach (Element e in indoors)
                {
                    exdoorss.Add(e);

                }
                if (exdoorss.Count != 0)
                {
                    Method_allRisk.ExternalDoors(doc);
                }


                ///

                IEnumerable<FamilyInstance> Sanitary_appliance = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_PlumbingFixtures)
                                                     .Cast<FamilyInstance>();
                IList<Element> Sanitary_appliances = new List<Element>();

                foreach (Element e in Sanitary_appliances)
                {
                    Sanitary_appliances.Add(e);

                }
                if (Sanitary_appliances.Count != 0)
                {
                    Method_allRisk.Sanitary_appliance(doc);
                }
                ///

                IEnumerable<FamilyInstance> Disposal_eurobin = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                            .OfCategory(BuiltInCategory.OST_Site)
                                                            .Cast<FamilyInstance>()
                                                            .Where(m => m.Symbol.Family.Name.Contains("Eurobin"));
                IList<Element> Disposal_eurobins = new List<Element>();

                foreach (Element e in Disposal_eurobin)
                {
                    Disposal_eurobins.Add(e);

                }
                if (Disposal_eurobins.Count != 0)
                {
                    Method_allRisk.Disposal(doc);
                }
                ///
                IEnumerable<FamilyInstance> WaterInstallations_DHWS = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_MechanicalEquipment)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("DHWS"));

                IList<Element> WaterInstallations_DHWSs = new List<Element>();

                foreach (Element e in WaterInstallations_DHWS)
                {
                    WaterInstallations_DHWSs.Add(e);

                }
                if (WaterInstallations_DHWSs.Count != 0)
                {
                    Method_allRisk.WaterInstallations(doc);
                }
                ///
                IEnumerable<FamilyInstance> Furniture_chair = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Chair"));

                IList<Element> Furniture_chairs = new List<Element>();

                foreach (Element e in Furniture_chair)
                {
                    Furniture_chairs.Add(e);

                }
                if (Furniture_chairs.Count != 0)
                {
                    Method_allRisk.Furniture_chair(doc);
                }
                ///
                IEnumerable<FamilyInstance> Furniture_6241_GEIC_Training_Room = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("6241_GEIC_"));

                IList<Element> Furniture_6241_GEIC_Training_Rooms = new List<Element>();

                foreach (Element e in Furniture_6241_GEIC_Training_Room)
                {
                    Furniture_6241_GEIC_Training_Rooms.Add(e);

                }
                if (Furniture_6241_GEIC_Training_Rooms.Count != 0)
                {
                    Method_allRisk.Furniture_6241_GEIC_Training_Room(doc);
                }
                ///
                IEnumerable<FamilyInstance> Furniture_6241_GEIC_Toilet_Cubicle = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Toilet"));

                IList<Element> Furniture_6241_GEIC_Toilet_Cubicles = new List<Element>();

                foreach (Element e in Furniture_6241_GEIC_Toilet_Cubicle)
                {
                    Furniture_6241_GEIC_Toilet_Cubicles.Add(e);

                }
                if (Furniture_6241_GEIC_Toilet_Cubicles.Count != 0)
                {
                    Method_allRisk.Furniture_6241_GEIC_Toilet_Cubicle(doc);
                }
                ///
                IEnumerable<FamilyInstance> Furniture_RoundTable = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Round"));

                IList<Element> Furniture_RoundTables = new List<Element>();

                foreach (Element e in Furniture_RoundTable)
                {
                    Furniture_RoundTables.Add(e);

                }
                if (Furniture_RoundTables.Count != 0)
                {
                    Method_allRisk.Furniture_RoundTable(doc);
                }
                ///
                IEnumerable<FamilyInstance> Furniture_Work_Stations_x3 = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Work Stations_x3"));

                IList<Element> Furniture_Work_Stations_x3s = new List<Element>();

                foreach (Element e in Furniture_Work_Stations_x3)
                {
                    Furniture_Work_Stations_x3s.Add(e);

                }
                if (Furniture_Work_Stations_x3s.Count != 0)
                {
                    Method_allRisk.Furniture_Work_Stations_x3(doc);
                }

                ///
                IEnumerable<FamilyInstance> Furniture_Work_Stations = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("Work Stations"));

                IList<Element> Furniture_Work_Stationss = new List<Element>();

                foreach (Element e in Furniture_Work_Stations)
                {
                    Furniture_Work_Stationss.Add(e);

                }
                if (Furniture_Work_Stationss.Count != 0)
                {
                    Method_allRisk.Furniture_Work_Stations(doc);
                }

                ///
                IEnumerable<FamilyInstance> Furniture_Work_Chair_Task = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Furniture)
                                                     .Cast<FamilyInstance>()
                                                      .Where(m => m.Symbol.Family.Name.Contains("6241_GEIC_Office Chair"));

                IList<Element> Furniture_Work_Chair_Tasks = new List<Element>();

                foreach (Element e in Furniture_Work_Chair_Task)
                {
                    Furniture_Work_Chair_Tasks.Add(e);

                }
                if (Furniture_Work_Chair_Tasks.Count != 0)
                {
                    Method_allRisk.Furniture_Work_Chair_Task(doc);
                }
                ///
                IEnumerable<FamilyInstance> structuralfound = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                 .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                 .Cast<FamilyInstance>();

                IList<Element> structuralfounds = new List<Element>();

                foreach (Element e in structuralfound)
                {
                    structuralfounds.Add(e);

                }
                if (structuralfounds.Count != 0)
                {
                    Method_allRisk.Structuralfoundation_Task(doc);
                }
                ///
                IEnumerable<HostObject> foundationslab = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                                      .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                      .Cast<HostObject>(); //2001

                IList<Element> foundationslabs = new List<Element>();

                foreach (Element e in foundationslab)
                {
                    foundationslabs.Add(e);

                }
                if (foundationslabs.Count != 0)
                {
                    Method_allRisk.foundationslab_Task(doc);
                }
                ///
                IEnumerable<HostObject> roofcovering = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                                .OfCategory(BuiltInCategory.OST_Roofs)
                                                .Cast<HostObject>()
                                                .Where(m => m.Name.Contains("Covering"));

                IList<Element> roofcoverings = new List<Element>();

                foreach (Element e in roofcovering)
                {
                    roofcoverings.Add(e);

                }
                if (roofcoverings.Count != 0)
                {
                    Method_allRisk.roofcovering(doc);
                }
                ///
                IEnumerable<HostObject> floorconcrete = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                               .OfCategory(BuiltInCategory.OST_Floors)
                                               .Cast<HostObject>()
                                               .Where(m => m.Name.Contains("Concrete"));

                IList<Element> floorconcretes = new List<Element>();

                foreach (Element e in floorconcrete)
                {
                    floorconcretes.Add(e);

                }
                if (floorconcretes.Count != 0)
                {
                    Method_allRisk.floorconcrete(doc);
                }
                ///
                IEnumerable<HostObject> floortimber = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                          .OfCategory(BuiltInCategory.OST_Floors)
                                          .Cast<HostObject>()
                                          .Where(m => m.Name.Contains("Timber"));

                IList<Element> floortimbers = new List<Element>();

                foreach (Element e in floortimber)
                {
                    floortimbers.Add(e);

                }
                if (floortimbers.Count != 0)
                {
                    Method_allRisk.floortimber(doc);
                }


                ///
                IEnumerable<HostObject> Wallinterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                          .OfCategory(BuiltInCategory.OST_Walls)
                                          .Cast<HostObject>()
                                          .Where(m => m.Name.Contains("Interior"));

                IList<Element> Wallinteriors = new List<Element>();

                foreach (Element e in Wallinteriors)
                {
                    Wallinteriors.Add(e);

                }
                if (Wallinteriors.Count != 0)
                {
                    Method_allRisk.Wallinterior(doc);
                }

                ///
                IEnumerable<HostObject> floorfinish = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                          .OfCategory(BuiltInCategory.OST_Floors)
                                          .Cast<HostObject>()
                                          .Where(m => m.Name.Contains("finish"));

                IList<Element> floorfinishs = new List<Element>();

                foreach (Element e in floorfinish)
                {
                    floorfinishs.Add(e);

                }
                if (floorfinishs.Count != 0)
                {
                    Method_allRisk.floorfinish(doc);
                }


                ///
                IEnumerable<HostObject> WallExterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                              .OfCategory(BuiltInCategory.OST_Walls)
                              .Cast<HostObject>()
                              .Where(m => m.Name.Contains("Exterior"));

                IList<Element> WallExteriors = new List<Element>();

                foreach (Element e in WallExterior)
                {
                    WallExteriors.Add(e);

                }
                if (WallExteriors.Count != 0)
                {
                    Method_allRisk.WallExterior(doc);
                }
                ///
                IEnumerable<HostObject> Wallfinishe = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                              .OfCategory(BuiltInCategory.OST_Walls)
                              .Cast<HostObject>()
                              .Where(m => m.Name.Contains("Finish"));

                IList<Element> Wallfinishes = new List<Element>();

                foreach (Element e in Wallfinishe)
                {
                    Wallfinishes.Add(e);

                }
                if (Wallfinishes.Count != 0)
                {
                    Method_allRisk.Wallfinishes(doc);
                }
                ///
                IEnumerable<HostObject> WallExteriorb = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                              .OfCategory(BuiltInCategory.OST_Walls)
                              .Cast<HostObject>()
                              .Where(m => m.Name.Contains("Wall-Ext_"));

                IList <Element> WallExteriorsb = new List<Element>();

                foreach (Element e in WallExteriorb)
                {
                    WallExteriorsb.Add(e);

                }
                if (WallExteriorsb.Count != 0)
                {
                    Method_allRisk.WallExteriorb(doc);
                }

                ////
                IEnumerable<HostObject> retainingwalls = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                           .OfCategory(BuiltInCategory.OST_Walls)
                           .Cast<HostObject>()
                           .Where(m => m.Name.Contains("Retaining"));

                IList<Element> retainingwallss = new List<Element>();

                foreach (Element e in retainingwalls)
                {
                    retainingwallss.Add(e);

                }
                if (retainingwallss.Count != 0)
                {
                    Method_allRisk.retainingwalls(doc);
                }
                ///
                IEnumerable<HostObject> RoofMetal = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                         .OfCategory(BuiltInCategory.OST_Roofs)
                         .Cast<HostObject>()
                         .Where(m => m.Name.Contains("Metal"));

                IList<Element> RoofMetals = new List<Element>();

                foreach (Element e in RoofMetal)
                {
                    RoofMetals.Add(e);

                }
                if (RoofMetals.Count != 0)
                {
                    Method_allRisk.RoofMetal(doc);
                }
                ///
                IEnumerable<HostObject> Roof = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                         .OfCategory(BuiltInCategory.OST_Roofs)
                         .Cast<HostObject>();
                         //.Where(m => m.Name.Contains("Metal"));

                IList<Element> Roofs = new List<Element>();

                foreach (Element e in Roof)
                {
                    Roofs.Add(e);

                }
                if (Roofs.Count != 0)
                {
                    Method_allRisk.Roof(doc);
                }

                ///
                IEnumerable<HostObject> Rooftimber = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                       .OfCategory(BuiltInCategory.OST_Roofs)
                       .Cast<HostObject>()
                       .Where(m => m.Name.Contains("Timber"));

                IList<Element> Rooftimbers = new List<Element>();

                foreach (Element e in Rooftimber)
                {
                    Rooftimbers.Add(e);

                }
                if (Rooftimbers.Count != 0)
                {
                    Method_allRisk.Rooftimber(doc);
                }
                ///
                IEnumerable<HostObject> floorFINISH_TIMBER = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Floors)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("Timber"));

                IList<Element> floorFINISH_TIMBERs = new List<Element>();

                foreach (Element e in floorFINISH_TIMBER)
                {
                    floorFINISH_TIMBERs.Add(e);

                }
                if (floorFINISH_TIMBERs.Count != 0)
                {
                    Method_allRisk.floorFINISH_TIMBER(doc);
                }

                ///
                IEnumerable<HostObject> GLAZEROOF = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Roofs)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("Glazing"));

                IList<Element> GLAZEROOFs = new List<Element>();

                foreach (Element e in GLAZEROOF)
                {
                    GLAZEROOFs.Add(e);

                }
                if (GLAZEROOFs.Count != 0)
                {
                    Method_allRisk.GLAZEROOF(doc);
                }

                ///
                IEnumerable<HostObject> Roofdrainage = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                       .OfCategory(BuiltInCategory.OST_Gutter)
                                       .Cast<HostObject>()
                                       .Where(m => m.Name.Contains("Gutter"));

                IList<Element> Roofdrainages = new List<Element>();

                foreach (Element e in Roofdrainage)
                {
                    Roofdrainages.Add(e);

                }
                if (Roofdrainages.Count != 0)
                {
                    Method_allRisk.Roofdrainage(doc);
                }

                ///
                IEnumerable<ElementId> filtstairs = new FilteredElementCollector(doc)
                                                    .WhereElementIsNotElementType()
                                                    .OfCategory(BuiltInCategory.OST_Stairs)
                                                    .ToElementIds();

                IList<ElementId> filtstairss = new List<ElementId>();

                foreach (ElementId e in filtstairs)
                {
                    filtstairss.Add(e);

                }
                if (filtstairss.Count != 0)
                {
                    Method_allRisk.filtstairs(doc);
                }
                ///
                IEnumerable<FamilyInstance> Timber = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                  .OfCategory(BuiltInCategory.OST_StructuralFraming)
                                                  .Cast<FamilyInstance>()
                                                   .Where(m => m.Symbol.Family.Name.Contains("Timber"));

                IList<ElementId> Timbers = new List<ElementId>();
                foreach (ElementId e in Timbers)
                {
                    Timbers.Add(e);

                }
                if (Timbers.Count != 0)
                {
                    Method_allRisk.frametimber(doc);
                }

            }
            catch (Exception e)
            {

            }









        }
    }
}
