using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkUI.Forms;
using DarkUI.Controls;
using QuadrotorDesigner.Workspace.Properties;
using static QuadrotorDesigner.Workspace.DocumentManager;

namespace QuadrotorDesigner.Workspace
{
    public class ComponentTreeView
    {
        public class TreeViewManager
        {
            public delegate void ItemDoubleClickedHandler(ComponentDocument currentSelectDocument);
            public event ItemDoubleClickedHandler ItemDoubleClicked;

            public delegate void ItemRightClickedHandler(ComponentDocument currentSelectDocument);
            public event ItemRightClickedHandler ItemRightClicked;

            public delegate void ItemNodeSelectedHandler(ComponentDocument currentSelectDocument);
            public event ItemNodeSelectedHandler ItemNodeSelected;

            public DarkTreeView ComponentTreeView;

            public TreeViewManager(DarkTreeView componentTreeView)
            {
                ComponentTreeView = componentTreeView;

                ComponentTreeView.DoubleClick += (_a, _b) =>
                {
                    if (ComponentTreeView.SelectedNodes.Count == 1 && componentTreeView.SelectedNodes[0].Tag != null)
                    {
                        ItemDoubleClicked?.Invoke((ComponentDocument) componentTreeView.SelectedNodes[0].Tag);
                    }
                };

                ComponentTreeView.MouseDown += (_a, _b) =>
                {
                    if (_b.Button == System.Windows.Forms.MouseButtons.Right)
                    {
                        if (ComponentTreeView.SelectedNodes.Count == 1 && componentTreeView.SelectedNodes[0].Tag != null)
                        {
                            ItemRightClicked?.Invoke((ComponentDocument)componentTreeView.SelectedNodes[0].Tag);
                        }
                    }
                };

                ComponentTreeView.SelectedNodesChanged += (_a, _b) =>
                {
                    if (ComponentTreeView.SelectedNodes.Count == 1 && componentTreeView.SelectedNodes[0].Tag != null)
                    {
                        ItemNodeSelected?.Invoke((ComponentDocument)componentTreeView.SelectedNodes[0].Tag);
                    }
                };
            }

            public void Initialize()
            {
                if (ComponentTreeView != null)
                {
                    ComponentTreeView.Nodes.Clear();

                    string[] treeViewRootList = Resources.ComponentsTypeList.Split(Resources.SplitChar[0]);

                    foreach (string rootName in treeViewRootList)
                    {
                        var currentNode = new DarkTreeNode(rootName);
                        currentNode.Icon = Resources.folder_closed;
                        currentNode.ExpandedIcon = Resources.folder_open;
                        currentNode.Expanded = true;
                        ComponentTreeView.Nodes.Add(currentNode);
                    }
                }
            }

            public void Refresh(List<ComponentDocument> currentModelList)
            {
                Initialize();

                foreach (var modelDocument in currentModelList)
                {
                    if (modelDocument.ModelType != Components.Model.ModelTypeList.Assembly)
                    {
                        var currentNode = new DarkTreeNode(modelDocument.ModelFileName);
                        currentNode.Icon = modelDocument.Selected ? Resources.properties_docking_icon : Resources.component_file;
                        currentNode.Tag = modelDocument;
                        ComponentTreeView.Nodes[(int)modelDocument.ModelType - 1].Nodes.Add(currentNode);
                    }
                }

                ComponentTreeView.Refresh();
            }
        }
    }
}
