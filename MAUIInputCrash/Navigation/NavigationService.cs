namespace MauiTheme.Navigation;

public sealed class NavigationService : INavigationService
{
    #region Constructor
    public NavigationService(IServiceProvider provider)
    {
    }
    #endregion

    #region Methods
    public async Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
    {
        try
        {
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                if (routeParameters != null)
                {
                    await Shell.Current.GoToAsync(route, true, routeParameters);
                }
                else
                {
                    await Shell.Current.GoToAsync(route, true);
                }
            });
        }
        catch (Exception)
        {
            //log error
        }
    }

    public async Task NavigateBackAsync()
    {
        await NavigateToAsync("..");
    }

    public void CloseApplication()
    {
        Application.Current.Quit();
    }
    #endregion
}
