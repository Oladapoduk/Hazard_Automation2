using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Hazard_Automation.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazard_Automation.RVT
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class RVT_Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            var lstDoor = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Doors).WhereElementIsNotElementType().ToElements();
            var lstWindow = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Windows).WhereElementIsNotElementType().ToElements();
            var lstroof= new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Floors).WhereElementIsNotElementType().ToElements();


            Execution execution = new Execution(doc);
            execution.HazardPlacement(lstDoor);
           // execution.HazardPlacement(lstWindow);

            return Result.Succeeded;
        }
    }
}
