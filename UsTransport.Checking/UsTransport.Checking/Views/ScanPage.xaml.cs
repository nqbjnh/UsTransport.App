using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsTransport.Checking.Models;
using UsTransport.Checking.Utils;
using UsTransport.Checking.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace UsTransport.Checking.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScanPage : ContentPage
	{
	    ZXingScannerPage scanPage;
	    private Grid GroupButton;
	    private ScanPageViewModel _scanPageViewModel;
	    private Order _order;
        public ScanPage ()
		{
			InitializeComponent ();
		    BindingContext = _scanPageViewModel = new ScanPageViewModel();

		}

	    protected override void OnAppearing()
	    {
	        var menuItem = BindingContext as MainPageMenuItem;
	        switch (menuItem.Id)
	        {
	            case 1:
                    //BtnNhanHang.IsVisible = true;
	                GroupButton = BtnNhanHang;

                    break;
	            case 2:
                    //BtnKhoHang.IsVisible = true;
	                GroupButton = BtnKhoHang;

                    break;
	            case 3:
                    //BtnVietNam.IsVisible = true;
	                GroupButton = BtnVietNam;

                    break;
	        }
        }

	    private void BtnClearCode_OnClicked(object sender, EventArgs e)
	    {
	        EtInputCode.Text = string.Empty;
	    }

        private void GetProductByCode(string Code)
        {
            GroupButton.IsVisible = true;
            //call api check code
            var result = _scanPageViewModel.GetOrderByCode(Code);
            if (result == null)
            {
                LbError.Text = "Có lỗi xảy ra, vui lòng thử lại sau!";
                LbError.IsVisible = true;
                return;
            }

            if (result.Code == 0)
            {
                _order = result.Data.ToJson().JsonToObject<Order>();
                EtInputCode.Text = string.Empty;
                EtInputCode.Text = string.Empty;
                LbOrderCode.Text = "Mã đơn hàng: " + _order.Code;
                /*LbStatusName.Text = "Trạng thái đơn hàng: " + _Order.StatusName;
                LbTotal.Text = "Số lượng sản phẩm: " + _Order.OrderDetails.Count;
                OrderDetails.ItemsSource = _Order.OrderDetails;*/

                //show control
                LbOrderCode.IsVisible = true;
               /* LbOrderId.IsVisible = true;
                LbStatusName.IsVisible = true;
                LbTotal.IsVisible = true;
                OrderDetails.IsVisible = true;
                //BtnUpdate.IsVisible = true;
                SlBtnUpdateStatus.IsVisible = true;*/
            }
            else
            {
                LbError.Text = result.Message + ": " + result.Data;
                LbError.IsVisible = true;
            }


        }

        private async void BtnScan_OnClicked(object sender, EventArgs e)
        {

           
            //check nếu nhập code bằng camera
            if (string.IsNullOrEmpty(EtInputCode.Text))
            {
                scanPage = new ZXingScannerPage();
                scanPage.OnScanResult += (result) =>
                {
                    scanPage.IsScanning = false;

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Navigation.PopAsync();
                        EtInputCode.Text = "Code: " + result.Text;
                        GetProductByCode(result.Text);

                    });
                };

                await Navigation.PushAsync(scanPage);
            }
            else//check nếu nhập code bằng tay
            {
                GetProductByCode(EtInputCode.Text);
            }


        }

	    private void UpdateOrderStatus_OnClicked(object sender, EventArgs e)
	    {
	        LbSuccess.IsVisible = false;
	        LbError.IsVisible = false;

	        var btn = (Button)sender;
	        var orderStatus = int.Parse(btn.ClassId);
	        var orderCode = _order.Code;
	        var result = _scanPageViewModel.UpdateOrderStatus(orderCode, orderStatus);
	        if (result == null)
	        {
	            LbError.Text = "Có lỗi xảy ra, vui lòng thử lại sau!";
	            LbError.IsVisible = true;
	            return;
	        }

	        if (result.Code == 0)
	        {
	            LbSuccess.Text = result.Data?.ToString();
	            LbSuccess.IsVisible = true;
	            //BtnUpdate.IsVisible = false;

	        }
	        else
	        {
	            LbError.Text = "Lỗi: " + result.Data;
	            LbError.IsVisible = true;
	        }
        }
	}
}