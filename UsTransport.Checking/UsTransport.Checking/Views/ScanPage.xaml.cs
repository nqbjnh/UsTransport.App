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
        private PackageViewDTO _order;
        public ScanPage()
        {
            InitializeComponent();
            _scanPageViewModel = new ScanPageViewModel();

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
            try
            {
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

                    _order = result.Data.ToJson().JsonToObject<PackageViewDTO>();
                    EtInputCode.Text = string.Empty;
                    EtInputCode.Text = string.Empty;


                    LbStoreName.Text = "Đại lý:" + _order.StoreName;
                    LbOrderCode.Text = "Mã gói hàng:" + _order.Code;
                    LbStatusName.Text = _order.StatusName;
                    LbStatusName.BackgroundColor =
                        Color.FromHex("#" + (_order.StatusName.GetHashCode() & 0x00FFFFFF).ToString("X6"));
                    LbTotalItem.Text = "Tổng số item:" + _order.TotalItems;
                    LvItems.ItemsSource = _order.Items;

                    SlInfo.IsVisible = true;
                    GroupButton.IsVisible = true;
                }
                else
                {
                    LbError.Text = result.Message + ": " + result.Data;
                    LbError.IsVisible = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           


        }

        private async void BtnScan_OnClicked(object sender, EventArgs e)
        {
            try
            {
                ClearControl();
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void UpdateOrderStatus_OnClicked(object sender, EventArgs e)
        {
            LbSuccess.IsVisible = false;
            LbError.IsVisible = false;

            var btn = (Button)sender;
            var orderStatus = int.Parse(btn.ClassId);
            
            var result = _scanPageViewModel.UpdateOrderStatus((int)_order.Id, orderStatus);
            if (result == null)
            {
                LbError.Text = "Có lỗi xảy ra, vui lòng thử lại sau!";
                LbError.IsVisible = true;
                return;
            }

            if (result.Code == 0)
            {
                LbSuccess.Text = result.Message + ": " + result.Data;
                LbSuccess.IsVisible = true;
                GroupButton.IsVisible = false;

            }
            else
            {
                LbError.Text = result.Message + ": " + result.Data;
                LbError.IsVisible = true;
            }
        }

        public void ClearControl()
        {
            LbSuccess.IsVisible = false;
            LbError.IsVisible = false;
            SlInfo.IsVisible = false;
            GroupButton.IsVisible = false;
        }
    }
}