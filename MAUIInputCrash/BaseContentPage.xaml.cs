using MauiTheme.Navigation;
using MauiTheme.ViewModel;

namespace MauiTheme;

public partial class BaseContentPage : ContentPage
{
    #region Properties
    protected readonly IServiceProvider provider;

    private readonly BaseViewModel baseViewModel;

    protected readonly INavigationService navigationService;

    #endregion

    #region Constructor
    public BaseContentPage(BaseViewModel viewModel, IServiceProvider provider)
    {
        InitializeComponent();
        BindingContext = viewModel;

        this.provider = provider;
        baseViewModel = viewModel;
        navigationService = provider.GetRequiredService<INavigationService>();

        Loaded += async (s, e) =>
        {
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                baseViewModel.IsLoading = true;
                await baseViewModel.InitViewAsync();
                baseViewModel.IsLoading = false;
            });
        };
    }

    protected override bool OnBackButtonPressed()
    {
        return baseViewModel.IsLoading;
    }
    #endregion
}