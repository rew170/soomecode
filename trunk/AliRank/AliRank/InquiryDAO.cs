﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace AliRank
{
    public class InquiryDAO
    {
        private SQLiteDBHelper dbHelper;

        public InquiryDAO(SQLiteDBHelper dbHelper)
        { 
            this.dbHelper = dbHelper;
            CreateTable();
        }

        private void CreateTable()
        {
            dbHelper.ExecuteNonQuery(
              "CREATE TABLE IF NOT EXISTS AliAccounts("
            + "AccountId integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,"
            + "Email varchar(100) NOT NULL,"
            + "Password varchar(100) NOT NULL,"
            + "Country varchar(100) NOT NULL,"
            + "LoginIp varchar(50) default '') ");

            dbHelper.ExecuteNonQuery(
              "CREATE TABLE IF NOT EXISTS InquiryInfos("
            + "AccountId integer NOT NULL,"
            + "ProductId integer NOT NULL,"
            + "MsgId integer NOT NULL,"
            + "Company varchar(100) NOT NULL,"
            + "InquiryIp varchar(50)  NOT NULL,"
            + "InquiryDate datetime NOT NULL)");
            dbHelper.ExecuteNonQuery("CREATE INDEX IF NOT EXISTS account_product on InquiryInfos(AccountId, ProductId, InquiryDate);");
            dbHelper.ExecuteNonQuery("CREATE INDEX IF NOT EXISTS idx_msgId on InquiryInfos(MsgId);");

            dbHelper.ExecuteNonQuery(
              "CREATE TABLE IF NOT EXISTS InquiryMessages("
            + "MsgId integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,"
            + "Content varchar(8000) NOT NULL,"
            + "SendNum integer NOT NULL default 0)");
        }

        public bool ExistAccount(string account)
        {
            string sql = "select count(1) from AliAccounts where Email= @Email";
            SQLiteParameter[] parameter = new SQLiteParameter[]
            {
                new SQLiteParameter("@Email", account),
            };
            int  r = Convert.ToInt32(dbHelper.ExecuteScalar(sql, parameter));
            if (r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public List<AliAccounts> GetAccounts()
        {
            DataTable dt = dbHelper.ExecuteDataTable(
                "SELECT a.AccountId, a.Email, "
                +" a.Password, a.Country, a.LoginIp, "
                +" (select count(1) from InquiryInfos i where a.AccountId=i.AccountId) as InquiryNum "
                +" from AliAccounts a", null);
            List<AliAccounts> list = new List<AliAccounts>();
            foreach (DataRow row in dt.Rows)
            {
                AliAccounts kw = new AliAccounts();
                kw.AccountId = Convert.ToInt32(row["AccountId"]);
                kw.Email = (string)row["Email"];
                kw.Password = (string)row["Password"];
                kw.Country = (string)row["Country"];
                kw.LoginIp = (string)row["LoginIp"];
                kw.InquiryNum = Convert.ToInt32(row["InquiryNum"]);
                list.Add(kw);
            }
            return list;
        }

        public void InsertAccount(AliAccounts model)
        {
            string sql = @"INSERT INTO AliAccounts(Email, Password, Country)values(@Email, @Password, @Country)";
            SQLiteParameter[] parameter = new SQLiteParameter[]
            {
                new SQLiteParameter("@Email",model.Email), 
                new SQLiteParameter("@Password",model.Password), 
                new SQLiteParameter("@Country",model.Country)
            };
            dbHelper.ExecuteNonQuery(sql, parameter);
        }

        public void ImportAccounts(List<AliAccounts> list)
        {
            string InsSql = @"INSERT INTO AliAccounts(Email, Password, Country)values(@Email,@Password,@Country)";

            string UpdSql = @"Update AliAccounts SET Password = @Password, Country = @Country WHERE Email = @Email";

            string ExistRecordSql = "SELECT count(1) FROM AliAccounts WHERE Email = ";
            List<SQLiteParameter[]> InsertParameters = new List<SQLiteParameter[]>();
            List<SQLiteParameter[]> UpdateParameters = new List<SQLiteParameter[]>();
            foreach (AliAccounts item in list)
            {
                int record = Convert.ToInt32(dbHelper.ExecuteScalar(ExistRecordSql + item.Email, null));
                if (record > 0)
                {
                    SQLiteParameter[] parameter = new SQLiteParameter[]
                    {
                        new SQLiteParameter("@Password",item.Password), 
                        new SQLiteParameter("@Country",item.Country), 
                        new SQLiteParameter("@Email",item.Email)
                    };
                    UpdateParameters.Add(parameter);
                }
                else
                {
                    SQLiteParameter[] parameter = new SQLiteParameter[]
                    {
                        new SQLiteParameter("@Email",item.Email), 
                        new SQLiteParameter("@Password", item.Password), 
                        new SQLiteParameter("@Country",item.Country)
                    };
                    InsertParameters.Add(parameter);
                }

            }
            if (InsertParameters.Count > 0)
            {
                dbHelper.ExecuteNonQuery(InsSql, InsertParameters);
            }
            if (UpdateParameters.Count > 0)
            {
                dbHelper.ExecuteNonQuery(UpdSql, UpdateParameters);
            }
        }


        public void DeleteAccount(List<string> idList)
        {
            foreach (string id in idList)
            {
                string sql = @"DELETE FROM AliAccounts WHERE AccountId = @AccountId";
                SQLiteParameter[] parameter = new SQLiteParameter[]
                {
                    new SQLiteParameter("@AccountId", Convert.ToInt32(id))
                };
                dbHelper.ExecuteNonQuery(sql, parameter);
            }
        }

        public void DeleteInquiryMessages(List<string> idList)
        {
            foreach (string id in idList)
            {
                string sql = @"DELETE FROM InquiryMessages WHERE MsgId = @MsgId";
                SQLiteParameter[] parameter = new SQLiteParameter[]
                {
                    new SQLiteParameter("@MsgId", Convert.ToInt32(id))
                };
                dbHelper.ExecuteNonQuery(sql, parameter);
            }
        }

        public void InsertInquiryInfos(InquiryInfos model)
        {
            string sql = @"INSERT INTO InquiryInfos(AccountId, ProductId, MsgId, Company, InquiryIp, InquiryDate)values(@AccountId,@ProductId,@MsgId,@Company,@InquiryIp,@InquiryDate)";
            SQLiteParameter[] parameter = new SQLiteParameter[]
            {
                new SQLiteParameter("@AccountId",model.AccountId), 
                new SQLiteParameter("@ProductId", model.ProductId), 
                new SQLiteParameter("@MsgId",model.MsgId), 
                new SQLiteParameter("@Company",model.Company),
                new SQLiteParameter("@InquiryIp",model.InquiryIp),
                new SQLiteParameter("@InquiryDate",model.InquiryDate)
            };
            dbHelper.ExecuteNonQuery(sql, parameter);
        }

        
        public void InsertInquiryMessages(InquiryMessages model)
        {
            string sql = @"INSERT INTO InquiryMessages(Content)values(@Content)";
            SQLiteParameter[] parameter = new SQLiteParameter[]
            {
                new SQLiteParameter("@Content", model.Content)
            };
            dbHelper.ExecuteNonQuery(sql, parameter);
        }

        

        public List<InquiryMessages> GetInquiryMessages()
        {
            DataTable dt = dbHelper.ExecuteDataTable("SELECT MsgId, Content, SendNum from InquiryMessages", null);
            List<InquiryMessages> list = new List<InquiryMessages>();
            foreach (DataRow row in dt.Rows)
            {
                InquiryMessages kw = new InquiryMessages();
                kw.MsgId = Convert.ToInt32(row["MsgId"]);
                kw.Content = (string)row["Content"];
                kw.SendNum = Convert.ToInt32(row["SendNum"]);
                list.Add(kw);
            }
            return list;
        }

        public InquiryMessages GetInquiryMinMessage()
        {
            DataTable dt = dbHelper.ExecuteDataTable(
                "SELECT MsgId, Content, SendNum from InquiryMessages order by SendNum asc limit 0,1", null);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                InquiryMessages kw = new InquiryMessages();
                kw.MsgId = Convert.ToInt32(row["MsgId"]);
                kw.Content = (string)row["Content"];
                kw.SendNum = Convert.ToInt32(row["SendNum"]);
                return kw;
            }
            return null;
        }

        /// <summary>
        /// 查询今天可用来发询盘的帐号
        /// </summary>
        /// <param name="yesterday"></param>
        /// <returns></returns>
        public AliAccounts GetCanInquiryAccounts(int yesterday)
        {
            DataTable dt = dbHelper.ExecuteDataTable(
                "select distinct a.AccountId, a.Email, a.Password,a.Country from aliaccounts  a "
                +"left join inquiryInfos i on a.AccountId=i.AccountId "
                + "where  i.accountId is null  and (i.inquiryDate > " + yesterday + " or i.inquiryDate is null)", null);
            List<AliAccounts> list = new List<AliAccounts>();
            foreach (DataRow row in dt.Rows)
            {
                AliAccounts kw = new AliAccounts();
                kw.AccountId = Convert.ToInt32(row["AccountId"]);
                kw.Email = (string)row["Email"];
                kw.Password = (string)row["Password"];
                kw.Country = (string)row["Country"];
                list.Add(kw);
            }
            if (list.Count == 0)
            {
                return null;
            }
            int randomNumber = new Random().Next(0, list.Count -1);
            return list[randomNumber];
        }
        
        /// <summary>
        /// 查询产品今天已经发送询盘的数量
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="todayDate"></param>
        /// <returns></returns>
        public int TodayInquiryQty4Product(int productId)
        {
            string sql = "select count(1) from  inquiryInfos where productId = @productId "
                + " and inquiryDate= @inquiryDate ";
            SQLiteParameter[] parameter = new SQLiteParameter[]
            {
                new SQLiteParameter("@productId", productId),
                new SQLiteParameter("@inquiryDate", DateTime.Now.ToString("yyyyMMdd"))
            };
            return Convert.ToInt32(dbHelper.ExecuteScalar(sql, parameter));
        }
        


    }
}
