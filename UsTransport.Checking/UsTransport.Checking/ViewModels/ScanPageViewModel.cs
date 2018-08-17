﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UsTransport.Checking.Models;
using UsTransport.Checking.Services;
using Xamarin.Forms;

namespace UsTransport.Checking.ViewModels
{
    public class ScanPageViewModel :BaseViewModel
    {
        public Order _Order { get; set; }

        public Order Order
        {
            get { return _Order; }
            set
            {
                _Order = value;
                OnPropertyChanged();
            }
        }
        public Command LoadStoresCommand { get; set; }
        public IStoreService _IStoreService;
        public ScanPageViewModel()
        {
            _IStoreService = new StoreService();
            Order = new Order();
        }

        public Response GetOrderByCode(string OrderCode)
        {

            try
            {
                return  _IStoreService.GetOrderByCodeAsync(OrderCode).Result;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw ex;
            }
        }

        public Response UpdateOrderStatus(string OrderCode,int Status)
        {

            try
            {
                return _IStoreService.UpdateOrderStatus(OrderCode, Status).Result;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw ex;
            }
        }
    }
}