using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsTransport.Checking.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsTransport.Checking.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemPage : ContentPage
	{
	    private ItemPageViewModel _itemPageViewModel;
		public ItemPage ()
		{
			InitializeComponent ();
		    
		}

	    private string _PackageCode;

	    public ItemPage(string PackageCode)
	    {
	        InitializeComponent();
	        BindingContext = _itemPageViewModel = new ItemPageViewModel();
            _PackageCode = PackageCode;
	    }

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        _itemPageViewModel.ExecuteLoadItemCommand(_PackageCode);
	    }
	}
}