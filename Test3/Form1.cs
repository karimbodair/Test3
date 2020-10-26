using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DAL;
using System.ServiceModel.Syndication;
using System.ServiceModel;


namespace Test3
{
    public partial class Form1 : Form
    {
        Url_reader urlReader = new Url_reader();
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           var podcast = urlReader.LasaUrl(textBox3.Text);

            string[] listPodcast = { podcast.namn, podcast.antalAvsnitt.ToString(), "", "" };
            ListViewItem lista = new ListViewItem(listPodcast);
            listView1.Items.Add(lista);

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
