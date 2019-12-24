using System.Windows.Forms;

using FinanceManagerClient.Util;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Managers;
using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Presenters
{
    class AddReasonPresenter : Presenter<IAddReasonView>
    {
        private readonly ITransactionReasonManager _manager;

        public AddReasonPresenter(IAddReasonView view) : base(view)
        {
            View.TransactionReasonAdd += OnTransactionReasonAdd;

            _manager = new TransactionReasonManager();
        }

        private void OnTransactionReasonAdd(object sender, TransactionReason e)
        {
            _manager.AddReason(e);

            (this.View as Form).Close();

            GlobalSettings.Instance.TransactionReasons = _manager.GetReasons();
        }
    }
}
