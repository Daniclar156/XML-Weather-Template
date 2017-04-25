namespace XMLWeather
{
    partial class ForecastScreen
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
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.dayPic1 = new System.Windows.Forms.PictureBox();
            this.dayPic2 = new System.Windows.Forms.PictureBox();
            this.dayPic3 = new System.Windows.Forms.PictureBox();
            this.date3 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic3)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Gray;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(442, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(448, 62);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "Forcast - 3 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 62);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(759, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max2
            // 
            this.max2.AutoSize = true;
            this.max2.BackColor = System.Drawing.Color.Transparent;
            this.max2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max2.ForeColor = System.Drawing.Color.White;
            this.max2.Location = new System.Drawing.Point(622, 236);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(158, 55);
            this.max2.TabIndex = 44;
            this.max2.Text = "temp2";
            // 
            // max1
            // 
            this.max1.AutoSize = true;
            this.max1.BackColor = System.Drawing.Color.Transparent;
            this.max1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.ForeColor = System.Drawing.Color.White;
            this.max1.Location = new System.Drawing.Point(622, 94);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(158, 55);
            this.max1.TabIndex = 64;
            this.max1.Text = "temp1";
            // 
            // date2
            // 
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.SystemColors.Control;
            this.date2.Location = new System.Drawing.Point(326, 236);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(290, 67);
            this.date2.TabIndex = 68;
            this.date2.Text = "date2";
            // 
            // date1
            // 
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.SystemColors.Control;
            this.date1.Location = new System.Drawing.Point(326, 94);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(290, 60);
            this.date1.TabIndex = 69;
            this.date1.Text = "date1";
            // 
            // dayPic1
            // 
            this.dayPic1.BackColor = System.Drawing.Color.Transparent;
            this.dayPic1.Location = new System.Drawing.Point(786, 78);
            this.dayPic1.Name = "dayPic1";
            this.dayPic1.Size = new System.Drawing.Size(88, 85);
            this.dayPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dayPic1.TabIndex = 70;
            this.dayPic1.TabStop = false;
            // 
            // dayPic2
            // 
            this.dayPic2.BackColor = System.Drawing.Color.Transparent;
            this.dayPic2.Location = new System.Drawing.Point(786, 218);
            this.dayPic2.Name = "dayPic2";
            this.dayPic2.Size = new System.Drawing.Size(88, 85);
            this.dayPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dayPic2.TabIndex = 71;
            this.dayPic2.TabStop = false;
            // 
            // dayPic3
            // 
            this.dayPic3.BackColor = System.Drawing.Color.Transparent;
            this.dayPic3.Location = new System.Drawing.Point(786, 343);
            this.dayPic3.Name = "dayPic3";
            this.dayPic3.Size = new System.Drawing.Size(88, 85);
            this.dayPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dayPic3.TabIndex = 74;
            this.dayPic3.TabStop = false;
            // 
            // date3
            // 
            this.date3.BackColor = System.Drawing.Color.Transparent;
            this.date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.SystemColors.Control;
            this.date3.Location = new System.Drawing.Point(326, 362);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(290, 55);
            this.date3.TabIndex = 73;
            this.date3.Text = "date3";
            // 
            // max3
            // 
            this.max3.AutoSize = true;
            this.max3.BackColor = System.Drawing.Color.Transparent;
            this.max3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.ForeColor = System.Drawing.Color.White;
            this.max3.Location = new System.Drawing.Point(622, 362);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(158, 55);
            this.max3.TabIndex = 72;
            this.max3.Text = "temp3";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.stratford;
            this.Controls.Add(this.dayPic3);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.dayPic2);
            this.Controls.Add(this.dayPic1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.label5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(890, 454);
            this.Load += new System.EventHandler(this.ForecastScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.PictureBox dayPic1;
        private System.Windows.Forms.PictureBox dayPic2;
        private System.Windows.Forms.PictureBox dayPic3;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label max3;
    }
}
