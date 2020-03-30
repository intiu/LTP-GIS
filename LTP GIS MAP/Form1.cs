using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace LTP_GIS_MAP
{
    public partial class Form1 : Form
    {
        [Export("Shell", typeof(ContainerControl))]
        private static ContainerControl Shell;
        public Form1()
        {
            InitializeComponent();
            if (DesignMode) return;
            Shell = this;
            appManager1.LoadExtensions();
        }
    }
}
