using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI;
using DarkUI.Forms;
using DarkUI.Win32;
using QuadrotorDesigner.Utils.IOStream;
using QuadrotorDesigner.Workspace.Properties;

namespace QuadrotorDesigner.Workspace.UserInterface
{
    public partial class FormNewDesign : DarkForm
    {
        public FormNewDesign()
        {
            InitializeComponent();
        }

        private void buttonDesignFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Design File|*" + Resources.DesignFileExtName;
            saveFileDialog.FileName = textBoxAuthor.Text + "-" + textboxName.Text + Resources.DesignFileExtName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDesignFile.Text = saveFileDialog.FileName;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            buttonOK.Enabled =
                textBoxAuthor.Text != string.Empty && textboxName.Text != string.Empty
                && textboxDescription.Text != string.Empty && textBoxDesignFile.Text != string.Empty;

            buttonDesignFile.Enabled = textBoxAuthor.Text != string.Empty && textboxName.Text != string.Empty
                && textboxDescription.Text != string.Empty;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DocumentManager.NewAssembly(textboxName.Text, textBoxAuthor.Text, textboxDescription.Text, Path.GetFileName(textBoxDesignFile.Text),
                textBoxDesignFile.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
