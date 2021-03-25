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
        public DockDocument()
        {
            InitializeComponent();
        }

        public DockDocument(DocumentManager.ComponentDocument currentDocument)
            : this()
        {
            DockText = currentDocument.ModelFileWindowTitle;
            textboxEditor.Text = currentDocument.JSONText;
            textboxEditor.ReadOnly = !currentDocument.Editable;
            Icon = currentDocument.DoucumentIcon;
        }

        public DockDocument(string title, string text, bool editable, Bitmap icon)
            : this()
        {
            DockText = title;
            textboxEditor.Text = text;
            textboxEditor.ReadOnly = !editable;
            Icon = icon;
        }

    }
}
