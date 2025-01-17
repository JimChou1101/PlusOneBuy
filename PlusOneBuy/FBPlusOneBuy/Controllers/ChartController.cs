﻿using FBPlusOneBuy.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBPlusOneBuy.Controllers
{
    public class ChartController : Controller
    {
        [HttpPost]
        public ActionResult GroupOrderDetailChart(int GroupOrderID)
        {
            var name = new List<string>();
            var qty = new List<int>();
            var dateTime = new List<string>();
            var price = new List<decimal>(); 
            var arrayData = new { name,dateTime, qty, price };
            
            var GOdetailService = new GroupOrderDetailService();
            var data = GOdetailService.GetDetailByGroupOrderID(GroupOrderID);
            foreach (var item in data)
            {
                name.Add(item.Name);
                qty.Add(item.Quantity);
                dateTime.Add(item.MessageDateTime.ToString());
                var amount = item.Quantity * item.UnitPrice;
                price.Add(amount);
            }           
            return Json(arrayData);
        }

        [HttpPost]
        public ActionResult GroupOrderChart(int CampaignID)
        {
            var name = new List<string>();
            var qty = new List<int>();
            var dateTime = new List<string>();
            var price = new List<decimal>();
            var arrayData = new { name, dateTime, qty, price };

            var GOdetailService = new GroupOrderDetailService();
            var data = GOdetailService.GetDetailByCampaignID(CampaignID);
            foreach (var item in data)
            {
                name.Add(item.Name);
                qty.Add(item.Quantity);
                dateTime.Add(item.MessageDateTime.ToString());
                var amount = item.Quantity * item.UnitPrice;
                price.Add(amount);
            }
            return Json(arrayData);
        }
    }
}