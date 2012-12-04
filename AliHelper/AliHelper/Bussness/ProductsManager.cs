﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Soomes;
using AliHelper.DAO;

namespace AliHelper.Bussness
{
    public class ProductsManager
    {

        public AliGroupDao groupDao;
        public AliProductDao productDao;
        public ProductsManager()
        {
            groupDao = DAOFactory.Instance.GetAliGroupDao();
            productDao = DAOFactory.Instance.GetAliProductDao();
        }

        public void UpdateGroupProdcuts(int GroupId, List<AliProduct> products)
        {
            productDao.DeleteProduct4GroupId(GroupId);
            productDao.Insert(products);
        }

        public void UpdateGroups(List<AliGroup> groups)
        {
            List<int> existGroupIds = groupDao.GetAliGroupIdList();
            List<AliGroup> InsertList = new List<AliGroup>();
            List<AliGroup> UpdateList = new List<AliGroup>();
            foreach (AliGroup item in groups)
            {
                if (existGroupIds.Contains(item.Id))
                {
                    UpdateList.Add(item);
                    existGroupIds.Remove(item.Id);
                }
                else
                {
                    InsertList.Add(item);
                }
            }
            foreach (int item in existGroupIds)
            {
                productDao.DeleteProduct4GroupId(item);
            }
            groupDao.DeleteGroups(existGroupIds);
            groupDao.Insert(InsertList);
            groupDao.Update(UpdateList);
        }


        public List<AliGroup> GetGroupList()
        {
            return groupDao.GetAliGroupList();
        }

    }
}
