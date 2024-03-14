using CrudProduct.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CrudProduct.Blazor;

public abstract class CrudProductComponentBase : AbpComponentBase
{
    protected CrudProductComponentBase()
    {
        LocalizationResource = typeof(CrudProductResource);
    }
}
