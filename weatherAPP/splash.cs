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
    public partial class splash: UserControl
    {
        int Count = 0;
        public int WaitSec = 8;
		Timer mainTimer = new Timer();
		Timer animationTimer = new Timer(); 

        public splash(int sec)
        {
			WaitSec = sec; 
            InitializeComponent();
			mainTimer.Tick += new EventHandler(On_Tick);
			mainTimer.Interval = 1000;

			animationTimer.Tick += new EventHandler(On_animation_tick); 
			animationTimer.Interval = 200; 
		}

		private void splash_Load(object sender, EventArgs e)
		{
			mainTimer.Start();
			animationTimer.Start(); 
		}

		private void On_Tick(object sender, EventArgs e)
		{
			Count++;
			if (Count == WaitSec) this.Dispose(); 
		}

		int countAnimateLabel = 0;
		private void On_animation_tick(object sender, EventArgs e)
		{
			label.Text += ".";
			countAnimateLabel++;

			if (countAnimateLabel == 7)
			{
				label.Text = "Data is loading";
				countAnimateLabel = 0; 
			}
		}
	}
}
