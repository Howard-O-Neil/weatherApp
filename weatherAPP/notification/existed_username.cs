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
	public partial class existed_username : Form
	{
		string existUsername = ""; 

		public existed_username()
		{
			InitializeComponent();
		}

		public existed_username(string value)
		{
			existUsername = value;
			InitializeComponent();
		}

		private void existed_username_Load(object sender, EventArgs e)
		{
			label1.Text = "There's Already User With Username:\n" +
				existUsername; 
		}
	}
}
