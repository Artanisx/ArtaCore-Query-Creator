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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNPCVendor = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNPCVendorPreview = new System.Windows.Forms.TextBox();
            this.cbEnableItemNameFetching = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbItemNames = new System.Windows.Forms.ListBox();
            this.labItemCostID = new System.Windows.Forms.Label();
            this.itemExtendedCostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new ArtaCore_Query_Creator.databaseDataSet();
            this.labVendorID = new System.Windows.Forms.Label();
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
            this.tbCreatureTemplate = new System.Windows.Forms.TabPage();
            this.tbQuestTemplate = new System.Windows.Forms.TabPage();
            this.tbCreatureQuestStarter = new System.Windows.Forms.TabPage();
            this.tbCreatureQuestEnder = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCVendorsTableAdapter = new ArtaCore_Query_Creator.databaseDataSetTableAdapters.NPCVendorsTableAdapter();
            this.itemExtendedCostsTableAdapter = new ArtaCore_Query_Creator.databaseDataSetTableAdapters.ItemExtendedCostsTableAdapter();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sqlSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.dgCreatureTemplate = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateNPCDatabase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNPCIDCreatureTemplate = new System.Windows.Forms.TextBox();
            this.txtNPCNAMECreatureTemplate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNPCSUBNAMECreatureTemplate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbNPCType = new System.Windows.Forms.ComboBox();
            this.labelNPCType = new System.Windows.Forms.Label();
            this.bntAddNPC = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSQLPreviewCreatureTemplate = new System.Windows.Forms.TextBox();
            this.cbSelectAcoreCreatureTemplate = new System.Windows.Forms.CheckBox();
            this.btnGenerateCreatureTemplateQuery = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClearQueryCreatureTemplate = new System.Windows.Forms.Button();
            this.btnAddQueryCreaturesToInternalDB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpNPCVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemExtendedCostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCVendorsBindingSource)).BeginInit();
            this.tbCreatureTemplate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCreatureTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNPCVendor);
            this.tabControl1.Controls.Add(this.tbCreatureTemplate);
            this.tabControl1.Controls.Add(this.tbQuestTemplate);
            this.tabControl1.Controls.Add(this.tbCreatureQuestStarter);
            this.tabControl1.Controls.Add(this.tbCreatureQuestEnder);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1331, 1027);
            this.tabControl1.TabIndex = 0;
            // 
            // tpNPCVendor
            // 
            this.tpNPCVendor.Controls.Add(this.label7);
            this.tpNPCVendor.Controls.Add(this.tbNPCVendorPreview);
            this.tpNPCVendor.Controls.Add(this.cbEnableItemNameFetching);
            this.tpNPCVendor.Controls.Add(this.label6);
            this.tpNPCVendor.Controls.Add(this.lbItemNames);
            this.tpNPCVendor.Controls.Add(this.labItemCostID);
            this.tpNPCVendor.Controls.Add(this.labVendorID);
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
            this.tpNPCVendor.Size = new System.Drawing.Size(1323, 977);
            this.tpNPCVendor.TabIndex = 0;
            this.tpNPCVendor.Text = "NPC_VENDOR";
            this.toolTip.SetToolTip(this.tpNPCVendor, "Open the SQL Query Creator for NPC_VENDOR table (Item inventories for NPC vendors" +
        ").");
            this.tpNPCVendor.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "SQL Preview";
            // 
            // tbNPCVendorPreview
            // 
            this.tbNPCVendorPreview.Location = new System.Drawing.Point(43, 502);
            this.tbNPCVendorPreview.Multiline = true;
            this.tbNPCVendorPreview.Name = "tbNPCVendorPreview";
            this.tbNPCVendorPreview.ReadOnly = true;
            this.tbNPCVendorPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNPCVendorPreview.Size = new System.Drawing.Size(1248, 448);
            this.tbNPCVendorPreview.TabIndex = 15;
            this.tbNPCVendorPreview.WordWrap = false;
            // 
            // cbEnableItemNameFetching
            // 
            this.cbEnableItemNameFetching.AutoSize = true;
            this.cbEnableItemNameFetching.Checked = true;
            this.cbEnableItemNameFetching.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnableItemNameFetching.Location = new System.Drawing.Point(1044, 42);
            this.cbEnableItemNameFetching.Name = "cbEnableItemNameFetching";
            this.cbEnableItemNameFetching.Size = new System.Drawing.Size(224, 24);
            this.cbEnableItemNameFetching.TabIndex = 14;
            this.cbEnableItemNameFetching.Text = "Enable item name fetching";
            this.toolTip.SetToolTip(this.cbEnableItemNameFetching, resources.GetString("cbEnableItemNameFetching.ToolTip"));
            this.cbEnableItemNameFetching.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(768, 49);
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
            this.lbItemNames.Location = new System.Drawing.Point(772, 72);
            this.lbItemNames.Name = "lbItemNames";
            this.lbItemNames.Size = new System.Drawing.Size(519, 384);
            this.lbItemNames.TabIndex = 12;
            this.toolTip.SetToolTip(this.lbItemNames, "The list of item names from the item ids pasted. This will be shown only if Enalb" +
        "e item name fetching is checked.");
            this.lbItemNames.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbItemNames_DrawItem);
            this.lbItemNames.SelectedIndexChanged += new System.EventHandler(this.lbItemNames_SelectedIndexChanged);
            // 
            // labItemCostID
            // 
            this.labItemCostID.AutoSize = true;
            this.labItemCostID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemExtendedCostsBindingSource, "ID Extended Cost", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.labItemCostID.Location = new System.Drawing.Point(694, 141);
            this.labItemCostID.Name = "labItemCostID";
            this.labItemCostID.Size = new System.Drawing.Size(54, 20);
            this.labItemCostID.TabIndex = 11;
            this.labItemCostID.Text = "00000";
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
            // labVendorID
            // 
            this.labVendorID.AutoSize = true;
            this.labVendorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nPCVendorsBindingSource, "NPC ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.labVendorID.Location = new System.Drawing.Point(694, 75);
            this.labVendorID.Name = "labVendorID";
            this.labVendorID.Size = new System.Drawing.Size(63, 20);
            this.labVendorID.TabIndex = 10;
            this.labVendorID.Text = "000000";
            // 
            // nPCVendorsBindingSource
            // 
            this.nPCVendorsBindingSource.DataMember = "NPCVendors";
            this.nPCVendorsBindingSource.DataSource = this.databaseDataSet;
            // 
            // chkUseAcoreWorld
            // 
            this.chkUseAcoreWorld.AutoSize = true;
            this.chkUseAcoreWorld.Location = new System.Drawing.Point(397, 193);
            this.chkUseAcoreWorld.Name = "chkUseAcoreWorld";
            this.chkUseAcoreWorld.Size = new System.Drawing.Size(247, 24);
            this.chkUseAcoreWorld.TabIndex = 9;
            this.chkUseAcoreWorld.Text = "Select \'acore_world\' database";
            this.toolTip.SetToolTip(this.chkUseAcoreWorld, "Check this if you want to create a SQL query that will select the database (meani" +
        "ng you won\'t need to be in the proper DB to import it). Experimental.");
            this.chkUseAcoreWorld.UseVisualStyleBackColor = true;
            // 
            // btnGenerateNPCVendorQuery
            // 
            this.btnGenerateNPCVendorQuery.Location = new System.Drawing.Point(397, 420);
            this.btnGenerateNPCVendorQuery.Name = "btnGenerateNPCVendorQuery";
            this.btnGenerateNPCVendorQuery.Size = new System.Drawing.Size(348, 36);
            this.btnGenerateNPCVendorQuery.TabIndex = 8;
            this.btnGenerateNPCVendorQuery.Text = "Generate SQL Query";
            this.toolTip.SetToolTip(this.btnGenerateNPCVendorQuery, "Generate the SQL query file.");
            this.btnGenerateNPCVendorQuery.UseVisualStyleBackColor = true;
            this.btnGenerateNPCVendorQuery.Click += new System.EventHandler(this.btnGenerateNPCVendorQuery_Click);
            // 
            // btnPreviewNPCVendorQuery
            // 
            this.btnPreviewNPCVendorQuery.Location = new System.Drawing.Point(397, 361);
            this.btnPreviewNPCVendorQuery.Name = "btnPreviewNPCVendorQuery";
            this.btnPreviewNPCVendorQuery.Size = new System.Drawing.Size(348, 36);
            this.btnPreviewNPCVendorQuery.TabIndex = 7;
            this.btnPreviewNPCVendorQuery.Text = "Preview SQL Query";
            this.toolTip.SetToolTip(this.btnPreviewNPCVendorQuery, "Preview the SQL creation.");
            this.btnPreviewNPCVendorQuery.UseVisualStyleBackColor = true;
            this.btnPreviewNPCVendorQuery.Click += new System.EventHandler(this.btnPreviewNPCVendorQuery_Click);
            // 
            // cbItemCost
            // 
            this.cbItemCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemExtendedCostsBindingSource, "Human Readable", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbItemCost.DataSource = this.itemExtendedCostsBindingSource;
            this.cbItemCost.DisplayMember = "Human Readable";
            this.cbItemCost.FormattingEnabled = true;
            this.cbItemCost.Location = new System.Drawing.Point(397, 138);
            this.cbItemCost.Name = "cbItemCost";
            this.cbItemCost.Size = new System.Drawing.Size(291, 28);
            this.cbItemCost.TabIndex = 6;
            this.toolTip.SetToolTip(this.cbItemCost, "Select the cost of the items in the list.");
            this.cbItemCost.ValueMember = "ID Extended Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 115);
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
            this.cbNPCVendor.Location = new System.Drawing.Point(397, 72);
            this.cbNPCVendor.Name = "cbNPCVendor";
            this.cbNPCVendor.Size = new System.Drawing.Size(291, 28);
            this.cbNPCVendor.TabIndex = 4;
            this.toolTip.SetToolTip(this.cbNPCVendor, "Select the NPC creature id who will be the vendor for this inventory.");
            this.cbNPCVendor.ValueMember = "NPC ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 49);
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
            this.listItemIDsNPCVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItemIDsNPCVendor.FormattingEnabled = true;
            this.listItemIDsNPCVendor.ItemHeight = 29;
            this.listItemIDsNPCVendor.Location = new System.Drawing.Point(43, 72);
            this.listItemIDsNPCVendor.Name = "listItemIDsNPCVendor";
            this.listItemIDsNPCVendor.Size = new System.Drawing.Size(333, 381);
            this.listItemIDsNPCVendor.TabIndex = 0;
            this.toolTip.SetToolTip(this.listItemIDsNPCVendor, "Paste inside the list of Item IDs you want to create a NPC_Vendor query for (the " +
        "inventory of the Vendor).");
            this.listItemIDsNPCVendor.SelectedIndexChanged += new System.EventHandler(this.listItemIDsNPCVendor_SelectedIndexChanged);
            // 
            // tbCreatureTemplate
            // 
            this.tbCreatureTemplate.Controls.Add(this.btnAddQueryCreaturesToInternalDB);
            this.tbCreatureTemplate.Controls.Add(this.btnClearQueryCreatureTemplate);
            this.tbCreatureTemplate.Controls.Add(this.pictureBox1);
            this.tbCreatureTemplate.Controls.Add(this.btnGenerateCreatureTemplateQuery);
            this.tbCreatureTemplate.Controls.Add(this.cbSelectAcoreCreatureTemplate);
            this.tbCreatureTemplate.Controls.Add(this.label11);
            this.tbCreatureTemplate.Controls.Add(this.txtSQLPreviewCreatureTemplate);
            this.tbCreatureTemplate.Controls.Add(this.bntAddNPC);
            this.tbCreatureTemplate.Controls.Add(this.labelNPCType);
            this.tbCreatureTemplate.Controls.Add(this.cbNPCType);
            this.tbCreatureTemplate.Controls.Add(this.label10);
            this.tbCreatureTemplate.Controls.Add(this.txtNPCSUBNAMECreatureTemplate);
            this.tbCreatureTemplate.Controls.Add(this.label9);
            this.tbCreatureTemplate.Controls.Add(this.txtNPCNAMECreatureTemplate);
            this.tbCreatureTemplate.Controls.Add(this.label8);
            this.tbCreatureTemplate.Controls.Add(this.txtNPCIDCreatureTemplate);
            this.tbCreatureTemplate.Controls.Add(this.label5);
            this.tbCreatureTemplate.Controls.Add(this.label4);
            this.tbCreatureTemplate.Controls.Add(this.btnUpdateNPCDatabase);
            this.tbCreatureTemplate.Controls.Add(this.dgCreatureTemplate);
            this.tbCreatureTemplate.Location = new System.Drawing.Point(4, 29);
            this.tbCreatureTemplate.Name = "tbCreatureTemplate";
            this.tbCreatureTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tbCreatureTemplate.Size = new System.Drawing.Size(1323, 994);
            this.tbCreatureTemplate.TabIndex = 1;
            this.tbCreatureTemplate.Text = "CREATURE_TEMPLATE";
            this.tbCreatureTemplate.UseVisualStyleBackColor = true;
            // 
            // tbQuestTemplate
            // 
            this.tbQuestTemplate.Location = new System.Drawing.Point(4, 29);
            this.tbQuestTemplate.Name = "tbQuestTemplate";
            this.tbQuestTemplate.Size = new System.Drawing.Size(1323, 977);
            this.tbQuestTemplate.TabIndex = 2;
            this.tbQuestTemplate.Text = "QUEST_TEMPLATE";
            this.tbQuestTemplate.UseVisualStyleBackColor = true;
            // 
            // tbCreatureQuestStarter
            // 
            this.tbCreatureQuestStarter.Location = new System.Drawing.Point(4, 29);
            this.tbCreatureQuestStarter.Name = "tbCreatureQuestStarter";
            this.tbCreatureQuestStarter.Size = new System.Drawing.Size(1323, 977);
            this.tbCreatureQuestStarter.TabIndex = 3;
            this.tbCreatureQuestStarter.Text = "CREATURE_QUESTSTARTER";
            this.tbCreatureQuestStarter.UseVisualStyleBackColor = true;
            // 
            // tbCreatureQuestEnder
            // 
            this.tbCreatureQuestEnder.Location = new System.Drawing.Point(4, 29);
            this.tbCreatureQuestEnder.Name = "tbCreatureQuestEnder";
            this.tbCreatureQuestEnder.Size = new System.Drawing.Size(1323, 977);
            this.tbCreatureQuestEnder.TabIndex = 4;
            this.tbCreatureQuestEnder.Text = "CREATURE_QUEST_ENDER";
            this.tbCreatureQuestEnder.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 33);
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
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 15000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "UI Help";
            // 
            // sqlSaveDialog
            // 
            this.sqlSaveDialog.DefaultExt = "sql";
            this.sqlSaveDialog.FileName = "NPCVendor_Items";
            this.sqlSaveDialog.Filter = "SQL Query|*.sql";
            this.sqlSaveDialog.Title = "Save the SQL Query";
            // 
            // dgCreatureTemplate
            // 
            this.dgCreatureTemplate.AutoGenerateColumns = false;
            this.dgCreatureTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCreatureTemplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nPCIDDataGridViewTextBoxColumn,
            this.nPCNameDataGridViewTextBoxColumn});
            this.dgCreatureTemplate.DataSource = this.nPCVendorsBindingSource;
            this.dgCreatureTemplate.Location = new System.Drawing.Point(25, 35);
            this.dgCreatureTemplate.Name = "dgCreatureTemplate";
            this.dgCreatureTemplate.RowHeadersWidth = 62;
            this.dgCreatureTemplate.RowTemplate.Height = 28;
            this.dgCreatureTemplate.Size = new System.Drawing.Size(1266, 181);
            this.dgCreatureTemplate.TabIndex = 0;
            this.toolTip.SetToolTip(this.dgCreatureTemplate, "Using this page you can add / remove / update or simply view the NPC name and rel" +
        "ated number that is used in other tabs.");
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nPCIDDataGridViewTextBoxColumn
            // 
            this.nPCIDDataGridViewTextBoxColumn.DataPropertyName = "NPC ID";
            this.nPCIDDataGridViewTextBoxColumn.HeaderText = "NPC ID";
            this.nPCIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nPCIDDataGridViewTextBoxColumn.Name = "nPCIDDataGridViewTextBoxColumn";
            this.nPCIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nPCNameDataGridViewTextBoxColumn
            // 
            this.nPCNameDataGridViewTextBoxColumn.DataPropertyName = "NPC Name";
            this.nPCNameDataGridViewTextBoxColumn.HeaderText = "NPC Name";
            this.nPCNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nPCNameDataGridViewTextBoxColumn.Name = "nPCNameDataGridViewTextBoxColumn";
            this.nPCNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnUpdateNPCDatabase
            // 
            this.btnUpdateNPCDatabase.Location = new System.Drawing.Point(25, 222);
            this.btnUpdateNPCDatabase.Name = "btnUpdateNPCDatabase";
            this.btnUpdateNPCDatabase.Size = new System.Drawing.Size(1266, 40);
            this.btnUpdateNPCDatabase.TabIndex = 1;
            this.btnUpdateNPCDatabase.Text = "Update internal Database";
            this.toolTip.SetToolTip(this.btnUpdateNPCDatabase, "Update the internal database if you edited something.");
            this.btnUpdateNPCDatabase.UseVisualStyleBackColor = true;
            this.btnUpdateNPCDatabase.Click += new System.EventHandler(this.btnUpdateNPCDatabase_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Internal Database Editor";
            this.toolTip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "NPC ID";
            // 
            // txtNPCIDCreatureTemplate
            // 
            this.txtNPCIDCreatureTemplate.Location = new System.Drawing.Point(25, 348);
            this.txtNPCIDCreatureTemplate.Name = "txtNPCIDCreatureTemplate";
            this.txtNPCIDCreatureTemplate.Size = new System.Drawing.Size(205, 26);
            this.txtNPCIDCreatureTemplate.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtNPCIDCreatureTemplate, "Input the ID the new creature will have. Advised to go from 700000 up.");
            // 
            // txtNPCNAMECreatureTemplate
            // 
            this.txtNPCNAMECreatureTemplate.Location = new System.Drawing.Point(256, 348);
            this.txtNPCNAMECreatureTemplate.Name = "txtNPCNAMECreatureTemplate";
            this.txtNPCNAMECreatureTemplate.Size = new System.Drawing.Size(205, 26);
            this.txtNPCNAMECreatureTemplate.TabIndex = 6;
            this.toolTip.SetToolTip(this.txtNPCNAMECreatureTemplate, "Insert the name for the new Creature.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "NPC NAME";
            // 
            // txtNPCSUBNAMECreatureTemplate
            // 
            this.txtNPCSUBNAMECreatureTemplate.Location = new System.Drawing.Point(483, 348);
            this.txtNPCSUBNAMECreatureTemplate.Name = "txtNPCSUBNAMECreatureTemplate";
            this.txtNPCSUBNAMECreatureTemplate.Size = new System.Drawing.Size(205, 26);
            this.txtNPCSUBNAMECreatureTemplate.TabIndex = 8;
            this.toolTip.SetToolTip(this.txtNPCSUBNAMECreatureTemplate, "Insert the text that should go between <> under the new Creature.");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "NPC <SUBNAME>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(712, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "NPC TYPE";
            // 
            // cbNPCType
            // 
            this.cbNPCType.FormattingEnabled = true;
            this.cbNPCType.Items.AddRange(new object[] {
            "Vendor",
            "Quest Giver"});
            this.cbNPCType.Location = new System.Drawing.Point(716, 348);
            this.cbNPCType.Name = "cbNPCType";
            this.cbNPCType.Size = new System.Drawing.Size(152, 28);
            this.cbNPCType.TabIndex = 10;
            this.cbNPCType.Text = "Vendor";
            this.toolTip.SetToolTip(this.cbNPCType, "Select the type of NPC, wheter it is a Vendor or Quest Giver.");
            this.cbNPCType.SelectedIndexChanged += new System.EventHandler(this.cbNPCType_SelectedIndexChanged);
            // 
            // labelNPCType
            // 
            this.labelNPCType.AutoSize = true;
            this.labelNPCType.Location = new System.Drawing.Point(886, 351);
            this.labelNPCType.Name = "labelNPCType";
            this.labelNPCType.Size = new System.Drawing.Size(36, 20);
            this.labelNPCType.TabIndex = 11;
            this.labelNPCType.Text = "128";
            // 
            // bntAddNPC
            // 
            this.bntAddNPC.Location = new System.Drawing.Point(964, 345);
            this.bntAddNPC.Name = "bntAddNPC";
            this.bntAddNPC.Size = new System.Drawing.Size(327, 45);
            this.bntAddNPC.TabIndex = 12;
            this.bntAddNPC.Text = "Add NPC to the Query";
            this.bntAddNPC.UseVisualStyleBackColor = true;
            this.bntAddNPC.Click += new System.EventHandler(this.bntAddNPC_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "SQL Preview";
            // 
            // txtSQLPreviewCreatureTemplate
            // 
            this.txtSQLPreviewCreatureTemplate.Location = new System.Drawing.Point(25, 416);
            this.txtSQLPreviewCreatureTemplate.Multiline = true;
            this.txtSQLPreviewCreatureTemplate.Name = "txtSQLPreviewCreatureTemplate";
            this.txtSQLPreviewCreatureTemplate.ReadOnly = true;
            this.txtSQLPreviewCreatureTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQLPreviewCreatureTemplate.Size = new System.Drawing.Size(1266, 448);
            this.txtSQLPreviewCreatureTemplate.TabIndex = 17;
            this.txtSQLPreviewCreatureTemplate.WordWrap = false;
            // 
            // cbSelectAcoreCreatureTemplate
            // 
            this.cbSelectAcoreCreatureTemplate.AutoSize = true;
            this.cbSelectAcoreCreatureTemplate.Location = new System.Drawing.Point(531, 884);
            this.cbSelectAcoreCreatureTemplate.Name = "cbSelectAcoreCreatureTemplate";
            this.cbSelectAcoreCreatureTemplate.Size = new System.Drawing.Size(247, 24);
            this.cbSelectAcoreCreatureTemplate.TabIndex = 19;
            this.cbSelectAcoreCreatureTemplate.Text = "Select \'acore_world\' database";
            this.toolTip.SetToolTip(this.cbSelectAcoreCreatureTemplate, "Check this if you want to create a SQL query that will select the database (meani" +
        "ng you won\'t need to be in the proper DB to import it). Experimental.");
            this.cbSelectAcoreCreatureTemplate.UseVisualStyleBackColor = true;
            // 
            // btnGenerateCreatureTemplateQuery
            // 
            this.btnGenerateCreatureTemplateQuery.Location = new System.Drawing.Point(943, 884);
            this.btnGenerateCreatureTemplateQuery.Name = "btnGenerateCreatureTemplateQuery";
            this.btnGenerateCreatureTemplateQuery.Size = new System.Drawing.Size(348, 85);
            this.btnGenerateCreatureTemplateQuery.TabIndex = 20;
            this.btnGenerateCreatureTemplateQuery.Text = "Generate SQL Query";
            this.toolTip.SetToolTip(this.btnGenerateCreatureTemplateQuery, "Generate the SQL query file.");
            this.btnGenerateCreatureTemplateQuery.UseVisualStyleBackColor = true;
            this.btnGenerateCreatureTemplateQuery.Click += new System.EventHandler(this.btnGenerateCreatureTemplateQuery_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(25, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1265, 10);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnClearQueryCreatureTemplate
            // 
            this.btnClearQueryCreatureTemplate.Location = new System.Drawing.Point(25, 884);
            this.btnClearQueryCreatureTemplate.Name = "btnClearQueryCreatureTemplate";
            this.btnClearQueryCreatureTemplate.Size = new System.Drawing.Size(348, 85);
            this.btnClearQueryCreatureTemplate.TabIndex = 22;
            this.btnClearQueryCreatureTemplate.Text = "Clear the Query";
            this.toolTip.SetToolTip(this.btnClearQueryCreatureTemplate, "Clear the Query");
            this.btnClearQueryCreatureTemplate.UseVisualStyleBackColor = true;
            this.btnClearQueryCreatureTemplate.Click += new System.EventHandler(this.btnClearQueryCreatureTemplate_Click);
            // 
            // btnAddQueryCreaturesToInternalDB
            // 
            this.btnAddQueryCreaturesToInternalDB.Location = new System.Drawing.Point(483, 914);
            this.btnAddQueryCreaturesToInternalDB.Name = "btnAddQueryCreaturesToInternalDB";
            this.btnAddQueryCreaturesToInternalDB.Size = new System.Drawing.Size(348, 55);
            this.btnAddQueryCreaturesToInternalDB.TabIndex = 23;
            this.btnAddQueryCreaturesToInternalDB.Text = "Add the query creatures to the Internal Database";
            this.toolTip.SetToolTip(this.btnAddQueryCreaturesToInternalDB, "Use the SQL query to add the NPC (id & name) to the internal database as well.");
            this.btnAddQueryCreaturesToInternalDB.UseVisualStyleBackColor = true;
            this.btnAddQueryCreaturesToInternalDB.Click += new System.EventHandler(this.btnAddQueryCreaturesToInternalDB_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 1060);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArtaCore Query Creator";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpNPCVendor.ResumeLayout(false);
            this.tpNPCVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemExtendedCostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCVendorsBindingSource)).EndInit();
            this.tbCreatureTemplate.ResumeLayout(false);
            this.tbCreatureTemplate.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCreatureTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNPCVendor;
        private System.Windows.Forms.TabPage tbCreatureTemplate;
        private System.Windows.Forms.CheckBox chkUseAcoreWorld;
        private System.Windows.Forms.Button btnGenerateNPCVendorQuery;
        private System.Windows.Forms.Button btnPreviewNPCVendorQuery;
        private System.Windows.Forms.ComboBox cbItemCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNPCVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listItemIDsNPCVendor;        
        private System.Windows.Forms.Label labVendorID;        
        private System.Windows.Forms.Label labItemCostID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource nPCVendorsBindingSource;
        private databaseDataSetTableAdapters.NPCVendorsTableAdapter nPCVendorsTableAdapter;
        private System.Windows.Forms.BindingSource itemExtendedCostsBindingSource;
        private databaseDataSetTableAdapters.ItemExtendedCostsTableAdapter itemExtendedCostsTableAdapter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbItemNames;
        private System.Windows.Forms.CheckBox cbEnableItemNameFetching;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNPCVendorPreview;
        private System.Windows.Forms.SaveFileDialog sqlSaveDialog;
        private System.Windows.Forms.TabPage tbQuestTemplate;
        private System.Windows.Forms.TabPage tbCreatureQuestStarter;
        private System.Windows.Forms.TabPage tbCreatureQuestEnder;
        private System.Windows.Forms.DataGridView dgCreatureTemplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdateNPCDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNPCType;
        private System.Windows.Forms.ComboBox cbNPCType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNPCSUBNAMECreatureTemplate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNPCNAMECreatureTemplate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNPCIDCreatureTemplate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSQLPreviewCreatureTemplate;
        private System.Windows.Forms.Button bntAddNPC;
        private System.Windows.Forms.Button btnGenerateCreatureTemplateQuery;
        private System.Windows.Forms.CheckBox cbSelectAcoreCreatureTemplate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClearQueryCreatureTemplate;
        private System.Windows.Forms.Button btnAddQueryCreaturesToInternalDB;
    }
}

