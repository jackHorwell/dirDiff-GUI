using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;

namespace dirDiff_GUI {
    public partial class dirDiff : Form {
        // Variables to store location of the selected folders
        string folder1;
        string folder2;
        // Variables to store the number of items found
        int itemsShare = 0;
        int itemsDiff = 0;
        // Variable to hold the directory name to move the files to
        string moveTo = "";
        // Boolean to detect weather currently looking for shared or different files
        bool shared;
        // Determines how many files have been copied
        int current;
        // Calculates how far into the operation the program is
        int progress;
        // Variables to help update the UI
        private readonly SynchronizationContext synchronizationContext;
        private DateTime previousTime = DateTime.Now;
        // Determines if a button should say "Select all" or "Deselect all"
        bool allSelected = true;

        public dirDiff() {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current; //context from UI thread
            itemsLbl.Text = "Total items: 0";
        }

        public void sharedOrDifference(bool shared) {
            // Resets counters
            itemsShare = 0;
            itemsDiff = 0;

            // Relabels the text on the button
            selectAllBtn.Text = "Select All";

            // Checks that boxes have a value, otherwise it will not run
            if (folder1TxtBox.Text == "" || folder2TxtBox.Text == "") {
                MessageBox.Show("Oh no... Not all fields are valid!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clears checked list box
            checkedBoxFiles.Items.Clear();

            // Sets value for the location of files
            folder1 = folder1TxtBox.Text;
            folder2 = folder2TxtBox.Text;

            // Determines length of folder path to remove it later
            int folderLength1 = folder1.Length + 1;
            int folderLength2 = folder2.Length + 1;

            // Generates array of all the files in a given directory
            string[] filesInFolder1 = Directory.GetFiles(folder1);
            string[] filesInFolder2 = Directory.GetFiles(folder2);

            // Removes path from all files for comparison
            for (int i = 0; i < filesInFolder1.Length; i++) {
                filesInFolder1[i] = filesInFolder1[i].Substring(folderLength1);
            }
            for (int i = 0; i < filesInFolder2.Length; i++) {
                filesInFolder2[i] = filesInFolder2[i].Substring(folderLength2);
            }

            // Creation of list to store the file names that are shared between both folders
            List<string> sharedFiles = new List<string>();
            List<string> differentFiles = new List<string>();

            // Exits function if there are no files in folder1
            if (filesInFolder1.Length == 0) {
                MessageBox.Show("Oh no... Folder does not contain any files!", "Empty folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Automatically adds all items into differentFiles if no files in folder2
            else if (filesInFolder2.Length == 0) {
                foreach (string file in filesInFolder1) {
                    differentFiles.Add(file);
                    itemsDiff++;
                }
            }
            else {
                // Goes through each file in folder 1 and compares it to each file in
                // folder 2. If they have the same name then it will be added to
                // sharedFiles and the loop will break, if a file gets to the end of
                // the files in folder 2 then it will be marked different and added to differentFiles
                for (int file1 = 0; file1 < filesInFolder1.Length; file1++) {
                    for (int file2 = 0; file2 < filesInFolder2.Length; file2++) {
                        if (filesInFolder1[file1] == filesInFolder2[file2]) {
                            sharedFiles.Add(filesInFolder1[file1]);
                            itemsShare += 1;
                            break;
                        }
                        else if (file2 == filesInFolder2.Length - 1) {
                            differentFiles.Add(filesInFolder1[file1]);
                            itemsDiff += 1;
                        }
                    }
                }
            }

            // Either does the actions for if the shared button was pressed or the difference button
            if (shared) {
                // Adds items to checked list box from sharedFiles then prints how many items were found
                checkedBoxFiles.Items.AddRange(sharedFiles.ToArray());
                itemsLbl.Text = $"Total items: {itemsShare}";
            }
            else {
                // Adds items to checked list box from differentFiles then prints how many items were found
                checkedBoxFiles.Items.AddRange(differentFiles.ToArray());
                itemsLbl.Text = $"Total items: {itemsDiff}";
            }
        }

        // Updates UI at regular intervals
        public void UpdateUI(int progress = 50) {
            var timeNow = DateTime.Now;

            // Refresh every 50ms 
            if ((DateTime.Now - previousTime).Milliseconds <= 50) {
                return;
            }

            // Send the update to UI thread  
            synchronizationContext.Post(new SendOrPostCallback(o => {
                progressBar.Value = (int)o;
                checkedBoxFiles.Items.Remove(0);
            }), progress);

            previousTime = timeNow;
        }

        private void folder1Btn_Click(object sender, EventArgs e) {
            // Opens folder browser dialog and allows user to select a directory path
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                folder1TxtBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void folder2Btn_Click(object sender, EventArgs e) {
            // Opens folder browser dialog and allows user to select a directory path
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK) {
                folder2TxtBox.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void sharedBtn_Click(object sender, EventArgs e) {
            // Calls function to find items that are in both folders
            shared = true;
            sharedOrDifference(shared);
        }

        private void differentBtn_Click(object sender, EventArgs e) {
            // Calls function to find items that are in folder1 but not folder2
            shared = false;
            sharedOrDifference(shared);
        }

        private void selectAllBtn_Click(object sender, EventArgs e) {
            // Calls function to check if the program should select all items
            // or delelect all items
            selectDeselect();
        }

        private void selectDeselect() {
            // Determines weather program should select all items or deselect
            // all items
            allSelected = false;

            if (checkedBoxFiles.CheckedItems.Count == checkedBoxFiles.Items.Count) {
                selectAllBtn.Text = "Select All";
                allSelected = true;
            }
            else {
                selectAllBtn.Text = "Deselect All";
                allSelected = false;
            }

            // Selects all of the items in the checkListBox
            for (int i = 0; i < checkedBoxFiles.Items.Count; i++) {
                checkedBoxFiles.SetItemChecked(i, !allSelected);
            }
        }

        private void moveItemsBtn_Click(object sender, EventArgs e) {
            // List of which files are selected
            List<String> selected = new List<string>();

            // Iterates through each item in the check list box and adds the value
            // to a list 
            for (int i = 0; i < checkedBoxFiles.Items.Count; i++) {
                if (checkedBoxFiles.GetItemChecked(i)) {
                    selected.Add(checkedBoxFiles.Items[i].ToString());
                }
            }

            // Opens folder browser dialog and allows user to select a target folder
            if (folderBrowserDialog3.ShowDialog() == DialogResult.OK) {
                moveTo = folderBrowserDialog3.SelectedPath;
            }

            // Values to determine how the progress nar should look
            current = 0;
            progressBar.Value = 0;

            var backgroundTask = new BackgroundWorker();
            backgroundTask.DoWork += (s, f) => {
                foreach (string file in selected) {
                    // Checks that the file does not already exists
                    // Passes directory location then concatenates the file name onto it
                    // Also passes target directory and concatenates file name
                    if (!File.Exists($"{moveTo}\\{file}")) {
                        File.Copy($"{folder1}\\{file}", $"{moveTo}\\{file}");
                    }

                    // Works out value of the progress bar
                    current += 1;
                    progress = (int)((float)current / selected.Count * 100);

                    // Performs UI update every 50ms
                    UpdateUI(progress);
                }
            };
            backgroundTask.RunWorkerAsync();

            // Clears area to show that it has finished copying files
            // Also sets progress value and total items to zero
            checkedBoxFiles.Items.Clear();
            progressBar.Value = 0;
            itemsLbl.Text = "Total items: 0";
        }
    }
}