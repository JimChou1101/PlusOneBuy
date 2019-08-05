﻿using FBPlusOneBuy.Models;
using FBPlusOneBuy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FBPlusOneBuy.ViewModels;

namespace FBPlusOneBuy.Services
{
    public class CampaignService
    {
        internal CampaignRepository Campaign_repo;

        public CampaignService()
        {
            Campaign_repo = new CampaignRepository();
        }
        public List<Campaign> GetAllCampaign(string groupid,DateTime time)
        {
            var result = Campaign_repo.GetALL(groupid);
            result=result.Where((x) => DateTime.Compare(x.EndTime, time) > 0);
            return result.ToList();
        }

        public List<Campaign> GetWorkingCampaign(string groupid)
        {
            DateTime now = DateTime.UtcNow.AddHours(8);
            List<Campaign> result = Campaign_repo.GetALL(groupid).Where(x => DateTime.Compare(x.EndTime, now) > 0).ToList();
            return result;
        }

        public bool InsertCampaign(CampaignViewModel cvm)
        {
            try
            {
                CampaignRepository campaign_repo = new CampaignRepository();
                campaign_repo.InsertGroupBuy(cvm);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}