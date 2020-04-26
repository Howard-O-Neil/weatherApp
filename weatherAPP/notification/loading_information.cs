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
	public partial class Loading_Information : Form
	{
		int count = 7; 

		public Loading_Information()
		{
			InitializeComponent();
		}

		private void Loading_Information_Load(object sender, EventArgs e)
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
				label1.Text = "Loading Information"; 
			}
		}
	}
}
