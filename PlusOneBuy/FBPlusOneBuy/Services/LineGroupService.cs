<<<<<<< HEAD
﻿using FBPlusOneBuy.Models;
using FBPlusOneBuy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FBPlusOneBuy.Models;
using FBPlusOneBuy.Repositories;
>>>>>>> 4c4ddc16040971e858585cd56988f8016fc456c2

namespace FBPlusOneBuy.Services
{
    public class LineGroupService
    {
<<<<<<< HEAD
        public static int GetManagerId(string aspNetUserId)
        {
            LineGroupRepository lineGroup_repo = new LineGroupRepository();
            int managerId = lineGroup_repo.GetMangerIdByAspNetId(aspNetUserId);
            return managerId;
        }
        public static void InsertGroupName(int managerId, string groupName)
        {
            LineGroupRepository lineGroup_repo = new LineGroupRepository();
            lineGroup_repo.InsertGroupName(managerId,groupName);
        }
        public static List<LineGroup> GetGroupList(int managerId)
        {
            LineGroupRepository lineGroup_repo = new LineGroupRepository();
            List<LineGroup> groupName = lineGroup_repo.GetGroupList(managerId).ToList();
            return groupName;
        }
        public static List<string> GetNullGroup(int managerId)
        {
            LineGroupRepository lineGroup_repo = new LineGroupRepository();
            List<string> nullGroupName = lineGroup_repo.GetNullGroup(managerId).ToList();
            return nullGroupName;
        }
        public static List<CompareStoreManager> GroupNullCompare()
        {
            LineGroupRepository lineGroup_repo = new LineGroupRepository();
            List<CompareStoreManager> userId = lineGroup_repo.GroupNullCompare();
            return userId;
        }
        public static void CompareUpdateGroupid(string groupId, int storeManagerId,DateTime? timestampTotime)
        {
            LineGroupRepository lineGroup_repo = new LineGroupRepository();
            lineGroup_repo.CompareUpdateGroupid(groupId, storeManagerId, timestampTotime);
           
        }
        //public static DateTime CheckBinding(string groupName, int managerId)
        //{
        //    LineGroupRepository lineGroup_repo = new LineGroupRepository();
        //    DateTime joinDate =lineGroup_repo.CheckBinding(groupName, managerId);
        //    return joinDate;

        //}
=======
        internal  string GroupId { get; set; }

        public LineGroupService(string groupId)
        {
            GroupId = groupId;
        }
        public bool SearchLineGroup()
        {
            LineGroupRepository lineGroup_repo = new LineGroupRepository();
            LineGroup lineGroup = lineGroup_repo.SearchLineGroup(GroupId);
            if (lineGroup != default)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
>>>>>>> 4c4ddc16040971e858585cd56988f8016fc456c2
    }
}