
namespace CDTTTN
{
    partial class searchKiemKe
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NgayKK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaKK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdKiemKe = new System.Windows.Forms.DataGridView();
            this.MaKK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdKiemKe)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.button1.Location = new System.Drawing.Point(475, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 50);
            this.button1.TabIndex = 38;
            this.button1.Text = "Xóa điều kiện";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(732, 372);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(181, 50);
            this.btn_edit.TabIndex = 37;
            this.btn_edit.Text = "Tìm kiếm";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaNV.Location = new System.Drawing.Point(892, 196);
            this.txt_MaNV.Multiline = true;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(339, 35);
            this.txt_MaNV.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(727, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã nhân viên";
            // 
            // txt_NgayKK
            // 
            this.txt_NgayKK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NgayKK.Location = new System.Drawing.Point(257, 272);
            this.txt_NgayKK.Multiline = true;
            this.txt_NgayKK.Name = "txt_NgayKK";
            this.txt_NgayKK.Size = new System.Drawing.Size(339, 35);
            this.txt_NgayKK.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(92, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ngày kiểm kê";
            // 
            // txt_MaKK
            // 
            this.txt_MaKK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaKK.Location = new System.Drawing.Point(257, 196);
            this.txt_MaKK.Multiline = true;
            this.txt_MaKK.Name = "txt_MaKK";
            this.txt_MaKK.Size = new System.Drawing.Size(339, 35);
            this.txt_MaKK.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(92, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã kiểm kê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(533, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "THÔNG TIN TÌM KIẾM";
            // 
            // grdKiemKe
            // 
            this.grdKiemKe.BackgroundColor = System.Drawing.Color.White;
            this.grdKiemKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKiemKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKK,
            this.NgayKK,
            this.MaNV,
            this.GhiChu,
            this.MaTT,
            this.MaTTB});
            this.grdKiemKe.Location = new System.Drawing.Point(43, 480);
            this.grdKiemKe.Name = "grdKiemKe";
            this.grdKiemKe.RowHeadersWidth = 62;
            this.grdKiemKe.RowTemplate.Height = 28;
            this.grdKiemKe.Size = new System.Drawing.Size(1237, 378);
            this.grdKiemKe.TabIndex = 40;
            // 
            // MaKK
            // 
            this.MaKK.DataPropertyName = "MaKK";
            this.MaKK.HeaderText = "Mã KK";
            this.MaKK.MinimumWidth = 8;
            this.MaKK.Name = "MaKK";
            this.MaKK.Width = 140;
            // 
            // NgayKK
            // 
            this.NgayKK.DataPropertyName = "NgayKK";
            this.NgayKK.HeaderText = "Ngày KK";
            this.NgayKK.MinimumWidth = 8;
            this.NgayKK.Name = "NgayKK";
            this.NgayKK.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 150;
            // 
            // MaTT
            // 
            this.MaTT.DataPropertyName = "MaTT";
            this.MaTT.HeaderText = "Mã TT";
            this.MaTT.MinimumWidth = 8;
            this.MaTT.Name = "MaTT";
            this.MaTT.Width = 150;
            // 
            // MaTTB
            // 
            this.MaTTB.DataPropertyName = "MaTTB";
            this.MaTTB.HeaderText = "Mã TTB";
            this.MaTTB.MinimumWidth = 8;
            this.MaTTB.Name = "MaTTB";
            this.MaTTB.Width = 135;
            // 
            // searchKiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdKiemKe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NgayKK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_MaKK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "searchKiemKe";
            this.Size = new System.Drawing.Size(1321, 880);
            this.Load += new System.EventHandler(this.searchKiemKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKiemKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NgayKK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaKK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdKiemKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTTB;
    }
}
