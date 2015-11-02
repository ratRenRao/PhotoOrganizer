using PhotoOrganizer.PictureObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PhotoOrganizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.SetScrollState(1, true);
            InitializeComponent();
            DisplayData();
            this.Refresh();
            this.Show();
        }

        public void DisplayData()
        {
            PictureData pictureData = new PictureData(@"C:\Users\Brandon\Pictures\2 Months\20141208_152422.jpg");
            dataOutputLabel.Text += pictureData.GetDate().ToString() + "\n";
            dataOutputLabel.Text += pictureData.GetLocationTaken().ToString();

/*
            // Create an Image object. 
            Image image = new Bitmap(@"C:\Users\Brandon\Pictures\2 Months\20141208_152422.jpg"); 

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
            }
             */
        }

        private void dataOutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
