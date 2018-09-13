using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsTransport.Checking.Models;
using UsTransport.Checking.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsTransport.Checking.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PackagePage : ContentPage
	{
	    private PackagePageViewModel _packagePageViewModel;
		public PackagePage ()
		{
			InitializeComponent ();
		}

	    private PackageSearchFromApp _packageSearchFromApp;

	    public PackagePage(PackageSearchFromApp packageSearchFromApp)
	    {
	        InitializeComponent();
	        _packageSearchFromApp = packageSearchFromApp;
	        BindingContext = _packagePageViewModel = new PackagePageViewModel(packageSearchFromApp,Navigation);
	    }


	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        if (_packagePageViewModel.Packages.Count == 0)
	            _packagePageViewModel.LoadPackagesCommand.Execute(null);
	    }

	    private void PackageListView_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        var package = e.Item as PackageViewDTO;
	        _packagePageViewModel.GetPackageDetail(package.Code);
        }
	}
}