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
    public class PodcastController
    {

        public PodcastController()
        {

        }

        public Podcast GetPodcast(string url) 
        {
            XmlReader FD_readxml = XmlReader.Create(url);
            SyndicationFeed stream = SyndicationFeed.Load(FD_readxml);
            var podcast = new Podcast();
            podcast.listOfEpisodes = GetEpisodes(stream);
            podcast.namn = stream.Title.Text;
            podcast.antalAvsnitt = stream.Items.Count();
            return podcast;
        }

        private List<Episodes> GetEpisodes(SyndicationFeed stream)
        {
            var EpisodeList = new List<Episodes>();

            foreach (SyndicationItem item in stream.Items)
            {
                var episode = new Episodes();
                episode.Title = item.Title.Text;
                episode.Description = item.Summary.Text;
                EpisodeList.Add(episode);
            }
            return EpisodeList;
        }
    }
}
