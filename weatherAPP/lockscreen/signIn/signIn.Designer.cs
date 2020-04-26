namespace weatherAPP.lockscreen.signIn
{
	partial class signIn
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
			this.label5 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Enroll = new Bunifu.Framework.UI.BunifuFlatButton();
			this.login = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(54, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 29);
			this.label5.TabIndex = 19;
			this.label5.Text = "Password";
			// 
			// password
			// 
			this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(59, 269);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(484, 53);
			this.password.TabIndex = 18;
			this.password.UseSystemPasswordChar = true;
			this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(54, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 29);
			this.label4.TabIndex = 17;
			this.label4.Text = "User Name";
			// 
			// username
			// 
			this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.Location = new System.Drawing.Point(59, 154);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(484, 53);
			this.username.TabIndex = 16;
			this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(224, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 46);
			this.label2.TabIndex = 11;
			this.label2.Text = "Sign In";
			// 
			// Enroll
			// 
			this.Enroll.Activecolor = System.Drawing.Color.Transparent;
			this.Enroll.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Enroll.BackColor = System.Drawing.Color.Transparent;
			this.Enroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Enroll.BorderRadius = 0;
			this.Enroll.ButtonText = "Dont have an account ?";
			this.Enroll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Enroll.DisabledColor = System.Drawing.Color.Transparent;
			this.Enroll.ForeColor = System.Drawing.Color.Transparent;
			this.Enroll.Iconcolor = System.Drawing.Color.Transparent;
			this.Enroll.Iconimage = null;
			this.Enroll.Iconimage_right = null;
			this.Enroll.Iconimage_right_Selected = null;
			this.Enroll.Iconimage_Selected = null;
			this.Enroll.IconMarginLeft = 0;
			this.Enroll.IconMarginRight = 0;
			this.Enroll.IconRightVisible = true;
			this.Enroll.IconRightZoom = 0D;
			this.Enroll.IconVisible = true;
			this.Enroll.IconZoom = 90D;
			this.Enroll.IsTab = false;
			this.Enroll.Location = new System.Drawing.Point(88, 461);
			this.Enroll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Enroll.Name = "Enroll";
			this.Enroll.Normalcolor = System.Drawing.Color.Transparent;
			this.Enroll.OnHovercolor = System.Drawing.Color.Transparent;
			this.Enroll.OnHoverTextColor = System.Drawing.Color.Black;
			this.Enroll.selected = false;
			this.Enroll.Size = new System.Drawing.Size(428, 43);
			this.Enroll.TabIndex = 21;
			this.Enroll.Text = "Dont have an account ?";
			this.Enroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Enroll.Textcolor = System.Drawing.Color.Black;
			this.Enroll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enroll.Click += new System.EventHandler(this.Enroll_Click);
			// 
			// login
			// 
			this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login.ForeColor = System.Drawing.Color.Black;
			this.login.Location = new System.Drawing.Point(232, 373);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(142, 71);
			this.login.TabIndex = 22;
			this.login.Text = "Sign In";
			this.login.UseVisualStyleBackColor = false;
			this.login.Click += new System.EventHandler(this.SignIn_Click);
			// 
			// signIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.login);
			this.Controls.Add(this.Enroll);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.password);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.username);
			this.Controls.Add(this.label2);
			this.Name = "signIn";
			this.Size = new System.Drawing.Size(601, 561);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		public Bunifu.Framework.UI.BunifuFlatButton Enroll;
		private System.Windows.Forms.Button login;
		public System.Windows.Forms.TextBox password;
		public System.Windows.Forms.TextBox username;
	}
}
