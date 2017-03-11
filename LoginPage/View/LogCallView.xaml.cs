using System;
using System.Collections.Generic;
using System.Diagnostics;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace LoginPage
{
	public partial class LogCallView : PopupPage
	{
		List<Point[]> points;
		public LogCallView()
		{
			InitializeComponent();

		}

		void Handle_Close_Clicked(object sender, System.EventArgs e)
		{
			PopupNavigation.PopAsync();
		}

		void Handle_Log_Clicked(object sender, System.EventArgs e)
		{
			if (padView.IsBlank)
			{
				padView.CaptionText = "mandatory";
				padView.CaptionTextColor = Color.Red;
			}
			else
			{
				PopupNavigation.PopAsync();
				var data = padView.GetImage(Acr.XamForms.SignaturePad.ImageFormatType.Png);
				Debug.WriteLine(data);
			}
		}
	}
}
