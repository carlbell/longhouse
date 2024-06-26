namespace dotnetprojects;

using System;
using Microsoft.Maui.Controls;

using dotnetprojects.ViewModels.Profile;

public partial class Profile : ContentPage
{
    public Profile()
    {
        InitializeComponent();
        BindingContext = new ProfileViewModel();
    }


}

// public partial class Profile : ContentPage
// {
// 	public Profile()
//     {
//         InitializeComponent();
//         SizeChanged += OnPageSizeChanged;
//     }

//     private void OnPageSizeChanged(object sender, EventArgs e)
//     {
//         MainGrid.WidthRequest = Width;
//         MainGrid.HeightRequest = Height;
//     }

//     protected override void OnAppearing()
//     {
//         base.OnAppearing();
//         MainGrid.WidthRequest = Width;
//         MainGrid.HeightRequest = Height;
//     }

// 	private void AddImageButtonClicked(object sender, EventArgs e)
// 	{

// 		DisplayAlert("Alert", "Button Clicked! This is a placeholder for adding images.", "OK");

// 		SemanticScreenReader.Announce(addImageButton.Text);
// 	}
// }

