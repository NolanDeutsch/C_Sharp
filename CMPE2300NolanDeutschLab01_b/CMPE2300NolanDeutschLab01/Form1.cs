/******************************************
 * Project: LAb 01 - Decod-a-tron
 * Course:  CMPE2300
 * Author:  Nolan Deutsch
 * Date:    9 30 2015
 * Version: 1.0
 *****************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE2300NolanDeutschLab01
{
    public partial class FormMain : Form
    {
        //initilize the bitmap
        Bitmap bitPic;
        public FormMain()
        {
            InitializeComponent();
        }
      
        private void FormMain_Load(object sender, EventArgs e)
        {
          
        }
        /*********************************************************************
         * Method:      Load Image
         * Arguments:   button click event
         * Returns:     void
         * Description: Load appropriate image from file
         * ******************************************************************/
        private void tsbLoadImage_Click(object sender, EventArgs e)
        {
            //Location where the open file dialog opens
            ofdLoad.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
            //Set filter for type of file to allow to open
            ofdLoad.Filter = "Bitmap (*.bmp)|*.bmp|All Files (*.*)|*.*";                                    
            try
            {
                //If the click event in the dialog is ok do the following
                if (ofdLoad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Convert the picture box image to bitmap
                    bitPic = (Bitmap)Image.FromFile(ofdLoad.FileName);
                    //Set the picture box image to the bitmap      
                    pictureBox.Image = bitPic;                                  
                }
            }
            catch (Exception)
            {
                //If something goes wrong when loading
                MessageBox.Show("Unable to load file", "Load Error");
            }

        }
        /*********************************************************************
         * Method:      Decode Button Click
         * Arguments:   button click event
         * Returns:     void
         * Description: checks which combobox item is selected and calls 
         *                   appropriate method
         * ******************************************************************/
        private void tsbDecodeImage_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox.Text == "Red")
                DecodeRed();
            else if (toolStripComboBox.Text == "Green")
                DecodeGreen();
            else if (toolStripComboBox.Text == "Blue")
                DecodeBlue();
            else if (toolStripComboBox.Text == "All")
                DecodeAll();
        }
        /*********************************************************************
         * Method:      DecodeRed
         * Arguments:   If red combobox is selected
         * Returns:     void
         * Description: find the least sig bit of the pixels in the image and 
         *                  if it is set then set the pixel to red. Alternatly  
         *                  if the bit isn't set then set the pixel to black
         * ******************************************************************/
        private void DecodeRed()
        {
            //Makes copy of bitmap to manipulate
            Bitmap copy = new Bitmap(bitPic);
            double red = 0;
            byte redByte = 0;
            byte mask = 0x01;
            //Itterates through each pixel along x axis
            for (int x = 0; x < bitPic.Width; x++)
                //Looks at each pixel along y axis     
                for (int y = 0; y < bitPic.Height; y++)
                {
                    //Gets the pixel values at the current x and y location
                    Color pixel = bitPic.GetPixel(x, y);
                    //Set individual red colour value to writable variables
                    red = pixel.R;
                    //Converts to byte value for masking
                    redByte = Convert.ToByte(red);
                    //Adds colour value with mask to check if least sig bit is set  
                    if ((byte)(mask & redByte) != 0)
                        //Sets pixel to red
                        copy.SetPixel(x, y, Color.Red);
                    else
                        //Sets pixel to black
                        copy.SetPixel(x, y, Color.Black);
                }
            //Sets picture box to displace the altered bitmap
            pictureBox.Image = copy;
        }
        /*********************************************************************
        * Method:      DecodeGreen
        * Arguments:   If green combobox is selected
        * Returns:     void
        * Description: find the least sig bit of the pixels in the image and 
        *                  if it is set then set the pixel to green. Alternatly  
        *                  if the bit isn't set then set the pixel to black
        * ******************************************************************/
        private void DecodeGreen()
        {
            //Makes copy of bitmap to manipulate
            Bitmap copy = new Bitmap(bitPic);
            double green = 0;
            byte greenByte = 0;
            byte mask = 0x01;
            //Itterates through each pixel along x axis
            for (int x = 0; x < bitPic.Width; x++)
                //Looks at each pixel along y axis     
                for (int y = 0; y < bitPic.Height; y++)
                {
                    //Gets the pixel values at the current x and y location
                    Color pixel = bitPic.GetPixel(x, y);
                    //Set individual green colour value to writable variables
                    green = pixel.G;
                    //Converts to byte value for masking
                    greenByte = Convert.ToByte(green);
                    //Adds colour value with mask to check if least sig bit is set  
                    if ((byte)(mask & greenByte) != 0)
                        //Sets pixel to green
                        copy.SetPixel(x, y, Color.Green);
                    else
                        //Sets pixel to black
                        copy.SetPixel(x, y, Color.Black);
                }
            //Sets picture box to displace the altered bitmap
            pictureBox.Image = copy;
        }
        /*********************************************************************
        * Method:      DecodeBlue
        * Arguments:   If blue combobox is selected
        * Returns:     void
        * Description: find the least sig bit of the pixels in the image and 
        *                  if it is set then set the pixel to blue. Alternatly  
        *                  if the bit isn't set then set the pixel to black
        * ******************************************************************/
        private void DecodeBlue()
        {
            //Makes copy of bitmap to manipulate
            Bitmap copy = new Bitmap(bitPic);
            double blue = 0;
            byte blueByte = 0;
            byte mask = 0x01;
            //Itterates through each pixel along x axis
            for (int x = 0; x < bitPic.Width; x++)
                //Looks at each pixel along y axis     
                for (int y = 0; y < bitPic.Height; y++)
                {
                    //Gets the pixel values at the current x and y location
                    Color pixel = bitPic.GetPixel(x, y);
                    //Set individual blue colour value to writable variables
                    blue = pixel.B;
                    //Converts to byte value for masking
                    blueByte = Convert.ToByte(blue);
                    //Adds colour value with mask to check if least sig bit is set 
                    if ((byte)(mask & blueByte) != 0)
                        //Sets pixel to blue
                        copy.SetPixel(x, y, Color.Blue);
                    else
                        //Sets pixel to black
                        copy.SetPixel(x, y, Color.Black);
                }
            //Sets picture box to displace the altered bitmap
            pictureBox.Image = copy;
        }
        /*********************************************************************
        * Method:      DecodeAll
        * Arguments:   If all combobox is selected
        * Returns:     void
        * Description: find the least sig bit of the pixels in the image and 
        *                  if it is set then set the pixel to a combination of
        *                  the colours. Alternatly  if the bit isn't set then
        *                  set the pixel to black
        * ******************************************************************/
        private void DecodeAll()
        {
            //Makes copy of bitmap to manipulate
            Bitmap copy = new Bitmap(bitPic);
            byte blueByte = 0;
            byte greenByte = 0;
            byte redByte = 0;
            byte mask = 0x01;

            //Itterates through each pixel along x axis
            for (int x = 0; x < bitPic.Width; x++)
                //Looks at each pixel along y axis     
                for (int y = 0; y < bitPic.Height; y++)
                {
                    //Gets the pixel values at the current x and y location
                    Color pixel = bitPic.GetPixel(x, y);
                    //Get writable variables for individual colour bytes
                    blueByte = 0;
                    greenByte = 0;
                    redByte = 0;
                    //Adds colour value with mask to check if least sig bit is set 
                    if ((byte)(mask & pixel.R) != 0)
                        redByte = 255;
                    //Adds colour value with mask to check if least sig bit is set 
                    if ((byte)(mask & pixel.G) != 0)
                        greenByte = 255;
                    //Adds colour value with mask to check if least sig bit is set 
                    if ((byte)(mask & pixel.B) != 0)
                        blueByte = 255;
                    //Sets pixel at the location to a combination of red, green, and blue
                    copy.SetPixel(x, y, Color.FromArgb((int)redByte, (int)greenByte, (int)blueByte));

                }
            //Sets picture box to displace the altered bitmap
            pictureBox.Image = copy;
        }
        /*********************************************************************
        * Method:      Encode Button Click
        * Arguments:   button click event
        * Returns:     void
        * Description: Itterate through each pixel in the image finding the underlying
        *                   message in the set bits
        * ******************************************************************/
        private void tsbEncode_Click(object sender, EventArgs e)
        {
            List<int> encodedPixel = new List<int>();
            Color pixel;
            byte mask = 0x01;
            int counter = 0;
            string charMessage = "";
            //Itterates through each pixel along x axis
            for (int y = 0; y < bitPic.Height; y++)
                //Looks at each pixel along y axis     
                for (int x = 0; x < bitPic.Width; x++)
                {
                    //Gets the pixel values at the current x and y location
                    pixel = bitPic.GetPixel(x, y);
                    //Adding the masked value of the lsb of blue to the list-
                    encodedPixel.Add(pixel.B & mask);
                    //Keeps track of number of data bits
                    counter++;
                    //If you have full bite of data
                    if (counter == 8)
                    {
                        //Check if we are at end of pic message
                        if (EncodeText(encodedPixel) == (char)255)
                        {
                            //Fail out of 2xfor loop
                            y = bitPic.Height;
                            x = bitPic.Width;
                        }
                        else
                            //Converts bites to char and adds to string 
                            charMessage += EncodeText(encodedPixel);
                        //Resets list
                        encodedPixel.Clear();
                        //Resets counter
                        counter = 0;
                    }
                }
            //Show finished message
            MessageBox.Show(charMessage, "This is a caption!");
        }
        /*********************************************************************
        * Method:      EncodeText
        * Arguments:   blue set bit found
        * Returns:     void
        * Description: 
        * ******************************************************************/
        private char EncodeText(List<int> characters)
        {
            byte decode = 0x00;
            //Looks at each bite of data
            for(int index = 0; index < 8; index++)
            {
                //Shifts it 7 minus the location in the bite of data in list
                decode += (byte)(characters[index] << (7 - index));
            }
            //returns decoded character
            return (char)decode;
        }
    }
}
