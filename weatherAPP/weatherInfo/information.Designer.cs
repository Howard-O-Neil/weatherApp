namespace weatherAPP.weatherInfo
{
	partial class information
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
			this.components = new System.ComponentModel.Container();
			BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(information));
			this.title = new System.Windows.Forms.Label();
			this.returnButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.currentButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.weeklyButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.mapButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.newsButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.leftPanel = new System.Windows.Forms.Panel();
			this.subMenu = new weatherAPP.historyControl.subMenu();
			this.historyButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.sliding = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.noteButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.leftPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.sliding.SetDecoration(this.title, BunifuAnimatorNS.DecorationType.None);
			this.title.Font = new System.Drawing.Font("Consolas", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.White;
			this.title.Location = new System.Drawing.Point(3, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(190, 51);
			this.title.TabIndex = 5;
			this.title.Text = "Welcome";
			// 
			// returnButton
			// 
			this.returnButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.returnButton.BackColor = System.Drawing.Color.Transparent;
			this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.returnButton.BorderRadius = 0;
			this.returnButton.ButtonText = "Return";
			this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sliding.SetDecoration(this.returnButton, BunifuAnimatorNS.DecorationType.None);
			this.returnButton.DisabledColor = System.Drawing.Color.Gray;
			this.returnButton.Iconcolor = System.Drawing.Color.Transparent;
			this.returnButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("returnButton.Iconimage")));
			this.returnButton.Iconimage_right = null;
			this.returnButton.Iconimage_right_Selected = null;
			this.returnButton.Iconimage_Selected = null;
			this.returnButton.IconMarginLeft = 0;
			this.returnButton.IconMarginRight = 0;
			this.returnButton.IconRightVisible = true;
			this.returnButton.IconRightZoom = 0D;
			this.returnButton.IconVisible = true;
			this.returnButton.IconZoom = 70D;
			this.returnButton.IsTab = false;
			this.returnButton.Location = new System.Drawing.Point(4, 64);
			this.returnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.returnButton.Name = "returnButton";
			this.returnButton.Normalcolor = System.Drawing.Color.Transparent;
			this.returnButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.returnButton.OnHoverTextColor = System.Drawing.Color.White;
			this.returnButton.selected = false;
			this.returnButton.Size = new System.Drawing.Size(212, 52);
			this.returnButton.TabIndex = 6;
			this.returnButton.Text = "Return";
			this.returnButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.returnButton.Textcolor = System.Drawing.Color.White;
			this.returnButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
			// 
			// currentButton
			// 
			this.currentButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.currentButton.BackColor = System.Drawing.Color.Transparent;
			this.currentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.currentButton.BorderRadius = 0;
			this.currentButton.ButtonText = "Current";
			this.currentButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sliding.SetDecoration(this.currentButton, BunifuAnimatorNS.DecorationType.None);
			this.currentButton.DisabledColor = System.Drawing.Color.Gray;
			this.currentButton.Iconcolor = System.Drawing.Color.Transparent;
			this.currentButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("currentButton.Iconimage")));
			this.currentButton.Iconimage_right = null;
			this.currentButton.Iconimage_right_Selected = null;
			this.currentButton.Iconimage_Selected = null;
			this.currentButton.IconMarginLeft = 0;
			this.currentButton.IconMarginRight = 0;
			this.currentButton.IconRightVisible = true;
			this.currentButton.IconRightZoom = 0D;
			this.currentButton.IconVisible = true;
			this.currentButton.IconZoom = 70D;
			this.currentButton.IsTab = false;
			this.currentButton.Location = new System.Drawing.Point(4, 144);
			this.currentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.currentButton.Name = "currentButton";
			this.currentButton.Normalcolor = System.Drawing.Color.Transparent;
			this.currentButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.currentButton.OnHoverTextColor = System.Drawing.Color.White;
			this.currentButton.selected = false;
			this.currentButton.Size = new System.Drawing.Size(212, 52);
			this.currentButton.TabIndex = 7;
			this.currentButton.Text = "Current";
			this.currentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.currentButton.Textcolor = System.Drawing.Color.White;
			this.currentButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentButton.Click += new System.EventHandler(this.current_Click);
			// 
			// weeklyButton
			// 
			this.weeklyButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.weeklyButton.BackColor = System.Drawing.Color.Transparent;
			this.weeklyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.weeklyButton.BorderRadius = 0;
			this.weeklyButton.ButtonText = "Weekly";
			this.weeklyButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sliding.SetDecoration(this.weeklyButton, BunifuAnimatorNS.DecorationType.None);
			this.weeklyButton.DisabledColor = System.Drawing.Color.Gray;
			this.weeklyButton.Iconcolor = System.Drawing.Color.Transparent;
			this.weeklyButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("weeklyButton.Iconimage")));
			this.weeklyButton.Iconimage_right = null;
			this.weeklyButton.Iconimage_right_Selected = null;
			this.weeklyButton.Iconimage_Selected = null;
			this.weeklyButton.IconMarginLeft = 0;
			this.weeklyButton.IconMarginRight = 0;
			this.weeklyButton.IconRightVisible = true;
			this.weeklyButton.IconRightZoom = 0D;
			this.weeklyButton.IconVisible = true;
			this.weeklyButton.IconZoom = 60D;
			this.weeklyButton.IsTab = false;
			this.weeklyButton.Location = new System.Drawing.Point(4, 204);
			this.weeklyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.weeklyButton.Name = "weeklyButton";
			this.weeklyButton.Normalcolor = System.Drawing.Color.Transparent;
			this.weeklyButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.weeklyButton.OnHoverTextColor = System.Drawing.Color.White;
			this.weeklyButton.selected = false;
			this.weeklyButton.Size = new System.Drawing.Size(212, 52);
			this.weeklyButton.TabIndex = 8;
			this.weeklyButton.Text = "Weekly";
			this.weeklyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.weeklyButton.Textcolor = System.Drawing.Color.White;
			this.weeklyButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weeklyButton.Click += new System.EventHandler(this.weekly_Click);
			// 
			// mapButton
			// 
			this.mapButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.mapButton.BackColor = System.Drawing.Color.Transparent;
			this.mapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.mapButton.BorderRadius = 0;
			this.mapButton.ButtonText = "Map";
			this.mapButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sliding.SetDecoration(this.mapButton, BunifuAnimatorNS.DecorationType.None);
			this.mapButton.DisabledColor = System.Drawing.Color.Gray;
			this.mapButton.Iconcolor = System.Drawing.Color.Transparent;
			this.mapButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("mapButton.Iconimage")));
			this.mapButton.Iconimage_right = null;
			this.mapButton.Iconimage_right_Selected = null;
			this.mapButton.Iconimage_Selected = null;
			this.mapButton.IconMarginLeft = 0;
			this.mapButton.IconMarginRight = 0;
			this.mapButton.IconRightVisible = true;
			this.mapButton.IconRightZoom = 0D;
			this.mapButton.IconVisible = true;
			this.mapButton.IconZoom = 60D;
			this.mapButton.IsTab = false;
			this.mapButton.Location = new System.Drawing.Point(4, 264);
			this.mapButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mapButton.Name = "mapButton";
			this.mapButton.Normalcolor = System.Drawing.Color.Transparent;
			this.mapButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.mapButton.OnHoverTextColor = System.Drawing.Color.White;
			this.mapButton.selected = false;
			this.mapButton.Size = new System.Drawing.Size(212, 52);
			this.mapButton.TabIndex = 9;
			this.mapButton.Text = "Map";
			this.mapButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mapButton.Textcolor = System.Drawing.Color.White;
			this.mapButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
			// 
			// newsButton
			// 
			this.newsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.newsButton.BackColor = System.Drawing.Color.Transparent;
			this.newsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.newsButton.BorderRadius = 0;
			this.newsButton.ButtonText = "News";
			this.newsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sliding.SetDecoration(this.newsButton, BunifuAnimatorNS.DecorationType.None);
			this.newsButton.DisabledColor = System.Drawing.Color.Gray;
			this.newsButton.Iconcolor = System.Drawing.Color.Transparent;
			this.newsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("newsButton.Iconimage")));
			this.newsButton.Iconimage_right = null;
			this.newsButton.Iconimage_right_Selected = null;
			this.newsButton.Iconimage_Selected = null;
			this.newsButton.IconMarginLeft = 0;
			this.newsButton.IconMarginRight = 0;
			this.newsButton.IconRightVisible = true;
			this.newsButton.IconRightZoom = 0D;
			this.newsButton.IconVisible = true;
			this.newsButton.IconZoom = 60D;
			this.newsButton.IsTab = false;
			this.newsButton.Location = new System.Drawing.Point(4, 324);
			this.newsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.newsButton.Name = "newsButton";
			this.newsButton.Normalcolor = System.Drawing.Color.Transparent;
			this.newsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.newsButton.OnHoverTextColor = System.Drawing.Color.White;
			this.newsButton.selected = false;
			this.newsButton.Size = new System.Drawing.Size(212, 52);
			this.newsButton.TabIndex = 10;
			this.newsButton.Text = "News";
			this.newsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.newsButton.Textcolor = System.Drawing.Color.White;
			this.newsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newsButton.Click += new System.EventHandler(this.newsButton_Click);
			// 
			// leftPanel
			// 
			this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.leftPanel.Controls.Add(this.noteButton);
			this.leftPanel.Controls.Add(this.subMenu);
			this.leftPanel.Controls.Add(this.historyButton);
			this.leftPanel.Controls.Add(this.newsButton);
			this.leftPanel.Controls.Add(this.mapButton);
			this.leftPanel.Controls.Add(this.weeklyButton);
			this.leftPanel.Controls.Add(this.currentButton);
			this.leftPanel.Controls.Add(this.returnButton);
			this.leftPanel.Controls.Add(this.title);
			this.sliding.SetDecoration(this.leftPanel, BunifuAnimatorNS.DecorationType.None);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(190, 900);
			this.leftPanel.TabIndex = 1;
			// 
			// subMenu
			// 
			this.subMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.sliding.SetDecoration(this.subMenu, BunifuAnimatorNS.DecorationType.None);
			this.subMenu.Location = new System.Drawing.Point(15, 503);
			this.subMenu.Name = "subMenu";
			this.subMenu.Size = new System.Drawing.Size(178, 149);
			this.subMenu.TabIndex = 13;
			// 
			// historyButton
			// 
			this.historyButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.historyButton.BackColor = System.Drawing.Color.Transparent;
			this.historyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.historyButton.BorderRadius = 0;
			this.historyButton.ButtonText = "History";
			this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sliding.SetDecoration(this.historyButton, BunifuAnimatorNS.DecorationType.None);
			this.historyButton.DisabledColor = System.Drawing.Color.Gray;
			this.historyButton.Iconcolor = System.Drawing.Color.Transparent;
			this.historyButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("historyButton.Iconimage")));
			this.historyButton.Iconimage_right = null;
			this.historyButton.Iconimage_right_Selected = null;
			this.historyButton.Iconimage_Selected = null;
			this.historyButton.IconMarginLeft = 0;
			this.historyButton.IconMarginRight = 0;
			this.historyButton.IconRightVisible = true;
			this.historyButton.IconRightZoom = 0D;
			this.historyButton.IconVisible = true;
			this.historyButton.IconZoom = 60D;
			this.historyButton.IsTab = false;
			this.historyButton.Location = new System.Drawing.Point(4, 444);
			this.historyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.historyButton.Name = "historyButton";
			this.historyButton.Normalcolor = System.Drawing.Color.Transparent;
			this.historyButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.historyButton.OnHoverTextColor = System.Drawing.Color.White;
			this.historyButton.selected = false;
			this.historyButton.Size = new System.Drawing.Size(212, 52);
			this.historyButton.TabIndex = 12;
			this.historyButton.Text = "History";
			this.historyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.historyButton.Textcolor = System.Drawing.Color.White;
			this.historyButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
			// 
			// mainPanel
			// 
			this.sliding.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(190, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1499, 900);
			this.mainPanel.TabIndex = 4;
			// 
			// sliding
			// 
			this.sliding.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
			this.sliding.Cursor = null;
			animation7.AnimateOnlyDifferences = true;
			animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
			animation7.LeafCoeff = 0F;
			animation7.MaxTime = 1F;
			animation7.MinTime = 0F;
			animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
			animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
			animation7.MosaicSize = 0;
			animation7.Padding = new System.Windows.Forms.Padding(0);
			animation7.RotateCoeff = 0F;
			animation7.RotateLimit = 0F;
			animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
			animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
			animation7.TimeCoeff = 0F;
			animation7.TransparencyCoeff = 0F;
			this.sliding.DefaultAnimation = animation7;
			// 
			// noteButton
			// 
			this.noteButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.noteButton.BackColor = System.Drawing.Color.Transparent;
			this.noteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.noteButton.BorderRadius = 0;
			this.noteButton.ButtonText = "Note";
			this.noteButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sliding.SetDecoration(this.noteButton, BunifuAnimatorNS.DecorationType.None);
			this.noteButton.DisabledColor = System.Drawing.Color.Gray;
			this.noteButton.Iconcolor = System.Drawing.Color.Transparent;
			this.noteButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("noteButton.Iconimage")));
			this.noteButton.Iconimage_right = null;
			this.noteButton.Iconimage_right_Selected = null;
			this.noteButton.Iconimage_Selected = null;
			this.noteButton.IconMarginLeft = 0;
			this.noteButton.IconMarginRight = 0;
			this.noteButton.IconRightVisible = true;
			this.noteButton.IconRightZoom = 0D;
			this.noteButton.IconVisible = true;
			this.noteButton.IconZoom = 60D;
			this.noteButton.IsTab = false;
			this.noteButton.Location = new System.Drawing.Point(4, 384);
			this.noteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.noteButton.Name = "noteButton";
			this.noteButton.Normalcolor = System.Drawing.Color.Transparent;
			this.noteButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
			this.noteButton.OnHoverTextColor = System.Drawing.Color.White;
			this.noteButton.selected = false;
			this.noteButton.Size = new System.Drawing.Size(212, 52);
			this.noteButton.TabIndex = 14;
			this.noteButton.Text = "Note";
			this.noteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.noteButton.Textcolor = System.Drawing.Color.White;
			this.noteButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
			// 
			// information
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.leftPanel);
			this.sliding.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.Name = "information";
			this.Size = new System.Drawing.Size(1689, 900);
			this.Load += new System.EventHandler(this.Information_Load);
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label title;
		private Bunifu.Framework.UI.BunifuFlatButton returnButton;
		private Bunifu.Framework.UI.BunifuFlatButton currentButton;
		private Bunifu.Framework.UI.BunifuFlatButton weeklyButton;
		private Bunifu.Framework.UI.BunifuFlatButton mapButton;
		private Bunifu.Framework.UI.BunifuFlatButton newsButton;
		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Panel mainPanel;
		private Bunifu.Framework.UI.BunifuFlatButton historyButton;
		private historyControl.subMenu subMenu;
		private BunifuAnimatorNS.BunifuTransition sliding;
		private Bunifu.Framework.UI.BunifuFlatButton noteButton;
	}
}