using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CrudProduct;

[Dependency(ReplaceServices = true)]
public class CrudProductBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CrudProduct";
}
