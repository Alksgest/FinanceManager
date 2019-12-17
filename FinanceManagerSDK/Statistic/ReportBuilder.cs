namespace FinanceManagerSDK.Statistic
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
