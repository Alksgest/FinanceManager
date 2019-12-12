using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Statistic
{
    public interface IReportBuilder
    {
        void BuildOutcomeStatistic();
        void BuildIncomeStatistc();
        void BuildFirstHalfYearReport();
        void BuildSecondHalfYearReport();
        void BuildYearReport();
        void BuildMembershipFeeReport();
    }


    class ReportBuilder /* : IReportBuilder */
    {

    }
}
