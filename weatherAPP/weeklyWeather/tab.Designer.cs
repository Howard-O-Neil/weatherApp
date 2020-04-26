namespace weatherAPP.weeklyWeather
{
	partial class tab
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tab));
			this.date = new System.Windows.Forms.Label();
			this.temper = new System.Windows.Forms.Label();
			this.description = new System.Windows.Forms.Label();
			this.humid = new System.Windows.Forms.Label();
			this.wind = new System.Windows.Forms.Label();
			this.icon = new System.Windows.Forms.PictureBox();
			this.panel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.SuspendLayout();
			// 
			// date
			// 
			this.date.Dock = System.Windows.Forms.DockStyle.Top;
			this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date.Location = new System.Drawing.Point(0, 0);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(1469, 47);
			this.date.TabIndex = 0;
			this.date.Text = "waitting";
			this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// temper
			// 
			this.temper.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.temper.Location = new System.Drawing.Point(162, 71);
			this.temper.Name = "temper";
			this.temper.Size = new System.Drawing.Size(239, 58);
			this.temper.TabIndex = 2;
			this.temper.Text = "waitting";
			this.temper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// description
			// 
			this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description.Location = new System.Drawing.Point(38, 153);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(460, 50);
			this.description.TabIndex = 3;
			this.description.Text = "waitting";
			this.description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// humid
			// 
			this.humid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.humid.Location = new System.Drawing.Point(38, 203);
			this.humid.Name = "humid";
			this.humid.Size = new System.Drawing.Size(460, 50);
			this.humid.TabIndex = 4;
			this.humid.Text = "waitting";
			this.humid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// wind
			// 
			this.wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wind.Location = new System.Drawing.Point(38, 253);
			this.wind.Name = "wind";
			this.wind.Size = new System.Drawing.Size(460, 50);
			this.wind.TabIndex = 5;
			this.wind.Text = "waitting";
			this.wind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// icon
			// 
			this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
			this.icon.Location = new System.Drawing.Point(6, 50);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(168, 100);
			this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.icon.TabIndex = 1;
			this.icon.TabStop = false;
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.White;
			this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel.Location = new System.Drawing.Point(0, 317);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1469, 15);
			this.panel.TabIndex = 6;
			// 
			// tab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.Controls.Add(this.panel);
			this.Controls.Add(this.wind);
			this.Controls.Add(this.humid);
			this.Controls.Add(this.description);
			this.Controls.Add(this.temper);
			this.Controls.Add(this.icon);
			this.Controls.Add(this.date);
			this.Name = "tab";
			this.Size = new System.Drawing.Size(1469, 332);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label date;
		private System.Windows.Forms.Label temper;
		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Label humid;
		private System.Windows.Forms.Label wind;
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Panel panel;
	}
}
