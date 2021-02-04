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
using QuadrotorDesigner.Workspace.Properties;

namespace QuadrotorDesigner.Workspace.UserInterface.DockTools
{
    public partial class DockComponents : DarkToolWindow
    {
        public DockComponents()
        {
            InitializeComponent();

            var nodeBody = new DarkTreeNode($"Body");
            nodeBody.Icon = Resources.folder_closed;
            nodeBody.ExpandedIcon = Resources.folder_open;
            treeComponents.Nodes.Add(nodeBody);

            var nodeMotor = new DarkTreeNode($"Motor");
            nodeMotor.Icon = Resources.folder_closed;
            nodeMotor.ExpandedIcon = Resources.folder_open;
            treeComponents.Nodes.Add(nodeMotor);

            var nodeESC = new DarkTreeNode($"ESC");
            nodeESC.Icon = Resources.folder_closed;
            nodeESC.ExpandedIcon = Resources.folder_open;
            treeComponents.Nodes.Add(nodeESC);

            var nodeBattery = new DarkTreeNode($"Battery");
            nodeBattery.Icon = Resources.folder_closed;
            nodeBattery.ExpandedIcon = Resources.folder_open;
            treeComponents.Nodes.Add(nodeBattery);

            var nodePropeller = new DarkTreeNode($"Propeller");
            nodePropeller.Icon = Resources.folder_closed;
            nodePropeller.ExpandedIcon = Resources.folder_open;
            treeComponents.Nodes.Add(nodePropeller);

            var nodeDevice = new DarkTreeNode($"Device");
            nodeDevice.Icon = Resources.folder_closed;
            nodeDevice.ExpandedIcon = Resources.folder_open;
            treeComponents.Nodes.Add(nodeDevice);

            var nodeRC = new DarkTreeNode($"RC");
            nodeRC.Icon = Resources.folder_closed;
            nodeRC.ExpandedIcon = Resources.folder_open;
            treeComponents.Nodes.Add(nodeRC);

            var nodeFlightController = new DarkTreeNode($"Flight Controller");
            nodeFlightController.Icon = Resources.folder_closed;
            nodeFlightController.ExpandedIcon = Resources.folder_open;
            treeComponents.Nodes.Add(nodeFlightController);
        }
    }
}
