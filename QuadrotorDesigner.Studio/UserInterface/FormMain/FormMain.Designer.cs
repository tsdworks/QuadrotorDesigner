
namespace QuadrotorDesigner.Studio.UserInterface
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.modelEditor1 = new QuadrotorDesigner.Editor.Control.ModelEditor();
            this.SuspendLayout();
            // 
            // modelEditor1
            // 
            this.modelEditor1.Location = new System.Drawing.Point(116, 62);
            this.modelEditor1.Name = "modelEditor1";
            this.modelEditor1.Size = new System.Drawing.Size(800, 500);
            this.modelEditor1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 616);
            this.Controls.Add(this.modelEditor1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadrotor Designer Prototype";
            this.ResumeLayout(false);

        }

        #endregion

        private QuadrotorDesigner.Editor.Control.ModelEditor modelEditor1;
    }
}

