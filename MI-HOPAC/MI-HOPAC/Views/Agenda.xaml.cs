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

namespace MI_HOPAC.Views
{
    /// <summary>
    /// Lógica de interacción para Agenda.xaml
    /// </summary>
    public partial class Agenda : Page
    {
        public Agenda()
        {
            InitializeComponent();
        }

        public void Consolidate()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NuevaCitaDialog dlg = new NuevaCitaDialog();
            dlg.ShowDialog();
        }
    }
}
