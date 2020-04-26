namespace weatherAPP.weeklyWeather
{
	partial class detail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detail));
			this.date = new System.Windows.Forms.Label();
			this.icon = new System.Windows.Forms.PictureBox();
			this.description = new System.Windows.Forms.Label();
			this.temper = new System.Windows.Forms.Label();
			this.humid = new System.Windows.Forms.Label();
			this.wind = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.SuspendLayout();
			// 
			// date
			// 
			this.date.Dock = System.Windows.Forms.DockStyle.Top;
			this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date.Location = new System.Drawing.Point(0, 0);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(252, 51);
			this.date.TabIndex = 0;
			this.date.Text = "waitting";
			this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// icon
			// 
			this.icon.Dock = System.Windows.Forms.DockStyle.Top;
			this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
			this.icon.Location = new System.Drawing.Point(0, 51);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(252, 148);
			this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.icon.TabIndex = 1;
			this.icon.TabStop = false;
			// 
			// description
			// 
			this.description.Dock = System.Windows.Forms.DockStyle.Top;
			this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description.Location = new System.Drawing.Point(0, 199);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(252, 41);
			this.description.TabIndex = 2;
			this.description.Text = "waitting";
			this.description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// temper
			// 
			this.temper.Dock = System.Windows.Forms.DockStyle.Top;
			this.temper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.temper.Location = new System.Drawing.Point(0, 240);
			this.temper.Name = "temper";
			this.temper.Size = new System.Drawing.Size(252, 41);
			this.temper.TabIndex = 3;
			this.temper.Text = "waitting";
			this.temper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// humid
			// 
			this.humid.Dock = System.Windows.Forms.DockStyle.Top;
			this.humid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.humid.Location = new System.Drawing.Point(0, 281);
			this.humid.Name = "humid";
			this.humid.Size = new System.Drawing.Size(252, 41);
			this.humid.TabIndex = 4;
			this.humid.Text = "waitting";
			this.humid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// wind
			// 
			this.wind.Dock = System.Windows.Forms.DockStyle.Top;
			this.wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wind.Location = new System.Drawing.Point(0, 322);
			this.wind.Name = "wind";
			this.wind.Size = new System.Drawing.Size(252, 41);
			this.wind.TabIndex = 5;
			this.wind.Text = "waitting";
			this.wind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// detail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.wind);
			this.Controls.Add(this.humid);
			this.Controls.Add(this.temper);
			this.Controls.Add(this.description);
			this.Controls.Add(this.icon);
			this.Controls.Add(this.date);
			this.Name = "detail";
			this.Size = new System.Drawing.Size(252, 371);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label date;
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Label temper;
		private System.Windows.Forms.Label humid;
		private System.Windows.Forms.Label wind;
	}
}
