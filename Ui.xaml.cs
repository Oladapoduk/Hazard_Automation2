using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

using Hazard_Automation.RVT;
using Hazard_Automation.Business;
using Hazard_Automation.LogicBusiness;
using System.Threading;

using System.Data;

using System.Globalization;

using Hazard_Automation.LogicBusinessb;





namespace Hazard_Automation
{
    /// <summary>
    /// Interaction logic for Ui.xaml
    /// </summary>
    [Transaction(TransactionMode.ReadOnly)]
    public partial class Ui : Window

    {
        //public Document document;
        //public UIDocument uidoc = null;
        //public ExternalCommandData eData = null;

        //public string message=null; 
        //public ElementSet elements =null;
        //readonly List<items> it = new List<items>();
        private readonly Document _doc;

        //private readonly UIApplication _uiApp;
        //private readonly Autodesk.Revit.ApplicationServices.Application _app;
        private readonly UIDocument _uiDoc;

        private readonly EventHandlerWithStringArg _mExternalMethodStringArg;
        private readonly EventHandlerWithWpfArg _mExternalMethodWpfArg;
        private readonly EventHandlerWithWpfArgb _mEventHandlerWithWpfArgb;
        private readonly EventHandlerWithWpfArgc _mEventHandlerWithWpfArgc;
        private readonly EventHandlerWithWpfArgd _mEventHandlerWithWpfArgd;
        private readonly EventHandlerWithWpfArge _mEventHandlerWithWpfArge;
        private readonly EventHandlerWithWpfArgf _mEventHandlerWithWpfArgf;






        //public Ui(Document doc)
        //{
        //    InitializeComponent();
        //    Window win = new Window();
        //    ///  win.Content = userControl;
        //    win.Show();
        //}
        public Ui(UIApplication uiApp, EventHandlerWithStringArg evExternalMethodStringArg,     EventHandlerWithWpfArg eExternalMethodWpfArg, 
            EventHandlerWithWpfArgb eExternalMethodWpfArgb, EventHandlerWithWpfArgc eExternalMethodWpfArgbc, EventHandlerWithWpfArgd eExternalMethodWpfArgbd, EventHandlerWithWpfArge eExternalMethodWpfArgbe, EventHandlerWithWpfArgf eExternalMethodWpfArgbf)
       
        {
            _uiDoc = uiApp.ActiveUIDocument;
            _doc = _uiDoc.Document;
            //_app = _doc.Application;
            //_uiApp = _doc.Application;
            Closed += MainWindow_Closed;

            InitializeComponent();
            _mExternalMethodStringArg = evExternalMethodStringArg;
            _mExternalMethodWpfArg = eExternalMethodWpfArg;
            _mEventHandlerWithWpfArgb = eExternalMethodWpfArgb;
            _mEventHandlerWithWpfArgc = eExternalMethodWpfArgbc;
            _mEventHandlerWithWpfArgd = eExternalMethodWpfArgbd;
            _mEventHandlerWithWpfArge = eExternalMethodWpfArgbe;
            _mEventHandlerWithWpfArgf = eExternalMethodWpfArgbf;
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            Close();
        }


        private void ShowHazzardButton_Click(object sender, RoutedEventArgs e)
        {
      
            _mExternalMethodWpfArg.Raise(this);

        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            _mEventHandlerWithWpfArgb.Raise(this);

        }

        private void HSR_Click(object sender, RoutedEventArgs e)
        {
            _mEventHandlerWithWpfArgd.Raise(this);
        }

        private void ShowRiskCategory_Click(object sender, RoutedEventArgs e)
        {
            _mEventHandlerWithWpfArgc.Raise(this);

        }
        private void BExtString_Click(object sender, RoutedEventArgs e)
        {
            // Raise external event with a string argument. The string MAY
            // be pulled from a Revit API context because this is an external event
            _mExternalMethodStringArg.Raise($"Title: {_doc.Title}");
        }

        private void BExternalMethod1_Click(object sender, RoutedEventArgs e)
        {
            // Raise external event with this UI instance (WPF) as an argument
            _mExternalMethodWpfArg.Raise(this);
        }

        private void Showallelements_Click(object sender, RoutedEventArgs e)
        {
            _mEventHandlerWithWpfArge.Raise(this);
        }

        private void ArrayButton_Click(object sender, RoutedEventArgs e)
        {
            _mEventHandlerWithWpfArgf.Raise(this);
        }


    }
    public class items
    {
        public string RiskCategory { get; set; }
        public string hsr { get; set; }
        public string gcm { get; set; }
        public string RiskCategoryb { get; set; }
    }

    public class DelayAction : IDisposable
    {
        private Timer timer;

        public static DelayAction Initialize(Action action)
        {
            if (action == null)
            {
                throw new ArgumentNullException("DeferredAction Initialize NULL excpetion");
            }

            return new DelayAction(action);
        }

        private DelayAction(Action action)
        {
            this.timer = new Timer(new TimerCallback(delegate
            {
                Application.Current.Dispatcher.Invoke(action);
            }));
        }

        public void Wait(TimeSpan delay)
        {
            this.timer.Change(delay, TimeSpan.FromMilliseconds(-1));
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (this.timer != null)
            {
                this.timer.Dispose();
                this.timer = null;
            }
        }

