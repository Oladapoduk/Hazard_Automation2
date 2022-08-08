using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.DB;

namespace Hazard_Automation.Business
{
    public class Executionall
    {
        Document _doc;

        public Executionall(Document doc)
        {
            _doc = doc;
        }
        public void HazardPlacement_single_placement(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

         
                XYZ lp = GetLocation(collection);
                if (lp != null)
                {
                    XYZ newLocationPoint = GetDirection(collection, lp);
                    loadHazrdModel.LoadHazrd(_doc, newLocationPoint);
                }
            
        }
        private XYZ GetLocation(Element e)
        {
            XYZ lp = null;
            if (e is FamilyInstance)
            {
                FamilyInstance fi = e as FamilyInstance;
                if (fi.Location != null)
                    lp = (fi.Location as LocationPoint).Point;
                else if (fi.Location == null)
                {
                    var trans = fi.GetTransform();
                    lp = trans.Origin;
                }
            }

            return lp;
        }
        public void HazardPlacementstairs(ElementId collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();
            XYZ lp = null;


            ElementCategoryFilter siteCategoryfilter = new ElementCategoryFilter(BuiltInCategory.OST_ProjectBasePoint);
            FilteredElementCollector basepointcoll = new FilteredElementCollector(_doc);
            IList<Element> siteElements = basepointcoll.WherePasses(siteCategoryfilter).ToElements();
            double Elev = new double();
            FilteredElementCollector levels = new FilteredElementCollector(_doc);
            ICollection<Element> levelcollection = levels.OfClass(typeof(Level)).ToElements();

            foreach (Element ele in siteElements)
            {

                Parameter paramElev = ele.ParametersMap.get_Item("Elev");
                Elev = paramElev.AsDouble();

            }

            //foreach (ElementId stairId in collection)
            //{
                Stairs stairs = _doc.GetElement(collection) as Stairs;
                var param0 = stairs.LookupParameter("Base Level");
                string level = param0.AsValueString();
                double u = new double();

                foreach (var j in levelcollection) if (j.Name == level)
                    {
                        Level lev = j as Level;
                        u = lev.Elevation - Elev;
                    }
                ICollection<ElementId> runIds = stairs.GetStairsRuns();

                foreach (ElementId runId in runIds)
                {
                    StairsRun run = stairs.Document.GetElement(runId) as StairsRun;

                    CurveLoop c = run.GetStairsPath();

                    var bas = run.get_Parameter(BuiltInParameter.STAIRS_RUN_BOTTOM_ELEVATION).AsDouble();
                    var top = run.get_Parameter(BuiltInParameter.STAIRS_RUN_TOP_ELEVATION).AsDouble();

                    var g = c.ElementAt<Curve>(0);

                    XYZ start = g.GetEndPoint(0);
                    XYZ end = g.GetEndPoint(1);

                    var pointx = (start.X + end.X) / 2;
                    var pointy = (start.Y + end.Y) / 2;
                    var pointz = ((bas + top) / 2) + u;

                    lp = new XYZ(pointx, pointy, pointz);

                    loadHazrdModel.LoadHazrd(_doc, lp);
                }

            //}

        }
        public void HazardPlacementFrame(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();
            XYZ lp = null;


            ElementCategoryFilter siteCategoryfilter = new ElementCategoryFilter(BuiltInCategory.OST_ProjectBasePoint);
            FilteredElementCollector basepointcoll = new FilteredElementCollector(_doc);
            IList<Element> siteElements = basepointcoll.WherePasses(siteCategoryfilter).ToElements();
            double Elev = new double();
            FilteredElementCollector levels = new FilteredElementCollector(_doc);
            ICollection<Element> levelcollection = levels.OfClass(typeof(Level)).ToElements();

            foreach (Element ele in siteElements)
            {

                Parameter paramElev = ele.ParametersMap.get_Item("Elev");
                Elev = paramElev.AsDouble();

            }
            //IList<Element> frame = new List<Element>();
            //foreach (Element e in collection)
            //{
            //    frame.Add(e);

            //}

            //foreach (var ele in frame)
            //{
                var t = collection.Location as LocationCurve;
                var curve = t.Curve;

                var pointx = (curve.GetEndPoint(0).X + curve.GetEndPoint(1).X) / 2;
                var pointy = (curve.GetEndPoint(0).Y + curve.GetEndPoint(1).Y) / 2;

                var param0 = collection.LookupParameter("Reference Level");
                string level = param0.AsValueString();
                double u = new double();

                foreach (var j in levelcollection) if (j.Name == level)
                    {
                        Level lev = j as Level;
                        u = lev.Elevation - Elev;
                    }
                var param1 = collection.LookupParameter("Start Level Offset");
                var param2 = collection.LookupParameter("End Level Offset");
                double startlevel = param1.AsDouble();
                double endlevel = param2.AsDouble();
                double sl = startlevel;
                double el = endlevel;
                double mid = (sl + el) / 2;
                double z = (UnitUtils.ConvertToInternalUnits(mid, DisplayUnitType.DUT_MILLIMETERS)) + u;
                lp = new XYZ(pointx, pointy, z);
                loadHazrdModel.LoadHazrd(_doc, lp);

            //}
        }
        public void HazardPlacementflatsingle(HostObject collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

                XYZ newLocationPoint = GetLocationcentroidb(collection);
                loadHazrdModel.LoadHazrd(_doc, newLocationPoint);            
        }
        private XYZ GetLocationcentroidb(Element e)
        {
            XYZ lp = null;
            if (e is HostObject)
            {
                Element fe = e;

                Options gOptions = new Options();
                gOptions.DetailLevel = ViewDetailLevel.Fine;
                GeometryElement geom = fe.get_Geometry(gOptions);

                foreach (GeometryObject geomObj in geom)
                {
                    Solid gsolid = geomObj as Solid;
                    lp = gsolid.ComputeCentroid();
                }

            }

            return lp;
        }




        private XYZ GetDirection(Element e, XYZ locationPoint)
        {
            XYZ newPoint = null;
            bool gotOrientation = false;
            Sign sign;

            if (e is FamilyInstance)
            {
                FamilyInstance fi = e as FamilyInstance;
                if (GetOrientation(fi.FacingOrientation.X, out sign))
                {
                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X - 3, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 3, locationPoint.Y, locationPoint.Z);

                    gotOrientation = true;
                }

                if (GetOrientation(fi.FacingOrientation.Y, out sign))
                {
                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y - 3, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y + 3, locationPoint.Z);

                    gotOrientation = true;
                }

                if (!gotOrientation)
                {
                    GetOrientation(fi.FacingOrientation.X, out sign);

                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X - 3.5, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 3.5, locationPoint.Y, locationPoint.Z);
                }
            }

            return newPoint;
        }
        /// <param name="value">orientation value</param>
        /// <param name="sign">out sign that say the positive sign or negative sign (+1 or -1)</param>
        /// <returns></returns>
        private bool GetOrientation(double value, out Sign sign)
        {
            bool isCorrect = false;
            sign = Sign.Positive;

            if (value == 1)
            {
                isCorrect = true;
                sign = Sign.Positive;
            }

            if (value == -1)
            {
                isCorrect = true;
                sign = Sign.Negative;
            }

            return isCorrect;
        }

        enum Sign
        {
            Positive,
            Negative
        }
    }



}

