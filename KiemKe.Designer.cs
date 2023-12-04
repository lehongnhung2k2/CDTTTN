
namespace CDTTTN
{
    partial class KiemKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.theeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelKiemKe = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theeToolStripMenuItem,
            this.xuấtBáoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1321, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // theeToolStripMenuItem
            // 
            this.theeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.theeToolStripMenuItem.Image = global::CDTTTN.Properties.Resources.add1;
            this.theeToolStripMenuItem.Name = "theeToolStripMenuItem";
            this.theeToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.theeToolStripMenuItem.Text = "Thêm mới";
            this.theeToolStripMenuItem.Click += new System.EventHandler(this.theeToolStripMenuItem_Click);
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.xuấtBáoCáoToolStripMenuItem.Image = global::CDTTTN.Properties.Resources.export;
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
            this.xuấtBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoCáoToolStripMenuItem_Click);
            // 
            // panelKiemKe
            // 
            this.panelKiemKe.Location = new System.Drawing.Point(0, 51);
            this.panelKiemKe.Name = "panelKiemKe";
            this.panelKiemKe.Size = new System.Drawing.Size(1321, 880);
            this.panelKiemKe.TabIndex = 10;
            // 
            // KiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelKiemKe);
            this.Controls.Add(this.menuStrip1);
            this.Name = "KiemKe";
            this.Size = new System.Drawing.Size(1321, 950);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem theeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel panelKiemKe;
    }
}
