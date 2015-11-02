using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoOrganizer.PictureObjects;

namespace PhotoOrganizer.ObjectBuilders
{
    class BuildPictureObject
    {
        Location location;
        string picturePath;
        DateTime dateTaken;

        public BuildPictureObject(string picturePath) 
        {
            this.picturePath = picturePath;
            ParsePictureData();
        }

        public void ParsePictureData()
        {
            // get data from picture 
            // location = new LocationBuilder(
        }

    }
}
