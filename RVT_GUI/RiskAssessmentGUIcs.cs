using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace Hazard_Automation.RVT_GUI
{
    [Transaction(TransactionMode.Manual)]
    public class RiskAssessmentGUIcs : Autodesk.Revit.UI.IExternalApplication
    {
        //class instance
        //public static RiskAssessmentGUIcs ThisApp;
        ////ModelessForm instance
        //private Ui _mMyForm;
        public Autodesk.Revit.UI.Result OnStartup(UIControlledApplication application)
        {
            // _mMyForm = null; // no dialog needed yet; the command will bring it
            RibbonPanel panel = application.CreateRibbonPanel("GetRiskassement");
            panel.AddSeparator();
            AddPushButton(panel);

            return Result.Succeeded;
        }

        private static void AddPushButton(RibbonPanel panel)
        {
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            PushButton pushButton = panel.AddItem(new PushButtonData("Hazard Lookup", "Hazard Lookup", thisAssemblyPath, "Hazard_Automation.RVT_GUI.Showdialogue")) as PushButton;
            pushButton.ToolTip = "Scan For Hazards";
            // Set the large image shown on button

            //Uri uriImage = new Uri("pack://application:,,,/RiskAssessmentGUI; component/Resources/risk_png.png");
            pushButton.LargeImage = new BitmapImage(new Uri(@"C:\Users\babaji01\source\repos\RiskAssessmentGUI\RiskAssessmentGUI\Resources\risk_png.png"));


        }
        //public void ShowForm(UIApplication uiapp)
        //{
        //    // If we do not have a dialog yet, create and show it


        //}

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }




    }
}
