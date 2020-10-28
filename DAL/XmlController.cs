using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace DAL
{
    class XmlController
    {
        public void Serialize(Podcast podObj)
        {
            XmlSerializer xmlSeralizer = new XmlSerializer(podObj.GetType());
            using (FileStream outFile = new FileStream("PodcastData.xml", FileMode.Create,
                FileAccess.Write)) 
            {
                xmlSeralizer.Serialize(outFile, podObj);
            }

        }

        public Podcast PodcastDeserializer()
        {
            Podcast podcastObjToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Podcast));
            using (FileStream inFile = new FileStream("PodcastData.xml", FileMode.Open,
                FileAccess.Read)) 
            {
                podcastObjToBeReturned = (Podcast)xmlSerializer.Deserialize(inFile);
            }
            return podcastObjToBeReturned;
        }

        public void Serialize(Category categoryObjekt)
        {
            XmlSerializer xmlSeralizer = new XmlSerializer(categoryObjekt.GetType());
            using (FileStream outFile = new FileStream("CategoryData.xml", FileMode.Create,
                FileAccess.Write))
            {
                xmlSeralizer.Serialize(outFile, categoryObjekt);
            }

        }

        public Category CategoryDeserializer()
        {
            Category categoryObjToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Category));
            using (FileStream inFile = new FileStream("CategoryData.xml", FileMode.Open,
                FileAccess.Read))
            {
                categoryObjToBeReturned = (Category)xmlSerializer.Deserialize(inFile);
            }
            return categoryObjToBeReturned;
        }

        public void Serialize(Episodes episodeObjekt)
        {
            XmlSerializer xmlSeralizer = new XmlSerializer(episodeObjekt.GetType());
            using (FileStream outFile = new FileStream("CategoryData.xml", FileMode.Create,
                FileAccess.Write))
            {
                xmlSeralizer.Serialize(outFile, episodeObjekt);
            }

        }

        public Episodes EpisodesDeserializer()
        {
            Episodes episodeObjToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Episodes));
            using (FileStream inFile = new FileStream("EpisodesData.xml", FileMode.Open,
                FileAccess.Read))
            {
                episodeObjToBeReturned = (Episodes)xmlSerializer.Deserialize(inFile);
            }
            return episodeObjToBeReturned;
        }
    }
}