        #endregion
    }
    public class DataTemplateSelectorBase : DataTemplateSelector
    {
        protected Ui GetMainWindow(DependencyObject inContainer)
        {
            DependencyObject c = inContainer;
            while (true)
            {
                DependencyObject p = VisualTreeHelper.GetParent(c);

                if (c is Ui)
                {
                    return c as Ui;
                }
                else
                {
                    c = p;
                }
            }
        }

        public override DataTemplate SelectTemplate(object inItem, DependencyObject inContainer)
        {
            DataRowView row = inItem as DataRowView;

            if (row != null)
            {
                if (row.DataView.Table.Columns.Contains("Fatal Risk Category Status"))
                {
                    Ui w = GetMainWindow(inContainer);
                    return (DataTemplate)w.FindResource("StatusImage");
                }
            }
            return null;
        }

    }
    public class BoolToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DataRowView)
            {
                DataRowView row = value as DataRowView;

                if (row != null)
                {
                    if (row.DataView.Table.Columns.Contains("Fatal Risk Category Status"))
                    {
                        Type type = row["Fatal Risk Category Status"].GetType();
                        string status = (string)row["Fatal Risk Category Status"];
                        if (status == "working at height")
                        {
                            Uri uriImage = new Uri("pack://application:,,,/Hazard_Automation;component/Resources/Risk-Height.png");
                           // Uri uri = new Uri("pack://application:,,,Hazard_Automation;component/Resources/yellow.jpg");
                            //"pack://application:,,,/Images/yellow.jpg"
                            ///Hazard_Automation;component
                            BitmapImage source = new BitmapImage(uriImage);
                            return source;
                        }
                        if (status == "Lifting")
                        {
                            //Uri uri = new Uri("pack://application:,,,/Images/green.jpg");
                            Uri uriImage = new Uri("pack://application:,,,/Hazard_Automation;component/Resources/Risk-Lifting.png");
                            //Uri uri = new Uri("pack://application:,,,Hazard_Automation;component/Resources/green.jpg");
                            //Uri uriImage = new Uri("pack://application:,,,/Hazard_Automation;component/Resources/risk_png.png");
                            ///Hazard_Automation;component
                            BitmapImage source = new BitmapImage(uriImage);
                            return source;
                        }
                        if (status == "Health")
                        {
                            Uri uriImage = new Uri("pack://application:,,,/Hazard_Automation;component/Resources/Risk-Health.png");
                            //Uri uri = new Uri("pack://application:,,,Hazard_Automation;component/Resources/red.jpg");
                            //"pack://application:,,,/Images/red.jpg"
                            ///Hazard_Automation;component
                            BitmapImage source = new BitmapImage(uriImage);
                            return source;
                        }
                        if (status == "Excavations")
                        {
                            Uri uriImage = new Uri("pack://application:,,,/Hazard_Automation;component/Resources/Risk-Excavations.png");
                            //Uri uri = new Uri("pack://application:,,,Hazard_Automation;component/Resources/red.jpg");
                            //"pack://application:,,,/Images/red.jpg"
                            ///Hazard_Automation;component
                            BitmapImage source = new BitmapImage(uriImage);
                            return source;
                        }
                
                        if (status == "Underground and overhead services")
                        {
                            Uri uriImage = new Uri("pack://application:,,,/Hazard_Automation;component/Resources/Risk-UGServices.png");
                            //Uri uri = new Uri("pack://application:,,,Hazard_Automation;component/Resources/red.jpg");
                            //"pack://application:,,,/Images/red.jpg"
                            ///Hazard_Automation;component
                            BitmapImage source = new BitmapImage(uriImage);
                            return source;
                        }
                        if (status == "people Plant Interface")
                        {
                            Uri uriImage = new Uri("pack://application:,,,/Hazard_Automation;component/Resources/Risk-PeoplePlantInterface.png");
                            //Uri uri = new Uri("pack://application:,,,Hazard_Automation;component/Resources/red.jpg");
                            //"pack://application:,,,/Images/red.jpg"
                            ///Hazard_Automation;component
                            BitmapImage source = new BitmapImage(uriImage);
                            return source;
                        }
                        if (status == "Catastrophic risk")
                        {
                            Uri uriImage = new Uri("pack://application:,,,/Hazard_Automation;component/Resources/Risk-Catastrophe.png");
                            //Uri uri = new Uri("pack://application:,,,Hazard_Automation;component/Resources/red.jpg");
                            //"pack://application:,,,/Images/red.jpg"
                            ///Hazard_Automation;component
                            BitmapImage source = new BitmapImage(uriImage);
                            return source;
                        }
                        if (status == "NA")
                        {
                            Uri uriImage = new Uri("pack://application:,,,/Hazard_Automation;component/Resources/code.png");
                            //Uri uri = new Uri("pack://application:,,,Hazard_Automation;component/Resources/red.jpg");
                            //"pack://application:,,,/Images/red.jpg"
                            ///Hazard_Automation;component
                            BitmapImage source = new BitmapImage(uriImage);
                            return source;
                        }
                    }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }

}
