using System;
using EntryDemo.Customer;
using EntryDemo.iOS.CustomerRender;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BlueEntry), typeof(BlueEntryRender))]
namespace EntryDemo.iOS.CustomerRender
{
	public class BlueEntryRender : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null)
			{
				//Xamarin Form Entry
			}

			if (e.NewElement != null)
			{
				//iOS Native Entry
			}

			if (Control != null)
			{
				Control.BackgroundColor = UIKit.UIColor.Purple;
				//Control.TextColor = UIKit.UIColor.White;
				//Control.BorderStyle = UIKit.UITextBorderStyle.None;
			}
		}
	}
}
