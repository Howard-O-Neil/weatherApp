namespace weatherAPP.weeklyWeather
{
	partial class fullContent
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
			this.label = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.AutoScroll = true;
			this.mainPanel.BackColor = System.Drawing.Color.FloralWhite;
			this.mainPanel.Controls.Add(this.label);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1469, 900);
			this.mainPanel.TabIndex = 2;
			// 
			// label
			// 
			this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.ForeColor = System.Drawing.Color.White;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(1469, 82);
			this.label.TabIndex = 1;
			this.label.Text = "thành phố vĩnh long";
			// 
			// fullContent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.mainPanel);
			this.Name = "fullContent";
			this.Size = new System.Drawing.Size(1469, 900);
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label;
	}
}
