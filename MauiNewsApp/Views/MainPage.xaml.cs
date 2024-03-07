using MauiNewsApp.ViewModels;

namespace MauiNewsApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        Console.WriteLine("MainPage invoked");
        BindingContext = vm;
    }
}