using System;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public static class ImageHelper
    {
        public static void LoadImage(PictureBox element, string image)
        {
            try
            {
                element.Load(image);
            }
            catch (Exception ex)
            {
                element.Load("https://demofree.sirv.com/nope-not-here.jpg");
            }
        }
    }
}
