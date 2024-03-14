using System;
using System.Collections.Generic;
using System.Text;
using CrudProduct.Localization;
using Volo.Abp.Application.Services;

namespace CrudProduct;

/* Inherit your application services from this class.
 */
public abstract class CrudProductAppService : ApplicationService
{
    protected CrudProductAppService()
    {
        LocalizationResource = typeof(CrudProductResource);
    }
}
