namespace weatherAPP.notification
{
	partial class network_error
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
			this.label1 = new System.Windows.Forms.Label();
			this.button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(70, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(648, 88);
			this.label1.TabIndex = 1;
			this.label1.Text = "You Have The Networking Error :(((\r\nThis App Will Be Restared.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button
			// 
			this.button.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button.Location = new System.Drawing.Point(303, 194);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(216, 56);
			this.button.TabIndex = 2;
			this.button.Text = "OK";
			this.button.UseVisualStyleBackColor = false;
			// 
			// network_error
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 332);
			this.ControlBox = false;
			this.Controls.Add(this.button);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "network_error";
			this.Text = "Notification";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button;
	}
}