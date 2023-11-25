
namespace CDTTTN
{
    partial class editTTBTrongPhong
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
            this.grd_TTB = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_TenPhong = new System.Windows.Forms.Label();
            this.grd_TTBPhong = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTBPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_TTB
            // 
            this.grd_TTB.BackgroundColor = System.Drawing.Color.White;
            this.grd_TTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_TTB.Location = new System.Drawing.Point(44, 182);
            this.grd_TTB.Name = "grd_TTB";
            this.grd_TTB.RowHeadersWidth = 62;
            this.grd_TTB.RowTemplate.Height = 28;
            this.grd_TTB.Size = new System.Drawing.Size(516, 350);
            this.grd_TTB.TabIndex = 1;
            this.grd_TTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_TTB_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(279, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên trang thiết bị";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_add.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(196, 107);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(181, 50);
            this.btn_add.TabIndex = 58;
            this.btn_add.Text = "Tìm kiếm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.AutoSize = true;
            this.txt_TenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_TenPhong.Location = new System.Drawing.Point(835, 114);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(91, 30);
            this.txt_TenPhong.TabIndex = 59;
            this.txt_TenPhong.Text = "Phòng";
            // 
            // grd_TTBPhong
            // 
            this.grd_TTBPhong.BackgroundColor = System.Drawing.Color.White;
            this.grd_TTBPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_TTBPhong.Location = new System.Drawing.Point(628, 182);
            this.grd_TTBPhong.Name = "grd_TTBPhong";
            this.grd_TTBPhong.RowHeadersWidth = 62;
            this.grd_TTBPhong.RowTemplate.Height = 28;
            this.grd_TTBPhong.Size = new System.Drawing.Size(516, 350);
            this.grd_TTBPhong.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(196, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 50);
            this.button1.TabIndex = 61;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editTTBTrongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grd_TTBPhong);
            this.Controls.Add(this.txt_TenPhong);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_TTB);
            this.Name = "editTTBTrongPhong";
            this.Text = "editTTBTrongPhong";
            this.Load += new System.EventHandler(this.editTTBTrongPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTBPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_TTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label txt_TenPhong;
        private System.Windows.Forms.DataGridView grd_TTBPhong;
        private System.Windows.Forms.Button button1;
    }
}