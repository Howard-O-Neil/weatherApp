using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherAPP.notepad
{
	public partial class tabNote : UserControl
	{
		public MySQL_ORM_Binding.notepad_information data;
		public bool textChange = false;

		public tabNote()
		{
			InitializeComponent();
		}

		public tabNote(MySQL_ORM_Binding.notepad_information value)
		{
			data = value;
			InitializeComponent();
		}

		private void tabNote_Load(object sender, EventArgs e)
		{
			reloadDisplay();
		}

		private void reloadDisplay()
		{
			label.Text = "Notepad " + data.time_info;
			textBox.Text = data.content_information;
		}

		private async void cancel_Click(object sender, EventArgs e)
		{
			var message = new Loading_Information();
			message.StartPosition = FormStartPosition.CenterScreen;
			message.Show();

			await Task.Factory.StartNew(() =>
			{
				MySqlQuery query = new MySqlQuery();
				query.deleteNotepadInformation(data);
			});
			message.Dispose();

			this.Dispose();
		}

		private void label_Click(object sender, EventArgs e)
		{
			display contentDisplay = new display(data.content_information, this);
			contentDisplay.StartPosition = FormStartPosition.CenterScreen;
			contentDisplay.FormClosing += new FormClosingEventHandler(onDeleteDisplay);
			contentDisplay.Show();
		}

		private async void onDeleteDisplay(object sender, FormClosingEventArgs e)
		{
			if (textChange == true)
			{
				var message = new Loading_Information();
				message.StartPosition = FormStartPosition.CenterScreen;
				message.Show();

				data.content_information = (sender as display).data;

				await Task.Factory.StartNew(() =>
				{
					MySqlQuery query = new MySqlQuery();
					query.updateNotepadInformation(data);
				});
				message.Dispose();

				reloadDisplay();
				textChange = false;
			}
		}
	}
}
