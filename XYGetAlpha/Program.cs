using System.Drawing;
using System.Text;

namespace XYGetAlpha
{
    internal static class Program
    {
        static double brightnessThreshold = 0.5;
        public static Boolean highpass = false; // if highpass is false only accept pixels below threshold
        //progress bar
        public static int pixelsProcessedInImage;
        public static int totalPixelsInImage;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static Bitmap GetBitmapFromFilepath(string filepath)
        {
            Bitmap img = new(filepath);
            int imgWidth = img.Width;
            int imgHeight = img.Height;
            totalPixelsInImage = imgWidth * imgHeight;
            return img;
        }

        public static StringBuilder GetCoordinatesOfImage(Bitmap img)
        {
            // init
            StringBuilder coordinatesOutputSB = new StringBuilder();

            // processing
            if (highpass)
                getHighpassedCoordinates(img, coordinatesOutputSB);
            else
                getLowpassedCoordinates(img, coordinatesOutputSB);

            // finished
            pixelsProcessedInImage = 0;
            return coordinatesOutputSB;
        }

        private static void getLowpassedCoordinates(Bitmap img, StringBuilder coordinatesOutputSB)
        {
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    if (img.GetPixel(i, j).GetBrightness() <= brightnessThreshold) // lowpass
                    {
                        coordinatesOutputSB.Append("{" + i + "," + j + "}");
                    }
                    pixelsProcessedInImage++;
                }
            }
        }

        private static void getHighpassedCoordinates(Bitmap img, StringBuilder coordinatesOutputSB)
        {
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (pixel.GetBrightness() >= brightnessThreshold) // highpass
                    {
                        coordinatesOutputSB.Append("{" + i + "," + j + "}");
                    }
                    pixelsProcessedInImage++;
                }
            }
        }
    }
}