﻿namespace AliHelper.MyItem
{
    partial class MyItemList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MyItemGrid = new SourceGrid.Grid();
            this.label6 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.FinDetailQueryBtn = new System.Windows.Forms.Button();
            this.FinDetailGroup = new Guifreaks.NavigationBar.NaviGroup(this.components);
            this.Model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinDetailGroup)).BeginInit();
            this.FinDetailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FinDetailGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyItemGrid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 470);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // MyItemGrid
            // 
            this.MyItemGrid.AutoSize = true;
            this.MyItemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyItemGrid.EnableSort = true;
            this.MyItemGrid.Location = new System.Drawing.Point(1, 52);
            this.MyItemGrid.Margin = new System.Windows.Forms.Padding(0);
            this.MyItemGrid.Name = "MyItemGrid";
            this.MyItemGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.MyItemGrid.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.MyItemGrid.Size = new System.Drawing.Size(781, 417);
            this.MyItemGrid.TabIndex = 3;
            this.MyItemGrid.TabStop = true;
            this.MyItemGrid.ToolTipText = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(30, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "产品标题";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(83, 24);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(155, 21);
            this.Name.TabIndex = 0;
            // 
            // FinDetailQueryBtn
            // 
            this.FinDetailQueryBtn.Location = new System.Drawing.Point(650, 23);
            this.FinDetailQueryBtn.Name = "FinDetailQueryBtn";
            this.FinDetailQueryBtn.Size = new System.Drawing.Size(70, 23);
            this.FinDetailQueryBtn.TabIndex = 8;
            this.FinDetailQueryBtn.Text = "查询(&Q)";
            this.FinDetailQueryBtn.UseVisualStyleBackColor = true;
            // 
            // FinDetailGroup
            // 
            this.FinDetailGroup.Caption = "查询条件";
            this.FinDetailGroup.Controls.Add(this.Status);
            this.FinDetailGroup.Controls.Add(this.StatusLabel);
            this.FinDetailGroup.Controls.Add(this.Model);
            this.FinDetailGroup.Controls.Add(this.label1);
            this.FinDetailGroup.Controls.Add(this.FinDetailQueryBtn);
            this.FinDetailGroup.Controls.Add(this.Name);
            this.FinDetailGroup.Controls.Add(this.label6);
            this.FinDetailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinDetailGroup.ExpandedHeight = 100;
            this.FinDetailGroup.HeaderContextMenuStrip = null;
            this.FinDetailGroup.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Silver;
            this.FinDetailGroup.Location = new System.Drawing.Point(1, 1);
            this.FinDetailGroup.Margin = new System.Windows.Forms.Padding(0);
            this.FinDetailGroup.Name = "FinDetailGroup";
            this.FinDetailGroup.Padding = new System.Windows.Forms.Padding(1, 22, 1, 1);
            this.FinDetailGroup.Size = new System.Drawing.Size(781, 50);
            this.FinDetailGroup.TabIndex = 2;
            this.FinDetailGroup.Text = "查询条件";
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(316, 24);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(122, 21);
            this.Model.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(264, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "产品型号";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(507, 25);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(122, 21);
            this.Status.TabIndex = 11;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Location = new System.Drawing.Point(455, 29);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(53, 12);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "产品型号";
            // 
            // MyItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MyItemList";
            this.Size = new System.Drawing.Size(783, 470);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinDetailGroup)).EndInit();
            this.FinDetailGroup.ResumeLayout(false);
            this.FinDetailGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SourceGrid.Grid MyItemGrid;
        private Guifreaks.NavigationBar.NaviGroup FinDetailGroup;
        private System.Windows.Forms.Button FinDetailQueryBtn;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Label StatusLabel;
    }
}