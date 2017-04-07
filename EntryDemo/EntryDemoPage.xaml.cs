using Xamarin.Forms;

namespace EntryDemo
{
	public partial class EntryDemoPage : ContentPage
	{
		public EntryDemoPage()
		{
			InitializeComponent();
		}

		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			//throw new NotImplementedException();
			System.Diagnostics.Debug.WriteLine(string.Format("the value is {0}", e.NewTextValue));
		}

		void Handle_Completed(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			//var xEntry = sender as Entry; 
			//System.Diagnostics.Debug.WriteLine(string.Format("the value is {0}", xEntry.Text));
			//var xEditor = sender as Editor;
			//System.Diagnostics.Debug.WriteLine(string.Format("the value is {0}", xEditor.Text));
		}
	}
}
