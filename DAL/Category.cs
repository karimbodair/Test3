﻿using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    [Serializable]
    public class Category
    {
        //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
        public string Title { get; set; } //Här har vi skapat Title till kategory, detta är en node. 
        public string aPath { get; set; } // Här har vi skapat Path och den kommer visa vart mappen ligger på datorn, detta är en node.
        public List<Podcast> PodcastList { get; set; } // Här har vi skapat en lista med podcast obejct. Den kommer bestå av avsnitt. Detta är en node.



    }
}

