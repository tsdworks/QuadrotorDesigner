namespace QuadrotorDesigner.Editor.Control
{
    partial class ModelEditor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelEditor));
            this.ColoredEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ColoredEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // ColoredEditor
            // 
            this.ColoredEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ColoredEditor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.ColoredEditor.AutoScrollMinSize = new System.Drawing.Size(387, 3444);
            this.ColoredEditor.BackBrush = null;
            this.ColoredEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ColoredEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ColoredEditor.CharHeight = 14;
            this.ColoredEditor.CharWidth = 8;
            this.ColoredEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ColoredEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ColoredEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColoredEditor.FoldingIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColoredEditor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ColoredEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColoredEditor.IsReplaceMode = false;
            this.ColoredEditor.Language = FastColoredTextBoxNS.Language.DARK_JSON;
            this.ColoredEditor.LeftBracket = '[';
            this.ColoredEditor.LeftBracket2 = '{';
            this.ColoredEditor.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColoredEditor.Location = new System.Drawing.Point(0, 0);
            this.ColoredEditor.Name = "ColoredEditor";
            this.ColoredEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.ColoredEditor.RightBracket = ']';
            this.ColoredEditor.RightBracket2 = '}';
            this.ColoredEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ColoredEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ColoredEditor.ServiceColors")));
            this.ColoredEditor.Size = new System.Drawing.Size(800, 500);
            this.ColoredEditor.TabIndex = 0;
            this.ColoredEditor.Text = resources.GetString("ColoredEditor.Text");
            this.ColoredEditor.Zoom = 100;
            // 
            // ModelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ColoredEditor);
            this.Name = "ModelEditor";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.ColoredEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox ColoredEditor;
    }
}
