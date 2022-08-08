
using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using System.Collections.Generic;
using System.Linq;


namespace Hazard_Automation.RVT_GUI
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class EntryCommandSeparateThread : IExternalCommand
    {
        public virtual Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //try
            //{
            //    App.ThisApp.ShowFormSeparateThread(commandData.Application);
            //    return Result.Succeeded;
            //}
            //catch (Exception ex)
            //{
            //    message = ex.Message;
            //    return Result.Failed;
            //}
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            UIApplication uiapp = commandData.Application;
            Application revitApp = uiapp.Application;
            Categories cats = doc.Settings.Categories;
            List<string> par = new List<string>();
            List<string> parameters = new List<string> { "Health and Safety Risk Associated with the Activities",  "Fatal Risk Category", "GENERIC CONTROL MEASURES" };


            List<string> values_windows = new List<string> { "Work at Height, Lifting Operations, Noise, Vibration, Dropped Objects, Dust",
                                         "Working at height, Lifting, Health",
                                           "Ensure leading edge is protected, use of lanyards and fall preverntion and fall protection hierichy eliminating risk of falls. Dropped object control - tool tenthering. Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons, noise control areas, screens, engineering controls such as dampners, hearing protection, health surveilance, Enginnering controls within the vehicle such as vibration dampners, eliminating hand tools that cause vibration to the hand. Elimnating the need to cut concrete or timber by off site manufacture, re useable materials / moulds etc, PPE last reoort, tools to manage dust creation and capture of dust, no brooms!" };
            List<string> values_doors = new List<string> { "Fire - making sure fire does not spread during construction, manual handling",
                "Catastrophic risk, Health",
                "Fire risk assessment in place that considers risk of fire as building is constructed - temporary compartmentalisation. Mechanical aids, lightweght materials - alternatives say off site manufacued panels" };

            List<string> values_piles = new List<string> { "Fire - making sure fire does not spread during construction, manual handling",
                "Catastrophic risk, Health",
                "Fire risk assessment in place that considers risk of fire as building is constructed - temporary compartmentalisation. Mechanical aids, lightweght materials - alternatives say off site manufacued panels" };

            CategorySet categoryset = revitApp.Create.NewCategorySet();

            foreach (Category cat in cats)
            {
                if (cat.Name == "Doors" || cat.Name == "Windows" || cat.Name == "Structural Foundations")
                {
                    categoryset.Insert(cat);
                }
            }

            BindingMap map = doc.ParameterBindings;

            DefinitionBindingMapIterator iterator = map.ForwardIterator();

            while (iterator.MoveNext())
            {
                Definition def = iterator.Key;
                par.Add(def.Name);
            }


            using (Transaction trans = new Transaction(doc, "Add Parameter"))

            {
                DefinitionFile parafile = revitApp.OpenSharedParameterFile();
                List<String> definitions = new List<String>();

                trans.Start();

                DefinitionGroup group = parafile.Groups.get_Item("Risk Register");

                if (group is null)
                {
                    group = parafile.Groups.Create("Risk Register");
                }

                foreach (var y in parameters) if (!par.Contains(y))
                    {
                        if (group.Definitions.Count() == 0)
                        {
                            ExternalDefinitionCreationOptions opts = new ExternalDefinitionCreationOptions(y, ParameterType.Text);

                            Definition sharedParamDef = group.Definitions.Create(opts);

                            TypeBinding binding = revitApp.Create.NewTypeBinding(categoryset);

                            commandData.Application.ActiveUIDocument.Document.ParameterBindings.Insert(sharedParamDef, binding);
                        }

                        else
                        {
                            foreach (Definition def in group.Definitions)
                            {
                                definitions.Add(def.Name);
                            }

                            if (definitions.Contains(y))
                            {
                                Definition sharedParamDef = group.Definitions.get_Item(y);

                                TypeBinding binding = revitApp.Create.NewTypeBinding(categoryset);

                                commandData.Application.ActiveUIDocument.Document.ParameterBindings.Insert(sharedParamDef, binding);

                            }
                            else
                            {
                                ExternalDefinitionCreationOptions opts = new ExternalDefinitionCreationOptions(y, ParameterType.Text);

                                Definition sharedParamDef = group.Definitions.Create(opts);

                                TypeBinding binding = revitApp.Create.NewTypeBinding(categoryset);
                                commandData.Application.ActiveUIDocument.Document.ParameterBindings.Insert(sharedParamDef, binding);

                            }
                            definitions.Clear();
                        }
                    }
                trans.Commit();
            }

            IList<Element> windows = new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_Windows)
                .WhereElementIsElementType()
                .ToElements();

            using (Transaction trans = new Transaction(doc, "Set Parameter Windows"))
            {
                trans.Start();

                foreach (var b in windows)
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        var param = b.LookupParameter(parameters[i]);
                        param.Set(values_windows[i]);
                    }
                }
                trans.Commit();
            }

            IList<Element> doors = new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_Doors)
                .WhereElementIsElementType()
                .ToElements();

            using (Transaction trans = new Transaction(doc, "Set Parameter Doors"))
            {
                trans.Start();

                foreach (var b in doors)
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        var param = b.LookupParameter(parameters[i]);
                        param.Set(values_doors[i]);
                    }
                }
                trans.Commit();
            }

            IList<Element> piles = new FilteredElementCollector(doc)
                                    .OfCategory(BuiltInCategory.OST_StructuralFoundation)
                                        .WhereElementIsElementType()
                                 .ToElements();


            using (Transaction trans = new Transaction(doc, "Set Parameter Pile"))
            {
                trans.Start();

                foreach (ElementType b in piles) if (b.FamilyName.Contains("Pile"))
                    {
                        for (int i = 0; i < parameters.Count; i++)
                        {
                            var param = b.LookupParameter(parameters[i]);
                            param.Set(values_piles[i]);
                        }
                    }

                trans.Commit();
            }


            List<ViewSchedule> sched_list = new List<ViewSchedule>(new FilteredElementCollector(doc)
                .OfClass(typeof(ViewSchedule))
                .Cast<ViewSchedule>());

            bool isnew = false;

            List<string> paramname = new List<string>();

            ViewSchedule schedule = null;

            using (Transaction trans = new Transaction(doc, "Creating Schedule"))
            {
                trans.Start();

                foreach (var v in sched_list) if (v.Name == "Project Risk Register Schedule")
                    {
                        schedule = v;
                    }

                if (schedule == null)
                {
                    schedule = ViewSchedule.CreateSchedule(doc, new ElementId(BuiltInCategory.INVALID));
                    var h = schedule.get_Parameter(BuiltInParameter.VIEW_NAME);
                    h.Set("Project Risk Register Schedule");
                    isnew = true;

                }

                trans.Commit();
            }

            using (Transaction trans = new Transaction(doc, "Adding fields to schedule"))
            {
                trans.Start();

                IList<SchedulableField> schedulableFields = schedule.Definition.GetSchedulableFields();

                foreach (SchedulableField sf in schedulableFields)
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        if (sf.GetName(doc) == parameters[i] || sf.GetName(doc) == "Category")
                        {
                            paramname.Add(sf.GetName(doc));

                            bool fieldAlreadyAdded = false;

                            IList<ScheduleFieldId> ids = schedule.Definition.GetFieldOrder();

                            foreach (ScheduleFieldId id in ids)
                            {
                                if (schedule.Definition.GetField(id).GetSchedulableField().GetName(doc) == sf.GetName(doc))
                                {
                                    fieldAlreadyAdded = true;
                                    break;
                                }
                            }

                            if (fieldAlreadyAdded == false)
                            {
                                schedule.Definition.AddField(sf);
                            }
                        }

                    }
                }

                trans.Commit();
            }

            if (isnew == true)
            {
                using (Transaction trans = new Transaction(doc, "Sorting/Grouping"))
                {
                    trans.Start();

                    IList<ScheduleFieldId> ids = schedule.Definition.GetFieldOrder();

                    ScheduleFieldId fieldid = null;

                    foreach (ScheduleFieldId id in ids)
                    {
                        if (schedule.Definition.GetField(id).GetSchedulableField().GetName(doc) == "Category")
                        {
                            fieldid = id;
                        }
                    }

                    ScheduleSortGroupField sortgroupfield = new ScheduleSortGroupField(fieldid);

                    schedule.Definition.AddSortGroupField(sortgroupfield);

                    schedule.Definition.IsItemized = false;

                    trans.Commit();
                }

                using (Transaction trans = new Transaction(doc, "Filter"))
                {
                    trans.Start();

                    IList<ScheduleFieldId> ids = schedule.Definition.GetFieldOrder();

                    ScheduleFieldId fieldid = null;

                    foreach (ScheduleFieldId id in ids)
                    {
                        if (schedule.Definition.GetField(id).GetSchedulableField().GetName(doc) == parameters[0])
                        {
                            fieldid = id;
                        }
                    }
                    ScheduleFilter filter = new ScheduleFilter(fieldid, ScheduleFilterType.HasValue);

                    schedule.Definition.AddFilter(filter);

                    trans.Commit();
                }

            }

            var directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ViewScheduleExportOptions opt = new ViewScheduleExportOptions();

            schedule.Export(directory, schedule.Name + ".csv", opt);

            return Result.Succeeded;

        }


    }
    
}
