using MauiNewsApp.ViewModels;

namespace MauiNewsApp.Views;

public partial class LottiePage : ContentPage
{
    public LottiePage(LottieViewModel lm)
    {
        InitializeComponent();
        BindingContext = lm;
    }
}