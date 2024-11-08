using MauiAppSQLite.ViewModels;

namespace MauiAppSQLite;

public partial class CarPage : ContentPage
{
    public CarPage()
	{
		InitializeComponent();
        BindingContext = new CarPageViewModel();
	}

}