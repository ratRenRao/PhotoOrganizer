using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Xaml;

namespace PhotoOrganizer.PictureObjects
{
    class PictureData
    {
        private string picturePath;
        private BitmapMetadata metadata = null;

        public PictureData(string picturePath)
        {
            this.picturePath = picturePath;
            GetBitmapMetadata();
        }

        /*
        public Location ParseLocationData()
        {
            return ...;
        }

        public int GetPictureId()
        {
            return ...;
        }

        public List<Tag> GetTags()
        {
            return ...;
        }
        */

        private void GetBitmapMetadata()
        {
            FileInfo f = new FileInfo(picturePath); 
            FileStream fs = new FileStream(f.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
            BitmapSource img = BitmapFrame.Create(fs);
            metadata = (BitmapMetadata)img.Metadata;
        }

        public string GetDate()
        {
            return metadata.DateTaken;
        }

        public string GetFilePath()
        {
            return metadata.Location;
        }

        public string GetLocationTaken()
        {
            Image picture = new Bitmap(@"C:\Users\Brandon\Pictures\2 Months\20141208_152422.jpg");

            //Property Item 0x0002 corresponds to the Date Taken
            PropertyItem propItemRef = picture.GetPropertyItem(1);
            PropertyItem propItem = picture.GetPropertyItem(2);

            //Convert date taken metadata to a DateTime object
            double coordinates = ExifGpsToFloat(propItemRef, propItem);
            return coordinates.ToString();

        /*    string sdate = Encoding.UTF8.GetString(propItem.Value).Trim();
            dtaken = float.Parse(sdate);

            // Get the PropertyItems property from image.
            PropertyItem[] propItems = image.PropertyItems;

            // Set up the display.
            Font font = new Font("Arial", 12);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            int X = 0;
            int Y = 0;

            // For each PropertyItem in the array, display the ID, type, and 
            // length.
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            int count = 0;
            foreach (PropertyItem propItem in propItems)
            {
                dataOutputLabel.Text +=
                    "Property Item " + count.ToString() + ": " + encoding.GetString(propItem.Value).ToString() + "\n"
                    + "iD: 0x" + propItem.Id.ToString("x") + "\n"
                    + "type: " + propItem.Type.ToString() + "\n"
                    + "length: " + propItem.Len.ToString() + " bytes" + "\n\n";

                count++;
            } */
        }

        public static float? GetLatitude(Image targetImg)
        {
            try
            {
                //Property Item 0x0001 - PropertyTagGpsLatitudeRef
                PropertyItem propItemRef = targetImg.GetPropertyItem(1);
                //Property Item 0x0002 - PropertyTagGpsLatitude
                PropertyItem propItemLat = targetImg.GetPropertyItem(2);
                return ExifGpsToFloat(propItemRef, propItemLat);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
        public static float? GetLongitude(Image targetImg)
        {
            try
            {
                ///Property Item 0x0003 - PropertyTagGpsLongitudeRef
                PropertyItem propItemRef = targetImg.GetPropertyItem(3);
                //Property Item 0x0004 - PropertyTagGpsLongitude
                PropertyItem propItemLong = targetImg.GetPropertyItem(4);
                return ExifGpsToFloat(propItemRef, propItemLong);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
        private static float ExifGpsToFloat(PropertyItem propItemRef, PropertyItem propItem)
        {
            uint degreesNumerator = BitConverter.ToUInt32(propItem.Value, 0);
            uint degreesDenominator = BitConverter.ToUInt32(propItem.Value, 4);
            float degrees = degreesNumerator / (float)degreesDenominator;

            uint minutesNumerator = BitConverter.ToUInt32(propItem.Value, 8);
            uint minutesDenominator = BitConverter.ToUInt32(propItem.Value, 12);
            float minutes = minutesNumerator / (float)minutesDenominator;

            uint secondsNumerator = BitConverter.ToUInt32(propItem.Value, 16);
            uint secondsDenominator = BitConverter.ToUInt32(propItem.Value, 20);
            float seconds = secondsNumerator / (float)secondsDenominator;

            float coorditate = degrees + (minutes / 60f) + (seconds / 3600f);
            string gpsRef = System.Text.Encoding.ASCII.GetString(new byte[1] { propItemRef.Value[0] }); //N, S, E, or W
            if (gpsRef == "S" || gpsRef == "W")
                coorditate = 0 - coorditate;
            return coorditate;
        }
    }
}
