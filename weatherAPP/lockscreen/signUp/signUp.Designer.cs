namespace weatherAPP.lockscreen.signUp
{
	partial class signUp
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
			this.label2 = new System.Windows.Forms.Label();
			this.firstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lastName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.userName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.TextBox();
			this.button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(154, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(341, 46);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sign Up For Free";
			// 
			// firstName
			// 
			this.firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstName.Location = new System.Drawing.Point(67, 135);
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(205, 53);
			this.firstName.TabIndex = 2;
			this.firstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstName_KeyDown);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(62, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "First Name";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(380, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 29);
			this.label3.TabIndex = 5;
			this.label3.Text = "Last Name";
			// 
			// lastName
			// 
			this.lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastName.Location = new System.Drawing.Point(385, 135);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(205, 53);
			this.lastName.TabIndex = 4;
			this.lastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastName_KeyDown);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(62, 199);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 29);
			this.label4.TabIndex = 7;
			this.label4.Text = "User Name";
			// 
			// userName
			// 
			this.userName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userName.Location = new System.Drawing.Point(67, 241);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(523, 53);
			this.userName.TabIndex = 6;
			this.userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userName_KeyDown);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(62, 312);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 29);
			this.label5.TabIndex = 9;
			this.label5.Text = "Password";
			// 
			// password
			// 
			this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(67, 354);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(523, 53);
			this.password.TabIndex = 8;
			this.password.UseSystemPasswordChar = true;
			this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
			// 
			// button
			// 
			this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button.ForeColor = System.Drawing.Color.Black;
			this.button.Location = new System.Drawing.Point(250, 446);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(142, 71);
			this.button.TabIndex = 23;
			this.button.Text = "Sign Up";
			this.button.UseVisualStyleBackColor = false;
			this.button.Click += new System.EventHandler(this.SignUp_Click);
			// 
			// signUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.button);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.password);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.userName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lastName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.firstName);
			this.Controls.Add(this.label2);
			this.Name = "signUp";
			this.Size = new System.Drawing.Size(660, 561);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox firstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox lastName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox userName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button button;
	}
}
