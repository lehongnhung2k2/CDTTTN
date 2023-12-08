
namespace CDTTTN
{
    partial class DatPhong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.time_start = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.time_end = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.flp_Phong = new System.Windows.Forms.FlowLayoutPanel();
            this.grd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(61, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(114, 64);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(296, 26);
            this.date.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(490, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Từ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // time_start
            // 
            this.time_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_start.Location = new System.Drawing.Point(532, 67);
            this.time_start.Name = "time_start";
            this.time_start.ShowUpDown = true;
            this.time_start.Size = new System.Drawing.Size(88, 26);
            this.time_start.TabIndex = 3;
            this.time_start.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(652, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đến";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // time_end
            // 
            this.time_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_end.Location = new System.Drawing.Point(703, 67);
            this.time_end.Name = "time_end";
            this.time_end.ShowUpDown = true;
            this.time_end.Size = new System.Drawing.Size(88, 26);
            this.time_end.TabIndex = 4;
            this.time_end.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(882, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm phòng trống";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flp_Phong
            // 
            this.flp_Phong.AutoScroll = true;
            this.flp_Phong.Location = new System.Drawing.Point(34, 167);
            this.flp_Phong.Name = "flp_Phong";
            this.flp_Phong.Size = new System.Drawing.Size(1267, 780);
            this.flp_Phong.TabIndex = 6;
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(1125, 34);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 28;
            this.grd.Size = new System.Drawing.Size(81, 59);
            this.grd.TabIndex = 7;
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.flp_Phong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time_end);
            this.Controls.Add(this.time_start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DatPhong";
            this.Size = new System.Drawing.Size(1321, 950);
            this.Load += new System.EventHandler(this.DatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker time_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker time_end;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flp_Phong;
        private System.Windows.Forms.DataGridView grd;
    }
}
