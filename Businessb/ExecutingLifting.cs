using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;

namespace Hazard_Automation.Businessb
{
    public class ExecutingLifting
    {
        Document _doc;
        public ExecutingLifting(Document doc)
        {
            _doc = doc;
        }
        public void HazardPlacement(IList<Element> collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            foreach (var item in collection)
            {
                XYZ lp = GetLocation(item);
                if (lp != null)
                {
                    XYZ newLocationPoint = GetDirection(item, lp);
                    loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
                }
            }
        }
        public void HazardPlacementt(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();


            XYZ lp = GetLocation(collection);
            if (lp != null)
            {
                XYZ newLocationPoint = GetDirection(collection, lp);
                loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
            }
        }
        public void HazardPlacementLifting_pile(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();


            XYZ lp = GetLocation(collection);
            if (lp != null)
            {
                XYZ newLocationPoint = GetDirectionHealth_lift_pile(collection, lp);
                loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
            }
        }
        public void HazardPlacementLifting_SF(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();


            XYZ lp = GetLocation(collection);
            if (lp != null)
            {//GetDirectionHealth_lift_SF
                XYZ newLocationPoint = GetDirectionHealth_lift_SF(collection, lp);
                loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
            }
        }
        //HazardPlacementLifting_FS
        public void HazardPlacementLifting_FS(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
        }
        //HazardPlacementLifting_FC
        public void HazardPlacementLifting_FC(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
        }

        //HazardPlacementLifting_Roof
        public void HazardPlacementLifting_Roof(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
        }
        //HazardPlacementframeLifting_STEEL
        public void HazardPlacementframeLifting_STEEL(Element collection)
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
            lp = new XYZ(pointx + 25, pointy, z);
            loadHazrdModel.LoadHazrd(_doc, lp);

            //}
        }






