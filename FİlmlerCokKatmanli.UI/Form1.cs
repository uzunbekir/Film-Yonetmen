using FilmlerCokKatmanli.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FİlmlerCokKatmanli.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilmlerRepository fr = new FilmlerRepository();
        YonetmenlerRepository yr = new YonetmenlerRepository();
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = yr.SelectAll();
            comboBox1.DisplayMember = "Yonetmenadisoyadi";
            comboBox1.ValueMember = "YonetmenID";

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int Id = (int)comboBox1.SelectedValue;
            //listBox1.DataSource = fr.SelectBySupplierId(Id);
            //listBox1.DisplayMember = "Filmadi";
            //dataGridView1.DataSource = fr.SelectBySupplierId(Id);
            ListViewItem lst = new ListViewItem();
            foreach (var item in fr.SelectBySupplierId(Id))
            {
                lst.Text = item.FilmAdi;
            }
            listView1.Items.Add(lst);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
