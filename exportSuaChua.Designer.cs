
namespace CDTTTN
{
    partial class exportSuaChua
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_GiaTri = new System.Windows.Forms.ComboBox();
            this.cb_TenTruong = new System.Windows.Forms.ComboBox();
            this.grd_exportSuaChua = new System.Windows.Forms.DataGridView();
            this.MaSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_exportSuaChua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_GiaTri);
            this.groupBox1.Controls.Add(this.cb_TenTruong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.groupBox1.Location = new System.Drawing.Point(305, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 247);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(351, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 36);
            this.label3.TabIndex = 27;
            this.label3.Text = "=";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.button1.Location = new System.Drawing.Point(395, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "Xuất báo cáo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(401, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Giá trị";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(158, 167);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(181, 50);
            this.btn_TimKiem.TabIndex = 24;
            this.btn_TimKiem.Text = "Lọc";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(153, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Điều kiện lọc";
            // 
            // cb_GiaTri
            // 
            this.cb_GiaTri.FormattingEnabled = true;
            this.cb_GiaTri.Location = new System.Drawing.Point(395, 89);
            this.cb_GiaTri.Name = "cb_GiaTri";
            this.cb_GiaTri.Size = new System.Drawing.Size(181, 33);
            this.cb_GiaTri.TabIndex = 1;
            // 
            // cb_TenTruong
            // 
            this.cb_TenTruong.FormattingEnabled = true;
            this.cb_TenTruong.Items.AddRange(new object[] {
            "NgaySC",
            "MaNV"});
            this.cb_TenTruong.Location = new System.Drawing.Point(158, 89);
            this.cb_TenTruong.Name = "cb_TenTruong";
            this.cb_TenTruong.Size = new System.Drawing.Size(181, 33);
            this.cb_TenTruong.TabIndex = 0;
            this.cb_TenTruong.SelectedIndexChanged += new System.EventHandler(this.cb_TenTruong_SelectedIndexChanged);
            // 
            // grd_exportSuaChua
            // 
            this.grd_exportSuaChua.BackgroundColor = System.Drawing.Color.White;
            this.grd_exportSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_exportSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSC,
            this.MaTTB,
            this.NgaySC,
            this.GiaSC,
            this.MaNV});
            this.grd_exportSuaChua.Location = new System.Drawing.Point(47, 353);
            this.grd_exportSuaChua.Name = "grd_exportSuaChua";
            this.grd_exportSuaChua.RowHeadersWidth = 62;
            this.grd_exportSuaChua.RowTemplate.Height = 28;
            this.grd_exportSuaChua.Size = new System.Drawing.Size(1227, 493);
            this.grd_exportSuaChua.TabIndex = 5;
            // 
            // MaSC
            // 
            this.MaSC.DataPropertyName = "MaSC";
            this.MaSC.HeaderText = "Mã SC";
            this.MaSC.MinimumWidth = 8;
            this.MaSC.Name = "MaSC";
            this.MaSC.Width = 175;
            // 
            // MaTTB
            // 
            this.MaTTB.DataPropertyName = "MaTTB";
            this.MaTTB.HeaderText = "Mã TTB";
            this.MaTTB.MinimumWidth = 8;
            this.MaTTB.Name = "MaTTB";
            this.MaTTB.Width = 175;
            // 
            // NgaySC
            // 
            this.NgaySC.DataPropertyName = "NgaySC";
            this.NgaySC.HeaderText = "Ngày SC";
            this.NgaySC.MinimumWidth = 8;
            this.NgaySC.Name = "NgaySC";
            this.NgaySC.Width = 175;
            // 
            // GiaSC
            // 
            this.GiaSC.DataPropertyName = "GiaSC";
            this.GiaSC.HeaderText = "Giá SC (VNĐ)";
            this.GiaSC.MinimumWidth = 8;
            this.GiaSC.Name = "GiaSC";
            this.GiaSC.Width = 175;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 175;
            // 
            // exportSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grd_exportSuaChua);
            this.Name = "exportSuaChua";
            this.Size = new System.Drawing.Size(1321, 880);
            this.Load += new System.EventHandler(this.exportSuaChua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_exportSuaChua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_GiaTri;
        private System.Windows.Forms.ComboBox cb_TenTruong;
        private System.Windows.Forms.DataGridView grd_exportSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
    }
}
