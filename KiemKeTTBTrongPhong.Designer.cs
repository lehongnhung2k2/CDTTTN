
namespace CDTTTN
{
    partial class KiemKeTTBTrongPhong
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
            this.button1 = new System.Windows.Forms.Button();
            this.grd_KiemKeTTB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_KiemKeTTB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(298, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 50);
            this.button1.TabIndex = 66;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd_KiemKeTTB
            // 
            this.grd_KiemKeTTB.BackgroundColor = System.Drawing.Color.White;
            this.grd_KiemKeTTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_KiemKeTTB.Location = new System.Drawing.Point(48, 44);
            this.grd_KiemKeTTB.Name = "grd_KiemKeTTB";
            this.grd_KiemKeTTB.RowHeadersWidth = 62;
            this.grd_KiemKeTTB.RowTemplate.Height = 28;
            this.grd_KiemKeTTB.Size = new System.Drawing.Size(895, 398);
            this.grd_KiemKeTTB.TabIndex = 68;
            // 
            // KiemKeTTBTrongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 542);
            this.Controls.Add(this.grd_KiemKeTTB);
            this.Controls.Add(this.button1);
            this.Name = "KiemKeTTBTrongPhong";
            this.Text = "KiemKeTTBTrongPhong";
            this.Load += new System.EventHandler(this.KiemKeTTBTrongPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_KiemKeTTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grd_KiemKeTTB;
    }
}