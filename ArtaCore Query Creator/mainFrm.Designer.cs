﻿
namespace ArtaCore_Query_Creator
{
    partial class mainFrm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNPCVendor = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.itemExtendedCostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new ArtaCore_Query_Creator.databaseDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.nPCVendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkUseAcoreWorld = new System.Windows.Forms.CheckBox();
            this.btnGenerateNPCVendorQuery = new System.Windows.Forms.Button();
            this.btnPreviewNPCVendorQuery = new System.Windows.Forms.Button();
            this.cbItemCost = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNPCVendor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listItemIDsNPCVendor = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCVendorsTableAdapter = new ArtaCore_Query_Creator.databaseDataSetTableAdapters.NPCVendorsTableAdapter();
            this.itemExtendedCostsTableAdapter = new ArtaCore_Query_Creator.databaseDataSetTableAdapters.ItemExtendedCostsTableAdapter();
            this.mouseOverItem = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbItemNames = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpNPCVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemExtendedCostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCVendorsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNPCVendor);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 790);
            this.tabControl1.TabIndex = 0;
            // 
            // tpNPCVendor
            // 
            this.tpNPCVendor.Controls.Add(this.label6);
            this.tpNPCVendor.Controls.Add(this.lbItemNames);
            this.tpNPCVendor.Controls.Add(this.label5);
            this.tpNPCVendor.Controls.Add(this.label4);
            this.tpNPCVendor.Controls.Add(this.chkUseAcoreWorld);
            this.tpNPCVendor.Controls.Add(this.btnGenerateNPCVendorQuery);
            this.tpNPCVendor.Controls.Add(this.btnPreviewNPCVendorQuery);
            this.tpNPCVendor.Controls.Add(this.cbItemCost);
            this.tpNPCVendor.Controls.Add(this.label3);
            this.tpNPCVendor.Controls.Add(this.cbNPCVendor);
            this.tpNPCVendor.Controls.Add(this.label2);
            this.tpNPCVendor.Controls.Add(this.label1);
            this.tpNPCVendor.Controls.Add(this.listItemIDsNPCVendor);
            this.tpNPCVendor.Location = new System.Drawing.Point(4, 29);
            this.tpNPCVendor.Name = "tpNPCVendor";
            this.tpNPCVendor.Padding = new System.Windows.Forms.Padding(3);
            this.tpNPCVendor.Size = new System.Drawing.Size(1153, 757);
            this.tpNPCVendor.TabIndex = 0;
            this.tpNPCVendor.Text = "NPC_Vendor";
            this.tpNPCVendor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemExtendedCostsBindingSource, "ID Extended Cost", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.label5.Location = new System.Drawing.Point(701, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // itemExtendedCostsBindingSource
            // 
            this.itemExtendedCostsBindingSource.DataMember = "ItemExtendedCosts";
            this.itemExtendedCostsBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nPCVendorsBindingSource, "NPC ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.label4.Location = new System.Drawing.Point(701, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // nPCVendorsBindingSource
            // 
            this.nPCVendorsBindingSource.DataMember = "NPCVendors";
            this.nPCVendorsBindingSource.DataSource = this.databaseDataSet;
            // 
            // chkUseAcoreWorld
            // 
            this.chkUseAcoreWorld.AutoSize = true;
            this.chkUseAcoreWorld.Location = new System.Drawing.Point(404, 193);
            this.chkUseAcoreWorld.Name = "chkUseAcoreWorld";
            this.chkUseAcoreWorld.Size = new System.Drawing.Size(247, 24);
            this.chkUseAcoreWorld.TabIndex = 9;
            this.chkUseAcoreWorld.Text = "Select \'acore_world\' database";
            this.chkUseAcoreWorld.UseVisualStyleBackColor = true;
            // 
            // btnGenerateNPCVendorQuery
            // 
            this.btnGenerateNPCVendorQuery.Location = new System.Drawing.Point(404, 420);
            this.btnGenerateNPCVendorQuery.Name = "btnGenerateNPCVendorQuery";
            this.btnGenerateNPCVendorQuery.Size = new System.Drawing.Size(348, 36);
            this.btnGenerateNPCVendorQuery.TabIndex = 8;
            this.btnGenerateNPCVendorQuery.Text = "Generate SQL Query";
            this.btnGenerateNPCVendorQuery.UseVisualStyleBackColor = true;
            // 
            // btnPreviewNPCVendorQuery
            // 
            this.btnPreviewNPCVendorQuery.Location = new System.Drawing.Point(404, 361);
            this.btnPreviewNPCVendorQuery.Name = "btnPreviewNPCVendorQuery";
            this.btnPreviewNPCVendorQuery.Size = new System.Drawing.Size(348, 36);
            this.btnPreviewNPCVendorQuery.TabIndex = 7;
            this.btnPreviewNPCVendorQuery.Text = "Preview SQL Query";
            this.btnPreviewNPCVendorQuery.UseVisualStyleBackColor = true;
            // 
            // cbItemCost
            // 
            this.cbItemCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemExtendedCostsBindingSource, "Human Readable", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbItemCost.DataSource = this.itemExtendedCostsBindingSource;
            this.cbItemCost.DisplayMember = "Human Readable";
            this.cbItemCost.FormattingEnabled = true;
            this.cbItemCost.Location = new System.Drawing.Point(404, 138);
            this.cbItemCost.Name = "cbItemCost";
            this.cbItemCost.Size = new System.Drawing.Size(291, 28);
            this.cbItemCost.TabIndex = 6;
            this.cbItemCost.ValueMember = "ID Extended Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Cost";
            // 
            // cbNPCVendor
            // 
            this.cbNPCVendor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nPCVendorsBindingSource, "NPC Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbNPCVendor.DataSource = this.nPCVendorsBindingSource;
            this.cbNPCVendor.DisplayMember = "NPC Name";
            this.cbNPCVendor.FormattingEnabled = true;
            this.cbNPCVendor.Location = new System.Drawing.Point(404, 72);
            this.cbNPCVendor.Name = "cbNPCVendor";
            this.cbNPCVendor.Size = new System.Drawing.Size(291, 28);
            this.cbNPCVendor.TabIndex = 4;
            this.cbNPCVendor.ValueMember = "NPC ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NPC Vendor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item IDs";
            // 
            // listItemIDsNPCVendor
            // 
            this.listItemIDsNPCVendor.AllowDrop = true;
            this.listItemIDsNPCVendor.FormattingEnabled = true;
            this.listItemIDsNPCVendor.ItemHeight = 20;
            this.listItemIDsNPCVendor.Location = new System.Drawing.Point(43, 72);
            this.listItemIDsNPCVendor.Name = "listItemIDsNPCVendor";
            this.listItemIDsNPCVendor.Size = new System.Drawing.Size(333, 384);
            this.listItemIDsNPCVendor.TabIndex = 0;
            this.listItemIDsNPCVendor.SelectedIndexChanged += new System.EventHandler(this.listItemIDsNPCVendor_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1440, 757);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.operationsToolStripMenuItem.Text = "&Operations";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // nPCVendorsTableAdapter
            // 
            this.nPCVendorsTableAdapter.ClearBeforeFill = true;
            // 
            // itemExtendedCostsTableAdapter
            // 
            this.itemExtendedCostsTableAdapter.ClearBeforeFill = true;
            // 
            // mouseOverItem
            // 
            this.mouseOverItem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mouseOverItem.ToolTipTitle = "Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(775, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item Names";
            // 
            // lbItemNames
            // 
            this.lbItemNames.AllowDrop = true;
            this.lbItemNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbItemNames.FormattingEnabled = true;
            this.lbItemNames.ItemHeight = 20;
            this.lbItemNames.Location = new System.Drawing.Point(779, 72);
            this.lbItemNames.Name = "lbItemNames";
            this.lbItemNames.Size = new System.Drawing.Size(333, 384);
            this.lbItemNames.TabIndex = 12;
            this.lbItemNames.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbItemNames_DrawItem);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 823);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.Text = "ArtaCore Query Creator";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpNPCVendor.ResumeLayout(false);
            this.tpNPCVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemExtendedCostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCVendorsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNPCVendor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkUseAcoreWorld;
        private System.Windows.Forms.Button btnGenerateNPCVendorQuery;
        private System.Windows.Forms.Button btnPreviewNPCVendorQuery;
        private System.Windows.Forms.ComboBox cbItemCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNPCVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listItemIDsNPCVendor;        
        private System.Windows.Forms.Label label4;        
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource nPCVendorsBindingSource;
        private databaseDataSetTableAdapters.NPCVendorsTableAdapter nPCVendorsTableAdapter;
        private System.Windows.Forms.BindingSource itemExtendedCostsBindingSource;
        private databaseDataSetTableAdapters.ItemExtendedCostsTableAdapter itemExtendedCostsTableAdapter;
        private System.Windows.Forms.ToolTip mouseOverItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbItemNames;
    }
}

