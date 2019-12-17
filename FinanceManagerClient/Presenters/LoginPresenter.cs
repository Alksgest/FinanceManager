using System;
using System.Linq;
using System.Windows.Forms;

using FinanceManagerClient.Args;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Managers;

namespace FinanceManagerClient.Presenters
{
    class LoginPresenter : Presenter<ILoginView>
    {
        private readonly IUserManager _manager;

        public event EventHandler LoginDone;
        public event EventHandler NoUsersDetected;
        public event EventHandler ClosingFormInvoked;

        public User CurrentUser = null;

        public LoginPresenter(ILoginView view) : base(view)
        {
            _manager = new UserManager();
            this.View.Login += OnLogin;

        }

        private void OnLogin(object sender, LoginEventArgs args)
        {
            var user = _manager.GetUser(args.Lastname, args.Degree);
            if (user != null)
            {
                LoginDone?.Invoke(this, new EventArgs());

                CurrentUser = user;

                CreateMainForm();
            }

            else
            {
                MessageBox.Show("Lastname or degree is incorrect.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateFirstUser(EventArgs args)
        {
            NoUsersDetected?.Invoke(this, args);
            var res = MessageBox.Show("There are no users now, do you want to create new one?",
                "No users yet", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                using (var form = new CreateUserForm())
                {
                    form.ShowDialog();
                }
            }
            else
            {
                ClosingFormInvoked?.Invoke(this, args);
            }
        }

        private void CreateMainForm()
        {
            using (var form = new MainForm(CurrentUser, View))
            {
                form.ShowDialog();
            }
        }

        protected override void OnViewLoad(object sender, EventArgs e)
        {
            base.OnViewLoad(sender, e);

            int count = _manager.GetUsers().Count();
            if (count == 0)
            {
                CreateFirstUser(e);
            }
        }

        protected override void OnViewInitialize(object sender, EventArgs e) => base.OnViewInitialize(sender, e);

    }
}
