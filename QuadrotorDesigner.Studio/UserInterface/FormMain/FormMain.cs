using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI;
using DarkUI.Forms;
using DarkUI.Win32;
using QuadrotorDesigner.Studio.IO;
using QuadrotorDesigner.Studio.Properties;

namespace QuadrotorDesigner.Studio.UserInterface
{
    public partial class FormMain : DarkForm
    {
        public FormMain()
        {
            InitializeComponent();

            // load dock panel
            DisplayInitializeDockPanel();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisplaySerializeDockPanel(FStream.CombinePath(Application.StartupPath, Resources.DockConfigFile, false));
        }

        private void menuItemComponentsExplorer_Click(object sender, EventArgs e)
        {
            DisplayToggleDockWindow(dockToolComponents);
            DisplaySetupMenu();
        }

        private void menuItemProperties_Click(object sender, EventArgs e)
        {
            DisplayToggleDockWindow(dockToolProperties);
            DisplaySetupMenu();
        }

        private void menuItemOutput_Click(object sender, EventArgs e)
        {
            DisplayToggleDockWindow(dockToolOutput);
            DisplaySetupMenu();
        }

        private void dockPanelMain_ContentAdded(object sender, DarkUI.Docking.DockContentEventArgs e)
        {
            DisplaySetupMenu();
        }

        private void dockPanelMain_ContentRemoved(object sender, DarkUI.Docking.DockContentEventArgs e)
        {
            DisplaySetupMenu();
        }
    }
}
