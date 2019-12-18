using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinanceManagerClient.Views;
using FinanceManagerClient.Presenters;

namespace FinanceManagerClient.Controls
{
    public partial class UsersGridControl : UserControl, IUsersView
    {
        public event EventHandler Initialize;
        public object DataSource { get; set; }

        private readonly UsersGridControlPresenter _presenter;

        public UsersGridControl()
        {
            InitializeComponent();

            _presenter = new UsersGridControlPresenter(this);

            InvokeInitialize(EventArgs.Empty);

            _presenter.DataSourceUpdated += OnDataSourceUpdated;
        }

        private void OnDataSourceUpdated(object sender, EventArgs e)
        {
            UsersDataGridView.DataSource = DataSource;
        }

        public void InvokeInitialize(EventArgs e) => Initialize?.Invoke(this, e);
    }
}
