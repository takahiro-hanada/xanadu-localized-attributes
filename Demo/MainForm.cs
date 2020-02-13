using System.Windows.Forms;

namespace Demo
{
    public partial class MainfForm : Form
    {
        public MainfForm()
        {
            InitializeComponent();

            propertyGrid1.SelectedObject = new Person();
        }
    }
}
