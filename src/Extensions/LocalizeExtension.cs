using LocalizationSample.Resources.Localization;
using Microsoft.Extensions.Localization;

namespace LocalizationSample.Extensions
{
    [ContentProperty(nameof(Key))]
    public class LocalizeExtension : IMarkupExtension
    {
        IStringLocalizer<Localization> _localizer;

        public string Key { get; set; } = string.Empty;

        public LocalizeExtension()
        {
            _localizer = ServiceHelper.GetService<IStringLocalizer<Localization>>();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            string localizedText = _localizer[Key];
            return localizedText;
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ProvideValue(serviceProvider);
    }
}
