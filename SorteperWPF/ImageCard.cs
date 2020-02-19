using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SorteperWPF
{
    class ImageCard
    {

        public BitmapImage BitmapInIt(string cardName)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\marc3763\source\repos\Sorteper WPF\SorteperWPF\Assets\" + cardName +".png");
            bitmap.EndInit();
            return bitmap;
        }
    }
}
