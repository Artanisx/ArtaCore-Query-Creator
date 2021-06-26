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

        const string QUESTTEMPLATE_OPENINGLINE = "INSERT INTO `quest_template` (`ID`, `QuestType`, `QuestLevel`, `MinLevel`, `QuestSortID`, `QuestInfoID`, `SuggestedGroupNum`, `RequiredFactionId1`, `RequiredFactionId2`, `RequiredFactionValue1`, `RequiredFactionValue2`, `RewardNextQuest`, `RewardXPDifficulty`, `RewardMoney`, `RewardBonusMoney`, `RewardDisplaySpell`, `RewardSpell`, `RewardHonor`, `RewardKillHonor`, `StartItem`, `Flags`, `RequiredPlayerKills`, `RewardItem1`, `RewardAmount1`, `RewardItem2`, `RewardAmount2`, `RewardItem3`, `RewardAmount3`, `RewardItem4`, `RewardAmount4`, `ItemDrop1`, `ItemDropQuantity1`, `ItemDrop2`, `ItemDropQuantity2`, `ItemDrop3`, `ItemDropQuantity3`, `ItemDrop4`, `ItemDropQuantity4`, `RewardChoiceItemID1`, `RewardChoiceItemQuantity1`, `RewardChoiceItemID2`, `RewardChoiceItemQuantity2`, `RewardChoiceItemID3`, `RewardChoiceItemQuantity3`, `RewardChoiceItemID4`, `RewardChoiceItemQuantity4`, `RewardChoiceItemID5`, `RewardChoiceItemQuantity5`, `RewardChoiceItemID6`, `RewardChoiceItemQuantity6`, `POIContinent`, `POIx`, `POIy`, `POIPriority`, `RewardTitle`, `RewardTalents`, `RewardArenaPoints`, `RewardFactionID1`, `RewardFactionValue1`, `RewardFactionOverride1`, `RewardFactionID2`, `RewardFactionValue2`, `RewardFactionOverride2`, `RewardFactionID3`, `RewardFactionValue3`, `RewardFactionOverride3`, `RewardFactionID4`, `RewardFactionValue4`, `RewardFactionOverride4`, `RewardFactionID5`, `RewardFactionValue5`, `RewardFactionOverride5`, `TimeAllowed`, `AllowableRaces`, `LogTitle`, `LogDescription`, `QuestDescription`, `AreaDescription`, `QuestCompletionLog`, `RequiredNpcOrGo1`, `RequiredNpcOrGo2`, `RequiredNpcOrGo3`, `RequiredNpcOrGo4`, `RequiredNpcOrGoCount1`, `RequiredNpcOrGoCount2`, `RequiredNpcOrGoCount3`, `RequiredNpcOrGoCount4`, `RequiredItemId1`, `RequiredItemId2`, `RequiredItemId3`, `RequiredItemId4`, `RequiredItemId5`, `RequiredItemId6`, `RequiredItemCount1`, `RequiredItemCount2`, `RequiredItemCount3`, `RequiredItemCount4`, `RequiredItemCount5`, `RequiredItemCount6`, `Unknown0`, `ObjectiveText1`, `ObjectiveText2`, `ObjectiveText3`, `ObjectiveText4`, `VerifiedBuild`) VALUES (";
        const string QUESTTEMPLATE_CLOSINGLINE = ", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, NULL, NULL, NULL, NULL, 12340);";

        const string QUESTSTARTER_OPENINGLINE = "INSERT INTO `creature_queststarter` (`id`, `quest`) VALUES (";
        const string QUESTSTARTER_CLOSINGLINE = ");";

        const string QUESTENDER_OPENINGLINE = "INSERT INTO `creature_questender` (`id`, `quest`) VALUES (";
        const string QUESTENDER_CLOSINGLINE = ");";

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

            //MessageBox.Show("NPC added to the Query!");
        }

        public static void AddtoSQLQueryQuestTemplate(TextBox queryBox, string questID, string questLevel, string questMinLevel, string questRewardMoney, string questType, string rewardItem1, string rewardAmount1,
                                                    string rewardItem2, string rewardAmount2, string rewardItem3, string rewardAmount3, string rewardItem4, string rewardAmount4,
                                                    string questLogtitle, string questTarget, string questDescription, string questCompletionlog, 
                                                    string requiredNPC1, string requiredNPCAmount1, string requiredNPC2, string requiredNPCAmount2, string requiredNPC3, string requiredNPCAmount3, string requiredNPC4, string requiredNPCAmount4)
        {
            string result;

            // Check if we have all correct data
            if (int.TryParse(questID, out int questIDNumber) == false)
            {
                MessageBox.Show("Entered Quest ID is not valid: " + questID);
                return;
            }

            if (int.TryParse(questLevel, out int questLevelNum) == false)
            {
                MessageBox.Show("Entered Quest Level is not valid: " + questLevel);
                return;
            }

            if (int.TryParse(questMinLevel, out int questMinLevelNum) == false)
            {
                MessageBox.Show("Entered Quest Min Level is not valid: " + questMinLevel);
                return;
            }

            if (int.TryParse(questRewardMoney, out int questRewardMoneyNum) == false)
            {
                MessageBox.Show("Entered Quest Reward Money is not valid: " + questRewardMoney);
                return;
            }

            if (questType != "4096" && questType != "8")
            {
                MessageBox.Show("Entered Quest Type not valid: " + questType);
                return;
            }

            if (int.TryParse(rewardItem1, out int rewardItem1Num) == false ||
                int.TryParse(rewardItem2, out int rewardItem2Num) == false ||
                int.TryParse(rewardItem3, out int rewardItem3Num) == false ||
                int.TryParse(rewardItem4, out int rewardItem4Num) == false ||
                int.TryParse(rewardAmount1, out int rewardAmount1Num) == false ||
                int.TryParse(rewardAmount2, out int rewardAmount2Num) == false ||
                int.TryParse(rewardAmount3, out int rewardAmount3Num) == false ||
                int.TryParse(rewardAmount4, out int rewardAmount4Num) == false)
            {
                MessageBox.Show("Entered Quest reward items or amount are not valid!");
                return;
            }

            if (int.TryParse(requiredNPC1, out int requiredNPC1num) == false ||
                int.TryParse(requiredNPC2, out int requiredNPC2num) == false ||
                int.TryParse(requiredNPC3, out int requiredNPC3num) == false ||
                int.TryParse(requiredNPC4, out int requiredNPC4num) == false ||
                int.TryParse(requiredNPCAmount1, out int requiredNPCAmount1num) == false ||
                int.TryParse(requiredNPCAmount2, out int requiredNPCAmount2num) == false ||
                int.TryParse(requiredNPCAmount3, out int requiredNPCAmount3num) == false ||
                int.TryParse(requiredNPCAmount4, out int requiredNPCAmount4num) == false)
            {
                MessageBox.Show("Entered Quest target ids or amount are not valid!");
                return;
            }


            if (string.IsNullOrEmpty(questLogtitle) || string.IsNullOrEmpty(questTarget) || string.IsNullOrEmpty(questDescription) || string.IsNullOrEmpty(questCompletionlog))
            {
                MessageBox.Show("The Quest Log Title, Quest Target, Quest Description or Quest Completion Log are not valid.");
                return;
            }

            // remove new lines in the questlogtitle
            questLogtitle = questLogtitle.Replace(Environment.NewLine, "");

            // remove new lines in the questTarget
            questTarget = questTarget.Replace(Environment.NewLine, "");

            // remove new lines in the questCompletionlog
            questCompletionlog = questCompletionlog.Replace(Environment.NewLine, "");

            // replaces newlines in the questDescription with the correct characters  "$b$b"
            questDescription = questDescription.Replace(Environment.NewLine, "$b$b");

            if (queryBox == null)
            {
                MessageBox.Show("The passed Text Box for the SQL  is not valid.");
                return;
            }

            // SON QUI

            result = "";

            result = QUESTTEMPLATE_OPENINGLINE;

            result += questID + ", 2, ";

            result += questLevel + ", " + questMinLevel + ", -284, 0, 0, 0, 0, 0, 0, 0, 4, ";

            result += questRewardMoney + ", 0, 0, 0, 0, 0, 0, ";

            result += questType + ", 0, ";

            result += rewardItem1 + ", " + rewardAmount1 + ", ";
            result += rewardItem2 + ", " + rewardAmount2 + ", ";
            result += rewardItem3 + ", " + rewardAmount3 + ", ";
            result += rewardItem4 + ", " + rewardAmount4 + ", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, ";

            result += "'" + questLogtitle + "', ";

            result += "'" + questTarget + "', ";

            result += "'" + questDescription + "', NULL, ";

            result += "'" + questCompletionlog + "', ";

            result += requiredNPC1 + ", " + requiredNPC2 + ", " + requiredNPC3 + ", " + requiredNPC4 + ", ";

            result += requiredNPCAmount1 + ", " + requiredNPCAmount2 + ", " + requiredNPCAmount3 + ", " + requiredNPCAmount4;

            result += QUESTTEMPLATE_CLOSINGLINE + Environment.NewLine;

            queryBox.AppendText(result);

            //MessageBox.Show("NPC added to the Query!");
        }

        public static void AddtoSQLQueryQuestStarter(TextBox queryBox, string npcID, string questID)
        {
            string result;

            // Check if we have all correct data
            if (int.TryParse(npcID, out int npcIDnum) == false)
            {
                MessageBox.Show("Entered NPC ID is not valid: " + npcID);
                return;
            }

            if (int.TryParse(questID, out int questIDNum) == false)
            {
                MessageBox.Show("Entered Quest ID is not valid: " + questID);
                return;
            }           

            if (queryBox == null)
            {
                MessageBox.Show("The passed Text Box for the SQL is not valid.");
                return;
            }

            result = "";

            result = QUESTSTARTER_OPENINGLINE;

            result += npcID + ", ";

            result += questID;

            result += QUESTSTARTER_CLOSINGLINE + Environment.NewLine;

            queryBox.AppendText(result);

            //MessageBox.Show("NPC added to the Query!");
        }

        public static void AddtoSQLQueryQuestEnder(TextBox queryBox, string npcID, string questID)
        {
            string result;

            // Check if we have all correct data
            if (int.TryParse(npcID, out int npcIDnum) == false)
            {
                MessageBox.Show("Entered NPC ID is not valid: " + npcID);
                return;
            }

            if (int.TryParse(questID, out int questIDNum) == false)
            {
                MessageBox.Show("Entered Quest ID is not valid: " + questID);
                return;
            }

            if (queryBox == null)
            {
                MessageBox.Show("The passed Text Box for the SQL is not valid.");
                return;
            }

            result = "";

            result = QUESTENDER_OPENINGLINE;

            result += npcID + ", ";

            result += questID;

            result += QUESTENDER_CLOSINGLINE + Environment.NewLine;

            queryBox.AppendText(result);

            //MessageBox.Show("NPC added to the Query!");
        }

        public static void SaveSQLQueryQuestStarter(SaveFileDialog sqlSaveFileDialog, TextBox query, bool selectedDatabase)
        {
            string result;

            if (string.IsNullOrEmpty(query.Text) || query.Text.Length <= 10)
            {
                MessageBox.Show("The query is empty or invalid!");
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

            result += query.Text;

            sqlSaveFileDialog.FileName = "Quest_Starter";

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

        public static void SaveSQLQueryQuestEnder(SaveFileDialog sqlSaveFileDialog, TextBox query, bool selectedDatabase)
        {
            string result;

            if (string.IsNullOrEmpty(query.Text) || query.Text.Length <= 10)
            {
                MessageBox.Show("The query is empty or invalid!");
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

            result += query.Text;

            sqlSaveFileDialog.FileName = "Quest_Ender";

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

        public static void SaveSQLQueryQuestTemplate(SaveFileDialog sqlSaveFileDialog, TextBox query, bool selectedDatabase)
        {
            string result;

            if (string.IsNullOrEmpty(query.Text) || query.Text.Length <= 10)
            {
                MessageBox.Show("The query is empty or invalid!");
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

            result += query.Text;

            sqlSaveFileDialog.FileName = "Quest_Template";

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

        public static void SaveSQLQueryCreatureTemplate(SaveFileDialog sqlSaveFileDialog, TextBox query, bool selectedDatabase)
        {
            string result;

            if (string.IsNullOrEmpty(query.Text) || query.Text.Length <= 10)
            {
                MessageBox.Show("The query is empty or invalid!");
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

            result += query.Text;

            sqlSaveFileDialog.FileName = "Creature_Template";

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

            sqlSaveFileDialog.FileName = "NPCVendor_Items";

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
