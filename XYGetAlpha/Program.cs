using System.Drawing;

namespace XYGetAlpha
{
    internal static class Program
    {
        static double brightnessThreshold = 0.5;
        public static Boolean highpass = false; // if highpass is false only accept pixels below threshold
        //progress bar
        public static int progress;
        public static int total;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            // C:/Users/henry/OneDrive/Skrivbord/test.png
        }

        public static List<Coord> GetCoordinates(string filepath)
        {
            // Bitmap img = new("C:/Users/henry/OneDrive/Skrivbord/test.png");
            Bitmap img = new(filepath);
            total = img.Width * img.Height;
            List<Coord> coordinateList = new List<Coord>();
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (highpass && pixel.GetBrightness() > brightnessThreshold ||
                        !highpass && pixel.GetBrightness() < brightnessThreshold)
                    {
                        coordinateList.Add(new Coord(i, j));
                    }
                    // increment progress
                    progress++;
                }
            }

            progress = 0;
            return coordinateList;
        }
    }

    internal class Coord
    {
        // coordinate object (used to save coordinates of desired pixels)
        int x;
        int y;
        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override String ToString()
        {
            return ("{" + x + "," + y + "},");
        }
    }
}