using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ScanPage ()
		{
			InitializeComponent ();
		    
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
            /*var result = App.API._OrderOperation.GetProductByCode(Code);
            if (result == null)
            {
                LbError.Text = "Có lỗi xảy ra, vui lòng thử lại sau!";
                LbError.IsVisible = true;
                return;
            }

            if (result.Code == 0)
            {
                _Order = JsonConvert.DeserializeObject<Order>(result.Data.ToString());
                EtInputCode.Text = string.Empty;
                EtInputCode.Text = string.Empty;
                LbOrderId.Text = "Mã đơn hàng: US" + _Order.OrderId;
                LbStatusName.Text = "Trạng thái đơn hàng: " + _Order.StatusName;
                LbTotal.Text = "Số lượng sản phẩm: " + _Order.OrderDetails.Count;
                OrderDetails.ItemsSource = _Order.OrderDetails;

                //show control
                LbOrderId.IsVisible = true;
                LbOrderId.IsVisible = true;
                LbStatusName.IsVisible = true;
                LbTotal.IsVisible = true;
                OrderDetails.IsVisible = true;
                //BtnUpdate.IsVisible = true;
                SlBtnUpdateStatus.IsVisible = true;
            }
            else
            {
                LbError.Text = result.Message + ": " + result.Data;
                LbError.IsVisible = true;
            }*/


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
                //GetProductByCode(EtInputCode.Text);
            }


        }
    }
}