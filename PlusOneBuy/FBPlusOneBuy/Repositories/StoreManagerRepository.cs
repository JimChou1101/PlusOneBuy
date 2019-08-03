﻿using Dapper;
using FBPlusOneBuy.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FBPlusOneBuy.Repositories
{
    public class StoreManagerRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
        private SqlConnection conn;
        public void Insert(LineProfile profile)
        {
            using (conn = new SqlConnection(connectionString))
            {
                string userid= HttpContext.Current.User.Identity.GetUserId();
                string sql = "INSERT INTO StoreManager(UserId, AspNetUserId,Name,PictureUrl) VALUES ( @UserId, @AspNetUserId,@Name,@PictureUrl)";
                conn.Execute(sql, new { UserId=profile.userId, AspNetUserId = userid, Name=profile.displayName, PictureUrl=profile.pictureUrl });
            }
        }
        public LineProfile SelectBinding(string aspUserId)
        {
            using (conn = new SqlConnection(connectionString))
            {
                string sql = "select * from StoreManager where AspNetUserId=@aspUserId";
                var profile = conn.QueryFirstOrDefault<LineProfile>(sql, new { aspUserId });
                return profile;
            }

        }

    }
}