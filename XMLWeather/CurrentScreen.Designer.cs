namespace XMLWeather
{
    partial class CurrentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.weatherStatus = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.windLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(151, 67);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(165, 32);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(117, 160);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(0, 302);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(890, 152);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "10";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Gray;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(0, -3);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(450, 60);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Black;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(448, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(442, 57);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "Forcast - 3 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // weatherStatus
            // 
            this.weatherStatus.Location = new System.Drawing.Point(10, 60);
            this.weatherStatus.Name = "weatherStatus";
            this.weatherStatus.Size = new System.Drawing.Size(120, 116);
            this.weatherStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherStatus.TabIndex = 42;
            this.weatherStatus.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(151, 99);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(187, 32);
            this.dateLabel.TabIndex = 43;
            this.dateLabel.Text = "date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.Black;
            this.windLabel.Location = new System.Drawing.Point(151, 131);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(230, 32);
            this.windLabel.TabIndex = 45;
            this.windLabel.Text = "wind";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.stratford;
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.weatherStatus);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(890, 454);
            ((System.ComponentModel.ISupportInitialize)(this.weatherStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.PictureBox weatherStatus;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label windLabel;
    }
}
