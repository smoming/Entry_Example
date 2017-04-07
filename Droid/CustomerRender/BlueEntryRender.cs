using System;
using Android.Support.V4.Content;
using EntryDemo.Customer;
using EntryDemo.Droid.CustomerRender;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BlueEntry), typeof(BlueEntryRender))]
namespace EntryDemo.Droid.CustomerRender
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
				//Android Native Entry

			}

			if (Control != null)
			{
				//Control.Background = ContextCompat.GetDrawable(this.Context, Resource.Layout.BlueEditText);
				//Control.Background.Alpha = 0;
				//Control.Gravity = Android.Views.GravityFlags.Left;
				//Control.SetPadding(0, 0, 0, 0);

				Control.SetBackgroundColor(global::Android.Graphics.Color.Purple);
				//Control.SetTextColor(global::Android.Graphics.Color.White);
			}
		}
	}
}
