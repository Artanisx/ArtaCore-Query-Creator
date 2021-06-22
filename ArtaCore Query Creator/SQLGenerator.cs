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

        const string NPCVENDOR_OPENING_ITEMLINE = "INSERT INTO `npc_vendor` (`entry`, `slot`, `item`, `maxcount`, `incrtime`, `ExtendedCost`, `VerifiedBuild`) VALUES (";
        const string NPCVENDOR_CLOSING_ITEMLINE = ");";

        public static void PreviewSQLQuery(TextBox previewTextBox, ListBox itemIDsListBox, string nPCVendorID, string itemExtendedCostID)
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

        public static void SaveSQLQuery(SaveFileDialog sqlSaveFileDialog, ListBox itemIDsListBox, string nPCVendorID, string itemExtendedCostID)
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
