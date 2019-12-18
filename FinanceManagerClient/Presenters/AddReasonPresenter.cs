using System.Windows.Forms;

using FinanceManagerClient.Views;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

namespace FinanceManagerClient.Presenters
{
    class AddReasonPresenter : Presenter<IAddReasonView>
    {
        private readonly IReasonRepository _repo;

        public AddReasonPresenter(IAddReasonView view) : base(view)
        {
            View.TransactionReasonAdd += OnTransactionReasonAdd;

            _repo = new ReasonRepository();
        }

        private void OnTransactionReasonAdd(object sender, TransactionReason e)
        {
            _repo.AddReason(e);

            (this.View as Form).Close();
        }
    }
}
