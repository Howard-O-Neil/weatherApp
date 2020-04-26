namespace weatherAPP.bingMapControl
{
	partial class map
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
			this.mainPanel = new System.Windows.Forms.Panel();
			this.getLocation = new System.Windows.Forms.Button();
			this.mapControl = new DevExpress.XtraMap.MapControl();
			this.informationLayer = new DevExpress.XtraMap.InformationLayer();
			this.bingSearchDataProvider = new DevExpress.XtraMap.BingSearchDataProvider();
			this.imageLayer = new DevExpress.XtraMap.ImageLayer();
			this.bingMapDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.getLocation);
			this.mainPanel.Controls.Add(this.mapControl);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1469, 900);
			this.mainPanel.TabIndex = 2;
			// 
			// getLocation
			// 
			this.getLocation.BackColor = System.Drawing.Color.MediumAquamarine;
			this.getLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.getLocation.Location = new System.Drawing.Point(20, 21);
			this.getLocation.Name = "getLocation";
			this.getLocation.Size = new System.Drawing.Size(258, 58);
			this.getLocation.TabIndex = 2;
			this.getLocation.Text = "Get Location";
			this.getLocation.UseVisualStyleBackColor = false;
			this.getLocation.Click += new System.EventHandler(this.getLocation_Click);
			// 
			// mapControl
			// 
			this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mapControl.Layers.Add(this.informationLayer);
			this.mapControl.Layers.Add(this.imageLayer);
			this.mapControl.Location = new System.Drawing.Point(0, 0);
			this.mapControl.Name = "mapControl";
			this.mapControl.Size = new System.Drawing.Size(1469, 900);
			this.mapControl.TabIndex = 1;
			this.informationLayer.DataProvider = this.bingSearchDataProvider;
			this.imageLayer.DataProvider = this.bingMapDataProvider;
			this.bingMapDataProvider.BingKey = "YOUR BING MAPS KEY";
			// 
			// map
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Name = "map";
			this.Size = new System.Drawing.Size(1469, 900);
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private DevExpress.XtraMap.MapControl mapControl;
		private DevExpress.XtraMap.InformationLayer informationLayer;
		private DevExpress.XtraMap.BingSearchDataProvider bingSearchDataProvider;
		private DevExpress.XtraMap.ImageLayer imageLayer;
		private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider;
		private System.Windows.Forms.Button getLocation;
	}
}