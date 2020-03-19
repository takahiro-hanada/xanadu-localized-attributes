using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Demo
{
    sealed partial class MainForm : Form
    {
        static MainForm()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja");
        }

        public MainForm()
        {
            InitializeComponent();
            
            propertyGrid1.SelectedObject = new Person();
        }
    }
}
