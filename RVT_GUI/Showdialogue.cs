using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace Hazard_Automation.RVT_GUI
{
    [Transaction(TransactionMode.Manual)]
    public class Showdialogue : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // the current document
            Document document = commandData.Application.ActiveUIDocument.Document;

            //// wpf viewer form
            //Ui viewer = new Ui(document);
            //viewer.Show();

            // return result
            return Result.Succeeded;
        }
    }

}
