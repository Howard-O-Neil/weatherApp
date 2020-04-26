namespace weatherAPP.historyControl
{
	partial class currentWeather
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
			this.clearAll = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.AutoScroll = true;
			this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.mainPanel.Controls.Add(this.clearAll);
			this.mainPanel.Controls.Add(this.label);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1469, 900);
			this.mainPanel.TabIndex = 0;
			// 
			// clearAll
			// 
			this.clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearAll.Location = new System.Drawing.Point(1196, 12);
			this.clearAll.Name = "clearAll";
			this.clearAll.Size = new System.Drawing.Size(191, 53);
			this.clearAll.TabIndex = 4;
			this.clearAll.Text = "Clear All";
			this.clearAll.UseVisualStyleBackColor = true;
			this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
			// 
			// label
			// 
			this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold);
			this.label.ForeColor = System.Drawing.Color.White;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(1469, 82);
			this.label.TabIndex = 3;
			this.label.Text = "Current Weather History";
			// 
			// currentWeather
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.mainPanel);
			this.Name = "currentWeather";
			this.Size = new System.Drawing.Size(1469, 900);
			this.Load += new System.EventHandler(this.currentWeather_Load);
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button clearAll;
		private System.Windows.Forms.Label label;
	}
}
