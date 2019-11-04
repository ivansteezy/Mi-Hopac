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

namespace MI_HOPAC.Views
{
    /// <summary>
    /// Lógica de interacción para InventarioAcupunturaDialog.xaml
    /// </summary>
    public partial class InventarioAcupunturaDialog : Window
    {
        public InventarioAcupunturaDialog(string message)
        {
            InitializeComponent();
            Message.Text = message;
        }

        public InventarioAcupunturaDialog(string message, string mensaje, string nombre, int cantidad, int potencia)
        {
            InitializeComponent();
            Message.Text = message;
            txtNombre.Text = nombre;
            txtCantidad.Text = cantidad.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDatos())
                this.DialogResult = true;
            else
                MessageBox.Show("Completa todos los campos!");
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        public bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCantidad.Text))
                return false;
            else
                return true;
        }

        public string Nombre { get { return txtNombre.Text; } set { txtNombre.Text = value; } }
        public string Cantidad { get { return txtCantidad.Text; } set { txtCantidad.Text = value; } }
    }
}