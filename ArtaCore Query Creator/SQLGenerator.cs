using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArtaCore_Query_Creator
{
    public static class SQLGenerator
    {
        const string NPCVENDOR_OPENINGSTATEMENT = "USE `acore_world`;";
        const string NPCVENDOR_OPENING_ITEMLINE = "INSERT INTO `npc_vendor` (`entry`, `slot`, `item`, `maxcount`, `incrtime`, `ExtendedCost`, `VerifiedBuild`) VALUES (";
        const string NPCVENDOR_CLOSING_ITEMLINE = ");";

        const string CREATURETEMPLATE_OPENING_LINE = "INSERT INTO `creature_template` (`entry`, `difficulty_entry_1`, `difficulty_entry_2`, `difficulty_entry_3`, `KillCredit1`, `KillCredit2`, `modelid1`, `modelid2`, `modelid3`, `modelid4`, `name`, `subname`, `IconName`, `gossip_menu_id`, `minlevel`, `maxlevel`, `exp`, `faction`, `npcflag`, `speed_walk`, `speed_run`, `scale`, `rank`, `mindmg`, `maxdmg`, `dmgschool`, `attackpower`, `DamageModifier`, `BaseAttackTime`, `RangeAttackTime`, `unit_class`, `unit_flags`, `unit_flags2`, `dynamicflags`, `family`, `trainer_type`, `trainer_spell`, `trainer_class`, `trainer_race`, `minrangedmg`, `maxrangedmg`, `rangedattackpower`, `type`, `type_flags`, `lootid`, `pickpocketloot`, `skinloot`, `resistance1`, `resistance2`, `resistance3`, `resistance4`, `resistance5`, `resistance6`, `spell1`, `spell2`, `spell3`, `spell4`, `spell5`, `spell6`, `spell7`, `spell8`, `PetSpellDataId`, `VehicleId`, `mingold`, `maxgold`, `AIName`, `MovementType`, `InhabitType`, `HoverHeight`, `HealthModifier`, `ManaModifier`, `ArmorModifier`, `RacialLeader`, `movementId`, `RegenHealth`, `mechanic_immune_mask`, `flags_extra`, `ScriptName`, `VerifiedBuild`) VALUES (";
        const string CREATURETEMPLATE_CLOSING_LINE = ", 1, 1.14286, 1, 0, 49, 64, 0, 118, 1, 1500, 2000, 1, 512, 2048, 0, 0, 0, 0, 0, 0, 33, 49, 11, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 0, 3, 1, 1.1, 1, 1, 0, 0, 1, 0, 2, '', 12340);";

        public static void PreviewSQLQuery(TextBox previewTextBox, ListBox itemIDsListBox, string nPCVendorID, string itemExtendedCostID, bool selectedDatabase)
        {
            string result;

            // Check if we have all correct data
            if (int.TryParse(nPCVendorID, out int npcVendorID) == false)
            {
                MessageBox.Show("Entered NPC Vendor ID is not valid: " + nPCVendorID);
                return;
            }

            if (int.TryParse(itemExtendedCostID, out int itemCostID) == false)
            {
                MessageBox.Show("Entered Item Cost ID is not valid: " + itemCostID);
                return;
            }

            if (itemIDsListBox.Items.Count <= 0)
            {
                MessageBox.Show("The Listbox for Item IDs is empty and not valid.");
                return;
            }

            if (previewTextBox == null)
            {
                MessageBox.Show("The passed Text Box for the SQL preview is not valid.");
                return;
            }

            result = "";

            if (selectedDatabase == true)
                result += NPCVENDOR_OPENINGSTATEMENT + Environment.NewLine;

            foreach (string item in itemIDsListBox.Items)
            {
                result += NPCVENDOR_OPENING_ITEMLINE;

                result += npcVendorID + ", 0, ";

                result += item + ", 0, 0, ";

                result += itemCostID + ", 0";

                result += NPCVENDOR_CLOSING_ITEMLINE + Environment.NewLine;
            }

            previewTextBox.Text = result;

            MessageBox.Show("SQL preview completed");
        }

        public static void AddtoSQLQueryCreatureTemplate(TextBox queryBox, string npcID, string npcName, string npcSubname, string npcKind)
        {
            string result;

            // Check if we have all correct data
            if (int.TryParse(npcID, out int npcVendorID) == false)
            {
                MessageBox.Show("Entered NPC Vendor ID is not valid: " + npcID);
                return;
            }

            if (string.IsNullOrEmpty(npcName) || string.IsNullOrEmpty(npcSubname) || string.IsNullOrEmpty(npcKind))
            {
                MessageBox.Show("The NPC name or NPC Subname or NPC Kind is not valid.");
                return;
            }                

            if (queryBox == null)
            {
                MessageBox.Show("The passed Text Box for the SQL  is not valid.");
                return;
            }

            result = "";

            result = CREATURETEMPLATE_OPENING_LINE;

            result += npcID + ", 0, 0, 0, 0, 0, 4416, 0, 0, 0, ";

            result += "'" + npcName + "', ";

            result += "'" + npcSubname + "', NULL, 0, 66, 66, 0, 12, ";

            result += npcKind;

            result += CREATURETEMPLATE_CLOSING_LINE + Environment.NewLine;

            queryBox.AppendText(result);

            MessageBox.Show("NPC added to the Query!");
        }

        public static void SaveSQLQuery(SaveFileDialog sqlSaveFileDialog, ListBox itemIDsListBox, string nPCVendorID, string itemExtendedCostID, bool selectedDatabase)
        {
            string result;

            // Check if we have all correct data
            if (int.TryParse(nPCVendorID, out int npcVendorID) == false)
            {
                MessageBox.Show("Entered NPC Vendor ID is not valid: " + nPCVendorID);
                return;
            }

            if (int.TryParse(itemExtendedCostID, out int itemCostID) == false)
            {
                MessageBox.Show("Entered Item Cost ID is not valid: " + itemCostID);
                return;
            }

            if (itemIDsListBox.Items.Count <= 0)
            {
                MessageBox.Show("The Listbox for Item IDs is empty and not valid.");
                return;
            }

            if (sqlSaveFileDialog == null)
            {
                MessageBox.Show("The passed Save Dialog is not valid.");
                return;
            }

            result = "";

            if (selectedDatabase == true)
                result += NPCVENDOR_OPENINGSTATEMENT + Environment.NewLine;

            foreach (string item in itemIDsListBox.Items)
            {
                result += NPCVENDOR_OPENING_ITEMLINE;

                result += npcVendorID + ", 0, ";

                result += item + ", 0, 0, ";

                result += itemCostID + ", 0";

                result += NPCVENDOR_CLOSING_ITEMLINE + Environment.NewLine;
            }

            // Invoke the save dialog
            sqlSaveFileDialog.ShowDialog();

            // Write the sql file
            try
            {
                File.WriteAllText(sqlSaveFileDialog.FileName, result);

                MessageBox.Show("SQL creation completed. Written in file: " + sqlSaveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL creation failed. Error: " + ex.Message);
            }        
        }
    }
}
