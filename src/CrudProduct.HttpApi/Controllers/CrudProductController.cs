using CrudProduct.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CrudProduct.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CrudProductController : AbpControllerBase
{
    protected CrudProductController()
    {
        LocalizationResource = typeof(CrudProductResource);
    }
}
