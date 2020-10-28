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
using System.ServiceModel.Syndication;
using System.ServiceModel;


namespace Test3
{
    public partial class Form1 : Form
    {

        private string podname;


        PodcastController urlReader = new PodcastController();
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kategoriList.SelectedItems[0].Remove();
        }

        private void button_Click_Add(object sender, EventArgs e)
        {
            var podcast = PodcastController.GetPodcast(textBox3.Text);
            string[] listPodcast = { podcast.namn, podcast.antalAvsnitt.ToString(), "", "" };
            ListViewItem list = new ListViewItem(listPodcast);
            podcastList.Items.Add(list);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nyKategori = textBox2.Text.Trim();
            if (nyKategori.Length != 0)
            {
                kategoriBox.Items.Add(nyKategori);
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
            var podcastItem = avsnittList.SelectedItems;
            beskrivningList.Clear();

            if (avsnittList.SelectedItems.Count == 1)
            {
                var firstSelectedItem = avsnittList.SelectedItems[0].Text;
                podname = firstSelectedItem;
                var stream = urlReader.GetPodcast(textBox3.Text);
                //Gör ett urvarl från steamen där title är samma som den vi valt från Ui:et och välj ut desctription.
                var description = stream.listOfEpisodes.Where(x => x.Title == firstSelectedItem).Select(x => x.Description).FirstOrDefault();
                beskrivningList.Items.Add(description);
            }
        }

        private void podcastList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var podcastItem = podcastList.SelectedItems;
            avsnittList.Clear();

            if (podcastList.SelectedItems.Count == 1)
            {
                var firstSelectedItem = podcastList.SelectedItems[0].Text;
                podname = firstSelectedItem;
                var stream = urlReader.GetPodcast(textBox3.Text);
                if (stream.namn.Equals(firstSelectedItem))
                {
                    foreach (var item in stream.listOfEpisodes)
                    {
                        avsnittList.Items.Add(item.Title);
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void beskrivningList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBeskrivning.Text = "";
            txtBeskrivning.Text = PodcastController.GETPERSONDETAILSBYNAME(avsnittList.SelectedItem.ToString());
        }
    }
}