using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtaCore_Query_Creator
{
    public static class SQLGenerator
    {
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

            result = "This is just a test" + Environment.NewLine;
            foreach (string item in itemIDsListBox.Items)
            {
                result += "<Oggetto: " + item + " aggiunto a " + npcVendorID + " con costo " + itemCostID + ">" + Environment.NewLine;
            }

            previewTextBox.Text = result;

            MessageBox.Show("SQL preview completed");
        }
    }
}
