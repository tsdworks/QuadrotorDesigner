using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Config;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;

namespace QuadrotorDesigner.Workspace.UserInterface.DockTools
{
    public partial class DockDocument : DarkDocument
    {
        public void SetEditorContent(string Content)
        {
            textboxEditor.Text = Content;
        }

        public string GetEditorContent()
        {
            return textboxEditor.Text;
        }

        public void SetEditorReadonly(bool Editable)
        {
            textboxEditor.ReadOnly = !Editable;
        }
    }
}
