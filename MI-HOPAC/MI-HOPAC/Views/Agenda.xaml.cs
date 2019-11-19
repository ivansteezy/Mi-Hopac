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
using MI_HOPAC.MiHomeacupService;
using MI_HOPAC.Foundation;

namespace MI_HOPAC.Views
{
    /// <summary>
    /// Lógica de interacción para Agenda.xaml
    /// </summary>
    public partial class Agenda : Page
    {
        public List<CitaSection> DataCitas { get; set; }
        public Agenda()
        {
            InitializeComponent();
            Consolidate();
        }

        public void Consolidate()
        {
            //Llenamos el listview con las citas
            DataCitas = new List<CitaSection>();

            var client = new MainWebServiceSoapClient();
            var citas = client.GetCitas(UserControl.Pk).ToList();

            foreach(var cita in citas)
            {
                var row = new CitaSection();
                row.Fecha = cita.m_Fecha.ToString();
                row.Paciente = cita.m_Nombre;
                DataCitas.Add(row);
            }

            DataContext = this;
            ListaCitas.ItemsSource = DataCitas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NuevaCitaDialog dlg = new NuevaCitaDialog();
            var client = new MainWebServiceSoapClient();
            
            if (dlg.ShowDialog() == true)
            {
                if (ValidarDisponibilidadDoctor(dlg.Fecha))
                    if (ValidarExistencia(dlg.Fecha))
                        client.InsertCita(dlg.Fecha, dlg.idPaciente, UserControl.Pk);
                    else
                        MessageBox.Show("Este horario ya es ocupado por otra cita!");
                else
                    MessageBox.Show("Tu doctor no puede atenderte en este horario.");
            }

            ListaCitas.ItemsSource = null;
            Consolidate();
        }

        private bool ValidarExistencia(DateTime fechaCita)
        {
            var client = new MainWebServiceSoapClient();
            var list = client.CitasDisponibilidad(fechaCita, UserControl.Pk).ToList();

            return !(list.Count > 0);   //Si la lista contiene alguna cita, entonces no se podra agendar
        }

        public bool ValidarDisponibilidadDoctor(DateTime fecha)
        {
            var client = new MainWebServiceSoapClient();
            var list = client.DoctorDisponible(UserControl.Pk, fecha).ToList();

            return !(list.Count == 0);  //Si la lista no esta vacia el doctor esta disponible    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            var Res = Calendario.SelectedDate;

            var Dia = new DateTime(Calendario.SelectedDate.Value.Year, Calendario.SelectedDate.Value.Month,
                                    Calendario.SelectedDate.Value.Day);

            var client = new MainWebServiceSoapClient();
            client.DeleteCitasDelDia(Dia, UserControl.Pk);

            MessageBox.Show("Citas ELminadas");

            Consolidate();




        }
    }
}
