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
using System.Windows.Shapes;
using MI_HOPAC.MiHomeacupService;

namespace MI_HOPAC
{
    /// <summary>
    /// Lógica de interacción para MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        bool Con = true;
        int Tipo = 2; //De la Base de Datos

        public MainMenu()
        {
            InitializeComponent();
            Consolidate();
        }

        private void Consolidate()
        {
            ButtonOpenMenu.Visibility  = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            profile_Name.Visibility    = Visibility.Collapsed;
            main_Frame.Content         = new NotasBoton();
        }

        private void DoctorMode()
        {
            if (Tipo == 0)
                InventarioHomeopatia.Visibility = Visibility.Collapsed;
            else if (Tipo == 1)
                InventarioAcupuntura.Visibility = Visibility.Collapsed;
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility  = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            profile_Name.Visibility    = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility  = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            profile_Name.Visibility    = Visibility.Collapsed;
        }

        private void Side_Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(side_Menu.SelectedIndex)
            {
                case (int)Pagina.Inicio:
                    main_Frame.Content = new NotasBoton();
                    title.Text = "Inicio";
                    break;
                case (int)Pagina.Calendario:
                    main_Frame.Content = new Agenda();
                    title.Text = "Calendario";
                    break;
                case (int)Pagina.Expedientes:
                    title.Text = "Expedientes";
                    //TO DO: ver mas a detalle la paginacion de las carpetas de expedientes
                    break;
                case (int)Pagina.Eventos:
                    main_Frame.Content = new Eventos();
                    title.Text = "Eventos";
                    break;
                case (int)Pagina.NotasInformativas:
                    main_Frame.Content = new NotasInformativas();
                    title.Text = "Notas informativas";
                    break;
                case (int)Pagina.ForoPrivado:
                    main_Frame.Content = new ForoPrivado();
                    title.Text = "Foro privado";
                    break;
                case (int)Pagina.InventarioHomeopatico:
                    main_Frame.Content = new Inventario();
                    title.Text = "Inventario Homeopatico";
                    break;
                case (int)Pagina.InventarioAcupuntura:
                    main_Frame.Content = new InventarioA();
                    title.Text = "Inventario Acupuntura";
                    break;
            }
        }

        private void Boton_Cuenta_Click(object sender, RoutedEventArgs e)
        {
            //Cargar la pagina de configuracion de perfil
            main_Frame.Content = new InformacionPerfil();
            title.Text = "Editar perfil";
        }

        enum Pagina
        {
            Inicio                = 0x0000,
            Calendario            = 0x0001,
            Expedientes           = 0x0002,
            Eventos               = 0x0003,
            NotasInformativas     = 0x0004,
            ForoPrivado           = 0x0005,
            InventarioHomeopatico = 0x0006,
            InventarioAcupuntura  = 0x0007
        }
    }
}
