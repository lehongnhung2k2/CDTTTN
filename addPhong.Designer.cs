
namespace CDTTTN
{
    partial class addPhong
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
            this.grd_Phong = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Phong
            // 
            this.grd_Phong.BackgroundColor = System.Drawing.Color.White;
            this.grd_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Phong.Location = new System.Drawing.Point(594, 106);
            this.grd_Phong.Name = "grd_Phong";
            this.grd_Phong.RowHeadersWidth = 62;
            this.grd_Phong.RowTemplate.Height = 28;
            this.grd_Phong.Size = new System.Drawing.Size(650, 688);
            this.grd_Phong.TabIndex = 58;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.btn_add.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(183, 426);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(181, 50);
            this.btn_add.TabIndex = 57;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoLuong.Location = new System.Drawing.Point(241, 306);
            this.txt_SoLuong.Multiline = true;
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(214, 35);
            this.txt_SoLuong.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(76, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Số lượng";
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenPhong.Location = new System.Drawing.Point(241, 234);
            this.txt_TenPhong.Multiline = true;
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(214, 35);
            this.txt_TenPhong.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(76, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tên phòng";
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaPhong.Location = new System.Drawing.Point(241, 161);
            this.txt_MaPhong.Multiline = true;
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(214, 35);
            this.txt_MaPhong.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(76, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(177, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 50;
            this.label1.Text = "Thêm phòng";
            // 
            // addPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd_Phong);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addPhong";
            this.Size = new System.Drawing.Size(1321, 880);
            this.Load += new System.EventHandler(this.addPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Phong;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
