using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Docking;

namespace QuadrotorDesigner.Workspace.UserInterface.DockTools
{
    public partial class DockOutput : DarkToolWindow
    {
        public DockOutput()
        {
            InitializeComponent();
        }

        public void LogOutput(string output)
        {
            DarkListItem listItem = new DarkListItem();
            listItem.Text = output;
            listOutput.Items.Add(listItem);
        }
    }
}
