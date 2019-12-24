using System.Collections.Generic;

using FinanceManagerClient.Util;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Managers;
using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Presenters
{
    class CreateCriteriaPresenter : Presenter<ICreateCriteriaView>
    {

        private readonly IUserManager _userManager;
        private readonly ISearchCriteriaManager _criteriaManager;
        private readonly ITransactionReasonManager _reasonManager;

        public IEnumerable<User> Users => _userManager.GetUsers();
        public IEnumerable<TransactionReason> Reasons => _reasonManager.GetReasons();

        public CreateCriteriaPresenter(ICreateCriteriaView view) : base(view)
        {
            View.CreateCriteria += OnCreateCriteria;

            this._userManager = new UserManager();
            this._reasonManager = new TransactionReasonManager();
            this._criteriaManager = new SearchCriteriaManager();
        }

        private void OnCreateCriteria(object sender, SearchCriteria cr)
        {
            _criteriaManager.AddCriteria(cr);

            GlobalSettings.Instance.SearchCriteria = _criteriaManager.GetCriterias();
        }
    }
}
