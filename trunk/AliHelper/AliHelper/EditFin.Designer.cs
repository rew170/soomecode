﻿namespace AliHelper
{
    partial class EditFin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EventTypeTxt = new System.Windows.Forms.ComboBox();
            this.OrderNoTxt = new System.Windows.Forms.TextBox();
            this.AssociationTxt = new System.Windows.Forms.TextBox();
            this.EventNameTxt = new System.Windows.Forms.TextBox();
            this.ItemTypeTxt = new System.Windows.Forms.ComboBox();
            this.EventTimeTxt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RemarkTxt = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cannel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RateTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CurrenyTxt = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventTypeTxt
            // 
            this.EventTypeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventTypeTxt.FormattingEnabled = true;
            this.EventTypeTxt.Location = new System.Drawing.Point(96, 261);
            this.EventTypeTxt.Name = "EventTypeTxt";
            this.EventTypeTxt.Size = new System.Drawing.Size(178, 20);
            this.EventTypeTxt.TabIndex = 5;
            // 
            // OrderNoTxt
            // 
            this.OrderNoTxt.Location = new System.Drawing.Point(96, 188);
            this.OrderNoTxt.Name = "OrderNoTxt";
            this.OrderNoTxt.Size = new System.Drawing.Size(177, 21);
            this.OrderNoTxt.TabIndex = 3;
            // 
            // AssociationTxt
            // 
            this.AssociationTxt.Location = new System.Drawing.Point(95, 295);
            this.AssociationTxt.Name = "AssociationTxt";
            this.AssociationTxt.Size = new System.Drawing.Size(179, 21);
            this.AssociationTxt.TabIndex = 6;
            // 
            // EventNameTxt
            // 
            this.EventNameTxt.Location = new System.Drawing.Point(96, 25);
            this.EventNameTxt.Name = "EventNameTxt";
            this.EventNameTxt.Size = new System.Drawing.Size(266, 21);
            this.EventNameTxt.TabIndex = 1;
            // 
            // ItemTypeTxt
            // 
            this.ItemTypeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemTypeTxt.FormattingEnabled = true;
            this.ItemTypeTxt.Location = new System.Drawing.Point(96, 225);
            this.ItemTypeTxt.Name = "ItemTypeTxt";
            this.ItemTypeTxt.Size = new System.Drawing.Size(178, 20);
            this.ItemTypeTxt.TabIndex = 4;
            // 
            // EventTimeTxt
            // 
            this.EventTimeTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EventTimeTxt.Location = new System.Drawing.Point(96, 58);
            this.EventTimeTxt.Name = "EventTimeTxt";
            this.EventTimeTxt.Size = new System.Drawing.Size(88, 21);
            this.EventTimeTxt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(275, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "*必须(业务员/经手人)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-52, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "开始时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(34, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "项目描述";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(34, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "收支类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(34, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "所属业务";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(34, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "账务类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "财务时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(275, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "(订单号)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(34, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "相关人员";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.TotalAmount);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.CurrenyTxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.RateTxt);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.AmountTxt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.RemarkTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EventTimeTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ItemTypeTxt);
            this.groupBox1.Controls.Add(this.EventNameTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AssociationTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OrderNoTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EventTypeTxt);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 370);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(34, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "备    注";
            // 
            // RemarkTxt
            // 
            this.RemarkTxt.Location = new System.Drawing.Point(93, 331);
            this.RemarkTxt.Name = "RemarkTxt";
            this.RemarkTxt.Size = new System.Drawing.Size(267, 21);
            this.RemarkTxt.TabIndex = 7;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(104, 382);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 8;
            this.Confirm.Text = "确认(&S)";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cannel
            // 
            this.Cannel.Location = new System.Drawing.Point(229, 382);
            this.Cannel.Name = "Cannel";
            this.Cannel.Size = new System.Drawing.Size(75, 23);
            this.Cannel.TabIndex = 9;
            this.Cannel.Text = "取消(&C)";
            this.Cannel.UseVisualStyleBackColor = true;
            this.Cannel.Click += new System.EventHandler(this.Cannel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(364, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 30;
            this.label11.Text = "*必须";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(186, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 31;
            this.label12.Text = "*必须";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(34, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 33;
            this.label14.Text = "金    额";
            // 
            // AmountTxt
            // 
            this.AmountTxt.Location = new System.Drawing.Point(96, 156);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(88, 21);
            this.AmountTxt.TabIndex = 32;
            this.AmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AmountTxt_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(35, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 37;
            this.label15.Text = "汇    率";
            // 
            // RateTxt
            // 
            this.RateTxt.Location = new System.Drawing.Point(97, 123);
            this.RateTxt.Name = "RateTxt";
            this.RateTxt.Size = new System.Drawing.Size(88, 21);
            this.RateTxt.TabIndex = 36;
            this.RateTxt.Text = "1.0";
            this.RateTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RateTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AmountTxt_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(187, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 35;
            this.label16.Text = "*必须";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(35, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 39;
            this.label17.Text = "币    种";
            // 
            // CurrenyTxt
            // 
            this.CurrenyTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrenyTxt.FormattingEnabled = true;
            this.CurrenyTxt.Location = new System.Drawing.Point(97, 90);
            this.CurrenyTxt.Name = "CurrenyTxt";
            this.CurrenyTxt.Size = new System.Drawing.Size(88, 20);
            this.CurrenyTxt.TabIndex = 38;
            this.CurrenyTxt.SelectedValueChanged += new System.EventHandler(this.CurrenyTxt_SelectedValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(231, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 41;
            this.label18.Text = "总金额";
            // 
            // TotalAmount
            // 
            this.TotalAmount.Enabled = false;
            this.TotalAmount.Location = new System.Drawing.Point(274, 154);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Size = new System.Drawing.Size(110, 21);
            this.TotalAmount.TabIndex = 40;
            this.TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(260, 85);
            this.maskedTextBox1.Mask = "###,###,###.0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox1.TabIndex = 42;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EditFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 412);
            this.Controls.Add(this.Cannel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑账务信息";
            this.Load += new System.EventHandler(this.EditFin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EventTypeTxt;
        private System.Windows.Forms.TextBox OrderNoTxt;
        private System.Windows.Forms.TextBox AssociationTxt;
        private System.Windows.Forms.TextBox EventNameTxt;
        private System.Windows.Forms.ComboBox ItemTypeTxt;
        private System.Windows.Forms.DateTimePicker EventTimeTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RemarkTxt;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cannel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AmountTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CurrenyTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox RateTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TotalAmount;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}