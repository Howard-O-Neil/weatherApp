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
    public partial class note : UserControl
    {
        List<tabNote> currentNote = new List<tabNote>();
        UserControl currentSplash;

        public note()
        {
            InitializeComponent();
        }

        private void note_Load(object sender, EventArgs e)
        {
            refreshNote();
        }

        public async void refreshNote()
        {
            initSplashScreen();

            MySqlQuery query = new MySqlQuery();

            List<MySQL_ORM_Binding.notepad_information> noteData =
                new List<MySQL_ORM_Binding.notepad_information>();

            await Task.Factory.StartNew(() =>
            {
                noteData = query.getNotepadInformation(mainApp.customer_id);

                foreach (var item in noteData)
                {
                    initNewNote(item);
                }
            });
            currentSplash.Dispose();
        }

        private void initNewNote(MySQL_ORM_Binding.notepad_information noteValue)
        {
            tabNote newTab = new tabNote(noteValue);

            Invoke(new Action(() =>
            {
                mainPanel.Controls.Add(newTab);
            }));
            newTab.Show();
        }

        private void initSplashScreen()
        {
            if (currentSplash != null)
            {
                currentSplash.Dispose();
            }
            currentSplash = new splash(99999999);
            currentSplash.Dock = DockStyle.Fill;
            this.Controls.Add(currentSplash);

            currentSplash.BringToFront();
            currentSplash.Show();
        }

        private void addNote_Click(object sender, EventArgs e)
        {
            display noteDisplay = new display();
            noteDisplay.StartPosition = FormStartPosition.CenterScreen;
            noteDisplay.FormClosing += new FormClosingEventHandler(onDeleteDisplay);
            noteDisplay.Show();
        }

        private async void onDeleteDisplay(object sender, FormClosingEventArgs e)
        {
			var message = new Loading_Information();
            message.StartPosition = FormStartPosition.CenterScreen;
            message.Show();

            long noteID = 0;

            await Task.Factory.StartNew(() =>
            {
				MySqlQuery query = new MySqlQuery(); 
				noteID = query.getNotepadInformationID(); 
            });

            MySQL_ORM_Binding.notepad_information note =
                new MySQL_ORM_Binding.notepad_information
                {
                    customer_id = mainApp.customer_id,
					time_table_id = noteID,
                    time_info = string.Format("{0:dd/MM/yyyy hh:mm:ss tt}",
                        DateTime.Now),
                    content_information = (sender as display).data
                };
            initNewNote(note);

            message.Dispose();

			await Task.Factory.StartNew(() =>
            {
                MySqlQuery query = new MySqlQuery();
                query.insertNotepadInformation(note);
            });
        }
    }
}
