namespace weatherAPP
{
	partial class lockScreen
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
			BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lockScreen));
			BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
			this.loginTrans = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.mainPanel = new System.Windows.Forms.Panel();
			this.label = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();
			this.appear = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.SuspendLayout();
			// 
			// loginTrans
			// 
			this.loginTrans.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
			this.loginTrans.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 0F;
			this.loginTrans.DefaultAnimation = animation1;
			this.loginTrans.TimeStep = 0.009F;
			// 
			// mainPanel
			// 
			this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.appear.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
			this.loginTrans.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
			this.mainPanel.Location = new System.Drawing.Point(580, 106);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(614, 577);
			this.mainPanel.TabIndex = 4;
			// 
			// label
			// 
			this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.loginTrans.SetDecoration(this.label, BunifuAnimatorNS.DecorationType.None);
			this.appear.SetDecoration(this.label, BunifuAnimatorNS.DecorationType.None);
			this.label.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.Location = new System.Drawing.Point(607, 9);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(532, 45);
			this.label.TabIndex = 6;
			this.label.Text = "Login Form";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			this.label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
			// 
			// panel
			// 
			this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
			this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.appear.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
			this.loginTrans.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
			this.panel.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(559, 741);
			this.panel.TabIndex = 7;
			this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
			// 
			// cancel
			// 
			this.cancel.Activecolor = System.Drawing.Color.Transparent;
			this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancel.BackColor = System.Drawing.Color.Transparent;
			this.cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel.BackgroundImage")));
			this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cancel.BorderRadius = 0;
			this.cancel.ButtonText = "";
			this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginTrans.SetDecoration(this.cancel, BunifuAnimatorNS.DecorationType.None);
			this.appear.SetDecoration(this.cancel, BunifuAnimatorNS.DecorationType.None);
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
			this.cancel.Location = new System.Drawing.Point(1157, 9);
			this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cancel.Name = "cancel";
			this.cancel.Normalcolor = System.Drawing.Color.Transparent;
			this.cancel.OnHovercolor = System.Drawing.Color.Transparent;
			this.cancel.OnHoverTextColor = System.Drawing.Color.Transparent;
			this.cancel.selected = false;
			this.cancel.Size = new System.Drawing.Size(46, 45);
			this.cancel.TabIndex = 5;
			this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cancel.Textcolor = System.Drawing.Color.Transparent;
			this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// appear
			// 
			this.appear.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
			this.appear.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
			animation2.LeafCoeff = 0F;
			animation2.MaxTime = 1F;
			animation2.MinTime = 0F;
			animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
			animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
			animation2.MosaicSize = 0;
			animation2.Padding = new System.Windows.Forms.Padding(0);
			animation2.RotateCoeff = 0F;
			animation2.RotateLimit = 0F;
			animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
			animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
			animation2.TimeCoeff = 0F;
			animation2.TransparencyCoeff = 0F;
			this.appear.DefaultAnimation = animation2;
			this.appear.TimeStep = 0.01F;
			// 
			// lockScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1216, 741);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.label);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.mainPanel);
			this.appear.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.loginTrans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "lockScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "login";
			this.Load += new System.EventHandler(this.lockscreen_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion
		private BunifuAnimatorNS.BunifuTransition loginTrans;
		private BunifuAnimatorNS.BunifuTransition appear;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel panel;
		private Bunifu.Framework.UI.BunifuFlatButton cancel;
	}
}

