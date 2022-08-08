using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Hazard_Automation.Business;
using Hazard_Automation.LogicBusiness;


namespace Hazard_Automation.LogicBusinessb
{
    public class EventHandlerWithWpfArgf : RevitEventWrapper<Ui>
    {
        public override void Execute(UIApplication uiApp, Ui ui)
        {
            // SETUP

            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;
            try
            {
                ///
                IList<Element> lstWindow = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Windows).WhereElementIsNotElementType().ToElements();
                IList<Element> lstWindows = new List<Element>();
                foreach (Element e in lstWindow)
                {
                    lstWindows.Add(e);

                }
                if (lstWindows.Count != 0)
                {
                    Method_allRisk_symbols.GetWindow(doc);


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
                    Method_allRisk_symbols.Pilefoundations(doc);
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
                    Method_allRisk_symbols.InternalDoors(doc);
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
                    Method_allRisk_symbols.ExternalDoors(doc);
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
                    Method_allRisk_symbols.Structuralfoundation_Task(doc);
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
                    Method_allRisk_symbols.foundationslab_Task(doc);
                   
                }
                
                ///
                IEnumerable < HostObject > roofcovering = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
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
                    Method_allRisk_symbols.roofcovering(doc);

                }
                ///
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
                    Method_allRisk_symbols.floorconcrete(doc);
                    //Method_allRisk.floorconcrete(doc);
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
                    Method_allRisk_symbols.floortimber(doc);
                  
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
                    Method_allRisk_symbols.Wallinterior(doc);
                    
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
                    Method_allRisk_symbols.floorfinish(doc);
                    
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
                    Method_allRisk_symbols.WallExterior(doc);
                    
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
                    Method_allRisk_symbols.Wallfinishes(doc);
                    
                }
                ///
                ///
                IEnumerable<HostObject> WallExteriorb = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                              .OfCategory(BuiltInCategory.OST_Walls)
                              .Cast<HostObject>()
                              .Where(m => m.Name.Contains("Wall-Ext_"));

                IList<Element> WallExteriorsb = new List<Element>();

                foreach (Element e in WallExteriorb)
                {
                    WallExteriorsb.Add(e);

                }
                if (WallExteriorsb.Count != 0)
                {
                    Method_allRisk_symbols.WallExteriorb(doc);
                    //Method_allRisk.WallExteriorb(doc);
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
                    Method_allRisk_symbols.retainingwalls(doc);
                    //Method_allRisk.retainingwalls(doc);
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
                    Method_allRisk_symbols.RoofMetal(doc);
                    //Method_allRisk.RoofMetal(doc);
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
                    Method_allRisk_symbols.Roof(doc);
                  //  Method_allRisk.Roof(doc);
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
                    Method_allRisk_symbols.Rooftimber(doc);

              
                }
                ///Roofglazed
          
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
                    Method_allRisk_symbols.Roofglazed(doc);
                    //Method_allRisk.GLAZEROOF(doc);
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
                    Method_allRisk_symbols.floorFINISH_TIMBER(doc);
                    //Method_allRisk.floorFINISH_TIMBER(doc);
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
                    Method_allRisk_symbols.Roofdrainage(doc);
                    
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
                    Method_allRisk_symbols.filtstairs(doc);
                 
                }
                ///
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
                    Method_allRisk_symbols.frametimber(doc);
                   // Method_allRisk.frametimber(doc);
                }

                ///
                IEnumerable<FamilyInstance> Concrete = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                  .OfCategory(BuiltInCategory.OST_StructuralFraming)
                                                  .Cast<FamilyInstance>()
                                                   .Where(m => m.Symbol.Family.Name.Contains("Concrete"));

                IList<ElementId> Concretes = new List<ElementId>();
                foreach (ElementId e in Concretes)
                {
                    Concretes.Add(e);

                }
                if (Concretes.Count != 0)
                {
                    Method_allRisk_symbols.frameconcrete(doc);

                   // Method_allRisk_symbols.frametimber(doc);
                    // Method_allRisk.frametimber(doc);
                }
                ///
                IEnumerable<FamilyInstance> Steel = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                  .OfCategory(BuiltInCategory.OST_StructuralFraming)
                                                  .Cast<FamilyInstance>()
                                                   .Where(m => m.Symbol.Family.Name.Contains("Steel"));

                IList<ElementId> Steels = new List<ElementId>();
                foreach (ElementId e in Steels)
                {
                    Steels.Add(e);

                }
                if (Steels.Count != 0)
                {
                    Method_allRisk_symbols.frameSteels(doc);

             
                }





            }
            catch (Exception e)
            {

            }



        }
    }
}
