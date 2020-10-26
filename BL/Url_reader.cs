using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.ServiceModel.Syndication;
using System.ServiceModel;
#pragma warning disable CS0246 // The type or namespace name 'Test3' could not be found (are you missing a using directive or an assembly reference?)
using DAL;
using System.Linq;
#pragma warning restore CS0246 // The type or namespace name 'Test3' could not be found (are you missing a using directive or an assembly reference?)
namespace BL
{
    public class Url_reader
    {

        public Url_reader()
         {

         }

        public Podcast LasaUrl (string url)
        {
            
                XmlReader FD_readxml = XmlReader.Create(url);
                SyndicationFeed FD_feed = SyndicationFeed.Load(FD_readxml);

            var podcast = new Podcast();

            podcast.namn = FD_feed.Title.Text;

            podcast.antalAvsnitt = FD_feed.Items.Count();

            return podcast;

                
        }
    }
}
