using System;
using System.Diagnostics;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace LoginPage
{
	public class LoadingPopUp : PopupPage
	{
		public LoadingPopUp()
		{
			Content = new StackLayout()
			{
				BackgroundColor = Color.Transparent,
				Children =
		{
			new Label()
			{
				Text = "Loading data ...",
				FontSize = 18,
				TextColor = Color.White,
				HorizontalTextAlignment = TextAlignment.Center
			},
			new ActivityIndicator()
			{
				IsRunning = true
			},
		},
				VerticalOptions = LayoutOptions.Center,
				Padding = new Thickness(10, 0, 10, 0),
			};

			// set the background to transparent color 
			// (actually darkened-transparency: notice the alpha value at the end)
			this.BackgroundColor = new Color(0, 0, 0, 0.4);
		}

		public void ClosePopUp()
		{
			// Close the modal page
			PopupNavigation.PopAllAsync();
		}

		public async void OpenPopUp(PopupPage page)
		{
			Debug.WriteLine("Loading pop up");
			await PopupNavigation.PushAsync(page);
		}
	}
}
