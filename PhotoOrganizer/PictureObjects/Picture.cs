using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoOrganizer.PictureObjects
{
    class Picture
    {
        private int id { get; set; }
        private List<Tag> tags = null;
        private Location location { get; set; }
        private string picPath { get; set; }

        public Picture(int id, Location location, string picPath)
        {
            this.id = id;
            this.location = location;
            this.picPath = picPath;
            this.tags = new List<Tag>();
        }
        
        public Picture(int id, Location location, string picPath, List<Tag> tags)
        {
            this.id = id;
            this.location = location;
            this.picPath = picPath;
            this.tags = tags; 
        }

        public List<Tag> GetTags()
        {
            return tags;
        }

        public void AddTag(Tag tag)
        {
            this.tags.Add(tag);
        }
    }
}
