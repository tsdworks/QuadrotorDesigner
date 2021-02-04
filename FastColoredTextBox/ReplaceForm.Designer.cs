namespace FastColoredTextBoxNS
{
    partial class ReplaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceForm));
            this.btClose = new DarkUI.Controls.DarkButton();
            this.btFindNext = new DarkUI.Controls.DarkButton();
            this.tbFind = new DarkUI.Controls.DarkTextBox();
            this.cbRegex = new DarkUI.Controls.DarkCheckBox();
            this.cbMatchCase = new DarkUI.Controls.DarkCheckBox();
            this.labelFind = new DarkUI.Controls.DarkLabel();
            this.cbWholeWord = new DarkUI.Controls.DarkCheckBox();
            this.btReplace = new DarkUI.Controls.DarkButton();
            this.btReplaceAll = new DarkUI.Controls.DarkButton();
            this.labelReplace = new DarkUI.Controls.DarkLabel();
            this.tbReplace = new DarkUI.Controls.DarkTextBox();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClose.Location = new System.Drawing.Point(277, 142);
            this.btClose.Name = "btClose";
            this.btClose.Padding = new System.Windows.Forms.Padding(5);
            this.btClose.Size = new System.Drawing.Size(75, 21);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btFindNext
            // 
            this.btFindNext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFindNext.Location = new System.Drawing.Point(115, 115);
            this.btFindNext.Name = "btFindNext";
            this.btFindNext.Padding = new System.Windows.Forms.Padding(5);
            this.btFindNext.Size = new System.Drawing.Size(75, 21);
            this.btFindNext.TabIndex = 5;
            this.btFindNext.Text = "Find next";
            this.btFindNext.Click += new System.EventHandler(this.btFindNext_Click);
            // 
            // tbFind
            // 
            this.tbFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tbFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tbFind.Location = new System.Drawing.Point(66, 11);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(286, 23);
            this.tbFind.TabIndex = 0;
            this.tbFind.TextChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // cbRegex
            // 
            this.cbRegex.AutoSize = true;
            this.cbRegex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRegex.Location = new System.Drawing.Point(292, 35);
            this.cbRegex.Name = "cbRegex";
            this.cbRegex.Size = new System.Drawing.Size(63, 21);
            this.cbRegex.TabIndex = 3;
            this.cbRegex.Text = "Regex";
            this.cbRegex.CheckedChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbMatchCase.Location = new System.Drawing.Point(66, 35);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(93, 21);
            this.cbMatchCase.TabIndex = 1;
            this.cbMatchCase.Text = "Match case";
            this.cbMatchCase.CheckedChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelFind.Location = new System.Drawing.Point(23, 13);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(39, 17);
            this.labelFind.TabIndex = 5;
            this.labelFind.Text = "Find: ";
            // 
            // cbWholeWord
            // 
            this.cbWholeWord.AutoSize = true;
            this.cbWholeWord.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbWholeWord.Location = new System.Drawing.Point(156, 35);
            this.cbWholeWord.Name = "cbWholeWord";
            this.cbWholeWord.Size = new System.Drawing.Size(135, 21);
            this.cbWholeWord.TabIndex = 2;
            this.cbWholeWord.Text = "Match whole word";
            this.cbWholeWord.CheckedChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            // 
            // btReplace
            // 
            this.btReplace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReplace.Location = new System.Drawing.Point(196, 115);
            this.btReplace.Name = "btReplace";
            this.btReplace.Padding = new System.Windows.Forms.Padding(5);
            this.btReplace.Size = new System.Drawing.Size(75, 21);
            this.btReplace.TabIndex = 6;
            this.btReplace.Text = "Replace";
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btReplaceAll
            // 
            this.btReplaceAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReplaceAll.Location = new System.Drawing.Point(277, 115);
            this.btReplaceAll.Name = "btReplaceAll";
            this.btReplaceAll.Padding = new System.Windows.Forms.Padding(5);
            this.btReplaceAll.Size = new System.Drawing.Size(75, 21);
            this.btReplaceAll.TabIndex = 7;
            this.btReplaceAll.Text = "Replace all";
            this.btReplaceAll.Click += new System.EventHandler(this.btReplaceAll_Click);
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelReplace.Location = new System.Drawing.Point(6, 75);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(57, 17);
            this.labelReplace.TabIndex = 9;
            this.labelReplace.Text = "Replace:";
            // 
            // tbReplace
            // 
            this.tbReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tbReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReplace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tbReplace.Location = new System.Drawing.Point(66, 72);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(286, 23);
            this.tbReplace.TabIndex = 0;
            this.tbReplace.TextChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            this.tbReplace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 176);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.labelReplace);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.btReplaceAll);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.cbWholeWord);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.cbRegex);
            this.Controls.Add(this.btFindNext);
            this.Controls.Add(this.btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton btClose;
        private DarkUI.Controls.DarkButton btFindNext;
        private DarkUI.Controls.DarkCheckBox cbRegex;
        private DarkUI.Controls.DarkCheckBox cbMatchCase;
        private DarkUI.Controls.DarkLabel labelFind;
        private DarkUI.Controls.DarkCheckBox cbWholeWord;
        private DarkUI.Controls.DarkButton btReplace;
        private DarkUI.Controls.DarkButton btReplaceAll;
        private DarkUI.Controls.DarkLabel labelReplace;
        public DarkUI.Controls.DarkTextBox tbFind;
        public DarkUI.Controls.DarkTextBox tbReplace;
    }
}