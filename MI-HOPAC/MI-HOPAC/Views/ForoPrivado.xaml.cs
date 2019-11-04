﻿using MI_HOPAC.Foundation;
using MI_HOPAC.MiHomeacupService;
using System;
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
    /// Lógica de interacción para ForoPrivado.xaml
    /// </summary>
    public partial class ForoPrivado : Page
    {
        public ForoPrivado()
        {
            InitializeComponent();
            Imprimir();
        }


        private void Imprimir()
        {
            List<Foro> publicaciones = GetForo();

            if (publicaciones.Count > 0)
            {
                ListViewForo.ItemsSource = publicaciones;
            }
        }

        private List<Foro> GetForo()
        {

            MiHomeacupService.MainWebServiceSoapClient client = new MainWebServiceSoapClient();

            //Consultamos las notas
            var result = client.GetForoPrivado(UserControl.Pk);
            List<Foro> publicaciones = new List<Foro>();

            //Para cada nota de la base de datos, lo pasasmos a una lista para imprimr.
            foreach (MiHomeacupService.ForoPrivadoModel i in result)
            {
                string nombre = i.m_Nombre + i.m_Apellidos;
                var publicacion = new Foro(i.m_IdCForoPrivado, i.m_Texto, nombre, i.m_Fecha);
                //Lo aniadimos a la lista
                publicaciones.Add(publicacion);
            }

            //Retornamos la lista con las notas para imprimir
            return publicaciones;

        }


    }
}