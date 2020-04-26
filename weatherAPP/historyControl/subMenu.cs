using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherAPP.historyControl
{
	public partial class subMenu : UserControl
	{
		public event EventHandler currentClick;
		public event EventHandler weeklyClick;  

		public subMenu()
		{
			InitializeComponent();
		}

		private void current_Click(object sender, EventArgs e)
		{
			if (currentClick != null)
				currentClick(null, null); 
		}

		private void weekly_Click(object sender, EventArgs e)
		{
			if (weeklyClick != null)
				weeklyClick(null, null); 
		}
	}
}
