using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazard_Automation.RVT_GUI;
using Autodesk.Revit.DB;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Collections;
using System.Reflection;



namespace Hazard_Automation.LogicBusiness
{
    internal class Methods_Risks
    {
        //ListCollectionView CollectionViewList;
        //DataTable DataTableFiltered;
        private readonly TimeSpan filterDelay = TimeSpan.FromMilliseconds(350);
        private DelayAction delayedAction;
        public static void GetwindowsriskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("working at height",
                "working at height", "Work at Height, Lifting Operations, Noise, \r  Vibration, Dropped Objects, Dust",
                "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall protection hierichy " +
                "eliminating risk of falls. \r Dropped object control - tool tenthering");

            dt.Rows.Add("Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury",
                "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons");

            dt.Rows.Add("Health", "Health", "Noise - hearning loss", "Noise control areas, screens, engineering controls \r such as dampners, hearing protection, health surveilance");

            dt.Rows.Add("Health", "Health", "Vibration - damage to hands", "enginnering controls within the vehicle such as \r vibration dampners, eliminating hand tools that cause \r vibration to the hand");

            dt.Rows.Add("working at height", "working at height", "Working at height people falling into or from things \r - materials falling", "Ensure leading edge is protected, use of lanyards and fall preverntion and \r fall protection hierichy eliminating risk of falls. \r Dropped object control - tool tenthering");

            dt.Rows.Add("working at height", "working at height", "Working at height people falling into or from \r things - materials falling", "Ensure leading edge is protected, use of lanyards and fall preverntion and \r fall protection hierichy eliminating risk of falls.\r Dropped object control - tool tenthering");

            dt.Rows.Add("Health", "Health", "Dust - lung disease.", "Elimnating the need to cut \r concrete or timber by off site manufacture, re useable materials / moulds etc, \r PPE last reoort, tools to manage dust creation and capture of dust, no brooms !");
            dt.Rows.Add("Health", "Health", "manual handling", "Mechanical aids, lightweght materials - alternatives say off site manufacued panels");

            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "working at height", "working at height", "Work at Height, Lifting Operations, Noise, Vibration, Dropped Objects, Dust", "Ensure leading edge is protected, use of lanyards and fall preverntion and fall protection hierichy " +
                "eliminating risk of falls. Dropped object control - tool tenthering"};

            List<string> list2 = new List<string>() { "Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury", "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons" };

            List<string> list3 = new List<string>() { "Health", "Health", "Noise - hearning loss", "Noise control areas, screens, engineering controls such as dampners, hearing protection, health surveilance" };

            List<string> list4 = new List<string>() { "Health", "Health", "Vibration - damage to hands", "enginnering controls within the vehicle such as vibration dampners, eliminating hand tools that cause vibration to the hand" };
            List<string> list5 = new List<string>() { "working at height", "working at height", "Ensure leading edge is protected, use of lanyards and fall preverntion and fall protection hierichy eliminating risk of falls. Dropped object control - tool tenthering" };

            List<string> list6 = new List<string>() { "working at height", "working at height", "Working at height people falling into or from things - materials falling", "Ensure leading edge is protected, use of lanyards and fall preverntion and fall protection hierichy eliminating risk of falls. Dropped object control - tool tenthering" };

            List<string> list7 = new List<string>() { "Health", "Health", "Dust - lung disease.", "Elimnating the need to cut concrete or timber by off site manufacture, re useable materials / moulds etc, PPE last reoort, tools to manage dust creation and capture of dust, no brooms !" };
            List<string> list8 = new List<string>() { "Health", "Health", "manual handling", "Mechanical aids, lightweght materials - alternatives say off site manufacued panels" };

            List<List<string>> alist = new List<List<string>>() { list1, list2, list3, list4, list5, list6, list7, list8 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Pilefoundations_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Excavations",
                "Excavations", "Excavations - collapse, falling into open pile hole, ",
                "Ensuring the design of support is applicable for depth \r and type of soil encountered, propping and supporting trench");

            dt.Rows.Add("Underground and overhead services", "Underground and overhead services", "Underground services - Striking them whilst piling",
                "Striking a service overhead causing an electricity arc,\r BT cutting off supply to a house, underground striking gas, water, elec, sewage " +
                "and causing an explosion or flood endangering life, \r possible oil and gas pipelines depending on location. Also fibre optic - taking out business and homes");

            dt.Rows.Add("Underground and overhead services", "Underground and overhead services", "Overhead services - Hitting overhead service with rig mast",
                "Striking a service overhead causing an electricity arc, \r BT cutting off supply to a house, underground striking gas, water, \r elec, sewage and causing an " +
                "explosion or flood endangering life, \r possible oil and gas pipelines depending on location. \r Also fibre optic - taking out business and homes");

            dt.Rows.Add("people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, or fall into excavation - \r also used for lifting piles so could drop something",
                "Control of the interface between plant and \r operators on the ground assisting with the piling operation");

            dt.Rows.Add("Health", "Health", "Vibration - whole body vibration or hand arm vibration leading to health issues",
                "Enginnering controls within the vehicle \r such as vibration dampners, eliminating hand tools that cause vibration to \r the hand");

