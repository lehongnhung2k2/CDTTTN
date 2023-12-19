
namespace CDTTTN
{
    partial class KiemKeTTB_TrongPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKeTTB_TrongPhong));
            this.grd = new System.Windows.Forms.DataGridView();
            this.du = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.thieu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.BackgroundColor = System.Drawing.Color.White;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.du,
            this.thieu,
            this.ghichu,
            this.MaTTB,
            this.TenTTB});
            this.grd.Location = new System.Drawing.Point(42, 104);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 28;
            this.grd.Size = new System.Drawing.Size(1225, 314);
            this.grd.TabIndex = 0;
            // 
            // du
            // 
            this.du.HeaderText = "Đủ";
            this.du.MinimumWidth = 8;
            this.du.Name = "du";
            this.du.Width = 150;
            // 
            // thieu
            // 
            this.thieu.HeaderText = "Thiếu";
            this.thieu.MinimumWidth = 8;
            this.thieu.Name = "thieu";
            this.thieu.Width = 150;
            // 
            // ghichu
            // 
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 8;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 150;
            // 
            // MaTTB
            // 
            this.MaTTB.DataPropertyName = "MaTTB";
            this.MaTTB.HeaderText = "Mã TTB";
            this.MaTTB.MinimumWidth = 8;
            this.MaTTB.Name = "MaTTB";
            this.MaTTB.Width = 150;
            // 
            // TenTTB
            // 
            this.TenTTB.DataPropertyName = "TenTTB";
            this.TenTTB.HeaderText = "Tên TTB";
            this.TenTTB.MinimumWidth = 8;
            this.TenTTB.Name = "TenTTB";
            this.TenTTB.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(575, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KiemKeTTB_TrongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KiemKeTTB_TrongPhong";
            this.Text = "Kiểm kê trang thiết bị trong phòng";
            this.Load += new System.EventHandler(this.KiemKeTTB_TrongPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn du;
        private System.Windows.Forms.DataGridViewCheckBoxColumn thieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTTB;
    }
}