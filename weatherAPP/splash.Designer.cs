namespace weatherAPP
{
	partial class splash
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
			this.label = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.BackColor = System.Drawing.Color.Transparent;
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.ForeColor = System.Drawing.Color.Black;
			this.label.Location = new System.Drawing.Point(442, 202);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(356, 55);
			this.label.TabIndex = 10;
			this.label.Text = "Data is loading";
			// 
			// panel
			// 
			this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
			this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel.Location = new System.Drawing.Point(67, 106);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(343, 253);
			this.panel.TabIndex = 16;
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.title.Font = new System.Drawing.Font("Consolas", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.Black;
			this.title.Location = new System.Drawing.Point(55, 12);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(1119, 70);
			this.title.TabIndex = 17;
			this.title.Text = "The World 1st Weather Forecasting";
			// 
			// splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.title);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.label);
			this.ForeColor = System.Drawing.Color.Aqua;
			this.Name = "splash";
			this.Size = new System.Drawing.Size(1469, 900);
			this.Load += new System.EventHandler(this.splash_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Label title;
	}
}