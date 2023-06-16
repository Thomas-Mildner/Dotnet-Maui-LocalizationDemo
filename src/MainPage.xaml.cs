using LocalizationSample.Extensions;
using LocalizationSample.Resources.Localization;
using Microsoft.Extensions.Localization;

namespace LocalizationSample;

public partial class MainPage : ContentPage
{
    private int _count = 0;
    IStringLocalizer<Localization> _localizer;

    public MainPage()
    {
        InitializeComponent();
        _localizer = ServiceHelper.GetService<IStringLocalizer<Localization>>();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        _count++;

        var localizedString = _localizer["ClickMeButtonCounterText"];
        CounterBtn.Text = string.Format(localizedString, _count);



        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

