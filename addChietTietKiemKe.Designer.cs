
namespace CDTTTN
{
    partial class addChietTietKiemKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addChietTietKiemKe));
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_TenTTB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_TTB = new System.Windows.Forms.DataGridView();
            this.txt_MaKK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaTTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTB)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.btn_add.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(196, 96);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(181, 50);
            this.btn_add.TabIndex = 62;
            this.btn_add.Text = "Tìm kiếm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_TenTTB
            // 
            this.cb_TenTTB.FormattingEnabled = true;
            this.cb_TenTTB.Location = new System.Drawing.Point(279, 43);
            this.cb_TenTTB.Name = "cb_TenTTB";
            this.cb_TenTTB.Size = new System.Drawing.Size(267, 28);
            this.cb_TenTTB.TabIndex = 61;
            this.cb_TenTTB.SelectedIndexChanged += new System.EventHandler(this.cb_TenTTB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tên trang thiết bị";
            // 
            // grd_TTB
            // 
            this.grd_TTB.BackgroundColor = System.Drawing.Color.White;
            this.grd_TTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_TTB.Location = new System.Drawing.Point(44, 171);
            this.grd_TTB.Name = "grd_TTB";
            this.grd_TTB.RowHeadersWidth = 62;
            this.grd_TTB.RowTemplate.Height = 28;
            this.grd_TTB.Size = new System.Drawing.Size(516, 398);
            this.grd_TTB.TabIndex = 59;
            this.grd_TTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_TTB_CellClick);
            // 
            // txt_MaKK
            // 
            this.txt_MaKK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaKK.Location = new System.Drawing.Point(803, 171);
            this.txt_MaKK.Multiline = true;
            this.txt_MaKK.Name = "txt_MaKK";
            this.txt_MaKK.ReadOnly = true;
            this.txt_MaKK.Size = new System.Drawing.Size(339, 35);
            this.txt_MaKK.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(638, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mã kiểm kê";
            // 
            // txt_MaTTB
            // 
            this.txt_MaTTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaTTB.Location = new System.Drawing.Point(803, 248);
            this.txt_MaTTB.Multiline = true;
            this.txt_MaTTB.Name = "txt_MaTTB";
            this.txt_MaTTB.Size = new System.Drawing.Size(339, 35);
            this.txt_MaTTB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(638, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mã trang thiết bị";
            // 
            // txt_MaTT
            // 
            this.txt_MaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaTT.Location = new System.Drawing.Point(803, 325);
            this.txt_MaTT.Multiline = true;
            this.txt_MaTT.Name = "txt_MaTT";
            this.txt_MaTT.Size = new System.Drawing.Size(339, 35);
            this.txt_MaTT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(638, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Mã trạng thái";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_GhiChu.Location = new System.Drawing.Point(803, 401);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(339, 35);
            this.txt_GhiChu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(638, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 69;
            this.label5.Text = "Ghi chú";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(793, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 50);
            this.button1.TabIndex = 71;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addChietTietKiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MaTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MaTTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaKK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_TenTTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_TTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addChietTietKiemKe";
            this.Text = "Chi tiết kiểm kê trang thiết bị trong phòng";
            this.Load += new System.EventHandler(this.addChietTietKiemKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_TenTTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_TTB;
        private System.Windows.Forms.TextBox txt_MaKK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaTTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}