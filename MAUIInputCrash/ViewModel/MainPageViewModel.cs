using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiTheme.ViewModel;

public partial class MainPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private bool isDarkTheme;

    [ObservableProperty]
    private string inputOne;

    partial void OnInputOneChanged(string value)
    {
        InputTwo = value;
    }

    [ObservableProperty]
    private string inputTwo;

    public MainPageViewModel(IServiceProvider provider) : base(provider)
    {
        IsDarkTheme = Application.Current.RequestedTheme == AppTheme.Dark;
    }

    [RelayCommand]
    private async Task ChangeAppTheme()
    {
        try
        {
            IsLoading = true;
            Application.Current.UserAppTheme = IsDarkTheme ? AppTheme.Light : AppTheme.Dark;
            IsDarkTheme = !IsDarkTheme;

            await Task.Delay(2000); //Simulate long running task
        }
        catch (Exception)
        {
            //log error
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    private async void ExitApp()
    {
        navigationService.CloseApplication();
    }
}
