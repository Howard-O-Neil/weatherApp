using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;


namespace weatherAPP
{
	public partial class lockScreen : Form
	{
		public static lockScreen Instance;

		Point LastLocation;
		bool isDragging = false;
		UserControl signin, signup;

		public lockScreen()
		{
			Instance = this;
			this.DoubleBuffered = true; 
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private async void lockscreen_Load(object sender, EventArgs e)
		{
			label.Text = "Checking For Update...";
			label.Font = new Font("Gill Sans Ultra Bold", 16);

			string currentVersion = Assembly.GetExecutingAssembly().
				GetName().Version.ToString();

			bool flag = true;
			await Task.Factory.StartNew(() =>
			{
				MySqlQuery query = new MySqlQuery();

				flag = query.checkVersion(currentVersion); 

				if (flag == false)
				{
					var notification = new update_available();
					notification.StartPosition = FormStartPosition.CenterScreen;

					DialogResult dialog = notification.ShowDialog();

					if (dialog == DialogResult.Yes)
					{
						Process.Start("https://mingkhoi.com/Products/");
						Application.Exit();
					}
					notification.Dispose(); 
				}
			});
			initializeControl(ref signin, new weatherAPP.lockscreen.signIn.signIn());
			initializeControl(ref signup, new weatherAPP.lockscreen.signUp.signUp());
			signin.Show();

			(signin as lockscreen.signIn.signIn).username.Focus();
			label.Font = new Font("Gill Sans Ultra Bold", 24);
			label.Text = "Login Form"; 
		}

		private void initializeControl(ref UserControl value, UserControl type)
		{
			value = type;
			value.Dock = DockStyle.Fill;
			mainPanel.Controls.Add(value);
			value.Visible = false;
		}

		private void TitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			isDragging = true;
			LastLocation = e.Location;
		}

		private void TitleBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging == true)
			{
				this.Location = new Point(this.Location.X - LastLocation.X + e.X,
					this.Location.Y - LastLocation.Y + e.Y);
				this.Update();
			}
		}

		private void TitleBar_MouseUp(object sender, MouseEventArgs e)
		{
			isDragging = false;
		}

		private void SignIn_Click()
		{
			loginTrans.Hide(signup);
			signin.Visible = false;
			loginTrans.Show(signin);
		}

		private void SignUp_Click()
		{
			loginTrans.Hide(signin);
			signup.Visible = false;
			loginTrans.Show(signup);
		}

		public void performSignIn()
		{
			(signin as lockscreen.signIn.signIn).resetTextbox();
			SignIn_Click();
		}

		public void performSignUp()
		{
			(signup as lockscreen.signUp.signUp).resetTextbox();
			SignUp_Click();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
