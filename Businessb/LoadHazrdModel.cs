using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using System.IO;

namespace Hazard_Automation.Businessb
{
    public class LoadHazrdModel
    {
        private readonly string familyName__BB = "BB_Hazard_Marker";
        private readonly string familyName__CS = "Risk_Catastrophe2";
        private readonly string familyName__RD = "Risk_Driving2";
        private readonly string familyName__RE = "Risk_Electricity2";
        private readonly string familyName__RE2 = "Risk_Excavations2";
        private readonly string familyName__RH = "Risk_Health2";
        private readonly string familyName__RH2 = "Risk_Height2";
        private readonly string familyName__RL = "Risk_Lifting2";
        private readonly string familyName__PP = "Risk_PeoplePlantInterface2";
        private readonly string familyName__RT = "Risk_Traffic2";
        private readonly string familyName__UG = "Risk_UGServices2";
        //private string familyFilePath = @"D:\Santhosh\Fiverr\seundapolynabab\From Client\BB_Hazard_Marker.rfa";

        /// <summary>
        /// Load the Hazard family and place that near to the door/window element
        /// </summary>
        /// <param name="doc">currect actrive document</param>
        /// <param name="location">location that the hazard should be placed</param>
        public void LoadHazrd(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "BB_Hazard_Marker.rfa", Properties.Resources.BB_Hazard_Marker);
            //WriteFile(path, "Risk_Driving.rfa", Properties.Resources.Risk_Driving);

            //BB_Hazard_Marker.rfa
            //Risk - Driving.rfa


            string familyFilePath = Path.Combine(path, "BB_Hazard_Marker.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__BB; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__BB);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_catsrophe(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_Catastrophe2.rfa", Properties.Resources.Risk_Catastrophe2);

            string familyFilePath = Path.Combine(path, "Risk_Catastrophe2.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__CS; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__CS);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_Driving(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_Driving2.rfa", Properties.Resources.Risk_Driving2);

            string familyFilePath = Path.Combine(path, "Risk_Driving2.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__RD; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__RD);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_Electricity(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_Electricity2.rfa", Properties.Resources.Risk_Electricity2);

            string familyFilePath = Path.Combine(path, "Risk_Electricity2.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__RE; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__RE);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_Excavations(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_Excavations2.rfa", Properties.Resources.Risk_Excavations2);

            string familyFilePath = Path.Combine(path, "Risk_Excavations2.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__RE2; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__RE2);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_Health(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_Health2.rfa", Properties.Resources.Risk_Health2);

            string familyFilePath = Path.Combine(path, "Risk_Health2.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__RH; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__RH);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_Height(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_Height2.rfa", Properties.Resources.Risk_Height2);

            string familyFilePath = Path.Combine(path, "Risk_Height2.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__RH2; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__RH2);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_Lifiting(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_Lifting2.rfa", Properties.Resources.Risk_Lifting2);

            string familyFilePath = Path.Combine(path, "Risk_Lifting2.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__RL; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__RL);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_PeoplePlantInterface(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_PeoplePlantInterface2.rfa", Properties.Resources.Risk_PeoplePlantInterface2);

            string familyFilePath = Path.Combine(path, "Risk_PeoplePlantInterface2.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__PP; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__PP);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_Traffic(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_Traffic.rfa", Properties.Resources.Risk_Traffic);

            string familyFilePath = Path.Combine(path, "Risk_Traffic.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__RT; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__RT);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }
        public void LoadHazrd_UGservices(Document doc, XYZ location)
        {
            string path = Path.GetTempPath();

            WriteFile(path, "Risk_UGServices.rfa", Properties.Resources.Risk_UGServices);

            string familyFilePath = Path.Combine(path, "Risk_UGServices.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName__UG; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName__UG);
            }

            ElementId instanceId = Place_Hazard_Instance(doc, fs, location);
        }

        /// <summary>
        /// Load the hazard family instance
        /// </summary>
        /// <param name="familyFilePath">hazard family physical path</param>
        /// <param name="doc">current active document</param>
        /// <param name="familyName">family name that used to get the family symbol after the placement</param>
        /// <returns></returns>
        private FamilySymbol Load_Hazard_FamilyToDocument(string familyFilePath, Document doc, string familyName)
        {
            FamilySymbol fs = null;
            try
            {
                if (!String.IsNullOrEmpty(familyFilePath) && File.Exists(familyFilePath))
                {
                    Transaction tran = new Transaction(doc);
                    try
                    {
                        Family family = null;
                        tran.Start("Load");

                        FailureHandlingOptions failOption = tran.GetFailureHandlingOptions();
                        failOption.SetFailuresPreprocessor(new FailureWarningSwallower());

                        doc.LoadFamily(familyFilePath, new FamilyLoadingOptions(), out family);

                        failOption.SetClearAfterRollback(true);
                        tran.SetFailureHandlingOptions(failOption);

                        tran.Commit();

                    }
                    catch (Exception ex)
                    {
                        if (tran.HasStarted())
                            tran.Commit();
                    }
                }

                fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f =>
                {
                    var familySymbol = f as FamilySymbol;
                    return familySymbol != null && familySymbol.Family.Name == familyName;
                }).Select(f => f as FamilySymbol).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return fs;
        }

        /// <summary>
        /// Place the hazard family to the desired location
        /// </summary>
        /// <param name="doc">current active document</param>
        /// <param name="fs">hazard family symbol</param>
        /// <param name="location">location that the hazard family should be placed</param>
        /// <returns></returns>
        private ElementId Place_Hazard_Instance(Document doc, FamilySymbol fs, XYZ location)
        {
            ElementId instanceId = ElementId.InvalidElementId;
            try
            {
                //XYZ location = new XYZ(0, 0, 0);

                if (fs != null)
                {
                    Transaction tran = new Transaction(doc);
                    try
                    {
                        tran.Start("PlaceInstance");

                        FailureHandlingOptions failOption = tran.GetFailureHandlingOptions();
                        failOption.SetFailuresPreprocessor(new FailureWarningSwallower());

                        FamilyInstance fi = null;
                        if (!doc.IsFamilyDocument)
                        {
                            fs.Activate();
                            fi = doc.Create.NewFamilyInstance(location, fs, StructuralType.NonStructural);
                        }

                        instanceId = fi.Id;

                        failOption.SetClearAfterRollback(true);
                        tran.SetFailureHandlingOptions(failOption);
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (tran.HasStarted())
                            tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return instanceId;
        }

        /// <summary>
        /// Write the hazard family to the desired location
        /// </summary>
        /// <param name="path">writing rfa location</param>
        /// <param name="Hazard_FamilyName">hazard family name to be saved as</param>
        /// <param name="Hazard_FamilyFile">hazard family embedded file</param>
        private void WriteFile(string path, string Hazard_FamilyName, object Hazard_FamilyFile)
        {
            if (!File.Exists(Path.Combine(path, Hazard_FamilyName)))
                File.WriteAllBytes(Path.Combine(path, Hazard_FamilyName), (byte[])Hazard_FamilyFile);
        }
    }
}

