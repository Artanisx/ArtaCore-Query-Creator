﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

                // Fetch the item names
                
                    if (listItemIDsNPCVendor.Items != null)
                    {
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

            
        }

        private void listItemIDsNPCVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbItemNames.SelectedIndex = listItemIDsNPCVendor.SelectedIndex;
        }
    }
}
