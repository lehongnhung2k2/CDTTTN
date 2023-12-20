
namespace CDTTTN
{
    partial class DatPhongHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatPhongHo));
            this.button1 = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(163, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 50);
            this.button1.TabIndex = 65;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd
            // 
            this.grd.BackgroundColor = System.Drawing.Color.White;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(417, 97);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 28;
            this.grd.Size = new System.Drawing.Size(68, 29);
            this.grd.TabIndex = 66;
            this.grd.Visible = false;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaNV.Location = new System.Drawing.Point(227, 43);
            this.txt_MaNV.Multiline = true;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(242, 35);
            this.txt_MaNV.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Mã nhân viên";
            // 
            // DatPhongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 190);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatPhongHo";
            this.Text = "Đặt phòng hộ";
            this.Load += new System.EventHandler(this.DatPhongHo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label1;
    }
}