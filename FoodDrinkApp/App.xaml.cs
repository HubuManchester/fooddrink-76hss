namespace FoodDrinkApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new AppShell());

        
        if (DeviceInfo.Current.Platform == DevicePlatform.WinUI ||
            DeviceInfo.Current.Platform == DevicePlatform.MacCatalyst)
        {
            window.Width = 520;
            window.Height = 880;
        }

        return window;
    }
}