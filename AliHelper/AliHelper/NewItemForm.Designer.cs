﻿namespace AliHelper
{
    partial class NewItemForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Minimum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Price = new AliHelper.NumericTextbox();
            this.AddImageButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PriceCate = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ImageListView = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Image = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Packing = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Size = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.DetailTab = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CannelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.InfoTab.SuspendLayout();
            this.DetailTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Minimum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.AddImageButton);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PriceCate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ImageListView);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Image);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Packing);
            this.groupBox1.Controls.Add(this.Weight);
            this.groupBox1.Controls.Add(this.Size);
            this.groupBox1.Controls.Add(this.Model);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Minimum
            // 
            this.Minimum.Location = new System.Drawing.Point(99, 263);
            this.Minimum.Name = "Minimum";
            this.Minimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Minimum.Size = new System.Drawing.Size(425, 21);
            this.Minimum.TabIndex = 27;
            this.Minimum.Text = "100";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 267);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "最小订量：";
            // 
            // Price
            // 
            this.Price.CommaFormat = false;
            this.Price.CurrencyFormat = false;
            this.Price.DecimalPrecision = 0;
            this.Price.Location = new System.Drawing.Point(99, 140);
            this.Price.Name = "Price";
            this.Price.PercentFormat = false;
            this.Price.ReadOnly = false;
            this.Price.Size = new System.Drawing.Size(234, 24);
            this.Price.TabIndex = 25;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddImageButton
            // 
            this.AddImageButton.Location = new System.Drawing.Point(562, 20);
            this.AddImageButton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(234, 23);
            this.AddImageButton.TabIndex = 24;
            this.AddImageButton.Text = "添加更多图片";
            this.AddImageButton.UseVisualStyleBackColor = true;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 145);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "元";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(15, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(16, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(15, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "*";
            // 
            // PriceCate
            // 
            this.PriceCate.FormattingEnabled = true;
            this.PriceCate.Location = new System.Drawing.Point(99, 182);
            this.PriceCate.Name = "PriceCate";
            this.PriceCate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceCate.Size = new System.Drawing.Size(250, 20);
            this.PriceCate.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 186);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "价格种类：";
            // 
            // ImageListView
            // 
            this.ImageListView.Location = new System.Drawing.Point(562, 51);
            this.ImageListView.Name = "ImageListView";
            this.ImageListView.Size = new System.Drawing.Size(234, 401);
            this.ImageListView.TabIndex = 17;
            this.ImageListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(543, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(2, 430);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(399, 59);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(125, 125);
            this.Image.TabIndex = 15;
            this.Image.TabStop = false;
            this.Image.Click += new System.EventHandler(this.Image_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 144);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "产品价格：";
            // 
            // Packing
            // 
            this.Packing.Location = new System.Drawing.Point(99, 351);
            this.Packing.Multiline = true;
            this.Packing.Name = "Packing";
            this.Packing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Packing.Size = new System.Drawing.Size(425, 65);
            this.Packing.TabIndex = 12;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(99, 309);
            this.Weight.Name = "Weight";
            this.Weight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Weight.Size = new System.Drawing.Size(425, 21);
            this.Weight.TabIndex = 11;
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(99, 221);
            this.Size.Name = "Size";
            this.Size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size.Size = new System.Drawing.Size(425, 21);
            this.Size.TabIndex = 10;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(99, 100);
            this.Model.Name = "Model";
            this.Model.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Model.Size = new System.Drawing.Size(250, 21);
            this.Model.TabIndex = 9;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(99, 61);
            this.Category.Name = "Category";
            this.Category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Category.Size = new System.Drawing.Size(250, 20);
            this.Category.TabIndex = 8;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(99, 22);
            this.Name.Name = "Name";
            this.Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name.Size = new System.Drawing.Size(425, 21);
            this.Name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 65);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "自定义分类：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 354);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "包装与装箱：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 313);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "产品重量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 225);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "产品尺寸：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "产品型号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品标题：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InfoTab);
            this.tabControl1.Controls.Add(this.DetailTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 504);
            this.tabControl1.TabIndex = 1;
            // 
            // InfoTab
            // 
            this.InfoTab.Controls.Add(this.groupBox1);
            this.InfoTab.Location = new System.Drawing.Point(4, 21);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTab.Size = new System.Drawing.Size(814, 479);
            this.InfoTab.TabIndex = 0;
            this.InfoTab.Text = "基本信息";
            this.InfoTab.UseVisualStyleBackColor = true;
            // 
            // DetailTab
            // 
            this.DetailTab.Controls.Add(this.webBrowser1);
            this.DetailTab.Location = new System.Drawing.Point(4, 21);
            this.DetailTab.Name = "DetailTab";
            this.DetailTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailTab.Size = new System.Drawing.Size(814, 479);
            this.DetailTab.TabIndex = 1;
            this.DetailTab.Text = "产品详情";
            this.DetailTab.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(808, 473);
            this.webBrowser1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 534);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CannelButton);
            this.flowLayoutPanel1.Controls.Add(this.SaveButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 504);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(822, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // CannelButton
            // 
            this.CannelButton.Location = new System.Drawing.Point(667, 3);
            this.CannelButton.Margin = new System.Windows.Forms.Padding(80, 3, 3, 3);
            this.CannelButton.Name = "CannelButton";
            this.CannelButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CannelButton.Size = new System.Drawing.Size(75, 23);
            this.CannelButton.TabIndex = 1;
            this.CannelButton.Text = "取消(&C)";
            this.CannelButton.UseVisualStyleBackColor = true;
            this.CannelButton.Click += new System.EventHandler(this.CannelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(579, 3);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存(&S)";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 432);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(426, 20);
            this.comboBox1.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 436);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "状　　态：";
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "NewItemForm";
            this.Text = "新增产品";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.InfoTab.ResumeLayout(false);
            this.DetailTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.TextBox Packing;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.TabPage DetailTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CannelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ImageListView;
        private System.Windows.Forms.ComboBox PriceCate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private NumericTextbox Price;
        private System.Windows.Forms.TextBox Minimum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
    }
}