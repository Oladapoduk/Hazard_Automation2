using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;


namespace Hazard_Automation.Businessb
{
    public class ExecutionHealth
    {
        Document _doc;
        public ExecutionHealth(Document doc)
        {
            _doc = doc;
        }
        /// <summary>
        /// To place the Hazard element
        /// </summary>
        /// <param name="collection">Pass window or door family instances caollection</param>
        /// 
        public void HazardPlacement(IList<Element> collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            foreach (var item in collection)
            {
                XYZ lp = GetLocation(item);
                if (lp != null)
                {
                    //XYZ newLocationPoint = GetDirection(item, lp);
                    //loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);
                }
            }
        }
        public void HazardPlacementt(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();


            XYZ lp = GetLocation(collection);
            if (lp != null)
            {
                //XYZ newLocationPoint = GetDirection(collection, lp);
                //loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);
            }
        }
        public void HazardPlacementHealth_pile(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();


            XYZ lp = GetLocation(collection);
            if (lp != null)
            {
                XYZ newLocationPoint = GetDirectionHealth_pile(collection, lp);
                loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);
            }
        }
        public void HazardPlacementHealth_SF(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //GetDirectionHealth_SF
            XYZ lp = GetLocation(collection);
            if (lp != null)
            {
                XYZ newLocationPoint = GetDirectionHealth_SF(collection, lp);
                loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);
            }
        }
        public void HazardPlacementHealth_FS(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);

        }
        //HazardPlacementHealth_FC
        public void HazardPlacementHealth_FC(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);

        }

        //HazardPlacementHealth_FT
        public void HazardPlacementHealth_FT(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);

        }
        //HazardPlacementHealth_WI
        public void HazardPlacementHealth_WI(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);

        }
        //HazardPlacementHeight_WE
        public void HazardPlacementHealth_WE(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);

        }
        //HazardPlacementHealth_Roof
        public void HazardPlacementHealth_Roof(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);

        }
        //floorFINISH_TIMBER
        public void floorFINISH_TIMBER(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //

            XYZ newLocationPoint = GetLocationcentroidFS(collection);
            loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);

        }





        public void HazardPlacementHealth_windows(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //GetDirectionHealth_windows
            XYZ lp = GetLocation(collection);
            if (lp != null)
            {
                XYZ newLocationPoint = GetDirectionHealth_windows(collection, lp);
                loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);
            }
        }
        public void HazardPlacementslabttslab(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();


            XYZ newLocationPoint = GetLocationcentroidb(collection);
            loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);


        }
        public void HazardPlacement_health_intdoors(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //GetDirection_health_intdoors
            XYZ lp = GetLocation(collection);
            if (lp != null)
            {
                XYZ newLocationPoint = GetDirection_health_intdoors(collection, lp);
                loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);
            }

        }
        public void HazardPlacement_health_Exttdoors(Element collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            //GetDirection_health_Extdoors
            XYZ lp = GetLocation(collection);
            if (lp != null)
            {
                XYZ newLocationPoint = GetDirection_health_Extdoors(collection, lp);
                loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);
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
                    //XYZ newLocationPoint = GetDirection(item, lp);
                    //loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);
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
                    loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);
                }
            }
        }


        public void HazardPlacementslab(IEnumerable<HostObject> collection)
        {
            LoadHazrdModel loadHazrdModel = new LoadHazrdModel();

            foreach (var item in collection)
            {
                XYZ newLocationPoint = GetLocationcentroidb(item);
                loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);

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
                loadHazrdModel.LoadHazrd_Health(_doc, newLocationPoint);

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

                    loadHazrdModel.LoadHazrd_Health(_doc, lp);
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
                loadHazrdModel.LoadHazrd_Health(_doc, lp);

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
                    newPoint = new XYZ(lp.X+5, lp.Y , lp.Z);
                   
                }


            }

            //return lp;
            return newPoint;
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
        private XYZ GetDirection_health_intdoors(Element e, XYZ locationPoint)
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
        //GetDirection_catstrap_Extdoors
       

        private XYZ GetDirection_health_Extdoors(Element e, XYZ locationPoint)
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
        //GetDirectionHealth_windows
        private XYZ GetDirectionHealth_windows(Element e, XYZ locationPoint)
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
                        newPoint = new XYZ(locationPoint.X - 6, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 6, locationPoint.Y, locationPoint.Z);

                    gotOrientation = true;
                }

                if (GetOrientation(fi.FacingOrientation.Y, out sign))
                {
                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y - 7, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y + 7, locationPoint.Z);

                    gotOrientation = true;
                }

                if (!gotOrientation)
                {
                    GetOrientation(fi.FacingOrientation.X, out sign);

                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X - 6.5, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 6.5, locationPoint.Y, locationPoint.Z);
                }
            }

            return newPoint;
        }
        //GetDirectionHealth_SF
        private XYZ GetDirectionHealth_SF(Element e, XYZ locationPoint)
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
                        newPoint = new XYZ(locationPoint.X - 8, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 8, locationPoint.Y, locationPoint.Z);

                    gotOrientation = true;
                }

                if (GetOrientation(fi.FacingOrientation.Y, out sign))
                {
                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y - 10, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y + 10, locationPoint.Z);

                    gotOrientation = true;
                }

                if (!gotOrientation)
                {
                    GetOrientation(fi.FacingOrientation.X, out sign);

                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X - 10.5, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 10.5, locationPoint.Y, locationPoint.Z);
                }
            }

            return newPoint;
        }
        private XYZ GetDirectionHealth_pile(Element e, XYZ locationPoint)
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
                        newPoint = new XYZ(locationPoint.X - 8, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 8, locationPoint.Y, locationPoint.Z);

                    gotOrientation = true;
                }

                if (GetOrientation(fi.FacingOrientation.Y, out sign))
                {
                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y - 10, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X, locationPoint.Y + 10, locationPoint.Z);

                    gotOrientation = true;
                }

                if (!gotOrientation)
                {
                    GetOrientation(fi.FacingOrientation.X, out sign);

                    if (sign == Sign.Positive)
                        newPoint = new XYZ(locationPoint.X - 10.5, locationPoint.Y, locationPoint.Z);
                    else if (sign == Sign.Negative)
                        newPoint = new XYZ(locationPoint.X + 10.5, locationPoint.Y, locationPoint.Z);
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
        //HazardPlacementframeHeight_STEEL
        public void HazardPlacementframeHeight_STEEL(Element collection)
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


        //HazardPlacementFrame_Concrete
        public void HazardPlacementFrame_Concrete(Element collection)
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
            lp = new XYZ(pointx+5, pointy, z);
            loadHazrdModel.LoadHazrd(_doc, lp);

            //}
        }
        public void HazardPlacementFrame_Timber(Element collection)
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
            lp = new XYZ(pointx+10, pointy, z);
            loadHazrdModel.LoadHazrd(_doc, lp);

            //}
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

