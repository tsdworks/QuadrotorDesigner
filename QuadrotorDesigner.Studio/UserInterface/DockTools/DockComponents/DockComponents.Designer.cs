
namespace QuadrotorDesigner.Studio.UserInterface.DockTools
{
    partial class DockComponents
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
            this.treeComponents = new DarkUI.Controls.DarkTreeView();
            this.SuspendLayout();
            // 
            // treeComponents
            // 
            this.treeComponents.AllowMoveNodes = true;
            this.treeComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeComponents.Location = new System.Drawing.Point(0, 25);
            this.treeComponents.MaxDragChange = 20;
            this.treeComponents.Name = "treeComponents";
            this.treeComponents.ShowIcons = true;
            this.treeComponents.Size = new System.Drawing.Size(220, 303);
            this.treeComponents.TabIndex = 1;
            // 
            // DockComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeComponents);
            this.DefaultDockArea = DarkUI.Docking.DarkDockArea.Left;
            this.DockText = "Components";
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = global::QuadrotorDesigner.Studio.Properties.Resources.component_docking_icon;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DockComponents";
            this.SerializationKey = "DockComponents";
            this.Size = new System.Drawing.Size(220, 328);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkTreeView treeComponents;
    }
}
