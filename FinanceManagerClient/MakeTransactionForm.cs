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

namespace FinanceManagerClient
{
    public partial class MakeTransactionForm : Form, IMakeTransactionView
    {
        public event EventHandler Initialize;

        private readonly MakeTransactionPresenter _presenter;   

        public MakeTransactionForm()
        {
            InitializeComponent();

            _presenter = new MakeTransactionPresenter(this);

            InvokeInitialize(new EventArgs());  
        }

        public void InvokeInitialize(EventArgs e) => Initialize?.Invoke(this, e);

    }
}