            dt.Rows.Add("Health", "Health", "Noise - exposure to noise leading to hearing loss", "Noise control areas, screens, engineering controls \r such as dampners," +
                "hearing protection, health surveilance");
            dt.Rows.Add("Catastrophic risk", "Catastrophic risk", "Hot works - fire, burns", "Fire watch, hot works permit, remove combustable materials");
            dt.Rows.Add("Health", "Health", "Chemicals - use of various chemicals including concrete leading \r to skin or respitory issues or burns",
                "Alternative non hazardous chemicals, \r COSHH assessments and necessary controls such as PPE");
            dt.Rows.Add("Lifting", "Lifting ", "Lifting operations - dropping a \r load and causing a crush injury", "Checks on lifting accessories, planned and \r authorised lift plan, exclusion zones, competent persons");

            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "Excavations",
                "Excavations", "Excavations - collapse, falling into open pile hole, ",
                "Ensuring the design of support is applicable for depth and type of soil encountered, propping and supporting trench"};


            List<string> list3 = new List<string>() { "Underground and overhead services", "Underground and overhead services", "Underground services - Striking them whilst piling",
                "Striking a service overhead causing an electricity arc, BT cutting off supply to a house, underground striking gas, water, elec, sewage " +
                "and causing an explosion or flood endangering life, possible oil and gas pipelines depending on location. Also fibre optic - taking out business and homes" };

            List<string> list4 = new List<string>() {"Underground and overhead services", "Underground and overhead services", "Overhead services - Hitting overhead service with rig mast",
                "Striking a service overhead causing an electricity arc, BT cutting off supply to a house, underground striking gas, water, elec, sewage and causing an " +
                "explosion or flood endangering life, possible oil and gas pipelines depending on location. Also fibre optic - taking out business and homes"};

            List<string> list5 = new List<string>() { "people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, or fall into excavation - also used for lifting piles so could drop something",
                "Control of the interface between plant and operators on the ground assisting with the piling operation" };

            List<string> list6 = new List<string>() {"Health", "Health", "Vibration - whole body vibration or hand arm vibration leading to health issues",
                "Enginnering controls within the vehicle such as vibration dampners, eliminating hand tools that cause vibration to the hand"};

            List<string> list7 = new List<string>() { "Health", "Health", "Noise - exposure to noise leading to hearing loss", "Noise control areas, screens, engineering controls such as dampners," +
                " hearing protection, health surveilance" };
            List<string> list8 = new List<string>() { "Catastrophic risk", "Catastrophic risk", "Hot works - fire, burns", "Fire watch, hot works permit, remove combustable materials" };

            List<string> list9 = new List<string>() { "Health", "Health", "Chemicals - use of various chemicals including concrete leading to skin or respitory issues or burns",
                "Alternative non hazardous chemicals, COSHH assessments and necessary controls such as PPE" };

            List<string> list10 = new List<string>() {"Lifting", "Lifting ", "Lifting operations - dropping a load and causing a crush injury",
                "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons"};



            List<List<string>> alist = new List<List<string>>() { list1, list3, list4, list5, list6, list7, list8, list9, list10 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void InternalDoors_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Catastrophic risk",
                "Catastrophic risk", "Fire - making sure fire does not spread during construction",
                ", fire risk assessment in place that considers \r risk of fire as building is constructed - temporary compartmentalisation.");

            dt.Rows.Add("Health", "Health", "manual handling",
                "Mechanical aids, lightweght materials - alternatives say off site manufacued panels");

            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "Catastrophic risk",
                "Catastrophic risk", "Fire - making sure fire does not spread during construction",
                ", fire risk assessment in place that considers risk of fire as building is constructed - temporary compartmentalisation."};

            List<string> list2 = new List<string>() { "Health", "Health", "manual handling",
                "Mechanical aids, lightweght materials - alternatives say off site manufacued panels" };



            List<List<string>> alist = new List<List<string>>() { list1, list2 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void ExternalDoors_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Catastrophic risk",
                "Catastrophic risk", "Fire - making sure fire does not spread during construction",
                ", fire risk assessment in place that considers \r risk of fire as building is constructed - temporary compartmentalisation.");

            dt.Rows.Add("Health", "Health", "manual handling",
                "Mechanical aids, lightweght materials - \r alternatives say off site manufacued panels");

            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "Catastrophic risk",
                "Catastrophic risk", "Fire - making sure fire does not spread during construction",
                ", fire risk assessment in place that considers risk of fire as building is constructed - temporary compartmentalisation."};

            List<string> list2 = new List<string>() { "Health", "Health", "manual handling",
                "Mechanical aids, lightweght materials - alternatives say off site manufacued panels" };



            List<List<string>> alist = new List<List<string>>() { list1, list2 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Electricequip_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Disposal_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Sanitary_appliance_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void WaterInstallations_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Furniture_chair_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Furniture_6241_GEIC_Training_Room_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Furniture_6241_GEIC_Toilet_Cubicle_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Furniture_RoundTable_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Furniture_Work_Stations_x3_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Furniture_Work_Stations_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Furniture_Work_Chair_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void GetStructuralfoundationTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Excavations", "Excavations", "Excavations: Excavations collapsing and \r burying or injuring people working in them; Material falling from \r the sides into any excavation;" +
                " People or plant falling into excavations",
                "Decide the temporary support and precautions that will be required before digging any trench pit, \r tunnel, or other excavations; Ensure that required equipment and" +
                " precautions are available on site before work starts; Make the excavation safer by battering the excavation sides to a safe angle of repose; Edge protection should be " +
                "included to protect against falling materials and head protection should be worn; \r Excavation should be checked to ensure they do not undermine scaffold footings, buried services or" +
                " the foundations of nearby walls or buildings; \r Decide if extra support is required for the structure before any start; Structural engineer advice and surveys of the foundations " +
                "may be required; Plant and vehicles should not be parked close to the sides of excavations; \r Use substantial barriers to protect the edges of excavations where people are liable to" +
                " fall into them; Ensure that excavations are inspected at the start of each shift by a competent person who fully understands the dangers and necessary precautions;" +
                " Ensure that excavations are inspected after any event that may have affected their strength or stability; \r and Inspection records will be required and any discovered faults should" +
                " be corrected immediately.");


            dt.Rows.Add("Lifting", "Lifting", "Lifting operations: The use of tower and mobile cranes can present \r principal hazards, such as: The collapse of the crane can cause " +
                "significant potential for multiple fatal injuries, both on-site \r and off-site; and The falling of the load can cause a significant potential for death and major injury.",
                "Ensure that a Safe System \r of Work is developed and recorded as a Method Statement.");

            dt.Rows.Add("working at height", "working at height", "Working at height: Risks include fatal and serious injury because work at height \r is the biggest single cause of these in the construction" +
                " industry, particularly on smaller projects. \r In fact, falls from ladders, scaffolds, working platforms and roof edges, as well as through \r fragile roofs or rooflights account for over 60% of " +
                "deaths during work at height.",
                "Ensure that it is determined if the work can be done safely from the ground. Ensure that fall \r restraints and safety netting are only to be considered as a last resort if other safety" +
                " equipment cannot be used. Ensure that risks are assessed, precautions taken, and method statements are issued with clarity for everyone who will work at height. Ensure that safe access " +
                "is planned for roof work and falls from edges and openings are prevented. \r Ensure that ‘avoid’, ‘control’, ‘communicate’, and ‘co-operate’ are the hierarchy of controls for \r working on or near " +
                "fragile surfaces. Ensure that key safety issues, such as ‘position’, ‘condition’ and ‘safe use’ are considered when it is appropriate to use ladders. \r Ensure that the right tower scaffold is selected for" +
                " the job, and that it is safely erected, used, moved and dismantled, as well as stable and regularly inspected to prevent falls.");

            dt.Rows.Add("Underground and overhead services", "Underground and overhead services", "Underground Services: Electric shock, \r electrical arcs (causing an explosion)," +
                " and flames can kill and injure people," +
                " which often results in severe burns to hands, \r face and body, even if protective clothing are worn, when underground cables are damaged. ",
                "Ensure care is taken to avoid damaging underground services \r when digging or disturbing the earth; Ensure care is taken to avoid damaging \r underground electrical" +
                " cables that can be hazardous" +
                " because they often look like pipes and it is impossible to tell if \r they are live just by looking at them; and Ensure that excavation \r work is properly managed to control risks," +
                " including Planning" +
                " the work, Using cable plans, Cable locating \r devices, and Safe digging practices.");



            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "Excavations",
                "Excavations", "Excavations: Excavations collapsing and burying or injuring people working in them; Material falling from the sides into any excavation;" +
                " People or plant falling into excavations",
                "Decide the temporary support and precautions that will be required before digging any trench pit, tunnel, or other excavations; Ensure that required equipment and" +
                " precautions are available on site before work starts; Make the excavation safer by battering the excavation sides to a safe angle of repose; Edge protection should be " +
                "included to protect against falling materials and head protection should be worn; Excavation should be checked to ensure they do not undermine scaffold footings, buried services or" +
                " the foundations of nearby walls or buildings; Decide if extra support is required for the structure before any start; Structural engineer advice and surveys of the foundations " +
                "may be required; Plant and vehicles should not be parked close to the sides of excavations; Use substantial barriers to protect the edges of excavations where people are liable to" +
                " fall into them; Ensure that excavations are inspected at the start of each shift by a competent person who fully understands the dangers and necessary precautions;" +
                " Ensure that excavations are inspected after any event that may have affected their strength or stability; and Inspection records will be required and any discovered faults should" +
                " be corrected immediately."};

            List<string> list2 = new List<string>() { "Lifting", "Lifting", "Lifting operations: The use of tower and mobile cranes can present principal hazards, such as: The collapse of the crane can cause " +
                "significant potential for multiple fatal injuries, both on-site and off-site; and The falling of the load can cause a significant potential for death and major injury.",
                "Ensure that a Safe System of Work is developed and recorded as a Method Statement." };

            List<string> list3 = new List<string>() {"working at height", "Working at height", "Working at height: Risks include fatal and serious injury because work at height is the biggest single cause of these in the construction" +
                " industry, particularly on smaller projects. In fact, falls from ladders, scaffolds, working platforms and roof edges, as well as through fragile roofs or rooflights account for over 60% of " +
                "deaths during work at height.",
                "Ensure that it is determined if the work can be done safely from the ground. Ensure that fall restraints and safety netting are only to be considered as a last resort if other safety" +
                " equipment cannot be used. Ensure that risks are assessed, precautions taken, and method statements are issued with clarity for everyone who will work at height. Ensure that safe access " +
                "is planned for roof work and falls from edges and openings are prevented. Ensure that ‘avoid’, ‘control’, ‘communicate’, and ‘co-operate’ are the hierarchy of controls for working on or near " +
                "fragile surfaces. Ensure that key safety issues, such as ‘position’, ‘condition’ and ‘safe use’ are considered when it is appropriate to use ladders. Ensure that the right tower scaffold is selected for" +
                " the job, and that it is safely erected, used, moved and dismantled, as well as stable and regularly inspected to prevent falls." };


            List<List<string>> alist = new List<List<string>>() { list1, list2, list3 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

            //DataGridTemplateColumn statusColumnb = new DataGridTemplateColumn { CanUserReorder = false, MaxWidth = 100, CanUserSort = false }; ;
            //statusColumnb.Header = "Health and Safety Risk Associated with the Activities";

        }
        public static void foundationslab_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("working at height", "working at height", "Working at height people falling into or from things",
                "Ensure leading edge is protected, use of lanyards and fall preverntion and fall protection hierichy eliminating risk of falls. Dropped object control - tool tenthering");


            dt.Rows.Add("Health", "Health", "Chemicals - use of various chemicals including concrete leading to skin or respitory issues or burns",
                "Alternative non hazardous chemicals, COSHH assessments and necessary controls such as PPE");

            dt.Rows.Add("Health", "Health", "Vibrating tools - damaging hands",
                "enginnering controls within the vehicle such as vibration dampners, eliminating hand tools that cause vibration to the hand");

            dt.Rows.Add("people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, or fall into excavation - also used for lifting equipment so could drop something ",
                "Control of the interface between plant and people by segregating plant and having tight controls over anyone entering plant zones. Red Amber zone working");

            dt.Rows.Add("Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury",
               "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons");

            dt.Rows.Add("Health", "Health", "Noise - leading to hearing loss",
               "Noise control areas, screens, engineering controls such as dampners, hearing protection, health surveilance");
          
            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "working at height", "working at height", "Working at height people falling into or from things",
                "Ensure leading edge is protected, use of lanyards and fall preverntion and fall protection hierichy eliminating risk of falls. Dropped object control - tool tenthering"};

            List<string> list2 = new List<string>() { "Health", "Health", "Chemicals - use of various chemicals including concrete leading to skin or respitory issues or burns",
                "Alternative non hazardous chemicals, COSHH assessments and necessary controls such as PPE" };

            List<string> list3 = new List<string>() {"Health", "Health", "Vibrating tools - damaging hands",  "enginnering controls within the vehicle such as vibration dampners, eliminating hand tools that cause vibration to the hand" };

            List<string> list4 = new List<string>() { "people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, or fall into excavation - also used for lifting equipment so could drop something ",
                "Control of the interface between plant and people by segregating plant and having tight controls over anyone entering plant zones. Red Amber zone working" };

            List<string> list5 = new List<string>() { "Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury",  "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons"};
            List<string> list6 = new List<string>() { "Health", "Health", "Noise - leading to hearing loss", "Noise control areas, screens, engineering controls such as dampners, hearing protection, health surveilance" };


            List<List<string>> alist = new List<List<string>>() { list1, list2, list3, list4 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

            //DataGridTemplateColumn statusColumnb = new DataGridTemplateColumn { CanUserReorder = false, MaxWidth = 100, CanUserSort = false }; ;
            //statusColumnb.Header = "Health and Safety Risk Associated with the Activities";

        }
        public static void roofcovering_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Fragile surfaces", "Fragile surfaces", "Roof covering: Falls can occur through fragile surfaces," +
                " such as fibre-cement roofs and rooflights, " +
                "which account for 22% of all fall from height fatal injuries in the construction industry. " +
                "Death or permanent disability \r can occur when workers undertaking roof work and maintenance fall through fragile surfaces. " +
                "Statistically, these injuries appear to happen mainly \r to those carrying out small and short-term maintenance and cleaning jobs.",
                "Ensure that all roofs are treated as fragile until a competent person has confirmed they are non-fragile. " +
                "Ensure that the following roofs \r are treated as likely to be fragile: Fibre-cement sheets; \r Rooflights; Liner panels; Metal sheets; Glass; Chipboard;" +
                " and Others, such as wood wool slabs, slates and tiles. Ensure that \r effective precautions are taken to address the risks and hazards via a hierarchy of " +
                "steps for avoidance, control, communication and co-operation.");
            

            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() {"Fragile surfaces", "Fragile surfaces", "Roof covering: Falls can occur through fragile surfaces," +
                " such as fibre-cement roofs and rooflights, " +
                "which account for 22% of all fall from height fatal injuries in the construction industry. " +
                "Death or permanent disability \r can occur when workers undertaking roof work and maintenance fall through fragile surfaces. " +
                "Statistically, these injuries appear to happen mainly \r to those carrying out small and short-term maintenance and cleaning jobs.",
                "Ensure that all roofs are treated as fragile until a competent person has confirmed they are non-fragile. " +
                "Ensure that the following roofs \r are treated as likely to be fragile: Fibre-cement sheets; \r Rooflights; Liner panels; Metal sheets; Glass; Chipboard;" +
                " and Others, such as wood wool slabs, slates and tiles. Ensure that \r effective precautions are taken to address the risks and hazards via a hierarchy of " +
                "steps for avoidance, control, communication and co-operation."};
     
            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

            //DataGridTemplateColumn statusColumnb = new DataGridTemplateColumn { CanUserReorder = false, MaxWidth = 100, CanUserSort = false }; ;
            //statusColumnb.Header = "Health and Safety Risk Associated with the Activities";

        }
        public static void floorconcrete(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("working at height", "working at height", "Working at height people falling into or from things",
                "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall protection hierichy \r eliminating risk of falls. Dropped object control - tool tenthering");
            
            dt.Rows.Add("Health", "Health", "Chemicals - use of various chemicals including \r concrete leading to skin or respitory issues or burns",
               "Alternative non hazardous chemicals, COSHH assessments and necessary controls such as PPE");

            dt.Rows.Add("Health", "Health", "Vibrating tools - damaging hands",
               "enginnering controls within the vehicle such as vibration dampners, \r eliminating hand tools that cause vibration to the hand");

            dt.Rows.Add("Health", "Health", "Vibrating tools - damaging hands",
               "enginnering controls within the vehicle such as vibration dampners, \r eliminating hand tools that cause vibration to the hand");
            dt.Rows.Add("people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, or fall into excavation \r - also used for lifting equipment so could drop something",
               "Control of the interface between plant and people by segregating plant \r and having tight controls over anyone entering plant zones. Red Amber zone working");

            dt.Rows.Add("Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury",
               "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons");

            dt.Rows.Add("Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury","Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons");

            dt.Rows.Add("Health", "Health", "Noise - leading to hearing loss", "Noise control areas, screens, engineering controls \r such as dampners, hearing protection, health surveilance");
            
            dt.Rows.Add("Health", "Health", "Dust - created by construction processes or cutting", "Elimnating the need to cut concrete or timber by off site manufacture, \r re useable materials / moulds etc, PPE last reoort, tools to manage dust creation and capture of dust, no brooms !");

            dt.Rows.Add("Catastrophic risk", "Catastrophic risk", "Fire - use of hot works or fire controlas building is built", "Hot works permit, fire watch, remove and manage housekeeping \r and storage of combustable materials, " +
                "fire risk assessment in place that considers risk of \r fire as building is constructed - temporary compartmentalisation.");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() {"working at height", "working at height", "Working at height people falling into or from things",
                "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall protection hierichy \r eliminating risk of falls. Dropped object control - tool tenthering"};
            List<string> list2 = new List<string>() {"Health", "Health", "Chemicals - use of various chemicals including \r concrete leading to skin or respitory issues or burns",
               "Alternative non hazardous chemicals, COSHH assessments and necessary controls such as PPE"};
            List<string> list3 = new List<string>() {"Health", "Health", "Vibrating tools - damaging hands",
               "enginnering controls within the vehicle such as vibration dampners, \r eliminating hand tools that cause vibration to the hand"};
            List<string> list4 = new List<string>() {"Health", "Health", "Vibrating tools - damaging hands",
               "enginnering controls within the vehicle such as vibration dampners, \r eliminating hand tools that cause vibration to the hand"};
            List<string> list5 = new List<string>() {"people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, or fall into excavation \r - also used for lifting equipment so could drop something",
               "Control of the interface between plant and people by segregating plant \r and having tight controls over anyone entering plant zones. Red Amber zone working"};
            List<string> list6 = new List<string>() {"Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury",
               "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons"};
            List<string> list7 = new List<string>() {"Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury","Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons"};
            
            List<string> list8 = new List<string>() {"Health", "Health", "Noise - leading to hearing loss", "Noise control areas, screens, engineering controls \r such as dampners, hearing protection, health surveilance"};

            List<string> list9 = new List<string>() { "Health", "Health", "Dust - created by construction processes or cutting", "Elimnating the need to cut concrete or timber by off site manufacture, \r re useable materials / moulds etc, PPE last reoort, tools to manage dust creation and capture of dust, no brooms !" };

            List<string> list10= new List<string>() { "Health", "Health", "Dust - created by construction processes or cutting", "Elimnating the need to cut concrete or timber by off site manufacture, \r re useable materials / moulds etc, PPE last reoort, tools to manage dust creation and capture of dust, no brooms !" };


            List<List<string>> alist = new List<List<string>>() { list1, list2, list3, list4, list5, list6, list7, list8, list9, list10, };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

            //DataGridTemplateColumn statusColumnb = new DataGridTemplateColumn { CanUserReorder = false, MaxWidth = 100, CanUserSort = false }; ;
            //statusColumnb.Header = "Health and Safety Risk Associated with the Activities";

        }
        public static void Wallinterior_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("working at height", "working at height", "Working at height people falling into or from things - materials falling",
                "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall protection hierichy \r eliminating risk of falls. Dropped object control - tool tenthering");

            


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() {"working at height", "working at height", "Working at height people falling into or from things",
                "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall protection hierichy \r eliminating risk of falls. Dropped object control - tool tenthering"};
         

            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

            //DataGridTemplateColumn statusColumnb = new DataGridTemplateColumn { CanUserReorder = false, MaxWidth = 100, CanUserSort = false }; ;
            //statusColumnb.Header = "Health and Safety Risk Associated with the Activities";

        }
        public static void Wallexterior_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("working at height", "working at height", "Working at height people falling into or from things - materials falling",
               "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall protection hierichy \r eliminating risk of falls. Dropped object control - tool tenthering");

            dt.Rows.Add("Health", "Health", "manual handling",   "Mechanical aids, lightweght materials - alternatives say off site manufacued panels");
            
            dt.Rows.Add("Health", "Health", "Chemicals - use of various chemicals leading to skin or respitory issues or burns", "Alternative non hazardous chemicals, COSHH assessments and necessary controls such as PPE");





            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "working at height", "working at height", "Working at height people falling into or from things - materials falling",
               "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall protection hierichy \r eliminating risk of falls. Dropped object control - tool tenthering"};
            List<string> list2 = new List<string>() { "Health", "Health", "manual handling", "Mechanical aids, lightweght materials - alternatives say off site manufacued panels"};
            List<string> list3 = new List<string>() { "Health", "Health", "Chemicals - use of various chemicals leading to skin or respitory issues or burns", "Alternative non hazardous chemicals, " +
                "COSHH assessments and necessary controls such as PPE" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Retaining_walls_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Excavations", "Excavations", "Excavations: What risk is associated with this?  Asphyiation, drowning, collapse, hitting services underground, health risks",
               "Ensuring the design of support is applicable for depth and type of soil encountered, propping and supporting trench");

            dt.Rows.Add("Underground and overhead services", "Underground and overhead services", "Underground services - Striking them whilst piling",
                "Striking a service overhead causing an electricity arc, BT cutting off supply to a house, underground striking gas, water, elec, sewage and \r causing " +
                "an explosion or flood endangering life, possible oil and gas pipelines depending on location. \r Also fibre optic - taking out business and homes");

            dt.Rows.Add("Underground and overhead services", "Underground and overhead services", "Overhead services - Hitting overhead service with plant",
                "Striking a service overhead causing an electricity arc, \r BT cutting off supply to a house, underground striking gas, water, elec, \r sewage and causing an explosion or flood" +
                " endangering life, possible oil \r and gas pipelines depending on location. Also fibre optic - taking out business and homes");

            dt.Rows.Add("people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, or fall into excavation - also used for lifting equipment so could drop something",
                "Control of the interface between plant and operators on the ground assisting with the piling operation");
            
            
            dt.Rows.Add("Health", "Health", "Vibration - whole body hand arm vibration leading to health issues", "enginnering controls within the vehicle such as vibration dampners, eliminating hand tools that cause vibration to the hand");
            dt.Rows.Add("Health", "Health", "Noise - exposure to noise leading to hearing loss", "Noise control areas, screens, engineering controls such as dampners, hearing protection, health surveilance");

            dt.Rows.Add("Health", "Health", "Chemicals - use of various chemicals leading to skin or respitory issues or burns", "Alternative non hazardous chemicals, COSHH assessments and necessary controls such as PPE");

            dt.Rows.Add("Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury", "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons");
           


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "Excavations", "Excavations", "Excavations: What risk is associated with this?  Asphyiation, drowning, collapse, hitting services underground, health risks",
               "Ensuring the design of support is applicable for depth and type of soil encountered, propping and supporting trench"};

            List<string> list2 = new List<string>() { "Underground and overhead services", "Underground and overhead services", "Underground services - Striking them whilst piling",
                "Striking a service overhead causing an electricity arc, BT cutting off supply to a house, underground striking gas, water, elec, sewage and \r causing " +
                "an explosion or flood endangering life, possible oil and gas pipelines depending on location. \r Also fibre optic - taking out business and homes" };

            List<string> list3 = new List<string>() { "Underground and overhead services", "Underground and overhead services", "Overhead services - Hitting overhead service with plant",
                "Striking a service overhead causing an electricity arc, \r BT cutting off supply to a house, underground striking gas, water, elec, \r sewage and causing an explosion or flood" +
                " endangering life, possible oil \r and gas pipelines depending on location. Also fibre optic - taking out business and homes" };

            List<string> list4 = new List<string>() { "people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, or fall into excavation - also used for lifting equipment so could drop something",
                "Control of the interface between plant and operators on the ground assisting with the piling operation"};

            List<string> list5 = new List<string>() { "Health", "Health", "Vibration - whole body hand arm vibration leading to health issues", "enginnering controls within the vehicle such as vibration dampners, eliminating hand tools that cause vibration to the hand" };

            List<string> list6 = new List<string>() { "Health", "Health", "Noise - exposure to noise leading to hearing loss", "Noise control areas, screens, engineering controls such as dampners, hearing protection, health surveilance" };

            List<string> list7 = new List<string>() { "Health", "Health", "Chemicals - use of various chemicals leading to skin or respitory issues or burns", "Alternative non hazardous chemicals, " +
                "COSHH assessments and necessary controls such as PPE" };

            List<string> list8 = new List<string>() { "Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury", "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons COSHH assessments and necessary controls such as PPE" };



            List<List<string>> alist = new List<List<string>>() { list1, list2, list3, list4, list5, list6, list7, list8 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void floorFINISH_TIMBER_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Health", "Health", "manual handling", "Mechanical aids, lightweght materials - alternatives say off site manufacued panels");
            dt.Rows.Add("Health", "Health", "Chemicals - use of various chemicals leading to skin or respitory issues or burns",
                "Alternative non hazardous chemicals, COSHH assessments and necessary controls such as PPE");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "Health", "Health", "manual handling",  "Mechanical aids, lightweght materials - alternatives say off site manufacued panels"};
            List<string> list2 = new List<string>() { "Health", "Health", "Chemicals - use of various chemicals leading to skin or respitory issues or burns",
                "Alternative non hazardous chemicals, COSHH assessments and necessary controls such as PPE" };

            List<List<string>> alist = new List<List<string>>() { list1 , list2};

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void GLAZEROOF_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Fragile surfaces", "Glazed roofs: Falls can occur through fragile surfaces, " +
                "such as fibre-cement roofs and rooflights, \r which account for 22% of all fall from height fatal injuries in the construction industry. " +
                "Death or permanent disability can occur when workers undertaking roof work and \r maintenance fall through fragile surfaces. " +
                "Statistically, these injuries appear to happen mainly to" +
                " those carrying out small and \r short-term maintenance and cleaning jobs.", "Ensure that all roofs are treated as fragile until a \r competent person" +
                " has confirmed they are non-fragile. Ensure that the following roofs are \r treated as likely to be fragile: Fibre-cement sheets;" +
                " Rooflights; Liner panels; Metal sheets; Glass; Chipboard; and Others, \r such as wood wool slabs, slates and tiles. \r Ensure that effective " +
                "precautions are taken to address the risks and hazards via a hierarchy of steps for avoidance, control, communication and co-operation.");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Fragile surfaces", "Glazed roofs: Falls can occur through fragile surfaces, " +
                "such as fibre-cement roofs and rooflights, \r which account for 22% of all fall from height fatal injuries in the construction industry. " +
                "Death or permanent disability can occur when workers undertaking roof work and \r maintenance fall through fragile surfaces. " +
                "Statistically, these injuries appear to happen mainly to" +
                " those carrying out small and \r short-term maintenance and cleaning jobs.", "Ensure that all roofs are treated as fragile until a \r competent person" +
                " has confirmed they are non-fragile. Ensure that the following roofs are \r treated as likely to be fragile: Fibre-cement sheets;" +
                " Rooflights; Liner panels; Metal sheets; Glass; Chipboard; and Others, \r such as wood wool slabs, slates and tiles. \r Ensure that effective " +
                "precautions are taken to address the risks and hazards via a hierarchy of steps for avoidance, control, communication and co-operation."};


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Roof_drainage_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Fragile surfaces", "Roof covering: Falls can occur through fragile surfaces, \r such as fibre-cement roofs and rooflights," +
                " which account for 22% of all fall from \r height fatal injuries in the construction industry. Death or permanent disability \r can occur when" +
                " workers undertaking roof work and maintenance fall through fragile surfaces. \r Statistically, these injuries appear to happen mainly to those " +
                "carrying out small and short-term maintenance and cleaning jobs.",
                "Ensure that all roofs are treated as fragile until a \r competent person has confirmed they are non-fragile. \r Ensure that the following" +
                " roofs are treated as likely to be fragile: Fibre-cement sheets; Rooflights; Liner panels; Metal sheets; Glass; Chipboard; \r and Others," +
                " such as wood wool slabs, slates and tiles. \r Ensure that effective precautions are taken to address the risks and hazards via a hierarchy" +
                " of steps for avoidance, control, communication and co-operation.");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Fragile surfaces", "Roof covering: Falls can occur through fragile surfaces, \r such as fibre-cement roofs and rooflights," +
                " which account for 22% of all fall from \r height fatal injuries in the construction industry. Death or permanent disability \r can occur when" +
                " workers undertaking roof work and maintenance fall through fragile surfaces. \r Statistically, these injuries appear to happen mainly to those " +
                "carrying out small and short-term maintenance and cleaning jobs.",
                "Ensure that all roofs are treated as fragile until a \r competent person has confirmed they are non-fragile. \r Ensure that the following" +
                " roofs are treated as likely to be fragile: Fibre-cement sheets; Rooflights; Liner panels; Metal sheets; Glass; Chipboard; \r and Others," +
                " such as wood wool slabs, slates and tiles. \r Ensure that effective precautions are taken to address the risks and hazards via a hierarchy" +
                " of steps for avoidance, control, communication and co-operation."};


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void Stairs_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Reducing the risk of falls on stairs", "There appears to be numerous incidents \r where residents or patients had falls on stairs, which \r resulted in serious injury or death.",
                "Ensure that stairs are in a safe condition and suitably \r designed and dimensioned for use, as set out in Building Regulations \r Approved Document K. " +
                "Ensure that: Stairs are well lit; Stairs have \r handrails at an appropriate height, which contrasts with the surroundings; \r Stairs have good slip resistance properties, " +
                "particularly at the leading edge; Stairs have clearly \r marked edges; and Stairs are free from trip hazards or obstacles.");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Reducing the risk of falls on stairs", "There appears to be numerous incidents \r where residents or patients had falls on stairs, which \r resulted in serious injury or death.",
                "Ensure that stairs are in a safe condition and suitably \r designed and dimensioned for use, as set out in Building Regulations \r Approved Document K. " +
                "Ensure that: Stairs are well lit; Stairs have \r handrails at an appropriate height, which contrasts with the surroundings; \r Stairs have good slip resistance properties, " +
                "particularly at the leading edge; Stairs have clearly \r marked edges; and Stairs are free from trip hazards or obstacles."};


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void roofmetal_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void rooftimber_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("NA", "Not Available", "Not Available", "Not Available");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "NA", "Not Available", "Not Available", "Not Available" };


            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void frametimber_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Temporary works", "Temporary works", "Temporary works - Poor design - install and \r maintenance leads to failure", 
                "Ensuring the design of support is applicable for type of construction,\r propping and supporting floor or any temporary structure - weight v design");
            dt.Rows.Add("working at height", "working at height", "Working at height people\r falling into or from things",
                "Ensure leading edge is protected, use of lanyards and fall \r preverntion and fall protection hierichy eliminating \r risk of falls. Dropped object control - tool tenthering");
            dt.Rows.Add("Health", "Health", "Chemicals - use of various chemicals including concrete \r leading to skin or respitory issues or burns",
            "Alternative non hazardous chemicals, \r COSHH assessments and necessary controls such as PPE");
            dt.Rows.Add("Health", "Health", "Vibrating tools \r - damaging hands",
            "enginnering controls within the \r vehicle such as vibration dampners, eliminating hand tools that \r cause vibration to the hand");
            dt.Rows.Add("people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, \r or fall into excavation - also used for lifting equipment so could drop something",
           "Control of the interface between plant and people \r by segregating plant and having tight controls over \r anyone entering plant zones. Red Amber zone working");
            dt.Rows.Add("Lifting", "Lifting", "Lifting operations - \r dropping a load and causing a crush injury",
          "Checks on lifting accessories, \r planned and authorised lift plan, exclusion zones, competent persons");
            dt.Rows.Add("Health", "Health", "Noise - leading to hearing loss",
         "Noise control areas, screens, engineering controls such as dampners, hearing protection, health surveilance");


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "Temporary works", "Temporary works", "Temporary works - Poor design - install and \r maintenance leads to failure",
                "Ensuring the design of support is applicable for type of construction,\r propping and supporting floor or any temporary structure - weight v design" };

            List<string> list2 = new List<string>() { "working at height", "working at height", "Working at height people\r falling into or from things",
                "Ensure leading edge is protected, use of lanyards and fall \r preverntion and fall protection hierichy eliminating \r risk of falls. Dropped object control - tool tenthering" };

            List<string> list3 = new List<string>() { "Health", "Health", "Chemicals - use of various chemicals including concrete \r leading to skin or respitory issues or burns",
            "Alternative non hazardous chemicals, \r COSHH assessments and necessary controls such as PPE" };
            List<string> list4 = new List<string>() { "Health", "Health", "Vibrating tools \r - damaging hands",
            "enginnering controls within the \r vehicle such as vibration dampners, eliminating hand tools that \r cause vibration to the hand" };

            List<string> list5 = new List<string>() { "people Plant Interface", "people Plant Interface", "Plant -Striking workers, overturning, \r or fall into excavation - also used for lifting equipment so could drop something",
           "Control of the interface between plant and people \r by segregating plant and having tight controls over \r anyone entering plant zones. Red Amber zone working" };

            List<string> list6 = new List<string>() { "Lifting", "Lifting", "Lifting operations - \r dropping a load and causing a crush injury",
          "Checks on lifting accessories, \r planned and authorised lift plan, exclusion zones, competent persons" };
            List<string> list7 = new List<string>() { "Health", "Health", "Noise - leading to hearing loss",      "Noise control areas, screens, engineering controls such as dampners, hearing protection, health surveilance" };


            List<List<string>> alist = new List<List<string>>() { list1, list2, list3, list4, list5, list6, list7 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void WallFinishesIsChecked_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("working at height", "working at height", "Small risk - working at height from safe platforms",
                "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall \r protection hierichy" +
                " eliminating risk of falls. Dropped object control - tool tenthering, \r inspection of any work equipment in accordance with legal requirments.");
           


            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "working at height", "working at height", "Small risk - working at height from safe platforms",
                "Ensure leading edge is protected, use of lanyards and fall preverntion and fall \r protection hierichy" +
                " eliminating risk of falls. Dropped object control - tool tenthering, \r inspection of any work equipment in accordance with legal requirments." };

         

            List<List<string>> alist = new List<List<string>>() { list1 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
        public static void floorfinish_Task_riskTable_Task_riskTable(Ui ui, Document doc)
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Health", "Health", "manual handling",
                "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall \r protection hierichy" +
                " Mechanical aids, lightweght materials - alternatives say off site manufacued panels");
            dt.Rows.Add("Health", "Health", "Chemicals - use of various chemicals leading to skin or respitory issues or burns",
         "Alternative non hazardous chemicals, \r COSHH assessments and necessary controls such as PPE");



            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "Health", "Health", "manual handling",
                "Ensure leading edge is protected, \r use of lanyards and fall preverntion and fall \r protection hierichy" +
                " Mechanical aids, lightweght materials - alternatives say off site manufacued panels" };
            List<string> list2 = new List<string>() { "Health", "Health", "Chemicals - use of various chemicals leading to skin or respitory issues or burns",
         "Alternative non hazardous chemicals, \r COSHH assessments and necessary controls such as PPE" };


            List<List<string>> alist = new List<List<string>>() { list1, list2 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
       public static void ROOF_Task_riskTable(Ui ui, Document doc)
        
        {
            ListCollectionView CollectionViewList;
            DataTable DataTableFiltered;
            DataTable dt = new DataTable();
            DataTableFiltered = new DataTable();

            dt.Columns.Add("Fatal Risk Category Status", typeof(string));
            dt.Columns.Add("Fatal Risk Category", typeof(string));
            dt.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            dt.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //dt.Columns.Add("Column4", typeof(string));
            //dt.Columns.Add("Column5", typeof(string));

            dt.Rows.Add("Roof work", "Roof work", "Roof work: There are risks of injuries, including" +
                " permanent spinal injuries when a person falls from the roof. Unfortunately, there \r is a " +
                "high risk of almost one in five deaths in construction work involving roof work.\r Unfortunate" +
                " deaths and injuries are mainly caused by falling from roof edges or openings, through \r fragile" +
                " roofs and through fragile rooflights.",
                "Ensure that a 'method statement' is developed, and precautions communicated, to help people manage work " +
                "on roofs. Ensure there is roof edge protection to prevent falling; \r Ensure risk assessments have been carried" +
                " out and safe systems of work have been devised that would prevent accidents; \r Ensure roof edge protection consisting" +
                " of suitable guard rails and toe boards are provided to prevent people falling \r from the edges of roofs where there is" +
                " a risk of falling more than two metres; and Ensure there is reliance placed on \r fall arrest equipment, for" +
                " example, safety harnesses in exceptional circumstances. Ensure that many accidents \r are avoided by the use of " +
                "the most suitable equipment, and the provision of adequate information, instruction, \r training and supervision.");

            dt.Rows.Add("Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury",
         "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons");


            dt.Rows.Add("Health", "Health", "Noise - hearning loss", "Noise control areas, screens, engineering controls \r such as dampners, hearing protection, health surveilance");

            dt.Rows.Add("Health", "Health", "Vibration - damage to hands", "enginnering controls within the vehicle such \r as vibration dampners, eliminating hand tools that cause vibration to the hand");
            dt.Rows.Add("working at height", "working at height", "Working at height people \r falling into or from things - materials falling", 
                "Ensure leading edge is protected, use of lanyards and fall preverntion and fall protection \r hierichy eliminating risk of falls. \r Dropped object control - tool tenthering");
            dt.Rows.Add("Health", "Health", "Dust - lung disease.", "Elimnating the need to cut \r concrete or timber by off site manufacture," +
                " re useable materials / moulds etc, PPE last reoort, \r tools to manage dust creation and capture of dust, no brooms !");



            DataTableFiltered.Columns.Add("Fatal Risk Category Status", typeof(string));
            DataTableFiltered.Columns.Add("Fatal Risk Category", typeof(string));
            DataTableFiltered.Columns.Add("Health and Safety Risk Associated with the Activities", typeof(string));
            DataTableFiltered.Columns.Add("GENERIC CONTROL MEASURES", typeof(string));
            //DataTableFiltered.Columns.Add("Column4", typeof(string));
            //DataTableFiltered.Columns.Add("Column5", typeof(string));
            // DataGridTableStyle table_style = new DataGridTableStyle;

            List<string> list1 = new List<string>() { "Roof work", "Roof work", "Roof work: There are risks of injuries, including" +
                " permanent spinal injuries when a person falls from the roof. Unfortunately, there \r is a " +
                "high risk of almost one in five deaths in construction work involving roof work.\r Unfortunate" +
                " deaths and injuries are mainly caused by falling from roof edges or openings, through \r fragile" +
                " roofs and through fragile rooflights.",
                "Ensure that a 'method statement' is developed, and precautions communicated, to help people manage work " +
                "on roofs. Ensure there is roof edge protection to prevent falling; \r Ensure risk assessments have been carried" +
                " out and safe systems of work have been devised that would prevent accidents; \r Ensure roof edge protection consisting" +
                " of suitable guard rails and toe boards are provided to prevent people falling \r from the edges of roofs where there is" +
                " a risk of falling more than two metres; and Ensure there is reliance placed on \r fall arrest equipment, for" +
                " example, safety harnesses in exceptional circumstances. Ensure that many accidents \r are avoided by the use of " +
                "the most suitable equipment, and the provision of adequate information, instruction, \r training and supervision." };
            List<string> list2 = new List<string>() { "Lifting", "Lifting", "Lifting operations - dropping a load and causing a crush injury",
         "Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons"};

            List<string> list3 = new List<string>() { "Health", "Health", "Noise - hearning loss", "Noise control areas, screens, engineering controls \r such as dampners, hearing protection, health surveilance" };

            List<string> list4 = new List<string>() { "Health", "Health", "Vibration - damage to hands", "enginnering controls within the vehicle such \r as vibration dampners, eliminating hand tools that cause vibration to the hand" };

            List<string> list5 = new List<string>() { "working at height", "working at height", "Working at height people \r falling into or from things - materials falling",
                "Ensure leading edge is protected, use of lanyards and fall preverntion and fall protection \r hierichy eliminating risk of falls. \r Dropped object control - tool tenthering"};

            List<string> list6 = new List<string>() { "Health", "Health", "Dust - lung disease.", "Elimnating the need to cut \r concrete or timber by off site manufacture," +
                " re useable materials / moulds etc, PPE last reoort, \r tools to manage dust creation and capture of dust, no brooms !"};


            List<List<string>> alist = new List<List<string>>() { list1, list2, list3, list4, list5, list6 };

            IList results = (IList)alist;

            CollectionViewList = new ListCollectionView(results);

            ui.dataGrid1.ItemsSource = dt.DefaultView;
            ui.dataGrid1.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            DataGridTemplateColumn statusColumn = new DataGridTemplateColumn { CanUserReorder = false, Width = 85, CanUserSort = false }; ;
            statusColumn.Header = "Fatal Risk Category Status";
            statusColumn.CellTemplateSelector = new DataTemplateSelectorBase();
            ui.dataGrid1.Columns.Insert(0, statusColumn);

        }
    }

    
}


    

       
    









