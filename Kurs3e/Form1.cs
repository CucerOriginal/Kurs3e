using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kurs3e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bank bank = new Bank(4);
        DateTime time;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            if (ClientNewName.Text == "" || !int.TryParse(BasicSum.Text, out int a))
            {
                MessageBox.Show("Введите корректные данные");
            }
            else
            {
                time = new DateTime(dateClientTime.Value.Year, dateClientTime.Value.Month, dateClientTime.Value.Day);
                bank.AddClient(ClientNewName.Text, Convert.ToInt32(BasicSum.Text), time);
                OperNameClient.Items.Add(ClientNewName.Text);
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            bank.DeleteClient();
            OperNameClient.Items.RemoveAt(0);
        }

        private void PopoltinSumButton_Click(object sender, EventArgs e)
        {
            if (OperNameClient.Text == "" || !int.TryParse(SumOper.Text, out int a))
            {
                MessageBox.Show("Введите корректные данные");
            }
            else
            {
                time = new DateTime(dateOperTime.Value.Year, dateOperTime.Value.Month, dateOperTime.Value.Day);
                bank.Search(OperNameClient.Text).AddOperation(Convert.ToInt32(SumOper.Text), time);
            }
        }

        private void SnatSumButton_Click(object sender, EventArgs e)
        {
            if (OperNameClient.Text == "" || !int.TryParse(SumOper.Text, out int a))
            {
                MessageBox.Show("Введите корректные данные");
            }
            else
            {
                time = new DateTime(dateOperTime.Value.Year, dateOperTime.Value.Month, dateOperTime.Value.Day);
                bank.Search(OperNameClient.Text).AddOperation(-Convert.ToInt32(SumOper.Text), time);
            }
        }

        private void DeleteOperButton_Click(object sender, EventArgs e)
        {
            if (OperNameClient.Text == "")
            {
                MessageBox.Show("Введите корректные данные");
            }
            else
            {
                time = new DateTime(dateOperTime.Value.Year, dateOperTime.Value.Month, dateOperTime.Value.Day);
                bank.Search(OperNameClient.Text).DelOpereation(time);
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (Convert.ToBoolean(saveFileDialog.ShowDialog()))
            {
                using (FileStream fs = (FileStream)saveFileDialog.OpenFile())
                {
                    bank.Save(fs);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
