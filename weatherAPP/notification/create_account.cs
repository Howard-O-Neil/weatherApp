using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherAPP
{
	public partial class create_account : Form
	{
		int count = 7; 

		public create_account()
		{
			InitializeComponent();
		}

		private void create_account_Load(object sender, EventArgs e)
		{
			timer.Start(); 
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			label1.Text += '.'; 
			count--; 

			if (count == 0)
			{
				count = 7;
				label1.Text = "Creating Account"; 
			}
		}
	}
}