        private XYZ GetLocationcentroidFS(Element e)
        {
            XYZ lp = null;
            XYZ newPoint = null;
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

                    //newPoint = new XYZ(lp.X + 3, lp.Y, lp.Z);
                    //newPoint = new XYZ(lp.X , lp.Y+6, lp.Z);
                    newPoint = new XYZ(lp.X, lp.Y+15, lp.Z);

                }


            }

            //return lp;
            return newPoint;
        }



        public void HazardPlacementslabttslab(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();


            XYZ newLocationPoint = GetLocationcentroidb(collection);
            loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);


        }
        public void HazardPlacement_single_placement(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();


            XYZ lp = GetLocation(collection);
            if (lp != null)
            {
                XYZ newLocationPoint = GetDirection(collection, lp);
                loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
            }

        }




        public void HazardPlacementb(IEnumerable<FamilyInstance> collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            foreach (var item in collection)
            {
                XYZ lp = GetLocation(item);
                if (lp != null)
                {
                    XYZ newLocationPoint = GetDirection(item, lp);
                    loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
                }
            }
        }
        public void HazardPlacementroofmetal(IEnumerable<HostObject> collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            foreach (var item in collection)
            {
                XYZ lp = GetLocationcentroidb(item);
                if (lp != null)
                {
                    XYZ newLocationPoint = GetDirectionRoofmetal(item, lp);
                    loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);
                }
            }
        }


        public void HazardPlacementslab(IEnumerable<HostObject> collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            foreach (var item in collection)
            {
                XYZ newLocationPoint = GetLocationcentroidb(item);
                loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);

            }
        }

        //public void HazardPlacementstairsa(ICollection<ElementId> collection)
        //{
        //    LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

        //    foreach (var item in collection)
        //    {
        //        XYZ newLocationPoint = GetLocationstairs(item);
        //        loadHazrdModel.LoadHazrd(_doc, newLocationPoint);

        //    }
        //}
        public void HazardPlacemenframe(IEnumerable<FamilyInstance> collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            foreach (var item in collection)
            {
                XYZ newLocationPoint = GetLocationcentroidtimber(item);
                loadHazrdModel.LoadHazrd_Lifiting(_doc, newLocationPoint);

            }
        }
        public void HazardPlacementstairs(ICollection<ElementId> collection)
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

            foreach (ElementId stairId in collection)
            {
                Stairs stairs = _doc.GetElement(stairId) as Stairs;
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

                    loadHazrdModel.LoadHazrd_Lifiting(_doc, lp);
                }

            }
        }
        public void HazardPlacementFrame(IEnumerable<FamilyInstance> collection)
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
            IList<Element> frame = new List<Element>();
            foreach (Element e in collection)
            {
                frame.Add(e);

            }

            foreach (var ele in frame)
            {
                var t = ele.Location as LocationCurve;
                var curve = t.Curve;

                var pointx = (curve.GetEndPoint(0).X + curve.GetEndPoint(1).X) / 2;
                var pointy = (curve.GetEndPoint(0).Y + curve.GetEndPoint(1).Y) / 2;

                var param0 = ele.LookupParameter("Reference Level");
                string level = param0.AsValueString();
                double u = new double();

                foreach (var j in levelcollection) if (j.Name == level)
                    {
                        Level lev = j as Level;
                        u = lev.Elevation - Elev;
                    }
                var param1 = ele.LookupParameter("Start Level Offset");
                var param2 = ele.LookupParameter("End Level Offset");
                double startlevel = param1.AsDouble();
                double endlevel = param2.AsDouble();
                double sl = startlevel;
                double el = endlevel;
                double mid = (sl + el) / 2;
                double z = (UnitUtils.ConvertToInternalUnits(mid, DisplayUnitType.DUT_MILLIMETERS)) + u;
                lp = new XYZ(pointx, pointy, z);
                loadHazrdModel.LoadHazrd_Lifiting(_doc, lp);

            }
        }


        /// <summary>
        /// Get location of the element
        /// It should be a family instance
        /// </summary>
        /// <param name="e">Element that should be a family instacne. otherwise returns null</param>
        /// <returns></returns>
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
        private XYZ GetLocationcentroidtimber(Element e)
        {
            XYZ lp = null;
            if (e is FamilyInstance)
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


        /// <summary>
        /// Get XYZ direction point
        /// </summary>
        /// <param name="e">Element that should be a family instacne. otherwise returns null</param>
        /// <param name="locationPoint">To create new location point based on orientation from existing location point</param>
        /// <returns></returns>
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
        private XYZ GetDirectionHealth_lift_pile(Element e, XYZ locationPoint)
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
                        newPoint = new XYZ(locationPoint.X - 33, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 33, locationPoint.Y, locationPoint.Z);

                    gotOrientation = true;
                }

                if (GetOrientation(fi.FacingOrientation.Y, out sign))
                {
                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y - 45, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y + 45, locationPoint.Z);

                    gotOrientation = true;
                }

                if (!gotOrientation)
                {
                    GetOrientation(fi.FacingOrientation.X, out sign);

                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X - 45.5, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 45.5, locationPoint.Y, locationPoint.Z);
                }
            }

            return newPoint;
        }
        private XYZ GetDirectionHealth_lift_SF(Element e, XYZ locationPoint)
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
                        newPoint = new XYZ(locationPoint.X - 18, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 18, locationPoint.Y, locationPoint.Z);

                    gotOrientation = true;
                }

                if (GetOrientation(fi.FacingOrientation.Y, out sign))
                {
                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y - 24, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y + 24, locationPoint.Z);

                    gotOrientation = true;
                }

                if (!gotOrientation)
                {
                    GetOrientation(fi.FacingOrientation.X, out sign);

                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X - 24.5, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 24.5, locationPoint.Y, locationPoint.Z);
                }
            }

            return newPoint;
        }
        private XYZ GetDirectionRoofmetal(Element e, XYZ locationPoint)
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
                    GetOrientation(fi.FacingOrientation.Z, out sign);

                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y, locationPoint.Z + 3.5);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y, locationPoint.Z + 3.5);
                }
            }

            return newPoint;
        }

        /// <summary>
        /// To check the orientation XY values are 1 or not
        /// </summary>
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

