
namespace QuadrotorDesigner.Workspace.UserInterface
{
    partial class FormNewDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewDesign));
            this.labelAuthor = new DarkUI.Controls.DarkLabel();
            this.textBoxAuthor = new DarkUI.Controls.DarkTextBox();
            this.textboxName = new DarkUI.Controls.DarkTextBox();
            this.labelName = new DarkUI.Controls.DarkLabel();
            this.textboxDescription = new DarkUI.Controls.DarkTextBox();
            this.labelDescription = new DarkUI.Controls.DarkLabel();
            this.textBoxDesignFile = new DarkUI.Controls.DarkTextBox();
            this.labelDesignFile = new DarkUI.Controls.DarkLabel();
            this.buttonDesignFile = new DarkUI.Controls.DarkButton();
            this.buttonCancel = new DarkUI.Controls.DarkButton();
            this.buttonOK = new DarkUI.Controls.DarkButton();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelAuthor.Location = new System.Drawing.Point(9, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 17);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxAuthor.Location = new System.Drawing.Point(12, 29);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(310, 23);
            this.textBoxAuthor.TabIndex = 1;
            // 
            // textboxName
            // 
            this.textboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textboxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textboxName.Location = new System.Drawing.Point(12, 78);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(310, 23);
            this.textboxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelName.Location = new System.Drawing.Point(9, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // textboxDescription
            // 
            this.textboxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textboxDescription.Location = new System.Drawing.Point(12, 127);
            this.textboxDescription.Multiline = true;
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.Size = new System.Drawing.Size(310, 53);
            this.textboxDescription.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelDescription.Location = new System.Drawing.Point(9, 107);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(74, 17);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDesignFile
            // 
            this.textBoxDesignFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxDesignFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDesignFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxDesignFile.Location = new System.Drawing.Point(12, 204);
            this.textBoxDesignFile.Name = "textBoxDesignFile";
            this.textBoxDesignFile.ReadOnly = true;
            this.textBoxDesignFile.Size = new System.Drawing.Size(280, 23);
            this.textBoxDesignFile.TabIndex = 7;
            // 
            // labelDesignFile
            // 
            this.labelDesignFile.AutoSize = true;
            this.labelDesignFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelDesignFile.Location = new System.Drawing.Point(9, 184);
            this.labelDesignFile.Name = "labelDesignFile";
            this.labelDesignFile.Size = new System.Drawing.Size(71, 17);
            this.labelDesignFile.TabIndex = 6;
            this.labelDesignFile.Text = "Design File";
            // 
            // buttonDesignFile
            // 
            this.buttonDesignFile.Location = new System.Drawing.Point(298, 204);
            this.buttonDesignFile.Name = "buttonDesignFile";
            this.buttonDesignFile.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDesignFile.Size = new System.Drawing.Size(24, 23);
            this.buttonDesignFile.TabIndex = 8;
            this.buttonDesignFile.Text = "...";
            this.buttonDesignFile.Click += new System.EventHandler(this.buttonDesignFile_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(247, 243);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(166, 243);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Padding = new System.Windows.Forms.Padding(5);
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Design File|*.assembly";
            // 
            // FormNewDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 278);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDesignFile);
            this.Controls.Add(this.textBoxDesignFile);
            this.Controls.Add(this.labelDesignFile);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Drone Design";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel labelAuthor;
        private DarkUI.Controls.DarkTextBox textBoxAuthor;
        private DarkUI.Controls.DarkTextBox textboxName;
        private DarkUI.Controls.DarkLabel labelName;
        private DarkUI.Controls.DarkTextBox textboxDescription;
        private DarkUI.Controls.DarkLabel labelDescription;
        private DarkUI.Controls.DarkTextBox textBoxDesignFile;
        private DarkUI.Controls.DarkLabel labelDesignFile;
        private DarkUI.Controls.DarkButton buttonDesignFile;
        private DarkUI.Controls.DarkButton buttonCancel;
        private DarkUI.Controls.DarkButton buttonOK;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}