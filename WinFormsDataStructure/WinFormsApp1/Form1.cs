using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;

namespace WinFormsApp1 {
    public partial class Form1 : Form {
        private Quadtree<Box> tree;
        public List<Box> Data { get; set; }
        public Form1() {
            InitializeComponent();
            var file = File.ReadAllText("C:\\Users\\yairsadan\\Source\\Repos\\WinFormsApp1\\TextFile1.txt");
            var data = JsonConvert.DeserializeObject<Quadtree<Box>>(file);
            tree = data;
            Data = tree.GetAll();
            var bindingList = new BindingList<Box>(Data);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }


        private void DeleteCButton_Click(object sender, EventArgs e) {
            ModelManager.DeleteById(DeleteId.Text, tree);
            UpdateTable();
        }

        private void AddSizes_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                // Allow the decimal separator (.)
                if (e.KeyChar != '.') {
                    e.Handled = true; // Ignore the keypress
                }
            }
        }

        private void AddSizes_Leave(object sender, EventArgs e) {

        }
        private void AddValidator() {
            if (double.TryParse(AddHeight.Text, out double value)) {
                // Check if the value is above zero
                if (value <= 0) {
                    MessageBox.Show("Please enter a double value above zero.");
                    AddHeight.Focus();
                }
            } else {
                MessageBox.Show("Please enter a valid double value.");
                AddHeight.Focus();
            }
            if (double.TryParse(AddWidth.Text, out double value1)) {
                // Check if the value is above zero
                if (value1 <= 0) {
                    MessageBox.Show("Please enter a double value above zero.");
                    AddWidth.Focus();
                }
            } else {
                MessageBox.Show("Please enter a valid double value.");
                AddWidth.Focus();
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {
            AddValidator();
            ModelManager.AddABox(AddHeight.Text, AddWidth.Text, tree);
            UpdateTable();
        }
        public void UpdateTable() {
            Data = tree.GetAll();
            var bindingList = new BindingList<Box>(Data);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void BuyButton_Click(object sender, EventArgs e) {
            var result = ModelManager.MakePurchase(BuyWidth.Text, BuyHeight.Text, MaxDifference.Text, tree);
            if (result == null || result.IsDeleted) {
                MessageBox.Show("Could not find a match :( \n Please try different size.");
                return;
            }
            int userAmount = int.MaxValue;
            while (userAmount > result.Count) {
                string input = Interaction.InputBox($"We have a match! \n Height: {result.Height}\n Width: {result.Width} \n Amount: {result.Count} ", "Choose Amount", "1");
                int.TryParse(input, out userAmount);
                if (userAmount <= result.Count) break;
                MessageBox.Show("Choose an amount smaller than the Amount in stock");
            }
            ModelManager.AskTheUserTheAmount(userAmount, result, tree);
            UpdateTable();
            MessageBox.Show("Box Bought Successfully");
        }

        private void DeleteId_Validating(object sender, CancelEventArgs e) {
            int result;
            if (!int.TryParse(DeleteId.Text, out result) || result < 0) {
                e.Cancel = true;
                MessageBox.Show("Please enter a positive whole number.");
            }
        }


        private void MaxDifference_Validating(object sender, CancelEventArgs e) {
            int result;
            if (!int.TryParse(MaxDifference.Text, out result) || result < 0) {
                e.Cancel = true;
                MessageBox.Show("Please enter a positive whole number.");
            }
        }

        private void SaveAndExit_Click(object sender, EventArgs e) {
            var file = JsonConvert.SerializeObject(tree);
            File.WriteAllText("C:\\Users\\yairsadan\\Source\\Repos\\WinFormsApp1\\TextFile1.txt", file);
            Application.Exit();
        }
    }
}