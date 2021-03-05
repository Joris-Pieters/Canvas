using System;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Ink;           
using System.Windows.Markup;         
using System.Windows.Input.StylusPlugIns;
using System.Diagnostics;
using Microsoft.Win32;

namespace Canvas
{
     //TODO
     // Save strokes
     // Pencil styles
     // Pan & Zoom

    public partial class InkPadWindow
    {
        int pencilWidth = 5;

        public InkPadWindow()
        {
            this.InitializeComponent();

        }

        private void btnBackWhite_Click(object sender, RoutedEventArgs e)
        {
            inkCanv.Background = new SolidColorBrush(Color.FromRgb(255,255,255));
        }

        private void btnBackBlack_Click(object sender, RoutedEventArgs e)
        {
            inkCanv.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var dlgSave = new SaveFileDialog();
            dlgSave.Filter = "(*.png)|*.png";
            dlgSave.ShowDialog();

            if(dlgSave.FileName != "")
            {
                StrokeTools.SerializeToImage(inkCanv, dlgSave.FileName);
            }
        }

        private void btnFrontWhite_Click(object sender, RoutedEventArgs e)
        {
            var d = new DrawingAttributes();
            d.Color = Color.FromRgb(255, 255, 255);
            d.Width = pencilWidth;
            d.Width = pencilWidth;
            inkCanv.DefaultDrawingAttributes = d;
        }

        private void btnFrontBlack_Click(object sender, RoutedEventArgs e)
        {
            var d = new DrawingAttributes();
            d.Color = Color.FromRgb(0, 0, 0);
            d.Width = pencilWidth;
            d.Width = pencilWidth;
            inkCanv.DefaultDrawingAttributes = d;
        }

        private void btnFrontRed_Click(object sender, RoutedEventArgs e)
        {
            var d = new DrawingAttributes();
            d.Color = Color.FromRgb(255, 0, 0);
            d.Width = pencilWidth;
            d.Width = pencilWidth;
            inkCanv.DefaultDrawingAttributes = d;
        }

        private void btnFrontGreen_Click(object sender, RoutedEventArgs e)
        {
            var d = new DrawingAttributes();
            d.Color = Color.FromRgb(0, 255, 0);
            d.Width = pencilWidth;
            d.Width = pencilWidth;
            inkCanv.DefaultDrawingAttributes = d;
        }

        private void btnFrontBlue_Click(object sender, RoutedEventArgs e)
        {
            var d = new DrawingAttributes();
            d.Color = Color.FromRgb(0, 0, 255);
            d.Width = pencilWidth;
            d.Width = pencilWidth;
            inkCanv.DefaultDrawingAttributes = d;
        }

        private void btnEraser_Click(object sender, RoutedEventArgs e)
        {
            inkCanv.Strokes.Clear();
        }
    }
}


