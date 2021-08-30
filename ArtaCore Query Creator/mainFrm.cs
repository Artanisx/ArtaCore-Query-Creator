using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtaCore_Query_Creator
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.ItemExtendedCosts' table. You can move, or remove it, as needed.
            this.itemExtendedCostsTableAdapter.Fill(this.databaseDataSet.ItemExtendedCosts);
            // TODO: This line of code loads data into the 'databaseDataSet.NPCVendors' table. You can move, or remove it, as needed.
            this.nPCVendorsTableAdapter.Fill(this.databaseDataSet.NPCVendors);

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpNPCVendor)
            {
                // We're trying to paste into the ITEM IDs Listbox of the NPC Vendor Creator.
                try
                {
                    // Get the data from the clipboard
                    string s = Clipboard.GetText();

                    // Prase each text as a new line/item
                    string[] lines = s.Split('\n');                     

                    // Clear the listbox
                    listItemIDsNPCVendor.Items.Clear();

                    foreach (string line in lines)
                    {
                        if (int.TryParse(line, out int itemID))
                            listItemIDsNPCVendor.Items.Add(line.Trim());
                        else
                            continue;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }

                // Fetch the item names if enabled
                if (cbEnableItemNameFetching.Checked == true)
                {
                    if (listItemIDsNPCVendor.Items != null)
                    {
                        // Clear the listbox
                        lbItemNames.Items.Clear();

                        foreach (string item in listItemIDsNPCVendor.Items)
                        {
                            try
                            {
                                string selectedItem = item.ToString();

                                WebClient x = new WebClient();
                                string source = x.DownloadString("https://wotlkdb.com/?item=" + selectedItem);
                                string itemName = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;

                                string[] itemNames = itemName.Split('-');

                                itemName = itemNames[0];

                                lbItemNames.Items.Add(itemName.Trim());
                            }
                            catch (WebException ex)
                            {
                                MessageBox.Show("Error! One of the Item IDs cannot be found.", "Error in one of the IDs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lbItemNames.Items.Add("Item not found!");
                            }
                        }
                    }
                }
                else                    
                    lbItemNames.Items.Clear();
            }            
        }

        private void listItemIDsNPCVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItemNames.Items.Count == listItemIDsNPCVendor.Items.Count)
                lbItemNames.SelectedIndex = listItemIDsNPCVendor.SelectedIndex;
        }

        private void lbItemNames_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (lbItemNames.Items[e.Index].ToString() == "Item not found!")
                e.Graphics.DrawString(lbItemNames.Items[e.Index].ToString(), lbItemNames.Font, Brushes.Red, e.Bounds);
            else
                e.Graphics.DrawString(lbItemNames.Items[e.Index].ToString(), lbItemNames.Font, Brushes.Black, e.Bounds);
        }

        private void lbItemNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItemNames.Items.Count == listItemIDsNPCVendor.Items.Count)
                listItemIDsNPCVendor.SelectedIndex = lbItemNames.SelectedIndex;
        }

        private void btnPreviewNPCVendorQuery_Click(object sender, EventArgs e)
        {
            SQLGenerator.PreviewSQLQuery(tbNPCVendorPreview, listItemIDsNPCVendor, labVendorID.Text, labItemCostID.Text, chkUseAcoreWorld.Checked);
        }

        private void btnGenerateNPCVendorQuery_Click(object sender, EventArgs e)
        {
            SQLGenerator.SaveSQLQuery(sqlSaveDialog, listItemIDsNPCVendor, labVendorID.Text, labItemCostID.Text, chkUseAcoreWorld.Checked);
        }

        private void btnUpdateNPCDatabase_Click(object sender, EventArgs e)
        {
            // Update the database with changes.           

            int success = this.nPCVendorsTableAdapter.Update(databaseDataSet.NPCVendors);

            if (success == 0)
                MessageBox.Show("Error while saving internal NPC Vendors database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Internal NPC Vendors database saved succesfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgCreatureTemplate.Refresh();            
        }

        private void cbNPCType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNPCType.SelectedItem.ToString() == "Vendor")
                labelNPCType.Text = "128";
            else if (cbNPCType.SelectedItem.ToString() == "Quest Giver")
                labelNPCType.Text = "130";
            else
                labelNPCType.Text = "Not recognized";
        }

        private void btnClearQueryCreatureTemplate_Click(object sender, EventArgs e)
        {
            txtSQLPreviewCreatureTemplate.Text = String.Empty;
        }

        private void bntAddNPC_Click(object sender, EventArgs e)
        {
            if (!cboxNewFormat.Checked)
                SQLGenerator.AddtoSQLQueryCreatureTemplate(txtSQLPreviewCreatureTemplate, txtNPCIDCreatureTemplate.Text, txtNPCNAMECreatureTemplate.Text, txtNPCSUBNAMECreatureTemplate.Text, labelNPCType.Text);
            else
                SQLGenerator.AddtoSQLQueryCreatureTemplateNEW(txtSQLPreviewCreatureTemplate, txtNPCIDCreatureTemplate.Text, txtNPCNAMECreatureTemplate.Text, txtNPCSUBNAMECreatureTemplate.Text, labelNPCType.Text);
        }

        private void btnAddQueryCreaturesToInternalDB_Click(object sender, EventArgs e)
        {
            string query = txtSQLPreviewCreatureTemplate.Text;

            string[] npcs = query.Split(';');

            foreach (string NPC in npcs)
            {
                if (NPC.Length <= 10)
                    continue;


                // NPC ID
                int first = NPC.IndexOf("VALUES (") + "VALUES (".Length;
                int last = NPC.LastIndexOf(", 0, 0, 0, 0, 0, 4416, 0, 0, 0, ");

                string NPCID = NPC.Substring(first, last - first);

                if (int.TryParse(NPCID, out int NPCIDINT) == false)
                {
                    MessageBox.Show("NPC ID is invalid.");
                    continue;
                }                

                // NPC NAME
                first = NPC.IndexOf(", 0, 0, 0, 0, 0, 4416, 0, 0, 0, ") + ", 0, 0, 0, 0, 0, 4416, 0, 0, 0, ".Length;                

                string NPCNAME = NPC.Substring(first, 50);

                NPCNAME = NPCNAME.Split(',')[0];

                NPCNAME = NPCNAME.Remove(0, 1);
                NPCNAME = NPCNAME.Remove(NPCNAME.Length -1, 1);

                string connection = Properties.Settings.Default.databaseConnectionString;

                OleDbConnection oleConnection1 = new OleDbConnection(connection);

                OleDbCommand cmd = new OleDbCommand();
                
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "INSERT INTO NPCVENDORS (NPC_ID, NPC_NAME) VALUES (" + NPCIDINT + ", " + NPCNAME + ")";
                //cmd.CommandText = "INSERT INTO NPCVendors ('NPC ID', 'NPC NAME') VALUES(" + NPCIDINT + ", " + NPCNAME + ")";

                cmd.CommandText = "insert into NPCVendors ([NPC ID],[NPC NAME]) values (?,?)";
                cmd.Parameters.AddWithValue("@npcid", NPCIDINT);
                cmd.Parameters.AddWithValue("@npcname", NPCNAME);

                cmd.Connection = oleConnection1;

                oleConnection1.Open();
                cmd.ExecuteNonQuery();
                oleConnection1.Close();
                                
                nPCVendorsTableAdapter.Update(databaseDataSet.NPCVendors);
                this.nPCVendorsTableAdapter.Fill(this.databaseDataSet.NPCVendors);
                dgCreatureTemplate.Refresh();
            }

            MessageBox.Show("Query imported into the internal Database.");
        }

        private void btnGenerateCreatureTemplateQuery_Click(object sender, EventArgs e)
        {
            SQLGenerator.SaveSQLQueryCreatureTemplate(sqlSaveDialog, txtSQLPreviewCreatureTemplate, cbSelectAcoreCreatureTemplate.Checked);
        }

        private void cbQuestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQuestType.SelectedItem.ToString() == "Daily")
                labelQuestType.Text = "4096";
            else if (cbQuestType.SelectedItem.ToString() == "Normal")
                labelQuestType.Text = "8";
            else
                labelQuestType.Text = "Not recognized";
        }

        private void btnAddQuestToQuery_Click(object sender, EventArgs e)
        {
            SQLGenerator.AddtoSQLQueryQuestTemplate(tbQueryQuestTemplate, tbQuestID.Text, tbQuestLevel.Text, tbQuestMinLevel.Text, tbQuestRewardMoney.Text,
                                                    labelQuestType.Text, tbQuestRewardID1.Text, tbQuestRewardAmount1.Text, tbQuestRewardID2.Text, tbQuestRewardAmount2.Text,
                                                    tbQuestRewardID3.Text, tbQuestRewardAmount3.Text, tbQuestRewardID4.Text, tbQuestRewardAmount4.Text, tbQuestLogTitle.Text,
                                                    tbQuestTarget.Text, tbQuestDescription.Text, tbQuestCompletionLog.Text, tbRequiredNPCID1.Text, tbRequiredAmountNPC1.Text,
                                                    tbRequiredNPCID2.Text, tbRequiredAmountNPC2.Text, tbRequiredNPCID3.Text, tbRequiredAmountNPC3.Text, tbRequiredNPCID4.Text,
                                                    tbRequiredAmountNPC4.Text);

            if (cbAutoGenerateStarterEnder.Checked)
            {
                // We need to create the QuestStarter and Ender for this quest as well.

                SQLGenerator.AddtoSQLQueryQuestStarter(tbQueryQuestStarter, labelNPCID_QuestTemplate.Text, tbQuestID.Text);                                
                SQLGenerator.AddtoSQLQueryQuestEnder(tbQueryBoxQuestEnder, labelNPCID_QuestTemplate.Text, tbQuestID.Text);


                //MessageBox.Show("Relevant queries have been added for this quest in the CREATURE_QUESTSTARTER and CREATURE_QUESTENDER pages. Make sure to generate the SQL file for those, going in their respective tabs.", "Quest Starter and Quest Ender queries added", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }

        }

        private void btnGenerateQuestTemplateQuery_Click(object sender, EventArgs e)
        {
            if (cbAutoGenerateStarterEnder.Checked == false)
            {
                // Simply generate the SQL Query for QUest Tempalte only
                SQLGenerator.SaveSQLQueryQuestTemplate(sqlSaveDialog, tbQueryQuestTemplate, cbSelectAcoreQuestTemplate.Checked);
            }
            else
            {
                // In theory we have queries ready for Quest Starter and QUest ENder too!

                // First gnerate tghe QuestTeamplte query
                SQLGenerator.SaveSQLQueryQuestTemplate(sqlSaveDialog, tbQueryQuestTemplate, cbSelectAcoreQuestTemplate.Checked);

                if (string.IsNullOrEmpty(tbQueryQuestStarter.Text) == false)
                {
                    // QuestStarter query can be created!
                    SQLGenerator.SaveSQLQueryQuestStarter(sqlSaveDialog, tbQueryQuestStarter, cbSelectAcoreQueryStarter.Checked);

                    if (string.IsNullOrEmpty(tbQueryBoxQuestEnder.Text) == false)
                    {
                        // QuestEnder query can be created
                        SQLGenerator.SaveSQLQueryQuestEnder(sqlSaveDialog, tbQueryBoxQuestEnder, cbSelectAcoreQUestEnder.Checked);
                    }
                    else
                    {
                        MessageBox.Show("You have selected 'Automatically generate the QuestStarter and QuestEnder queries as well.', but it looks like the QuestEnder query has not been created. Did you check the box AFTER adding the Quest?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("You have selected 'Automatically generate the QuestStarter and QuestEnder queries as well.', but it looks like the QuestStarter query has not been created. Did you check the box AFTER adding the Quest?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClearQuestTemplateQuery_Click(object sender, EventArgs e)
        {
            tbQueryQuestTemplate.Text = "";
        }

        private void btnAddNPCtoQueryStarter_Click(object sender, EventArgs e)
        {
            SQLGenerator.AddtoSQLQueryQuestStarter(tbQueryQuestStarter, labelNPCIDQuestStarter.Text, tbQuestIDQuestStarter.Text);
        }

        private void btnGenerateQueryQuestStarter_Click(object sender, EventArgs e)
        {
            SQLGenerator.SaveSQLQueryQuestStarter(sqlSaveDialog, tbQueryQuestStarter, cbSelectAcoreQueryStarter.Checked);
        }

        private void btnClearQueryQuestStarter_Click(object sender, EventArgs e)
        {
            tbQueryQuestStarter.Text = "";
        }

        private void btnGenerateQueryQuestEnder_Click(object sender, EventArgs e)
        {
            SQLGenerator.SaveSQLQueryQuestEnder(sqlSaveDialog, tbQueryBoxQuestEnder, cbSelectAcoreQUestEnder.Checked);
        }

        private void btnAddQuestEnder_Click(object sender, EventArgs e)
        {
            SQLGenerator.AddtoSQLQueryQuestEnder(tbQueryBoxQuestEnder, labelNPCIDEnder.Text, tbQuestIDEnder.Text);
        }

        private void aboutArtaCoreQueryCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ArtaCore Query Creator is a small utility made with the purpose of making database changes, like creating quests, npcs and vendors as painless as possible, automatically generating SQL queries which can be safely imported into the acore_world database of an AzerothCore server.\n\nThis program has been written by Fabrizio Tobia.", "ArtaCore Query Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void convertCreatureTemplateSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This will:

            /**
             * This will:
             * 1) Open a file browser to select a SQL to convert
             * 2) Check if the file needs conversion at all
             * 3) Copy and replace la parte che genera la tabela fino a "VALUES (" con il nuovo formato che è:
             *    INSERT INTO `creature_template` (`entry`, `difficulty_entry_1`, `difficulty_entry_2`, `difficulty_entry_3`, `KillCredit1`, `KillCredit2`, `modelid1`, `modelid2`, `modelid3`, `modelid4`, `name`, `subname`, `IconName`, `gossip_menu_id`, `minlevel`, `maxlevel`, `exp`, `faction`, `npcflag`, `speed_walk`, `speed_run`, `detection_range`, `scale`, `rank`, `dmgschool`, `DamageModifier`, `BaseAttackTime`, `RangeAttackTime`, `BaseVariance`, `RangeVariance`, `unit_class`, `unit_flags`, `unit_flags2`, `dynamicflags`, `family`, `trainer_type`, `trainer_spell`, `trainer_class`, `trainer_race`, `type`, `type_flags`, `lootid`, `pickpocketloot`, `skinloot`, `PetSpellDataId`, `VehicleId`, `mingold`, `maxgold`, `AIName`, `MovementType`, `InhabitType`, `HoverHeight`, `HealthModifier`, `ManaModifier`, `ArmorModifier`, `ExperienceModifier`, `RacialLeader`, `movementId`, `RegenHealth`, `mechanic_immune_mask`, `spell_school_immune_mask`, `flags_extra`, `ScriptName`, `VerifiedBuild`) VALUES (
               4) Estrarre il valore NPCID "VALUES(XXXXXXXXXX)" dal file old
               5) Estrarre il nome "VALUES (700000, 0, 0, 0, 0, 0, 4416, 0, 0, 0, 'XXXXXXX', " dal file old
               6) Estrarre il subname  "VALUES (700000, 0, 0, 0, 0, 0, 4416, 0, 0, 0, '', 'XXXXXXXXXXX', " dal file old
               7) Estrarre il numero 130 (quest giver), 128 npoc vendor  "VALUES (700000, 0, 0, 0, 0, 0, 4416, 0, 0, 0, 'Yoh Asakura', 'Vanilla Dungeon Quests', NULL, 0, 66, 66, 0, 12, XXXXXXXXX, " dal file old

             * */
            string oldQuery = "";

            oldQuery = SQLGenerator.OpenSQLQuery(sqlOpenFileDialog);

            string fullQuery = SQLGenerator.ConvertSQLQueryCreatureTemplate(oldQuery);
            
            SQLGenerator.SaveSQLQueryCreatureTemplate(sqlSaveDialog, fullQuery, true);
        }
    }
}
