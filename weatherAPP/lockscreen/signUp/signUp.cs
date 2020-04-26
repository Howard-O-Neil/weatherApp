using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;


namespace weatherAPP.lockscreen.signUp
{
    public partial class signUp : UserControl
    {
        public signUp()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void resetTextbox()
        {
            firstName.Text = lastName.Text =
                userName.Text = password.Text = "";
        }

        private async void SignUp_Click(object sender, EventArgs e)
        {
            bool exitFunction = false;
            
            var notification = new create_account();
            notification.StartPosition = FormStartPosition.CenterScreen;
            notification.Show();

            var customer = new MySQL_ORM_Binding.user_information
            {
                customer_id = Helper.getHashKey(userName.Text, password.Text),
                first_name = firstName.Text,
                last_name = lastName.Text,
                customer_user_name = userName.Text,
                customer_password = password.Text
            };

            await Task.Factory.StartNew(() =>
            {
                MySqlQuery query = new MySqlQuery(); 

                if (query.checkUsername(customer.customer_user_name) == false)
                {
                    Invoke(new Action(() =>
                    {
                        notification.Dispose();
                    }));

                    var message = new existed_username(customer.customer_user_name);
                    message.StartPosition = FormStartPosition.CenterParent;
                    message.ShowDialog();

                    resetTextbox();
                    exitFunction = true;
                }
            });

            await Task.Factory.StartNew(() =>
            {
                if (exitFunction == false)
                {
                    MySqlQuery query = new MySqlQuery(); 
                    query.insertUserInformation(customer);
                }
            });

            notification.Dispose();

            if (exitFunction == false)
                lockScreen.Instance.performSignIn();
        }

        private void firstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lastName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                userName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
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
                SignUp_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }
    }
}
