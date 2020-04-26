namespace weatherAPP.notepad
{
	partial class tabNote
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabNote));
			this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();
			this.label = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// cancel
			// 
			this.cancel.Activecolor = System.Drawing.Color.Transparent;
			this.cancel.BackColor = System.Drawing.Color.Transparent;
			this.cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel.BackgroundImage")));
			this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cancel.BorderRadius = 0;
			this.cancel.ButtonText = "";
			this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cancel.DisabledColor = System.Drawing.Color.Transparent;
			this.cancel.Iconcolor = System.Drawing.Color.Transparent;
			this.cancel.Iconimage = null;
			this.cancel.Iconimage_right = null;
			this.cancel.Iconimage_right_Selected = null;
			this.cancel.Iconimage_Selected = null;
			this.cancel.IconMarginLeft = 0;
			this.cancel.IconMarginRight = 0;
			this.cancel.IconRightVisible = true;
			this.cancel.IconRightZoom = 0D;
			this.cancel.IconVisible = true;
			this.cancel.IconZoom = 90D;
			this.cancel.IsTab = false;
			this.cancel.Location = new System.Drawing.Point(425, 4);
			this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cancel.Name = "cancel";
			this.cancel.Normalcolor = System.Drawing.Color.Transparent;
			this.cancel.OnHovercolor = System.Drawing.Color.Transparent;
			this.cancel.OnHoverTextColor = System.Drawing.Color.Transparent;
			this.cancel.selected = false;
			this.cancel.Size = new System.Drawing.Size(30, 32);
			this.cancel.TabIndex = 8;
			this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cancel.Textcolor = System.Drawing.Color.Transparent;
			this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.Location = new System.Drawing.Point(3, 8);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(259, 28);
			this.label.TabIndex = 10;
			this.label.Text = "12/12/1234 23:45:56";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label.Click += new System.EventHandler(this.label_Click);
			// 
			// textBox
			// 
			this.textBox.BackColor = System.Drawing.SystemColors.Info;
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(3, 49);
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.Size = new System.Drawing.Size(462, 242);
			this.textBox.TabIndex = 11;
			this.textBox.Text = "fefefefef\n";
			// 
			// tabNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.label);
			this.Controls.Add(this.cancel);
			this.Name = "tabNote";
			this.Size = new System.Drawing.Size(466, 292);
			this.Load += new System.EventHandler(this.tabNote_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Bunifu.Framework.UI.BunifuFlatButton cancel;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.RichTextBox textBox;
	}
}
