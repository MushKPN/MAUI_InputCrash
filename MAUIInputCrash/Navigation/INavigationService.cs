namespace MauiTheme.Navigation;

public interface INavigationService
{
    Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);

    Task NavigateBackAsync();

    void CloseApplication();
}
