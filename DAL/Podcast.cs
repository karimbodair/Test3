using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Podcast
    {
        public string namn { get; set; }

        public int antalAvsnitt { get; set; }

        public string kategori { get; set; }

        public int frekvens { get; set; }

        public List<Episode> listOfEpisodes { get; set; }
        //lista episode (title, desc)
    }
}
