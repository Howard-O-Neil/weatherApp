namespace weatherAPP.weatherControl
{
	partial class weather
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
			this.mainPanel = new System.Windows.Forms.Panel();
			this.humid = new System.Windows.Forms.Label();
			this.cloud = new System.Windows.Forms.Label();
			this.sunrise = new System.Windows.Forms.Label();
			this.sunset = new System.Windows.Forms.Label();
			this.wind = new System.Windows.Forms.Label();
			this.visibility = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.Label();
			this.icon = new System.Windows.Forms.PictureBox();
			this.update = new System.Windows.Forms.Label();
			this.temperature = new System.Windows.Forms.Label();
			this.city = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.LightBlue;
			this.mainPanel.Controls.Add(this.humid);
			this.mainPanel.Controls.Add(this.cloud);
			this.mainPanel.Controls.Add(this.sunrise);
			this.mainPanel.Controls.Add(this.sunset);
			this.mainPanel.Controls.Add(this.wind);
			this.mainPanel.Controls.Add(this.visibility);
			this.mainPanel.Controls.Add(this.status);
			this.mainPanel.Controls.Add(this.icon);
			this.mainPanel.Controls.Add(this.update);
			this.mainPanel.Controls.Add(this.temperature);
			this.mainPanel.Controls.Add(this.city);
			this.mainPanel.Controls.Add(this.label);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1469, 710);
			this.mainPanel.TabIndex = 7;
			// 
			// humid
			// 
			this.humid.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.humid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.humid.Location = new System.Drawing.Point(60, 335);
			this.humid.Margin = new System.Windows.Forms.Padding(0);
			this.humid.Name = "humid";
			this.humid.Size = new System.Drawing.Size(472, 43);
			this.humid.TabIndex = 30;
			this.humid.Text = "Humid 89%";
			this.humid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cloud
			// 
			this.cloud.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cloud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cloud.Location = new System.Drawing.Point(60, 378);
			this.cloud.Margin = new System.Windows.Forms.Padding(0);
			this.cloud.Name = "cloud";
			this.cloud.Size = new System.Drawing.Size(472, 43);
			this.cloud.TabIndex = 31;
			this.cloud.Text = "Cloud 80%";
			this.cloud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sunrise
			// 
			this.sunrise.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sunrise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.sunrise.Location = new System.Drawing.Point(58, 550);
			this.sunrise.Margin = new System.Windows.Forms.Padding(0);
			this.sunrise.Name = "sunrise";
			this.sunrise.Size = new System.Drawing.Size(376, 43);
			this.sunrise.TabIndex = 29;
			this.sunrise.Text = "Sunrise 5:25AM";
			this.sunrise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sunset
			// 
			this.sunset.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sunset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.sunset.Location = new System.Drawing.Point(58, 507);
			this.sunset.Margin = new System.Windows.Forms.Padding(0);
			this.sunset.Name = "sunset";
			this.sunset.Size = new System.Drawing.Size(376, 43);
			this.sunset.TabIndex = 28;
			this.sunset.Text = "Sunset 2:25PM";
			this.sunset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// wind
			// 
			this.wind.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.wind.Location = new System.Drawing.Point(60, 421);
			this.wind.Margin = new System.Windows.Forms.Padding(0);
			this.wind.Name = "wind";
			this.wind.Size = new System.Drawing.Size(376, 43);
			this.wind.TabIndex = 27;
			this.wind.Text = "Wind 5km/h";
			this.wind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// visibility
			// 
			this.visibility.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.visibility.Location = new System.Drawing.Point(60, 464);
			this.visibility.Margin = new System.Windows.Forms.Padding(0);
			this.visibility.Name = "visibility";
			this.visibility.Size = new System.Drawing.Size(376, 43);
			this.visibility.TabIndex = 26;
			this.visibility.Text = "Visibility 10km";
			this.visibility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// status
			// 
			this.status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.status.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.status.Location = new System.Drawing.Point(56, 254);
			this.status.Margin = new System.Windows.Forms.Padding(0);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(937, 63);
			this.status.TabIndex = 23;
			this.status.Text = "rain: heavy rainning";
			this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// icon
			// 
			this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.icon.InitialImage = null;
			this.icon.Location = new System.Drawing.Point(337, 167);
			this.icon.Margin = new System.Windows.Forms.Padding(0);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(100, 76);
			this.icon.TabIndex = 19;
			this.icon.TabStop = false;
			// 
			// update
			// 
			this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.update.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.update.Location = new System.Drawing.Point(57, 615);
			this.update.Margin = new System.Windows.Forms.Padding(0);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(603, 51);
			this.update.TabIndex = 17;
			this.update.Text = "last update at 11:35PM";
			this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// temperature
			// 
			this.temperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.temperature.Location = new System.Drawing.Point(50, 167);
			this.temperature.Margin = new System.Windows.Forms.Padding(0);
			this.temperature.Name = "temperature";
			this.temperature.Size = new System.Drawing.Size(306, 87);
			this.temperature.TabIndex = 9;
			this.temperature.Text = "28°C";
			this.temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// city
			// 
			this.city.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.city.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.city.Location = new System.Drawing.Point(54, 90);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(1206, 77);
			this.city.TabIndex = 8;
			this.city.Text = "Ho Chi Minh City";
			this.city.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label
			// 
			this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold);
			this.label.ForeColor = System.Drawing.Color.White;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(1469, 68);
			this.label.TabIndex = 7;
			this.label.Text = "Current Weather Forecasting";
			// 
			// weather
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.Controls.Add(this.mainPanel);
			this.Name = "weather";
			this.Size = new System.Drawing.Size(1469, 900);
			this.Load += new System.EventHandler(this.weather_Load);
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.Label temperature;
		public System.Windows.Forms.Label city;
		private System.Windows.Forms.Label label;
		public System.Windows.Forms.Panel mainPanel;
		public System.Windows.Forms.Label update;
		public System.Windows.Forms.Label status;
		public System.Windows.Forms.PictureBox icon;
		public System.Windows.Forms.Label sunrise;
		public System.Windows.Forms.Label sunset;
		public System.Windows.Forms.Label wind;
		public System.Windows.Forms.Label visibility;
		public System.Windows.Forms.Label humid;
		public System.Windows.Forms.Label cloud;
	}
}
