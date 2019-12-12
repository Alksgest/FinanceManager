using System;
using FinanceManagerClient.Views;

namespace FinanceManagerClient.Presenters
{
    public class Presenter<TView> where TView : class, IView
    {
        public TView View { get; private set; }

        public Presenter(TView view)
        {
            View = view ?? throw new ArgumentNullException(view.ToString());

            View.Initialize += OnViewInitialize;
            View.Load += OnViewLoad;
        }

        protected virtual void OnViewInitialize(object sender, EventArgs e) { }
        protected virtual void OnViewLoad(object sender, EventArgs e) { }
    }
}
