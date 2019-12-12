using FinanceManagerClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagerClient.Presenters
{
    public class MakeTransactionPresenter : Presenter<IMakeTransactionView>
    {

        public MakeTransactionPresenter(IMakeTransactionView view) : base(view) { }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);
        }
    }
}
