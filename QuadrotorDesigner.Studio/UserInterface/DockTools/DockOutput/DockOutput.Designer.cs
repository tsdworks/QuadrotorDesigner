
namespace QuadrotorDesigner.Studio.UserInterface.DockTools
{
    partial class DockOutput
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
            this.listOutput = new DarkUI.Controls.DarkListView();
            this.SuspendLayout();
            // 
            // listOutput
            // 
            this.listOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOutput.Location = new System.Drawing.Point(0, 25);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(500, 175);
            this.listOutput.TabIndex = 0;
            // 
            // DockOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listOutput);
            this.DefaultDockArea = DarkUI.Docking.DarkDockArea.Bottom;
            this.DockText = "Output";
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = global::QuadrotorDesigner.Studio.Properties.Resources.console_docking_icon;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DockOutput";
            this.SerializationKey = "DockOutput";
            this.Size = new System.Drawing.Size(500, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkListView listOutput;
    }
}
