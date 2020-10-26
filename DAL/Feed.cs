using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL { 

public class Feed
{
    //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
    public string Title { get; set; } //Här har vi skapat Title till podcasten, detta är en node. Behövs bara om vi vill namnge podcasten
    public string Category { get; set; }
    public string aPath { get; set; } // Här har vi skapat Path och den kommer visa vart filen ligger på datorn, detta är en node.
    public int Updateintervall { get; set; } // Här har vi skapat en node som innehåller updateintervall.
    public List<Episode> Episodes { get; set; } // Här har vi skapat en lista med Episode obejct. Den kommer bestå av avsnitt. Detta är en node.



    //public void Add(string theCategory, string selectedFeed)
    //{

    //    var path = Directory.GetCurrentDirectory() + @"\" + theCategory + @"\" + selectedFeed + ".xml";

    //}


    public void Edit(string newLocation, string oldLocation)
    {
        //ändra i en feed
    }
}
}
