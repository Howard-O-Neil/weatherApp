using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace weatherAPP.lockscreen.signIn
{
    public partial class signIn : UserControl
    {
        public signIn()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.GotFocus += new EventHandler(focusOnUsername);
        }

        public void resetTextbox()
        {
            username.Text = password.Text = "";
        }

        private void focusOnUsername(object sender, EventArgs e)
        {
            username.Focus();
        }

        private async void SignIn_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            await Task.Factory.StartNew(() =>
            {
                var message = new Loading_Information();
                message.StartPosition = FormStartPosition.CenterScreen;

                Invoke(new Action(() =>
                {
                    message.Show();
                }));

                MySqlQuery query = new MySqlQuery();

                if (query.checkCustomer(user, pass) == true)
                {
                    Invoke(new Action(() =>
                    {
                        message.Dispose();
                    }));
                    string hashKey = Helper.getHashKey(user, pass);

                    lockScreen.Instance.Hide();

                    Form newForm = new mainApp();
                    newForm.FormClosing += new FormClosingEventHandler(onClosingMainApp);
                    mainApp.customer_id = hashKey;

                    Invoke(new Action(() =>
                    {
                        newForm.Show();
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        message.Dispose();
                    }));

                    var notification = new cannot_find_user();
                    notification.StartPosition = FormStartPosition.CenterParent;
                    notification.ShowDialog();
                }
            });
        }

        int counterSecondStart = 0;
        int counterSecondEnd = 120; 
        private void localTimerTick(object sender, EventArgs e, object mainform)
        {
            counterSecondStart++;
            if (counterSecondStart == counterSecondEnd)
                (mainform as mainApp).Close();

        }

        private void onClosingMainApp(object mainform, FormClosingEventArgs local_event)
        {
            System.Windows.Forms.Timer newTimer = new System.Windows.Forms.Timer();

            newTimer.Tick += (sender, e) => localTimerTick(sender, e, mainform);
            newTimer.Start();
        }

        private void Enroll_Click(object sender, EventArgs e)
        {
            lockScreen.Instance.performSignUp();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignIn_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }
    }
}
