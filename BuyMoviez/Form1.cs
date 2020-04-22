using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyMoviez
{
    public partial class selectWinner : Form
    {
        public selectWinner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random winner = new Random();
            int i = listBox1.Items.Count;
            int chosenItem = winner.Next(0, i);

            listBox1.SelectedIndex = chosenItem;

            MessageBox.Show("The winner is: " + listBox1.SelectedItem.ToString());

        }
    }
}
