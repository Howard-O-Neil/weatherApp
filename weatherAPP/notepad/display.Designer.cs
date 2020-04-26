namespace weatherAPP.notepad
{
	partial class display
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
			this.textBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.BackColor = System.Drawing.SystemColors.Info;
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(0, 0);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(659, 757);
			this.textBox.TabIndex = 1;
			this.textBox.Text = "";
			this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// display
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 757);
			this.Controls.Add(this.textBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "display";
			this.Text = "WeatherForecast App";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RichTextBox textBox;
	}
}