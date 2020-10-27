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
            kategoriList.SelectedItems[0].Remove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           var podcast = urlReader.LasaUrl(textBox3.Text);

            string[] listPodcast = { podcast.namn, podcast.antalAvsnitt.ToString(), "", "" };
            ListViewItem lista = new ListViewItem(listPodcast);
            podcastList.Items.Add(lista);

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nyKategori = textBox2.Text.Trim();
            if (nyKategori.Length != 0)
            {
                comboBox2.Items.Add(nyKategori);
                kategoriList.Items.Add(nyKategori);
            }
            textBox2.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = kategoriList.SelectedItems[0];
            }

        private void avsnittList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }