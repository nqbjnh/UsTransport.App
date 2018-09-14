using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using UsTransport.Checking.Views;

namespace UsTransport.Checking.ViewModels
{
    public class MainPageMasterViewModel : BaseViewModel
    {
        public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }

        public MainPageMasterViewModel()
        {
            MenuItems = new ObservableCollection<MainPageMenuItem>();


            var menuItems = new List<MainPageMenuItem>()
            {
                new MainPageMenuItem { Id = 0, Title = "Danh sách đại lý",TargetType = typeof(StorePage),Icon = "icon_store.png"},
                new MainPageMenuItem { Id = 1, Title = "Scan nhận hàng",TargetType = typeof(ScanPage),Icon = "icon_scan.png" },
                new MainPageMenuItem { Id = 2, Title = "Scan kho hàng" ,TargetType = typeof(ScanPage),Icon = "icon_scan.png"},
                new MainPageMenuItem { Id = 3, Title = "Scan Việt Nam" ,TargetType = typeof(ScanPage),Icon = "icon_scan.png"}
            };

            foreach (var userRoleMenu in App.USER.RoleMenus)
            {
                var menu = menuItems.FirstOrDefault(x => x.Id == userRoleMenu);
                if (menu != null)
                {
                    MenuItems.Add(menu);
                }
                
            }
            MenuItems.Add(new MainPageMenuItem { Id = 10, Title = "Đăng xuất", TargetType = typeof(ScanPage), Icon = "icon_exit.png" });
        }

    }
}