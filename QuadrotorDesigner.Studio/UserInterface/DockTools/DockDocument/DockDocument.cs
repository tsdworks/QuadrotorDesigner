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

        public DockDocument(string text, string content, Image icon)
            : this()
        {
            DockText = text;
            textboxEditor.Text = content;
            Icon = icon;
        }
    }
}
