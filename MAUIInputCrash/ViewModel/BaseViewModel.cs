using CommunityToolkit.Mvvm.ComponentModel;
using MauiTheme.Navigation;

namespace MauiTheme.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    #region Private variables
    protected readonly IServiceProvider provider;

    protected readonly INavigationService navigationService;

    [ObservableProperty]
    private bool isLoading;
    #endregion

    #region Constructor
    public BaseViewModel(IServiceProvider provider)
    {
        this.provider = provider;
        navigationService = provider.GetRequiredService<INavigationService>();
    }
    #endregion

    #region Methods
    public virtual async Task InitViewAsync()
    {
        //Méthode virtuelle dédiée au chargement asynchrone des écrans (overridée de manière spécifique sur chaque enfant)
    }
    #endregion
}