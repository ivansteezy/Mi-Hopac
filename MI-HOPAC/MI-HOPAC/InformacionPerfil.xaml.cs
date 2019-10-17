﻿using MI_HOPAC.Foundation;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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

namespace MI_HOPAC
{
    /// <summary>
    /// Lógica de interacción para EditalPerfil.xaml
    /// </summary>
    public partial class InformacionPerfil : Page
    {
        public InformacionPerfil()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Selecciona una nueva imagen de perfil.";

            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                        "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                        "Portable Network Graphic (*.png)|*.png";

            if(op.ShowDialog() == true)
            {
                string path = op.FileName;

                var bitmap = new Bitmap(path);
                System.Drawing.Image img = bitmap;

                //Cambiar a directiorio relativo
                img.Save("C:/Users/Iván/Documents/Mi-Hopac/Mi-Hopac/MI-HOPAC/MI-HOPAC/Resources/ProfilePhoto.png", ImageFormat.Png);

                var bitmapImage = new BitmapImage(new Uri(path));
                ProfilePhoto.ImageSource = bitmapImage;
            }
        }

        void SaveImage()
        {
            //Realizar esta tarea en un Thread que no sea de la UI
        }
    }
}
