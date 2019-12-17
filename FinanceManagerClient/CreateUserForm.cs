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
            if (Validate())
            {
                User user = CreateUser();

                UserCreation(sender, user);

                this.Close();
            }
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

        private bool Validate()
        {
            var isFirstnameValid = ValidateFirstname();
            var isLastnameValid = ValidateSurname();
            var isDegreeValid = ValidateDegree();

            return isFirstnameValid && isLastnameValid && isDegreeValid;
        }

        private bool ValidateFirstname()
        {
            bool isValidated = true;
            if (FirstnameTextBox.Text.Trim().Length == 0)
            {
                ErrorProvider.SetError(FirstnameTextBox, "Enter firstname, please.");
                isValidated = false;
            }
            else
            {
                ErrorProvider.SetError(FirstnameTextBox, "");
            }
            return isValidated;
        }

        private bool ValidateSurname()
        {
            bool isValidated = true;
            if (LastnameTextBox.Text.Trim().Length == 0)
            {
                ErrorProvider.SetError(LastnameTextBox, "Enter lastname, please.");
                isValidated = false;
            }
            else
            {
                ErrorProvider.SetError(LastnameTextBox, "");
            }
            return isValidated;
        }

        private bool ValidateDegree()
        {
            bool isValidated = true;
            if (DegreeComboBox.SelectedIndex <= 0)
            {
                ErrorProvider.SetError(DegreeComboBox, "Select degree.");
                isValidated = false;
            }
            else
            {
                ErrorProvider.SetError(DegreeComboBox, "");
            }

            return isValidated;
        }
    }
}
