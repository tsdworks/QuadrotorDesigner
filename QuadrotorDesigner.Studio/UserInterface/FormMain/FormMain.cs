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
using QuadrotorDesigner.Utils.IOStream;
using QuadrotorDesigner.Workspace.Properties;
using QuadrotorDesigner.Workspace.UserInterface.DockTools;

namespace QuadrotorDesigner.Workspace.UserInterface
{
    public partial class FormMain : DarkForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // load dock panel
            DisplayInitializeDockPanel();

            // setup binding
            DisplaySetupBinding();

            // log workspace
            dockToolOutput.LogOutput("Workspace Initialized.");
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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

        private void buttonRunAnalysis_Click(object sender, EventArgs e)
        {
            dockPanelMain.AddContent(new DockDocument("Result", DocumentManager.CurrentAssembly.DroneDesigner.Valide(), false, Resources.design_icon));
        }

        private void contextMenuTreeViewSelect_Click(object sender, EventArgs e)
        {
            if (DocumentManager.CurrentSelectedModelNode != null && DocumentManager.CurrentAssembly != null)
            {
                if (!DocumentManager.CurrentSelectedModelNode.Selected)
                {
                    if (DocumentManager.CurrentAssembly.DroneDesigner.AddComponent(
                        DocumentManager.CurrentSelectedModelNode.ModelType, DocumentManager.CurrentSelectedModelNode))
                    {
                        treeViewManager.Refresh(DocumentManager.CurrentAssembly.DroneDesigner.CalcRelation());
                        dockToolOutput.LogOutput("Select " + DocumentManager.CurrentSelectedModelNode.ModelFileName);

                        DocumentManager.CurrentAssembly.AssemblyUpdateEditor();
                    }
                }
                else
                {
                    if (DocumentManager.CurrentAssembly.DroneDesigner.DeleteComponent(
                           DocumentManager.CurrentSelectedModelNode.ModelType, DocumentManager.CurrentSelectedModelNode))
                    {
                        treeViewManager.Refresh(DocumentManager.CurrentAssembly.DroneDesigner.CalcRelation());
                        dockToolOutput.LogOutput("Float " + DocumentManager.CurrentSelectedModelNode.ModelFileName);

                        DocumentManager.CurrentAssembly.AssemblyUpdateEditor();
                    }

                }
            }
        }

        private void contextMenuTreeView_Opening(object sender, CancelEventArgs e)
        {
            contextMenuTreeViewSelect.Text = DocumentManager.CurrentSelectedModelNode.Selected ? "Float" : "Select";
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            DisplaySetMenuEnable();
        }

        private void menuItemRunAnalysis_Click(object sender, EventArgs e)
        {
            buttonRunAnalysis_Click(null, null);
        }

        private void menuItemNewDesign_Click(object sender, EventArgs e)
        {
            FormNewDesign formNewDesign = new FormNewDesign();

            if (formNewDesign.ShowDialog() == DialogResult.OK)
            {
                DocumentManager.CurrentAssembly.AssemblyUpdateEditor();
                dockPanelMain.AddContent(DocumentManager.CurrentAssembly.DockDocument);
            }
        }
    }
}
