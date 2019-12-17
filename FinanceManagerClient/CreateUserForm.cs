using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinanceManagerClient.Presenters;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient
{
    public partial class CreateUserForm : Form, ICreateUserView
    {
        public event EventHandler Initialize;
        public event EventHandler<User> UserCreation;

        private CreateUserPresenter _presenter;

        public CreateUserForm()
        {
            InitializeComponent();
            _presenter = new CreateUserPresenter(this);

            InvokeInitialize(new EventArgs());
        }

        public void InvokeInitialize(EventArgs e)
        {
            Initialize?.Invoke(this, e);
            InitControls();
        }

        private void InitControls()
        {
            object[] values = { "", Degree.First, Degree.Second, Degree.Third };
            DegreeComboBox.Items.AddRange(values);
        }

        private void SubmitButtonClicked(object sender, EventArgs e)
        {
            User user = CreateUser();

            UserCreation(sender, user);

            this.Close();
        }

        private User CreateUser()
        {
            User u = null;
            try
            {
                var degree = (Degree)DegreeComboBox.SelectedItem;
                u = new User
                {
                    Firstname = FirstnameTextBox.Text,
                    Lastname = LastnameTextBox.Text,
                    Degree = degree
                };
            }
            catch
            {

            }
            return u;
        }
    }
}
