﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soomes;
using AliHelper.Bussness;

namespace AliHelper
{
    public partial class FinView : UserControl
    {
        FinOrderManager finOrderManager;
        public FinView()
        {
            InitializeComponent();
            FinDetailPager.PageIndex = 1;
            FinDetailPager.PageSize = 100;
            finOrderManager = new FinOrderManager();
            FinOrderManager.OnEditFinDetailEvent += new NewEditItemEvent(OnNewEditEvent);
        }

        void OnNewEditEvent(object sender, ItemEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                BindDataWithPage(FinDetailPager.PageIndex);
            }));
        }

        private void FinView_Load(object sender, EventArgs e)
        {
            this.BeginDateTxt.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.EndDateTxt.Value = DateTime.Now;
            this.ItemTypeTxt.DisplayMember = "Label";
            this.ItemTypeTxt.ValueMember = "Key";
            this.EventTypeTxt.DisplayMember = "Label";
            this.EventTypeTxt.ValueMember = "Key";
            this.AssociationTxt.DisplayMember = "Label";
            this.AssociationTxt.ValueMember = "Key";
            this.ItemTypeTxt.DataSource = finOrderManager.GetQueryAppDicOptions(Constants.BussnessType);
            this.EventTypeTxt.DataSource = finOrderManager.GetQueryAppDicOptions(Constants.DebitCredit);
            this.AssociationTxt.DataSource = finOrderManager.GetQueryAppDicOptions(Constants.Employee);
            BindDataWithPage(1);
        }

        private void BindDateTable(List<FinDetails> list)
        {
            FinDetailDataView.Rows.Clear();
            if (list == null) return;
            int i = 0;
            foreach (FinDetails item in list)
            {
                object[] item01 = new object[] { 
                    item.DetailId,
                    1 + i,
                    item.FinDate,
                    item.Description,
                    "￥" + item.TotalAmount.ToString("#,##0.00"),
                    item.OrderNo,
                    item.ItemType,
                    item.Association,
                    item.EventType,
                    item.Remark,
                };
                FinDetailDataView.Rows.Add(item01);
                FinDetailDataView.Rows[i].Cells[4].Style.ForeColor = 
                    (item.TotalAmount > 0)? Color.Red : Color.Blue;
                i++;
            }
        }

        private void BindDataWithPage(int Page)
        {
            QueryObject<FinDetails> query = new QueryObject<FinDetails>();
            query.Page = Page;
            query.PageSize = FinDetailPager.PageSize;
            query.Condition = new FinDetails();
            query.Condition.BeginTime = this.BeginDateTxt.Value.ToString(Constants.DateFormat);
            query.Condition.EndTime = this.EndDateTxt.Value.ToString(Constants.DateFormat);
            query.Condition.Description = this.EventNameTxt.Text.Trim();
            query.Condition.EventType = (string)this.EventTypeTxt.SelectedValue;
            query.Condition.ItemType = (string)this.ItemTypeTxt.SelectedValue;
            query.Condition.OrderNo = this.OrderNoTxt.Text.Trim();
            query.Condition.Association = this.AssociationTxt.Text.Trim();
            QueryObject<FinDetails> result = finOrderManager.GetFinDetails(query);
            if (result.Result != null)
            {
                FinDetailPager.PageIndex = result.Page;
                FinDetailPager.PageSize = result.PageSize;
                FinDetailPager.RecordCount = result.RecordCount;
                BindDateTable(result.Result);
            }
            else
            {
                FinDetailPager.PageIndex = Page;
                FinDetailPager.PageSize = 100;
                FinDetailPager.RecordCount = 0;
                BindDateTable(null);
            }
        }
        private void FinDetailPager_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataWithPage(FinDetailPager.PageIndex);
        }

        private void FinDetailQueryBtn_Click(object sender, EventArgs e)
        {
            BindDataWithPage(1);
        }

        private void FinDetailExpBtn_Click(object sender, EventArgs e)
        {
            QueryObject<FinDetails> query = new QueryObject<FinDetails>();
            query.IsExport = true;
            query.Condition = new FinDetails();
            query.Condition.BeginTime = this.BeginDateTxt.Value.ToString(Constants.DateFormat);
            query.Condition.EndTime = this.EndDateTxt.Value.ToString(Constants.DateFormat);
            query.Condition.Description = this.EventNameTxt.Text.Trim();
            query.Condition.EventType = (string)this.EventTypeTxt.SelectedValue;
            query.Condition.ItemType = (string)this.ItemTypeTxt.SelectedValue;
            query.Condition.OrderNo = this.OrderNoTxt.Text.Trim();
            query.Condition.Association = this.AssociationTxt.Text.Trim();
            QueryObject<FinDetails> result = finOrderManager.GetFinDetails(query);

        }

        private void FinDetailDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.FinDetailDataView.Rows[e.RowIndex].Cells[0].Value);
            EditFinDetail f = new EditFinDetail();
            f.UpdateDetail = finOrderManager.GetFinDetail(id);
            f.ShowDialog(this);
        }

        

        
    }
}