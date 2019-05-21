using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageVerificationTool
{
    public partial class IVT : Form
    {
        public IVT()
        {
            InitializeComponent();
            FlagStartup();
            LocationStartup();

        }
        // Initialize Flags
        // List Method
        // Initialize List
        List<string> FlagList = new List<string>
            {
            // Add List items (manually)
                "Reason A",
                "Reason B",
                "Reason C",
                "Reason D",
                "Reason E",
                "Reason F",
                "Reason G",
                "Reason H",
                "Reason I",
                "Reason J",
                "Reason K",
                "Reason L",
                "Reason M",
                "Reason N"
            };
        void FlagStartup()
        {
            // Add each item to the checkListFlags
            foreach (var flag in FlagList)
            {
                CheckedListFlags.Items.Add(flag);
            }
        }

        // Initialize ImageLocations
        List<string> ImageLocationsList = new List<string>
            {
                // Add List items (manually)
                "Location 1",
                "Location 2",
                "Location 3",
                "Location 4",
                "Location 5",
                "Location 6",
                "Location 7",
                "Location 8",
                "Location 9",
                "Location 10",
                "Location 11"
            };
        // Add each item to the checkListFlags
        void LocationStartup()
        {
            foreach (var location in ImageLocationsList)
            {
                ImageLocationComboBox.Items.Add(location);
            }
        }
        // Initialize storage containers
        public static Dictionary<string, List<string>> ImageFlags = new Dictionary<string, List<string>>();
        public static List<string> CheckedFlags = new List<string>();

        // Clear previous output (Image Locations, related Flags, and output text)
        void RefreshCheckedListFlags()
        {
            foreach (int i in CheckedListFlags.CheckedIndices)
            {
                CheckedListFlags.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        void FullRefresh()
        {
            OutputText.Clear();
            ImageLocationComboBox.Text = "";
            RefreshCheckedListFlags();

            CheckedListFlags.Enabled = false;
            Btn_Store.Enabled = false;
        }

        // Create a list containing CheckedFlags based on the CheckedListBox
        List<string> StoreFlags(CheckedListBox CLB, List<string> FlagList)
        {
            // Clear previous list contents
            FlagList.Clear();
            // Update the list contents from new CheckListBox checked boxes
            // Iterate over CheckedListFlags to find the Checked Flags
            foreach (string item in CLB.CheckedItems)
            {
                // Add Flag to the list
                FlagList.Add(item);
            }
            // Return the list of checked flags
            return FlagList;
        }

        private void Btn_Store_Click(object sender, EventArgs e)
        {
            // Update Flags
            StoreFlags(CheckedListFlags, CheckedFlags);

            // Create a temporary list
            List<string> SpecifcFlags = new List<string>(CheckedFlags);

            // Add Dictionary Key/Content Pair
            ImageFlags.Add(ImageLocationComboBox.Text, SpecifcFlags);

            // Remove Key from ImageLocationComboBox
            ImageLocationComboBox.Items.Remove(ImageLocationComboBox.Text);
            //Reset Functionality
            FullRefresh();

            OutputText.AppendText(NameTextBox.Text + " [" + "Image Check" + "] " + "(" + DateTextBox.Text + ")");
            foreach (var contents in ImageFlags.Keys)
            {
                OutputText.AppendText("\r\n" + contents);
                foreach (var listItem in ImageFlags[contents])
                {
                    OutputText.AppendText("\r\n"+"   "+"\u2022 " + listItem);
                }
            }
            OutputText.AppendText("\r\n");

        }


        private void Btn_Print_Click(object sender, EventArgs e)
        {

            // Print Key and Content pair
            OutputText.Clear();

            OutputText.AppendText(NameTextBox.Text + " [" + "Image Check" + "] " + "(" + DateTextBox.Text + ")");
            foreach (var contents in ImageFlags.Keys)
            {
                OutputText.AppendText("\r\n" + contents);
                foreach (var listItem in ImageFlags[contents])
                {
                    OutputText.AppendText("\r\n" + "   " + "\u2022 " + listItem);
                }
            }

        }

        // Button Activation
        private void ImageLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListFlags.Enabled = true;
        }
        private void CheckedListFlags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Btn_Store.Enabled = true;
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            FullRefresh();
            ImageFlags.Clear();
            ImageLocationComboBox.Items.Clear();
            LocationStartup();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(OutputText.Text);
        }

        private void OutputText_TextChanged(object sender, EventArgs e)
        {
            Btn_Copy.Enabled = !string.IsNullOrWhiteSpace(OutputText.Text);
        }
    }


}
