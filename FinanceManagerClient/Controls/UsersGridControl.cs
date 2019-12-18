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
using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Controls
{
    public partial class UsersGridControl : UserControl, IUsersView
    {
        public event EventHandler Initialize;
        public event EventHandler Refresh;

        public object DataSource { get; set; }

        private readonly UsersGridControlPresenter _presenter;

        private readonly IMainView _parent;

        public UsersGridControl(IMainView parent)
        {
            InitializeComponent();

            _presenter = new UsersGridControlPresenter(this);

            InvokeInitialize(EventArgs.Empty);

            _presenter.DataSourceUpdated += OnDataSourceUpdated;
            _presenter.SetDataSoruce();

            _parent = parent;
            _parent.RefreshNeeded += OnRefreshNeeded;
        }

        private void OnRefreshNeeded(object sender, EventArgs e)
        {
            Refresh?.Invoke(sender, e);
        }

        private void OnDataSourceUpdated(object sender, EventArgs e)
        {
            UsersDataGridView.DataSource = DataSource;
        }

        public void InvokeInitialize(EventArgs e) => Initialize?.Invoke(this, e);
    }
}
