using MauiTheme.ViewModel;

namespace MauiTheme;

public partial class MainPage : BaseContentPage
{
    public MainPage(MainPageViewModel viewModel, IServiceProvider provider) : base(viewModel, provider)
    {
        InitializeComponent();

        txtOne.Focus();
    }
}
