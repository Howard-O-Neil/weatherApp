namespace weatherAPP.historyControl
{
	partial class tabWeekly
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabWeekly));
			this.label = new System.Windows.Forms.Label();
			this.location = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label.Font = new System.Drawing.Font("Consolas", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.Location = new System.Drawing.Point(3, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(359, 38);
			this.label.TabIndex = 1;
			this.label.Text = "12/12/1234 23:45:56";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label.Click += new System.EventHandler(this.label_Click);
			// 
			// location
			// 
			this.location.AutoSize = true;
			this.location.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.location.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.location.Location = new System.Drawing.Point(2, 50);
			this.location.Name = "location";
			this.location.Size = new System.Drawing.Size(350, 47);
			this.location.TabIndex = 9;
			this.location.Text = "VN, Ho Chi Minh";
			this.location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.DarkGray;
			this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel.Location = new System.Drawing.Point(0, 112);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1469, 10);
			this.panel.TabIndex = 10;
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
			this.cancel.Location = new System.Drawing.Point(1357, 13);
			this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cancel.Name = "cancel";
			this.cancel.Normalcolor = System.Drawing.Color.Transparent;
			this.cancel.OnHovercolor = System.Drawing.Color.Transparent;
			this.cancel.OnHoverTextColor = System.Drawing.Color.Transparent;
			this.cancel.selected = false;
			this.cancel.Size = new System.Drawing.Size(41, 40);
			this.cancel.TabIndex = 11;
			this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cancel.Textcolor = System.Drawing.Color.Transparent;
			this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// tabWeekly
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.location);
			this.Controls.Add(this.label);
			this.Name = "tabWeekly";
			this.Size = new System.Drawing.Size(1469, 122);
			this.Load += new System.EventHandler(this.tabWeekly_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label location;
		private System.Windows.Forms.Panel panel;
		private Bunifu.Framework.UI.BunifuFlatButton cancel;
	}
}
