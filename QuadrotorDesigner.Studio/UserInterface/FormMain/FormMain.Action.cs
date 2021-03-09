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

namespace QuadrotorDesigner.Workspace.UserInterface
{
    public partial class FormMain : DarkForm
    {
        private void ActionSelectorDoubleClicked(DocumentManager.ComponentDocument currentDocument)
        {
            dockPanelMain.AddContent(currentDocument.DockDocument);
        }

        private void ActionSelectorRightClicked(DocumentManager.ComponentDocument currentDocument)
        {
            
        }

        private void ActionSelectorNodeChanged(DocumentManager.ComponentDocument currentDocument)
        {
            dockToolProperties.DisplayShowDetail(currentDocument.JSONText);
        }
    }
}
