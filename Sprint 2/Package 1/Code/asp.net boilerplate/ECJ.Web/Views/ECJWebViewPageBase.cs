using Abp.Web.Mvc.Views;

namespace ECJ.Web.Views
{
    public abstract class ECJWebViewPageBase : ECJWebViewPageBase<dynamic>
    {

    }

    public abstract class ECJWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ECJWebViewPageBase()
        {
            LocalizationSourceName = ECJConsts.LocalizationSourceName;
        }
    }
}