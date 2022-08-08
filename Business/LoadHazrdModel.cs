using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hazard_Automation.Business
{
    public class LoadHazrdModel
    {
        private readonly string familyName = "BB_Hazard_Marker";
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

            string familyFilePath = Path.Combine(path, "BB_Hazard_Marker.rfa");

            FamilySymbol fs = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).Where(f => { var familySymbol = f as FamilySymbol; return familySymbol != null && familySymbol.Family.Name == familyName; }).Select(f => f as FamilySymbol).FirstOrDefault();

            if (fs == null)
            {
                fs = Load_Hazard_FamilyToDocument(familyFilePath, doc, familyName);
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
