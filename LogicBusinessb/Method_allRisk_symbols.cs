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
using Hazard_Automation.Businessb;

namespace Hazard_Automation.LogicBusinessb
{
    internal class Method_allRisk_symbols
    {
        public static void GetWindow(Document doc)
        {

            var lstWindow = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Windows).WhereElementIsNotElementType().ToElements();
            //if (lstWindow == null)
            //{
            //    Execution executionf = new Execution(doc);
            //}
            //window_driving
            Element lstWindows = lstWindow.First<Element>();
            ExecutionDriving executionDriving = new ExecutionDriving(doc);
            executionDriving.HazardPlacementwindow_driving(lstWindows);


            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_windows(lstWindows);


        }
        public static void Pilefoundations(Document doc)
        {

            var pile = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                           .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                           .Cast<FamilyInstance>()
                                                           .Where(m => m.Symbol.Family.Name.Contains("Pile"));
            //done
            Element piles = pile.First<Element>();
            ExecutionExcavation executionexcavation = new ExecutionExcavation(doc);
            executionexcavation.HazardPlacement_single_placement_pile(piles);
            ///done
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_pile(piles);

            ///done HazardPlacementPPI_pile
            ExecutionPeoplePlantInterface executionPeoplePlantInterface = new ExecutionPeoplePlantInterface(doc);
            executionPeoplePlantInterface.HazardPlacementPPI_pile(piles);

            ///done
            ExecutionCatastrophic ExecutionCatastrophic = new ExecutionCatastrophic(doc);
            ExecutionCatastrophic.HazardPlacementCatastrophic_pile(piles);

            ///done
            ExecutingLifting ExecutionLifting = new ExecutingLifting(doc);
            ExecutionLifting.HazardPlacementLifting_pile(piles);

            ///done
            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_pile(piles);

            ///done
            ExecutingElectricity executingElectricity = new ExecutingElectricity(doc);
            executingElectricity.HazardPlacementElectricity_pile(piles);



        }
        public static void InternalDoors(Document doc)
        {

            var indoors = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                         .OfCategory(BuiltInCategory.OST_Doors)
                                                         .Cast<FamilyInstance>()
                                                         .Where(m => m.Symbol.Family.Name.Contains("IN"));
            //HazardPlacement_health_intdoors
            Element indoorss = indoors.First<Element>();
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacement_health_intdoors(indoorss);

        }
        public static void ExternalDoors(Document doc)
        {

            var exdoors = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                     .OfCategory(BuiltInCategory.OST_Doors)
                                                     .Cast<FamilyInstance>()
                                                     .Where(m => m.Symbol.Family.Name.Contains("Ext"));

            Element exdoorss = exdoors.First<Element>();
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacement_health_Exttdoors(exdoorss);



            ExecutionCatastrophic ExecutionCatastrophic = new ExecutionCatastrophic(doc);
            ExecutionCatastrophic.HazardPlacement_Catastrop_Exttdoors(exdoorss);



        }
        //Structuralfoundation_Task
        public static void Structuralfoundation_Task(Document doc)
        {

            var structuralfound = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                           .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                           .Cast<FamilyInstance>();

            //done1

            Element structuralfounds = structuralfound.First<Element>();
            ExecutionExcavation executionexcavation = new ExecutionExcavation(doc);

            executionexcavation.HazardPlacement_single_placement_Structuralfoundation(structuralfounds);
            ///DONE1
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_SF(structuralfounds);

            ///done1
            ExecutionPeoplePlantInterface executionPeoplePlantInterface = new ExecutionPeoplePlantInterface(doc);
            executionPeoplePlantInterface.HazardPlacementPPI_SF(structuralfounds);


            ///done1
            ExecutingLifting ExecutionLifting = new ExecutingLifting(doc);
            ExecutionLifting.HazardPlacementLifting_SF(structuralfounds);

            ///done1
            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_SF(structuralfounds);

            ///done
            ExecutingElectricity executingElectricity = new ExecutingElectricity(doc);
            executingElectricity.HazardPlacementElectricity_SF(structuralfounds);

            ExecutionDriving executionDriving = new ExecutionDriving(doc);
            executionDriving.HazardPlacementSF_driving(structuralfounds);







        }
        //foundationslab_Task
        public static void foundationslab_Task(Document doc)
        {


            var foundationslab = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                                      .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                                      .Cast<HostObject>(); //2001
            HostObject foundationslabs = foundationslab.First<HostObject>();
            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_FS(foundationslabs);
            ///DONE1
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_FS(foundationslabs);

            ///done1
            ExecutionPeoplePlantInterface executionPeoplePlantInterface = new ExecutionPeoplePlantInterface(doc);
            executionPeoplePlantInterface.HazardPlacementPPI_FS(foundationslabs);


            ///done1
            ExecutingLifting ExecutionLifting = new ExecutingLifting(doc);
            ExecutionLifting.HazardPlacementLifting_FS(foundationslabs);


        }
        public static void roofcovering(Document doc)
        {
            var roofcovering = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                                .OfCategory(BuiltInCategory.OST_Roofs)
                                                .Cast<HostObject>()
                                                .Where(m => m.Name.Contains("Covering"));
            HostObject roofcoverings = roofcovering.First<HostObject>();
            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_RC(roofcoverings);




        }
        ///floorconcrete
        public static void floorconcrete(Document doc)
        {
            var floorconcrete = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                               .OfCategory(BuiltInCategory.OST_Floors)
                                               .Cast<HostObject>()
                                               .Where(m => m.Name.Contains("Concrete"));
            HostObject floorconcretes = floorconcrete.First<HostObject>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_FC(floorconcretes);

            ///DONE1
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_FC(floorconcretes);

            ///done1
            ExecutionPeoplePlantInterface executionPeoplePlantInterface = new ExecutionPeoplePlantInterface(doc);
            executionPeoplePlantInterface.HazardPlacementPPI_FC(floorconcretes);


            ///done1
            ExecutingLifting ExecutionLifting = new ExecutingLifting(doc);
            ExecutionLifting.HazardPlacementLifting_FC(floorconcretes);

            ExecutionCatastrophic ExecutionCatastrophic = new ExecutionCatastrophic(doc);
            ExecutionCatastrophic.HazardPlacement_Cata_FC(floorconcretes);

        }
        public static void floortimber(Document doc)
        {
            var floortimber = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                          .OfCategory(BuiltInCategory.OST_Floors)
                                          .Cast<HostObject>()
                                          .Where(m => m.Name.Contains("Timber"));
            HostObject floortimbers = floortimber.First<HostObject>();
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_FT(floortimbers);



        }
        public static void Wallinterior(Document doc)
        {
            var Wallinterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                .OfCategory(BuiltInCategory.OST_Walls)
                                .Cast<HostObject>()
                                .Where(m => m.Name.Contains("Interior"));
            HostObject Wallinteriors = Wallinterior.First<HostObject>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_WI(Wallinteriors);

            ///DONE1
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_WI(Wallinteriors);
        }
        public static void floorfinish(Document doc)
        {
            var floorfinish = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Floors)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("finish"));
            HostObject floorfinishs = floorfinish.First<HostObject>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_ff(floorfinishs);

        
        }
        //WallExterior
        public static void WallExterior(Document doc)
        {
            var WallExterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                               .OfCategory(BuiltInCategory.OST_Walls)
                               .Cast<HostObject>()
                               .Where(m => m.Name.Contains("Exterior"));
            HostObject WallExteriors = WallExterior.First<HostObject>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_WE(WallExteriors);

            ///DONE1
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_WE(WallExteriors);


        }
        //Wallfinishes
        public static void Wallfinishes(Document doc)
        {
            var WallFinishes = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                            .OfCategory(BuiltInCategory.OST_Walls)
                            .Cast<HostObject>()
                            .Where(m => m.Name.Contains("Finish"));
            HostObject WallFinishess = WallFinishes.First<HostObject>();
            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_WF(WallFinishess);
 


        }
        //WallExteriorb
        public static void WallExteriorb(Document doc)
        {
            var WallExterior = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                .OfCategory(BuiltInCategory.OST_Walls)
                                .Cast<HostObject>()
                                .Where(m => m.Name.Contains("Wall-Ext_"));
            HostObject WallExteriors = WallExterior.First<HostObject>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_WE(WallExteriors);

            ///DONE1
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_WE(WallExteriors);

        }
        //retainingwalls
        public static void retainingwalls(Document doc)
        {
            var retainingwalls = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                .OfCategory(BuiltInCategory.OST_Walls)
                                .Cast<HostObject>()
                                .Where(m => m.Name.Contains("Retaining"));

            HostObject retainingwallss = retainingwalls.First<HostObject>();

           
            ExecutionExcavation executionexcavation = new ExecutionExcavation(doc);
            executionexcavation.HazardPlacementHeight_RW(retainingwallss);


        }
        //RoofMetal
        public static void RoofMetal(Document doc)
        {
            var RoofMetal = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                          .OfCategory(BuiltInCategory.OST_Roofs)
                          .Cast<HostObject>()
                          .Where(m => m.Name.Contains("Metal"));
            HostObject RoofMetals = RoofMetal.First<HostObject>();

      
            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_RC(RoofMetals);



        }
        //Roof
        public static void Roof(Document doc)
        {
            var Roof = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                          .OfCategory(BuiltInCategory.OST_Roofs)
                          .Cast<HostObject>();
                         // .Where(m => m.Name.Contains("Metal"));
            HostObject Roofs = Roof.First<HostObject>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_Roof(Roofs);
      
            ///DONE1
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementHealth_Roof(Roofs);

            ExecutingLifting ExecutionLifting = new ExecutingLifting(doc);
            ExecutionLifting.HazardPlacementLifting_Roof(Roofs);


        }
        //Rooftimber
        public static void Rooftimber(Document doc)
        {
            var Rooftimber = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                .OfCategory(BuiltInCategory.OST_Roofs)
                                .Cast<HostObject>()
                                .Where(m => m.Name.Contains("Timber"));
            HostObject Rooftimbers = Rooftimber.First<HostObject>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_Rooftimbers(Rooftimbers);


        }
        public static void Roofglazed(Document doc)
        {
            var Glazing = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                .OfCategory(BuiltInCategory.OST_Roofs)
                                .Cast<HostObject>()
                                .Where(m => m.Name.Contains("Glaz"));
            HostObject Glazings = Glazing.First<HostObject>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementHeight_Rooftimbers(Glazings);


        }
        //floorFINISH_TIMBER
        public static void floorFINISH_TIMBER(Document doc)
        {
            var floorFINISH_TIMBER = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Floors)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("Timber"));
            HostObject floorFINISH_TIMBERs = floorFINISH_TIMBER.First<HostObject>();

            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.floorFINISH_TIMBER(floorFINISH_TIMBERs);

        }
        //Roofdrainage
        public static void Roofdrainage(Document doc)
        {
            var Roofdrainage = new FilteredElementCollector(doc).OfClass(typeof(HostObject))
                                           .OfCategory(BuiltInCategory.OST_Gutter)
                                           .Cast<HostObject>()
                                           .Where(m => m.Name.Contains("Gutter"));
            HostObject Roofdrainages = Roofdrainage.First<HostObject>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementRoofdrainage(Roofdrainages);

        }
        //filtstairs
        public static void filtstairs(Document doc)
        {
            var filtstairs = new FilteredElementCollector(doc)
                                                     .WhereElementIsNotElementType()
                                                     .OfCategory(BuiltInCategory.OST_Stairs)
                                                     .ToElementIds();
            ElementId filtstairss = filtstairs.First<ElementId>();


            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementstairs(filtstairss);

        }

        //frametimber
        public static void frametimber(Document doc)
        {
            var Timber = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                   .OfCategory(BuiltInCategory.OST_StructuralFraming)
                                                   .Cast<FamilyInstance>()
                                                    .Where(m => m.Symbol.Family.Name.Contains("Timber"));
            Element Timbers = Timber.First<Element>();

            //ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            //ExecutingHeight.HazardPlacementFrame_Timber(Timbers);

            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementFrame_Timber(Timbers);

        }
        //frameconcrete
        public static void frameconcrete(Document doc)
        {
            var Concrete = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                   .OfCategory(BuiltInCategory.OST_StructuralFraming)
                                                   .Cast<FamilyInstance>()
                                                    .Where(m => m.Symbol.Family.Name.Contains("Concrete"));
            Element Concretes = Concrete.First<Element>();

            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementFrame_Concrete(Concretes);

        }
        //Steels
        public static void frameSteels(Document doc)
        {
            var Steel = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance))
                                                   .OfCategory(BuiltInCategory.OST_StructuralFraming)
                                                   .Cast<FamilyInstance>()
                                                    .Where(m => m.Symbol.Family.Name.Contains("Steel"));
            Element Steels = Steel.First<Element>();

            ExecutingHeight ExecutingHeight = new ExecutingHeight(doc);
            ExecutingHeight.HazardPlacementframeHeight_STEEL(Steels);

            ///DONE1
            ExecutionHealth executionHealth = new ExecutionHealth(doc);
            executionHealth.HazardPlacementframeHeight_STEEL(Steels);

            ///done1
            ExecutionPeoplePlantInterface executionPeoplePlantInterface = new ExecutionPeoplePlantInterface(doc);
            executionPeoplePlantInterface.HazardPlacementframePPI_STEEL(Steels);


            ///done1
            ExecutingLifting ExecutionLifting = new ExecutingLifting(doc);
            ExecutionLifting.HazardPlacementframeLifting_STEEL(Steels);
        }






    }
}
