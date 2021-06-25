
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
            this.btnAddQueryCreaturesToInternalDB = new System.Windows.Forms.Button();
            this.btnClearQueryCreatureTemplate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenerateCreatureTemplateQuery = new System.Windows.Forms.Button();
            this.cbSelectAcoreCreatureTemplate = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSQLPreviewCreatureTemplate = new System.Windows.Forms.TextBox();
            this.bntAddNPC = new System.Windows.Forms.Button();
            this.labelNPCType = new System.Windows.Forms.Label();
            this.cbNPCType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNPCSUBNAMECreatureTemplate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNPCNAMECreatureTemplate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNPCIDCreatureTemplate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateNPCDatabase = new System.Windows.Forms.Button();
            this.dgCreatureTemplate = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnClearQuestTemplateQuery = new System.Windows.Forms.Button();
            this.btnGenerateQuestTemplateQuery = new System.Windows.Forms.Button();
            this.cbSelectAcoreQuestTemplate = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbQueryQuestTemplate = new System.Windows.Forms.TextBox();
            this.btnAddQuestToQuery = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbQuestMinLevel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbQuestLevel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbQuestID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbQuestRewardMoney = new System.Windows.Forms.TextBox();
            this.labelQuestType = new System.Windows.Forms.Label();
            this.cbQuestType = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbQuestRewardID1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbQuestRewardAmount1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbQuestRewardAmount2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbQuestRewardID2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbQuestRewardAmount3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbQuestRewardID3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbQuestRewardAmount4 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbQuestRewardID4 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbQuestLogTitle = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbQuestTarget = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbQuestDescription = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbQuestCompletionLog = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbRequiredAmountNPC1 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbRequiredNPCID1 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tbRequiredAmountNPC2 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbRequiredNPCID2 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbRequiredAmountNPC3 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbRequiredNPCID3 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tbRequiredAmountNPC4 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tbRequiredNPCID4 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpNPCVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemExtendedCostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCVendorsBindingSource)).BeginInit();
            this.tbCreatureTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCreatureTemplate)).BeginInit();
            this.tbQuestTemplate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1344, 1027);
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
            this.tpNPCVendor.Size = new System.Drawing.Size(1323, 994);
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
            this.tbCreatureTemplate.Size = new System.Drawing.Size(1336, 994);
            this.tbCreatureTemplate.TabIndex = 1;
            this.tbCreatureTemplate.Text = "CREATURE_TEMPLATE";
            this.tbCreatureTemplate.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(25, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1265, 10);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            // labelNPCType
            // 
            this.labelNPCType.AutoSize = true;
            this.labelNPCType.Location = new System.Drawing.Point(886, 351);
            this.labelNPCType.Name = "labelNPCType";
            this.labelNPCType.Size = new System.Drawing.Size(36, 20);
            this.labelNPCType.TabIndex = 11;
            this.labelNPCType.Text = "128";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(712, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "NPC TYPE";
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
            // txtNPCIDCreatureTemplate
            // 
            this.txtNPCIDCreatureTemplate.Location = new System.Drawing.Point(25, 348);
            this.txtNPCIDCreatureTemplate.Name = "txtNPCIDCreatureTemplate";
            this.txtNPCIDCreatureTemplate.Size = new System.Drawing.Size(205, 26);
            this.txtNPCIDCreatureTemplate.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtNPCIDCreatureTemplate, "Input the ID the new creature will have. Advised to go from 700000 up.");
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
            // tbQuestTemplate
            // 
            this.tbQuestTemplate.Controls.Add(this.tbRequiredAmountNPC4);
            this.tbQuestTemplate.Controls.Add(this.label37);
            this.tbQuestTemplate.Controls.Add(this.tbRequiredNPCID4);
            this.tbQuestTemplate.Controls.Add(this.label38);
            this.tbQuestTemplate.Controls.Add(this.tbRequiredAmountNPC3);
            this.tbQuestTemplate.Controls.Add(this.label33);
            this.tbQuestTemplate.Controls.Add(this.tbRequiredNPCID3);
            this.tbQuestTemplate.Controls.Add(this.label36);
            this.tbQuestTemplate.Controls.Add(this.tbRequiredAmountNPC2);
            this.tbQuestTemplate.Controls.Add(this.label31);
            this.tbQuestTemplate.Controls.Add(this.tbRequiredNPCID2);
            this.tbQuestTemplate.Controls.Add(this.label32);
            this.tbQuestTemplate.Controls.Add(this.tbRequiredAmountNPC1);
            this.tbQuestTemplate.Controls.Add(this.label34);
            this.tbQuestTemplate.Controls.Add(this.tbRequiredNPCID1);
            this.tbQuestTemplate.Controls.Add(this.label35);
            this.tbQuestTemplate.Controls.Add(this.tbQuestCompletionLog);
            this.tbQuestTemplate.Controls.Add(this.label30);
            this.tbQuestTemplate.Controls.Add(this.tbQuestDescription);
            this.tbQuestTemplate.Controls.Add(this.label29);
            this.tbQuestTemplate.Controls.Add(this.tbQuestTarget);
            this.tbQuestTemplate.Controls.Add(this.label28);
            this.tbQuestTemplate.Controls.Add(this.tbQuestLogTitle);
            this.tbQuestTemplate.Controls.Add(this.label27);
            this.tbQuestTemplate.Controls.Add(this.tbQuestRewardAmount4);
            this.tbQuestTemplate.Controls.Add(this.label25);
            this.tbQuestTemplate.Controls.Add(this.tbQuestRewardID4);
            this.tbQuestTemplate.Controls.Add(this.label26);
            this.tbQuestTemplate.Controls.Add(this.tbQuestRewardAmount3);
            this.tbQuestTemplate.Controls.Add(this.label23);
            this.tbQuestTemplate.Controls.Add(this.tbQuestRewardID3);
            this.tbQuestTemplate.Controls.Add(this.label24);
            this.tbQuestTemplate.Controls.Add(this.tbQuestRewardAmount2);
            this.tbQuestTemplate.Controls.Add(this.label13);
            this.tbQuestTemplate.Controls.Add(this.tbQuestRewardID2);
            this.tbQuestTemplate.Controls.Add(this.label22);
            this.tbQuestTemplate.Controls.Add(this.tbQuestRewardAmount1);
            this.tbQuestTemplate.Controls.Add(this.label21);
            this.tbQuestTemplate.Controls.Add(this.tbQuestRewardID1);
            this.tbQuestTemplate.Controls.Add(this.label20);
            this.tbQuestTemplate.Controls.Add(this.labelQuestType);
            this.tbQuestTemplate.Controls.Add(this.cbQuestType);
            this.tbQuestTemplate.Controls.Add(this.label19);
            this.tbQuestTemplate.Controls.Add(this.tbQuestRewardMoney);
            this.tbQuestTemplate.Controls.Add(this.btnClearQuestTemplateQuery);
            this.tbQuestTemplate.Controls.Add(this.btnGenerateQuestTemplateQuery);
            this.tbQuestTemplate.Controls.Add(this.cbSelectAcoreQuestTemplate);
            this.tbQuestTemplate.Controls.Add(this.label12);
            this.tbQuestTemplate.Controls.Add(this.tbQueryQuestTemplate);
            this.tbQuestTemplate.Controls.Add(this.btnAddQuestToQuery);
            this.tbQuestTemplate.Controls.Add(this.label14);
            this.tbQuestTemplate.Controls.Add(this.tbQuestMinLevel);
            this.tbQuestTemplate.Controls.Add(this.label15);
            this.tbQuestTemplate.Controls.Add(this.tbQuestLevel);
            this.tbQuestTemplate.Controls.Add(this.label16);
            this.tbQuestTemplate.Controls.Add(this.tbQuestID);
            this.tbQuestTemplate.Controls.Add(this.label17);
            this.tbQuestTemplate.Location = new System.Drawing.Point(4, 29);
            this.tbQuestTemplate.Name = "tbQuestTemplate";
            this.tbQuestTemplate.Size = new System.Drawing.Size(1336, 994);
            this.tbQuestTemplate.TabIndex = 2;
            this.tbQuestTemplate.Text = "QUEST_TEMPLATE";
            this.tbQuestTemplate.UseVisualStyleBackColor = true;
            // 
            // tbCreatureQuestStarter
            // 
            this.tbCreatureQuestStarter.Location = new System.Drawing.Point(4, 29);
            this.tbCreatureQuestStarter.Name = "tbCreatureQuestStarter";
            this.tbCreatureQuestStarter.Size = new System.Drawing.Size(1323, 994);
            this.tbCreatureQuestStarter.TabIndex = 3;
            this.tbCreatureQuestStarter.Text = "CREATURE_QUESTSTARTER";
            this.tbCreatureQuestStarter.UseVisualStyleBackColor = true;
            // 
            // tbCreatureQuestEnder
            // 
            this.tbCreatureQuestEnder.Location = new System.Drawing.Point(4, 29);
            this.tbCreatureQuestEnder.Name = "tbCreatureQuestEnder";
            this.tbCreatureQuestEnder.Size = new System.Drawing.Size(1323, 994);
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
            this.menuStrip1.Size = new System.Drawing.Size(1344, 33);
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
            // btnClearQuestTemplateQuery
            // 
            this.btnClearQuestTemplateQuery.Location = new System.Drawing.Point(21, 894);
            this.btnClearQuestTemplateQuery.Name = "btnClearQuestTemplateQuery";
            this.btnClearQuestTemplateQuery.Size = new System.Drawing.Size(348, 85);
            this.btnClearQuestTemplateQuery.TabIndex = 38;
            this.btnClearQuestTemplateQuery.Text = "Clear the Query";
            this.toolTip.SetToolTip(this.btnClearQuestTemplateQuery, "Clear the Query");
            this.btnClearQuestTemplateQuery.UseVisualStyleBackColor = true;
            this.btnClearQuestTemplateQuery.Click += new System.EventHandler(this.btnClearQuestTemplateQuery_Click);
            // 
            // btnGenerateQuestTemplateQuery
            // 
            this.btnGenerateQuestTemplateQuery.Location = new System.Drawing.Point(957, 894);
            this.btnGenerateQuestTemplateQuery.Name = "btnGenerateQuestTemplateQuery";
            this.btnGenerateQuestTemplateQuery.Size = new System.Drawing.Size(348, 85);
            this.btnGenerateQuestTemplateQuery.TabIndex = 37;
            this.btnGenerateQuestTemplateQuery.Text = "Generate SQL Query";
            this.toolTip.SetToolTip(this.btnGenerateQuestTemplateQuery, "Generate the SQL query file.");
            this.btnGenerateQuestTemplateQuery.UseVisualStyleBackColor = true;
            this.btnGenerateQuestTemplateQuery.Click += new System.EventHandler(this.btnGenerateQuestTemplateQuery_Click);
            // 
            // cbSelectAcoreQuestTemplate
            // 
            this.cbSelectAcoreQuestTemplate.AutoSize = true;
            this.cbSelectAcoreQuestTemplate.Location = new System.Drawing.Point(522, 925);
            this.cbSelectAcoreQuestTemplate.Name = "cbSelectAcoreQuestTemplate";
            this.cbSelectAcoreQuestTemplate.Size = new System.Drawing.Size(247, 24);
            this.cbSelectAcoreQuestTemplate.TabIndex = 36;
            this.cbSelectAcoreQuestTemplate.Text = "Select \'acore_world\' database";
            this.toolTip.SetToolTip(this.cbSelectAcoreQuestTemplate, "Check this if you want to create a SQL query that will select the database (meani" +
        "ng you won\'t need to be in the proper DB to import it). Experimental.");
            this.cbSelectAcoreQuestTemplate.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 530);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "SQL Preview";
            // 
            // tbQueryQuestTemplate
            // 
            this.tbQueryQuestTemplate.Location = new System.Drawing.Point(21, 562);
            this.tbQueryQuestTemplate.Multiline = true;
            this.tbQueryQuestTemplate.Name = "tbQueryQuestTemplate";
            this.tbQueryQuestTemplate.ReadOnly = true;
            this.tbQueryQuestTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbQueryQuestTemplate.Size = new System.Drawing.Size(1284, 312);
            this.tbQueryQuestTemplate.TabIndex = 34;
            this.tbQueryQuestTemplate.WordWrap = false;
            // 
            // btnAddQuestToQuery
            // 
            this.btnAddQuestToQuery.Location = new System.Drawing.Point(26, 453);
            this.btnAddQuestToQuery.Name = "btnAddQuestToQuery";
            this.btnAddQuestToQuery.Size = new System.Drawing.Size(1279, 45);
            this.btnAddQuestToQuery.TabIndex = 33;
            this.btnAddQuestToQuery.Text = "Add QUEST to the Query";
            this.toolTip.SetToolTip(this.btnAddQuestToQuery, "Add the quest to the Query");
            this.btnAddQuestToQuery.UseVisualStyleBackColor = true;
            this.btnAddQuestToQuery.Click += new System.EventHandler(this.btnAddQuestToQuery_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(469, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Reward Money (Copper)";
            // 
            // tbQuestMinLevel
            // 
            this.tbQuestMinLevel.Location = new System.Drawing.Point(326, 45);
            this.tbQuestMinLevel.Name = "tbQuestMinLevel";
            this.tbQuestMinLevel.Size = new System.Drawing.Size(130, 26);
            this.tbQuestMinLevel.TabIndex = 29;
            this.toolTip.SetToolTip(this.tbQuestMinLevel, "Min level the player must be to get this quest.");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(322, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Quest Min Level";
            this.toolTip.SetToolTip(this.label15, "Min level the player must be to get this quest.");
            // 
            // tbQuestLevel
            // 
            this.tbQuestLevel.Location = new System.Drawing.Point(173, 45);
            this.tbQuestLevel.Name = "tbQuestLevel";
            this.tbQuestLevel.Size = new System.Drawing.Size(133, 26);
            this.tbQuestLevel.TabIndex = 27;
            this.toolTip.SetToolTip(this.tbQuestLevel, "The Quest level (xp and gold are determined by this and player level)");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(169, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Quest Level";
            this.toolTip.SetToolTip(this.label16, "The Quest level (xp and gold are determined by this and player level)");
            // 
            // tbQuestID
            // 
            this.tbQuestID.Location = new System.Drawing.Point(26, 45);
            this.tbQuestID.Name = "tbQuestID";
            this.tbQuestID.Size = new System.Drawing.Size(133, 26);
            this.tbQuestID.TabIndex = 25;
            this.toolTip.SetToolTip(this.tbQuestID, "The quest ID. Advised to start from 30000.");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Quest ID";
            this.toolTip.SetToolTip(this.label17, "The quest ID. Advised to start from 30000.");
            // 
            // tbQuestRewardMoney
            // 
            this.tbQuestRewardMoney.Location = new System.Drawing.Point(473, 45);
            this.tbQuestRewardMoney.Name = "tbQuestRewardMoney";
            this.tbQuestRewardMoney.Size = new System.Drawing.Size(273, 26);
            this.tbQuestRewardMoney.TabIndex = 40;
            this.tbQuestRewardMoney.Text = "0";
            this.toolTip.SetToolTip(this.tbQuestRewardMoney, "The money reward (expressed in copper).");
            // 
            // labelQuestType
            // 
            this.labelQuestType.AutoSize = true;
            this.labelQuestType.Location = new System.Drawing.Point(902, 48);
            this.labelQuestType.Name = "labelQuestType";
            this.labelQuestType.Size = new System.Drawing.Size(45, 20);
            this.labelQuestType.TabIndex = 45;
            this.labelQuestType.Text = "4096";
            // 
            // cbQuestType
            // 
            this.cbQuestType.FormattingEnabled = true;
            this.cbQuestType.Items.AddRange(new object[] {
            "Daily",
            "Normal"});
            this.cbQuestType.Location = new System.Drawing.Point(763, 43);
            this.cbQuestType.Name = "cbQuestType";
            this.cbQuestType.Size = new System.Drawing.Size(133, 28);
            this.cbQuestType.TabIndex = 44;
            this.cbQuestType.Text = "Daily";
            this.toolTip.SetToolTip(this.cbQuestType, "Select the type of Quest (Daily or Normal)");
            this.cbQuestType.SelectedIndexChanged += new System.EventHandler(this.cbQuestType_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(759, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 20);
            this.label19.TabIndex = 43;
            this.label19.Text = "Quest Type";
            // 
            // tbQuestRewardID1
            // 
            this.tbQuestRewardID1.Location = new System.Drawing.Point(26, 118);
            this.tbQuestRewardID1.Name = "tbQuestRewardID1";
            this.tbQuestRewardID1.Size = new System.Drawing.Size(133, 26);
            this.tbQuestRewardID1.TabIndex = 47;
            this.tbQuestRewardID1.Text = "0";
            this.toolTip.SetToolTip(this.tbQuestRewardID1, "Input the Item ID as reward for this quest.");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 20);
            this.label20.TabIndex = 46;
            this.label20.Text = "Reward Item ID 1";
            this.toolTip.SetToolTip(this.label20, "The quest ID. Advised to start from 30000.");
            // 
            // tbQuestRewardAmount1
            // 
            this.tbQuestRewardAmount1.Location = new System.Drawing.Point(173, 118);
            this.tbQuestRewardAmount1.Name = "tbQuestRewardAmount1";
            this.tbQuestRewardAmount1.Size = new System.Drawing.Size(133, 26);
            this.tbQuestRewardAmount1.TabIndex = 49;
            this.tbQuestRewardAmount1.Text = "0";
            this.toolTip.SetToolTip(this.tbQuestRewardAmount1, "Input the number of items to be rewarded.");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(169, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(137, 20);
            this.label21.TabIndex = 48;
            this.label21.Text = "Reward Amount 1";
            this.toolTip.SetToolTip(this.label21, "The Quet level (xp and gold are determined by this and player level)");
            // 
            // tbQuestRewardAmount2
            // 
            this.tbQuestRewardAmount2.Location = new System.Drawing.Point(473, 118);
            this.tbQuestRewardAmount2.Name = "tbQuestRewardAmount2";
            this.tbQuestRewardAmount2.Size = new System.Drawing.Size(133, 26);
            this.tbQuestRewardAmount2.TabIndex = 53;
            this.tbQuestRewardAmount2.Text = "0";
            this.toolTip.SetToolTip(this.tbQuestRewardAmount2, "Input the number of items to be rewarded.");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(469, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Reward Amount 2";
            this.toolTip.SetToolTip(this.label13, "The Quet level (xp and gold are determined by this and player level)");
            // 
            // tbQuestRewardID2
            // 
            this.tbQuestRewardID2.Location = new System.Drawing.Point(326, 118);
            this.tbQuestRewardID2.Name = "tbQuestRewardID2";
            this.tbQuestRewardID2.Size = new System.Drawing.Size(133, 26);
            this.tbQuestRewardID2.TabIndex = 51;
            this.tbQuestRewardID2.Text = "0";
            this.toolTip.SetToolTip(this.tbQuestRewardID2, "Input the Item ID as reward for this quest.");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(322, 95);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(134, 20);
            this.label22.TabIndex = 50;
            this.label22.Text = "Reward Item ID 2";
            this.toolTip.SetToolTip(this.label22, "The quest ID. Advised to start from 30000.");
            // 
            // tbQuestRewardAmount3
            // 
            this.tbQuestRewardAmount3.Location = new System.Drawing.Point(763, 118);
            this.tbQuestRewardAmount3.Name = "tbQuestRewardAmount3";
            this.tbQuestRewardAmount3.Size = new System.Drawing.Size(133, 26);
            this.tbQuestRewardAmount3.TabIndex = 57;
            this.tbQuestRewardAmount3.Text = "0";
            this.toolTip.SetToolTip(this.tbQuestRewardAmount3, "Input the number of items to be rewarded.");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(759, 95);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 20);
            this.label23.TabIndex = 56;
            this.label23.Text = "Reward Amount 3";
            this.toolTip.SetToolTip(this.label23, "The Quet level (xp and gold are determined by this and player level)");
            // 
            // tbQuestRewardID3
            // 
            this.tbQuestRewardID3.Location = new System.Drawing.Point(616, 118);
            this.tbQuestRewardID3.Name = "tbQuestRewardID3";
            this.tbQuestRewardID3.Size = new System.Drawing.Size(133, 26);
            this.tbQuestRewardID3.TabIndex = 55;
            this.tbQuestRewardID3.Text = "0";
            this.toolTip.SetToolTip(this.tbQuestRewardID3, "Input the Item ID as reward for this quest.");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(612, 95);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 20);
            this.label24.TabIndex = 54;
            this.label24.Text = "Reward Item ID 3";
            this.toolTip.SetToolTip(this.label24, "The quest ID. Advised to start from 30000.");
            // 
            // tbQuestRewardAmount4
            // 
            this.tbQuestRewardAmount4.Location = new System.Drawing.Point(1053, 118);
            this.tbQuestRewardAmount4.Name = "tbQuestRewardAmount4";
            this.tbQuestRewardAmount4.Size = new System.Drawing.Size(133, 26);
            this.tbQuestRewardAmount4.TabIndex = 61;
            this.tbQuestRewardAmount4.Text = "0";
            this.toolTip.SetToolTip(this.tbQuestRewardAmount4, "Input the number of items to be rewarded.");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1049, 95);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(137, 20);
            this.label25.TabIndex = 60;
            this.label25.Text = "Reward Amount 4";
            this.toolTip.SetToolTip(this.label25, "The Quet level (xp and gold are determined by this and player level)");
            // 
            // tbQuestRewardID4
            // 
            this.tbQuestRewardID4.Location = new System.Drawing.Point(906, 118);
            this.tbQuestRewardID4.Name = "tbQuestRewardID4";
            this.tbQuestRewardID4.Size = new System.Drawing.Size(133, 26);
            this.tbQuestRewardID4.TabIndex = 59;
            this.tbQuestRewardID4.Text = "0";
            this.toolTip.SetToolTip(this.tbQuestRewardID4, "Input the Item ID as reward for this quest.");
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(902, 95);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(134, 20);
            this.label26.TabIndex = 58;
            this.label26.Text = "Reward Item ID 4";
            this.toolTip.SetToolTip(this.label26, "The quest ID. Advised to start from 30000.");
            // 
            // tbQuestLogTitle
            // 
            this.tbQuestLogTitle.Location = new System.Drawing.Point(26, 192);
            this.tbQuestLogTitle.Name = "tbQuestLogTitle";
            this.tbQuestLogTitle.Size = new System.Drawing.Size(629, 26);
            this.tbQuestLogTitle.TabIndex = 63;
            this.toolTip.SetToolTip(this.tbQuestLogTitle, "Input the quest title. For example \"Conquer Molten Core\"");
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(22, 169);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 20);
            this.label27.TabIndex = 62;
            this.label27.Text = "Log title";
            this.toolTip.SetToolTip(this.label27, "Input the quest title. For example \"Conquer Molten Core\"");
            // 
            // tbQuestTarget
            // 
            this.tbQuestTarget.Location = new System.Drawing.Point(676, 192);
            this.tbQuestTarget.Name = "tbQuestTarget";
            this.tbQuestTarget.Size = new System.Drawing.Size(629, 26);
            this.tbQuestTarget.TabIndex = 65;
            this.toolTip.SetToolTip(this.tbQuestTarget, "The target of the quest. For example \"Kill the final boss of Molten Core\"");
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(672, 169);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(102, 20);
            this.label28.TabIndex = 64;
            this.label28.Text = "Quest Target";
            this.toolTip.SetToolTip(this.label28, "The target of the quest. For example \"Kill the final boss of Molten Core\"");
            // 
            // tbQuestDescription
            // 
            this.tbQuestDescription.Location = new System.Drawing.Point(26, 252);
            this.tbQuestDescription.Multiline = true;
            this.tbQuestDescription.Name = "tbQuestDescription";
            this.tbQuestDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbQuestDescription.Size = new System.Drawing.Size(629, 93);
            this.tbQuestDescription.TabIndex = 67;
            this.toolTip.SetToolTip(this.tbQuestDescription, "Input the quest full description.");
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(22, 229);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(136, 20);
            this.label29.TabIndex = 66;
            this.label29.Text = "Quest Description";
            this.toolTip.SetToolTip(this.label29, "The full quest text.");
            // 
            // tbQuestCompletionLog
            // 
            this.tbQuestCompletionLog.Location = new System.Drawing.Point(676, 252);
            this.tbQuestCompletionLog.Name = "tbQuestCompletionLog";
            this.tbQuestCompletionLog.Size = new System.Drawing.Size(629, 26);
            this.tbQuestCompletionLog.TabIndex = 69;
            this.toolTip.SetToolTip(this.tbQuestCompletionLog, "The message in the quest log that should appear once the quest is complete. For e" +
        "xample \"Return to Darth Sidious in Stormwind\".");
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(672, 229);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(167, 20);
            this.label30.TabIndex = 68;
            this.label30.Text = "Quest Completion Log";
            this.toolTip.SetToolTip(this.label30, "The message in the quest log that should appear once the quest is complete. For e" +
        "xample \"Return to Darth Sidious in Stormwind\".");
            // 
            // tbRequiredAmountNPC1
            // 
            this.tbRequiredAmountNPC1.Location = new System.Drawing.Point(186, 389);
            this.tbRequiredAmountNPC1.Name = "tbRequiredAmountNPC1";
            this.tbRequiredAmountNPC1.Size = new System.Drawing.Size(133, 26);
            this.tbRequiredAmountNPC1.TabIndex = 73;
            this.tbRequiredAmountNPC1.Text = "0";
            this.toolTip.SetToolTip(this.tbRequiredAmountNPC1, "Input the number of items to be rewarded.");
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(182, 366);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(163, 20);
            this.label34.TabIndex = 72;
            this.label34.Text = "Number of NPC 1 Kills";
            this.toolTip.SetToolTip(this.label34, "The number of NPC to be killed");
            // 
            // tbRequiredNPCID1
            // 
            this.tbRequiredNPCID1.Location = new System.Drawing.Point(26, 389);
            this.tbRequiredNPCID1.Name = "tbRequiredNPCID1";
            this.tbRequiredNPCID1.Size = new System.Drawing.Size(133, 26);
            this.tbRequiredNPCID1.TabIndex = 71;
            this.tbRequiredNPCID1.Text = "0";
            this.toolTip.SetToolTip(this.tbRequiredNPCID1, "Input the NPC ID that needs to be killed.");
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(22, 366);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(164, 20);
            this.label35.TabIndex = 70;
            this.label35.Text = "Required NPC to Kill 1";
            // 
            // tbRequiredAmountNPC2
            // 
            this.tbRequiredAmountNPC2.Location = new System.Drawing.Point(522, 389);
            this.tbRequiredAmountNPC2.Name = "tbRequiredAmountNPC2";
            this.tbRequiredAmountNPC2.Size = new System.Drawing.Size(133, 26);
            this.tbRequiredAmountNPC2.TabIndex = 77;
            this.tbRequiredAmountNPC2.Text = "0";
            this.toolTip.SetToolTip(this.tbRequiredAmountNPC2, "Input the number of items to be rewarded.");
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(518, 366);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(163, 20);
            this.label31.TabIndex = 76;
            this.label31.Text = "Number of NPC 2 Kills";
            this.toolTip.SetToolTip(this.label31, "The number of NPC to be killed");
            // 
            // tbRequiredNPCID2
            // 
            this.tbRequiredNPCID2.Location = new System.Drawing.Point(362, 389);
            this.tbRequiredNPCID2.Name = "tbRequiredNPCID2";
            this.tbRequiredNPCID2.Size = new System.Drawing.Size(133, 26);
            this.tbRequiredNPCID2.TabIndex = 75;
            this.tbRequiredNPCID2.Text = "0";
            this.toolTip.SetToolTip(this.tbRequiredNPCID2, "Input the NPC ID that needs to be killed.");
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(358, 366);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(164, 20);
            this.label32.TabIndex = 74;
            this.label32.Text = "Required NPC to Kill 2";
            // 
            // tbRequiredAmountNPC3
            // 
            this.tbRequiredAmountNPC3.Location = new System.Drawing.Point(848, 389);
            this.tbRequiredAmountNPC3.Name = "tbRequiredAmountNPC3";
            this.tbRequiredAmountNPC3.Size = new System.Drawing.Size(133, 26);
            this.tbRequiredAmountNPC3.TabIndex = 81;
            this.tbRequiredAmountNPC3.Text = "0";
            this.toolTip.SetToolTip(this.tbRequiredAmountNPC3, "Input the number of items to be rewarded.");
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(844, 366);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(163, 20);
            this.label33.TabIndex = 80;
            this.label33.Text = "Number of NPC 3 Kills";
            this.toolTip.SetToolTip(this.label33, "The number of NPC to be killed");
            // 
            // tbRequiredNPCID3
            // 
            this.tbRequiredNPCID3.Location = new System.Drawing.Point(688, 389);
            this.tbRequiredNPCID3.Name = "tbRequiredNPCID3";
            this.tbRequiredNPCID3.Size = new System.Drawing.Size(133, 26);
            this.tbRequiredNPCID3.TabIndex = 79;
            this.tbRequiredNPCID3.Text = "0";
            this.toolTip.SetToolTip(this.tbRequiredNPCID3, "Input the NPC ID that needs to be killed.");
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(684, 366);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(164, 20);
            this.label36.TabIndex = 78;
            this.label36.Text = "Required NPC to Kill 3";
            // 
            // tbRequiredAmountNPC4
            // 
            this.tbRequiredAmountNPC4.Location = new System.Drawing.Point(1172, 389);
            this.tbRequiredAmountNPC4.Name = "tbRequiredAmountNPC4";
            this.tbRequiredAmountNPC4.Size = new System.Drawing.Size(133, 26);
            this.tbRequiredAmountNPC4.TabIndex = 85;
            this.tbRequiredAmountNPC4.Text = "0";
            this.toolTip.SetToolTip(this.tbRequiredAmountNPC4, "Input the number of items to be rewarded.");
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(1168, 366);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(163, 20);
            this.label37.TabIndex = 84;
            this.label37.Text = "Number of NPC 4 Kills";
            this.toolTip.SetToolTip(this.label37, "The number of NPC to be killed");
            // 
            // tbRequiredNPCID4
            // 
            this.tbRequiredNPCID4.Location = new System.Drawing.Point(1012, 389);
            this.tbRequiredNPCID4.Name = "tbRequiredNPCID4";
            this.tbRequiredNPCID4.Size = new System.Drawing.Size(133, 26);
            this.tbRequiredNPCID4.TabIndex = 83;
            this.tbRequiredNPCID4.Text = "0";
            this.toolTip.SetToolTip(this.tbRequiredNPCID4, "Input the NPC ID that needs to be killed.");
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(1008, 366);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(164, 20);
            this.label38.TabIndex = 82;
            this.label38.Text = "Required NPC to Kill 4";
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 1060);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCreatureTemplate)).EndInit();
            this.tbQuestTemplate.ResumeLayout(false);
            this.tbQuestTemplate.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox tbRequiredAmountNPC4;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbRequiredNPCID4;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tbRequiredAmountNPC3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbRequiredNPCID3;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbRequiredAmountNPC2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbRequiredNPCID2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbRequiredAmountNPC1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbRequiredNPCID1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbQuestCompletionLog;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbQuestDescription;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbQuestTarget;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbQuestLogTitle;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbQuestRewardAmount4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbQuestRewardID4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbQuestRewardAmount3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbQuestRewardID3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbQuestRewardAmount2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbQuestRewardID2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbQuestRewardAmount1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbQuestRewardID1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelQuestType;
        private System.Windows.Forms.ComboBox cbQuestType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbQuestRewardMoney;
        private System.Windows.Forms.Button btnClearQuestTemplateQuery;
        private System.Windows.Forms.Button btnGenerateQuestTemplateQuery;
        private System.Windows.Forms.CheckBox cbSelectAcoreQuestTemplate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbQueryQuestTemplate;
        private System.Windows.Forms.Button btnAddQuestToQuery;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbQuestMinLevel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbQuestLevel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbQuestID;
        private System.Windows.Forms.Label label17;
    }
}

