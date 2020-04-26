namespace weatherAPP.historyControl
{
	partial class subMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subMenu));
			this.current = new Bunifu.Framework.UI.BunifuFlatButton();
			this.weekly = new Bunifu.Framework.UI.BunifuFlatButton();
			this.SuspendLayout();
			// 
			// current
			// 
			this.current.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.current.BackColor = System.Drawing.Color.Transparent;
			this.current.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.current.BorderRadius = 0;
			this.current.ButtonText = " Current";
			this.current.Cursor = System.Windows.Forms.Cursors.Hand;
			this.current.DisabledColor = System.Drawing.Color.Gray;
			this.current.Dock = System.Windows.Forms.DockStyle.Top;
			this.current.Iconcolor = System.Drawing.Color.Transparent;
			this.current.Iconimage = ((System.Drawing.Image)(resources.GetObject("current.Iconimage")));
			this.current.Iconimage_right = null;
			this.current.Iconimage_right_Selected = null;
			this.current.Iconimage_Selected = null;
			this.current.IconMarginLeft = 0;
			this.current.IconMarginRight = 0;
			this.current.IconRightVisible = true;
			this.current.IconRightZoom = 0D;
			this.current.IconVisible = true;
			this.current.IconZoom = 20D;
			this.current.IsTab = false;
			this.current.Location = new System.Drawing.Point(0, 0);
			this.current.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.current.Name = "current";
			this.current.Normalcolor = System.Drawing.Color.Transparent;
			this.current.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.current.OnHoverTextColor = System.Drawing.Color.White;
			this.current.selected = false;
			this.current.Size = new System.Drawing.Size(243, 72);
			this.current.TabIndex = 15;
			this.current.Text = " Current";
			this.current.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.current.Textcolor = System.Drawing.Color.White;
			this.current.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.current.Click += new System.EventHandler(this.current_Click);
			// 
			// weekly
			// 
			this.weekly.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.weekly.BackColor = System.Drawing.Color.Transparent;
			this.weekly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.weekly.BorderRadius = 0;
			this.weekly.ButtonText = " Weekly";
			this.weekly.Cursor = System.Windows.Forms.Cursors.Hand;
			this.weekly.DisabledColor = System.Drawing.Color.Gray;
			this.weekly.Dock = System.Windows.Forms.DockStyle.Top;
			this.weekly.Iconcolor = System.Drawing.Color.Transparent;
			this.weekly.Iconimage = ((System.Drawing.Image)(resources.GetObject("weekly.Iconimage")));
			this.weekly.Iconimage_right = null;
			this.weekly.Iconimage_right_Selected = null;
			this.weekly.Iconimage_Selected = null;
			this.weekly.IconMarginLeft = 0;
			this.weekly.IconMarginRight = 0;
			this.weekly.IconRightVisible = true;
			this.weekly.IconRightZoom = 0D;
			this.weekly.IconVisible = true;
			this.weekly.IconZoom = 20D;
			this.weekly.IsTab = false;
			this.weekly.Location = new System.Drawing.Point(0, 72);
			this.weekly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.weekly.Name = "weekly";
			this.weekly.Normalcolor = System.Drawing.Color.Transparent;
			this.weekly.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.weekly.OnHoverTextColor = System.Drawing.Color.White;
			this.weekly.selected = false;
			this.weekly.Size = new System.Drawing.Size(243, 72);
			this.weekly.TabIndex = 16;
			this.weekly.Text = " Weekly";
			this.weekly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.weekly.Textcolor = System.Drawing.Color.White;
			this.weekly.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weekly.Click += new System.EventHandler(this.weekly_Click);
			// 
			// subMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.Controls.Add(this.weekly);
			this.Controls.Add(this.current);
			this.Name = "subMenu";
			this.Size = new System.Drawing.Size(243, 172);
			this.ResumeLayout(false);

		}

		#endregion
		private Bunifu.Framework.UI.BunifuFlatButton current;
		private Bunifu.Framework.UI.BunifuFlatButton weekly;
	}
}
