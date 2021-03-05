using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media.Imaging;

namespace Canvas
{
    public static class StrokeTools
    {
        public static void SerializeToImage(InkCanvas inkCanv, string fileOut)
        {
            //render InkCanvas to a RenderBitmapTarget  
            RenderTargetBitmap rtb = new RenderTargetBitmap((int)inkCanv.ActualWidth, (int)inkCanv.ActualHeight, 
                                                96, 96, System.Windows.Media.PixelFormats.Default);
            rtb.Render(inkCanv);

            //endcode as PNG  
            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(rtb));
            using (var fs = new FileStream(fileOut, FileMode.Create))
            {
                encoder.Save(fs);
            }
        }
        
    }
}
