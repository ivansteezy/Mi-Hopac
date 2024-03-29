﻿using System;
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

namespace MI_HOPAC
{
    /// <summary>
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();


            Imprimir();

            List<Nota> notas = GetNotas();

            if (notas.Count > 0)
            {
                ListViewNotas.ItemsSource = notas;
            }
        }

        private void Imprimir()
        {

            

        }

        private List<Nota> GetNotas()
        {

            return new List<Nota>()
            {
                new Nota("laskdjalksdjlañskdjlaskd", "#ff9aa2", 1),
                new Nota("hsdfdsfgsdfg", "#ffdac1", 2),
                new Nota("fshjfgjhdfgn", "#f7f7b7", 3),
                new Nota("asdfsbrfsdfv", "#e2f0cb", 4),
                new Nota("jrtyjfhjfgnwfgwef", "#b5ead7", 5),
                new Nota("zxczdagadg", "#c7ceea", 6),         
        };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            var pk = ((MI_HOPAC.Nota)((System.Windows.FrameworkElement)sender).DataContext).Id;

            var color = ((MI_HOPAC.Nota)((System.Windows.FrameworkElement)sender).DataContext).Color;



            if(color == "#ff9aa2")  
                ((MI_HOPAC.Nota)((System.Windows.FrameworkElement)sender).DataContext).Color = "#ffdac1";        
            else if(color == "#ffdac1")
                ((MI_HOPAC.Nota)((System.Windows.FrameworkElement)sender).DataContext).Color = "#f7f7b7";
            else if (color == "#f7f7b7")
                ((MI_HOPAC.Nota)((System.Windows.FrameworkElement)sender).DataContext).Color = "#e2f0cb";
            else if (color == "#e2f0cb")
                ((MI_HOPAC.Nota)((System.Windows.FrameworkElement)sender).DataContext).Color = "#b5ead7";
            else if (color == "#b5ead7")
                ((MI_HOPAC.Nota)((System.Windows.FrameworkElement)sender).DataContext).Color = "#c7ceea";
            else if (color == "#c7ceea")
                ((MI_HOPAC.Nota)((System.Windows.FrameworkElement)sender).DataContext).Color = "#ff9aa2";


            ((MI_HOPAC.Nota)((System.Windows.FrameworkElement)sender).DataContext).Change = 1;


            ListViewNotas.Items.Refresh();


        }



    }
}
