﻿using System;

namespace UsTransport.Checking.Models
{
    public class PackageSearchFromApp
    {
        public PackageSearchFromApp()
        {
            StatusId = -1;
            FromDate = DateTime.Now.AddMonths(-3);
            ToDate = DateTime.Now;
            PageSize = 20;
        }
        public string StoreName { get; set; }
        /// <summary>
        /// Null -> ToDate
        /// </summary>
        public DateTime? FromDate { get; set; }
        /// <summary>
        /// Null -> ToDate
        /// </summary>
        public DateTime? ToDate { get; set; }
        /// <summary>
        /// -1 Search All
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// Begin = 0
        /// </summary>
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        /// <summary>
        /// Total record
        /// </summary>
        public int Total { get; set; }

    }
}