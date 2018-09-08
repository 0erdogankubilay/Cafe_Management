using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Cafe_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToShortDateString();
            Reset();
        }

        public void Reset()
        {
            txtBlackFrstCake.Text = "0";
            txtBrownie.Text = "0";
            txtCafeLatte.Text = "0";
            txtCoffeeCake.Text = "0";
            txtCreamCake.Text = "0";
            txtCroissant.Text = "0";
            txtDblEspresso.Text = "0";
            txtEspresso.Text = "0";
            txtIcedCappucino.Text = "0";
            txtLatte.Text = "0";
            txtLemonCake.Text = "0";
            txtMocha.Text = "0";
            txtMuffin.Text = "0";
            txtRedValvetCake.Text = "0";
            txtTeaLatte.Text = "0";
            txtTurkishCoffee.Text = "0";
            txtCostCake.Text = "0";
            txtCostDrink.Text = "0";
            txtSubTotal.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";



        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Are you sure to reset?", "Reset", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                rchtxtReceipt.Clear();
                Reset();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rchtxtReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rchtxtReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rchtxtReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rchtxtReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rchtxtReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rchtxtReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            string path = @"D:\Cikti.txt";
            using (StreamWriter w = File.AppendText(path))
            {
                w.WriteLine(rchtxtReceipt.Text + "----------->>>" + DateTime.Now.ToLongTimeString());
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {

            rchtxtReceipt.Clear();
            rchtxtReceipt.AppendText("\t" + "WELCOME" + Environment.NewLine);
            rchtxtReceipt.AppendText("-----------------------------------------------------------" + Environment.NewLine);
            rchtxtReceipt.AppendText("Latte\t\t\t" + 12 * (Convert.ToInt32(txtLatte.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Espresso\t\t\t" + 14 * (Convert.ToInt32(txtEspresso.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Double Espresso\t\t" + 18 * (Convert.ToInt32(txtDblEspresso.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Cafe Latte\t\t" + 10 * (Convert.ToInt32(txtCafeLatte.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Mocha\t\t\t" + 16 * (Convert.ToInt32(txtMocha.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Tea Latte\t\t\t" + 9 * (Convert.ToInt32(txtTeaLatte.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Turkish Coffee\t\t" + 12 * (Convert.ToInt32(txtTurkishCoffee.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Iced Cappucino\t\t" + 14 * (Convert.ToInt32(txtIcedCappucino.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Coffee Cake\t\t" + 16 * (Convert.ToInt32(txtCoffeeCake.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Red Valvet Cake\t\t" + 18 * (Convert.ToInt32(txtRedValvetCake.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Black Forest Cake\t\t" + 18 * (Convert.ToInt32(txtBlackFrstCake.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Cream Cake\t\t" + 15 * (Convert.ToInt32(txtCreamCake.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Muffin\t\t\t" + 14 * (Convert.ToInt32(txtMuffin.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Lemon Cake\t\t" + 12 * (Convert.ToInt32(txtLemonCake.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Croissant\t\t\t" + 10 * (Convert.ToInt32(txtCroissant.Text)) + ",00" + Environment.NewLine);
            rchtxtReceipt.AppendText("Brownie\t\t\t" + 14 * (Convert.ToInt32(txtBrownie.Text)) + ",00" + Environment.NewLine);
            int total = ((12 * Convert.ToInt32(txtLatte.Text) + 14 * Convert.ToInt32(txtEspresso.Text)+18*Convert.ToInt32(txtDblEspresso.Text)+10*Convert.ToInt32(txtCafeLatte.Text)+16*Convert.ToInt32(txtMocha.Text)+9*Convert.ToInt32(txtTeaLatte.Text)+12*Convert.ToInt32(txtTurkishCoffee.Text)+14*Convert.ToInt32(txtIcedCappucino.Text)+16*Convert.ToInt32(txtCoffeeCake.Text)+18*Convert.ToInt32(txtRedValvetCake.Text)+18*Convert.ToInt32(txtBlackFrstCake.Text)+15*Convert.ToInt32(txtCreamCake.Text)+14*Convert.ToInt32(txtMuffin.Text)+12*Convert.ToInt32(txtLemonCake.Text)+10*Convert.ToInt32(txtCroissant.Text)+14*Convert.ToInt32(txtBrownie.Text)));
            int coffee = (12 * Convert.ToInt32(txtLatte.Text) + 14 * Convert.ToInt32(txtEspresso.Text) + 18 * Convert.ToInt32(txtDblEspresso.Text) + 10 * Convert.ToInt32(txtCafeLatte.Text) + 16 * Convert.ToInt32(txtMocha.Text) + 9 * Convert.ToInt32(txtTeaLatte.Text) + 12 * Convert.ToInt32(txtTurkishCoffee.Text) + 14 * Convert.ToInt32(txtIcedCappucino.Text));
            int cake=( 16 * Convert.ToInt32(txtCoffeeCake.Text) + 18 * Convert.ToInt32(txtRedValvetCake.Text) + 18 * Convert.ToInt32(txtBlackFrstCake.Text) + 15 * Convert.ToInt32(txtCreamCake.Text) + 14 * Convert.ToInt32(txtMuffin.Text) + 12 * Convert.ToInt32(txtLemonCake.Text) + 10 * Convert.ToInt32(txtCroissant.Text) + 14 * Convert.ToInt32(txtBrownie.Text));
            rchtxtReceipt.AppendText("-----------------------------------------------------------" + Environment.NewLine);
            rchtxtReceipt.AppendText("-----------------------------------------------------------" + Environment.NewLine);
            txtTax.Text = (total * 8 / 100).ToString();
            txtSubTotal.Text = (total - total * 8 / 100).ToString();
            txtTotal.Text = total.ToString();
            txtCostCake.Text = cake.ToString();
            txtCostDrink.Text = coffee.ToString();
            rchtxtReceipt.AppendText("Tax:\t\t\t" + txtTax.Text+Environment.NewLine);
            rchtxtReceipt.AppendText("Sub Total\t\t\t" + txtSubTotal.Text+Environment.NewLine);
            rchtxtReceipt.AppendText("Total Cost\t\t\t" + txtTotal.Text +Environment.NewLine);
            rchtxtReceipt.AppendText("------------------------------------------------------------\n\t\tBAN APETITE...\n------------------------------------------------------------"+Environment.NewLine);
            rchtxtReceipt.AppendText(lblDate.Text + "\t\t" + lblTimer.Text + Environment.NewLine);
        }
    }
}
