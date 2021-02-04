
namespace QuadrotorDesigner.Studio.UserInterface
{
    partial class FromLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromLoad));
            this.labelLoadState = new System.Windows.Forms.Label();
            this.timerLoader = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelLoadState
            // 
            this.labelLoadState.BackColor = System.Drawing.Color.Transparent;
            this.labelLoadState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelLoadState.Location = new System.Drawing.Point(2, 288);
            this.labelLoadState.Name = "labelLoadState";
            this.labelLoadState.Size = new System.Drawing.Size(270, 18);
            this.labelLoadState.TabIndex = 0;
            this.labelLoadState.Text = "Initializing...";
            this.labelLoadState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerLoader
            // 
            this.timerLoader.Interval = 1000;
            this.timerLoader.Tick += new System.EventHandler(this.timerLoader_Tick);
            // 
            // FromLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuadrotorDesigner.Studio.Properties.Resources.bg_load;
            this.ClientSize = new System.Drawing.Size(280, 368);
            this.Controls.Add(this.labelLoadState);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FromLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadrotor Designer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FromLoad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLoadState;
        private System.Windows.Forms.Timer timerLoader;
    }
}