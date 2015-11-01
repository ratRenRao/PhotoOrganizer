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
        private List<Tag> tags = new List<Tag>();
        private Location location { get; set; }
        private string picPath { get; set; }

        public Picture(int id, Location location, string picPath)
        {
            this.id = id;
            this.location = location;
            this.picPath = picPath;
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
