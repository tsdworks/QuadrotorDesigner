
namespace QuadrotorDesigner.Workspace.UserInterface.DockTools
{
    partial class DockDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockDocument));
            this.textboxEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textboxEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxEditor
            // 
            this.textboxEditor.AutoCompleteBracketsList = new char[] {
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
            this.textboxEditor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.textboxEditor.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.textboxEditor.BackBrush = null;
            this.textboxEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.textboxEditor.BookmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(110)))), ((int)(((byte)(175)))));
            this.textboxEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.textboxEditor.CharHeight = 14;
            this.textboxEditor.CharWidth = 8;
            this.textboxEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textboxEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxEditor.FoldingIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(110)))), ((int)(((byte)(175)))));
            this.textboxEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textboxEditor.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.textboxEditor.IsReplaceMode = false;
            this.textboxEditor.Language = FastColoredTextBoxNS.Language.DARK_JSON;
            this.textboxEditor.LeftBracket = '[';
            this.textboxEditor.LeftBracket2 = '{';
            this.textboxEditor.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textboxEditor.Location = new System.Drawing.Point(0, 0);
            this.textboxEditor.Name = "textboxEditor";
            this.textboxEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.textboxEditor.RightBracket = ']';
            this.textboxEditor.RightBracket2 = '}';
            this.textboxEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(110)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.textboxEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("textboxEditor.ServiceColors")));
            this.textboxEditor.Size = new System.Drawing.Size(659, 431);
            this.textboxEditor.TabIndex = 4;
            this.textboxEditor.TextAreaBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.textboxEditor.Zoom = 100;
            // 
            // DockDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textboxEditor);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DockDocument";
            this.SerializationKey = "";
            this.Size = new System.Drawing.Size(659, 431);
            ((System.ComponentModel.ISupportInitialize)(this.textboxEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FastColoredTextBoxNS.FastColoredTextBox textboxEditor;
    }
}
