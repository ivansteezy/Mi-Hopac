﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService.Models;
using WebService.Controllers;
using WebService.Configurations;

namespace WebService
{
    /// <summary>
    /// Descripción breve de MainWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MainWebService : System.Web.Services.WebService
    {
        #region CuentaDoctores
        [WebMethod]
        public List<CuentaDoctoresModel> GetCuentaDoctores(string correo, string contrasena)
        {
            var controlador = new CuentaDoctoresController();
            return controlador.ConsultaCuentaDoctores(correo, contrasena);
        }

        [WebMethod]
        public List<CuentaDoctoresModel> GetCuentaDoctoresById(int pk)
        {
            var controlador = new CuentaDoctoresController();
            return controlador.ConsultaCuentaDoctoresById(pk);
        }

        [WebMethod]
        public void DeleteCuentaDoctores(int pk)
        {
            var controlador = new CuentaDoctoresController();
            controlador.EliminarCuentadoctores(pk);
        }

        [WebMethod]
        public int InsertCuentaDoctores(string nombre, string appellidos, string Correo, string Contrasena, int Medicina)
        {
            var controlador = new CuentaDoctoresController();
            var res = controlador.InsertaCuentaDoctor(nombre, appellidos, Correo, Contrasena, Medicina);
            return res;
        }
        #endregion

        #region CuentaPacientes
        [WebMethod]
        public List<CuentaPacientesModel> GetCuentaPacientes(int pk)
        {
            var controlador = new CuentaPacientesController();
            return controlador.ConsultaCuentaPacientes(pk);
        }

        [WebMethod]
        public void DeleteCuentaPacientes(int pk)
        {
            var controlador = new CuentaPacientesController();
            controlador.EliminarCuentaPacientes(pk);
        }
        #endregion

        #region Pacientes
        [WebMethod]
        public List<PacienteModel> GetPacientes(int fk)
        {
            var controlador = new PacienteController();
            return controlador.ConsultaPacientes(fk);
        }
        #endregion

        #region Dias
        [WebMethod]
        public List<DiasModel> GetDias(int pk)
        {
            var controlador = new DiasController();
            return controlador.ConsultaDias(pk);
        }
        #endregion

        #region Doctores
        [WebMethod]
        public List<DoctoresModel> GetDoctores(int pk)
        {
            var controlador = new DoctoresControllers();
            return controlador.ConsultaDoctores(pk);
        }

        [WebMethod]
        public void DeleteDoctores(int pk)
        {
            var controlador = new DoctoresControllers();
            controlador.EliminarDoctores(pk);
        }

        [WebMethod]
        public void UpdateDoctres(int pk, string ubicacion = "", long cedula = 0)
        {
            var controlador = new DoctoresControllers();
            controlador.ActualizarDoctores(pk, ubicacion, cedula);
        }

        #endregion

        #region Eventos
        [WebMethod]
        public List<EventosModel> GetEventos(int pk)
        {
            var controlador = new EventosController();
            return controlador.ConsultaEvento(pk);
        }

        [WebMethod]
        public List<EventosModel> GetEventosByName(string name)
        {
            var controlador = new EventosController();
            return controlador.ConsultaEvento(name);
        }

        [WebMethod]
        public void DeleteEventos(int pk)
        {
            var controlador = new EventosController();
            controlador.EliminarEvento(pk);
        }

        [WebMethod]
        public void InsertEventos(string nombre, DateTime fecha, string ubicacion, string guia, int fkDoctor)
        {
            var controlador = new EventosController();
            controlador.InsertarEvento(nombre, fecha, ubicacion, guia, fkDoctor);
        }

        [WebMethod]
        public void UpdateEventos(int pk, string nombre)
        {
            var controlador = new EventosController();
            controlador.ActualizarEvento(pk, nombre);
        }
        #endregion

        #region NotasDigitales
        [WebMethod]
        public List<NotasDigitalesModel> GetNotasDig(int fk)
        {
            var controlador = new NotasDigitalesController();
            return controlador.ConsultaNotasDig(fk);
        }

        [WebMethod]
        public void DeleteNotaDig(int pk)
        {
            var controlador = new NotasDigitalesController();
            controlador.EliminarNotaDig(pk);
        }

        [WebMethod]
        public void InsertNotaDig(string texto, string color, int fkDoctor)
        {
            var controlador = new NotasDigitalesController();
            controlador.InsertarNotaDig(texto, color, fkDoctor);
        }

        [WebMethod]
        public void UpdateNotaDig(int pk, string texto, string color)
        {
            var controlador = new NotasDigitalesController();
            controlador.ActualizarNota(pk, texto, color);
        }
        #endregion

        #region NotasInformativas
        [WebMethod]
        public List<NotasInformativasModel> GetNotasInfo(int fk)
        {
            var controlador = new NotasInformativasController();
            return controlador.ConsultaNotasInfo(fk);
        }

        [WebMethod]
        public void DeleteNotaInfo(int pk)
        {
            var controlador = new NotasInformativasController();
            controlador.EliminarNotaInfo(pk);
        }

        [WebMethod]
        public void InsertNotaInfo(string titulo, string texto, string link, int fkDoctor)
        {
            var controlador = new NotasInformativasController();
            controlador.InsertarNotaInfo(titulo, texto, link, fkDoctor);
        }

        [WebMethod]
        public void UpdateNotaInfo(int pk, string titulo, string texto, string link)
        {
            var controlador = new NotasInformativasController();
            controlador.ActualizarNotaInfo(pk, titulo, texto, link);
        }
        #endregion

        #region Inventario Homeopatia
        [WebMethod]
        public List<InventarioHomeopatiaModel> GetInventarioHomeopatia(int pk)
        {
            var controlador = new InventarioHomeopatiaController();
            return controlador.ConsultaInventarioHomeopatia(pk);
        }

        [WebMethod]
        public void DeleteInventarioHomeopatia(int pk)
        {
            var controlador = new InventarioHomeopatiaController();
            controlador.EliminarInventarioHomeopatia(pk);
        }

        [WebMethod]
        public void InsertInventarioHomeopatia(string nombre, int potencia, int cantidad, int fkDoctor)
        {
            var controlador = new InventarioHomeopatiaController();
            controlador.InsertarInvetarioHomeopatia(nombre, potencia, cantidad, fkDoctor);
        }

        [WebMethod]
        public void UpdateInventarioHomeopatia(string nombre, int potencia, int cantidad, int pk)
        {
            var controlador = new InventarioHomeopatiaController();
            controlador.ActualizarInventarioHomeopatia(nombre, potencia, cantidad, pk);
        }
        #endregion

        #region Inventario Acupuntura

        [WebMethod]
        public List<InventarioAcupunturaModel> GetInventarioAcupuntura(int pk)
        {
            var controlador = new InventarioAcupunturaController();
            return controlador.ConsultaInventarioAcupuntura(pk);
        }

        [WebMethod]
        public void DeleteInventarioAcupuntura(int pk)
        {
            var controlador = new InventarioAcupunturaController();
            controlador.EliminarInventarioAcupuntura(pk);
        }

        [WebMethod]
        public void InsertInventarioAcupuntura(string nombre, int cantidad, int fkDoctor)
        {
            var controlador = new InventarioAcupunturaController();
            controlador.InsertarInvetarioAcupuntura(nombre, cantidad, fkDoctor);
        }

        [WebMethod]
        public void UpdateInventarioAcupuntura(string nombre, int cantidad, int pk)
        {
            var controlador = new InventarioAcupunturaController();
            controlador.ActualizarInventarioAcupuntura(nombre, cantidad, pk);
        }
        #endregion

        #region Citas
        [WebMethod]
        public List<CitasPacientesModel> GetCitas(int fkDoctor)
        {
            var controlador = new CitasPacientesController();
            return controlador.ConsultaCitas(fkDoctor);
        }

        [WebMethod]
        public void InsertCita(DateTime fecha, int fkPaciente, int fkDoctor)
        {
            var controlador = new CitasController();
            controlador.InsertarCita(fecha, fkPaciente, fkDoctor);
        }

        [WebMethod]
        public List<CitasModel> CitasDisponibilidad(DateTime fechaCita, int fkDoctor)
        {
            var controlador = new CitasController();
            return controlador.CitasDisponibles(fechaCita, fkDoctor);
        }

        #endregion

        #region Horarios
        [WebMethod]
        public void InsertarHorarios(string horaInicio, string horaFinal, int fkDia, int fkDoctor)
        {
            var controlador = new HorariosController();
            controlador.InsertarHorarios(horaInicio, horaFinal, fkDia, fkDoctor);
        }

        [WebMethod]
        public void LimpiarHorario(int fkDoctor)
        {
            var controlador = new HorariosController();
            controlador.EliminarHorarios(fkDoctor);
        }

        [WebMethod]
        public List<HorariosModel> DoctorDisponible(int fkDoctor, DateTime fecha)
        {
            var controlador = new HorariosController();
            return controlador.HorarioDisponible(fkDoctor, fecha);
        }
        #endregion

        #region ForoPrivado

        [WebMethod]
        public List<ForoPrivadoModel> GetForoPrivado(int pk)
        {
            var controlador = new ForoPrivadoController();
            return controlador.ConsultaForo(pk);
        }

        [WebMethod]
        public void DeleteForoPrivado(int pk)
        {
            var controlador = new ForoPrivadoController();
            controlador.EliminarForo(pk);
        }


        #endregion

        #region Expedientes Homeopaticos

        [WebMethod]
        public List<ExpedienteHomeopatiaModel> GetExpedientesHom(int fkDoctor)
        {
            var controlador = new ExpedienteHomeopatiaController();
            return controlador.ConsultaExpedienteHomeopatia(fkDoctor);
        }


        [WebMethod]
        public void InsertExpedientesHom(ExpedienteHomeopatiaModel Expediente)
        {
            var controlador = new ExpedienteHomeopatiaController();
            controlador.InsertarExpedienteHom(Expediente);
        }

        #endregion

        #region Citas Acupuntura

        [WebMethod]
        public void InsertarCitaAcupuntura(CitasAcupunturaModel Cita)
        {
            var controlador = new CitasAcupunturaController();
            controlador.InsertarExpedientesAcu(Cita);
        }


        [WebMethod]
        public List<CitasAcupunturaModel> GetCitasAcupunturabyPaciente(int fkPaciente)
        {
            var controlador = new CitasAcupunturaController();
            return controlador.ConsultaCitasAcupuntura(fkPaciente);
        }


        [WebMethod]
        public List<CitasAcupunturaModel> GetCitasAcupunturabyID(int id)
        {
            var controlador = new CitasAcupunturaController();
            return controlador.ConsultaCitasAcupunturabyId(id);
        }

        #endregion

        #region Expedientes Acupuntura

        [WebMethod]
        public int CrearExpedientesAcu(string nombre, int fkDoctor)
        {
            var controlador = new ExpedienteAcupunturaController();
            return controlador.CrearExpedientesAcu(nombre, fkDoctor);
        }


        [WebMethod]
        public List<ExpedienteAcupunturaModel> GetExpedienteAcupuntura(int fkDoctor)
        {
            var controlador = new ExpedienteAcupunturaController();
            return controlador.ConsultaExpedienteAcupuntura(fkDoctor);
        }


        #endregion

        #region Citas Hemeopaticos

        [WebMethod]
        public void InsertCitaHomeopactica(string sintomas, string reper, string fecha, int fkPaciente)
        {
            var controlador = new CitasHomeopaticoController();
            controlador.InsertCitaHomeopactica(sintomas, reper, fecha, fkPaciente);
        }


        [WebMethod]
        public List<CitasHomeopaticoModel> GetCitasHomeipatica(int fkPaciente)
        {
            var controlador = new CitasHomeopaticoController();
            return controlador.ConsultaCitasHomeopatica(fkPaciente);
        }

        #endregion

        #region Recetas

        [WebMethod]
        public int InsertRecetas(string Nombre, DateTime FechaCreacion, int fkDoctor)
        {
            var controlador = new RecetasController();
            return controlador.InsertarRecetas(Nombre, FechaCreacion, fkDoctor);
        }


        [WebMethod]
        public List<RecetasModel> GetRecetas(int FkDoctor)
        {
            var controlador = new RecetasController();
            return controlador.ConsultaReceta(FkDoctor);
        }

        [WebMethod]
        public void InsertCodigos(int codigo, int fkDoctor, int fkReceta)
        {
            var controlador = new CodigosController();
            controlador.InsertarCodigo(codigo, fkDoctor, fkReceta);
        }

        #endregion

        #region RecetasInfo

        [WebMethod]
        public void InsertRecetasInfo(RecetaInfoModel receta)
        {
            var controlador = new RecetaInfoController();
            controlador.InsertarRecetaInfo(receta);
        }


        [WebMethod]
        public List<RecetaInfoModel> GetRecetasInfo(int FKReceta)
        {
            var controlador = new RecetaInfoController();
            return controlador.ConsultaReceta(FKReceta);
        }

        #endregion



        //---------------- Movil -------------------------

        #region CuentaPacientes

        [WebMethod]
        public CuentaPacientesModel InsertCuentaPacientes(string nombre, string appellidos, string Correo, string Contrasena)
        {
            var controlador = new CuentaPacientesController();
            CuentaPacientesModel modelo = new CuentaPacientesModel();
            modelo.m_IdCuenta = controlador.InsertaCuentaPaciente(nombre, appellidos, Correo, Contrasena);
            return modelo;
        }


        [WebMethod]
        public CuentaPacientesModel GetCuentaPaciente(string correo, string contrasena)
        {
            var controlador = new CuentaPacientesController();
            return controlador.ConsultaCuentaPaciente(correo, contrasena);
        }

        #endregion

        #region Pacietnes

        [WebMethod]
        public PacienteModel GetPaciente(int pk)
        {
            var controlador = new PacienteController();
            return controlador.ConsultaCuentaPacientes(pk);

        }


        #endregion

        #region Doctores

        [WebMethod]
        public DoctoresModel MovilGetDoctores(int pk)
        {
            var controlador = new DoctoresControllers();
            return controlador.ConsultaDoctoresMovil(pk);
        }

        #endregion

        #region ForoPrivado

        [WebMethod]
        public List<ForoPrivadoPacienteModel> GetForoPrivadoPaciente(int pkPac, int pkDoc)
        {
            var controlador = new ForoPrivadoPacienteController();
            return controlador.ConsultaForoPaciente(pkPac, pkDoc);
        }


        [WebMethod]
        public void InsertForoPrivado(string texto, string fecha, int fkPaciente, int fkDoctor)
        {
            var controlador = new ForoPrivadoController();
            controlador.InsertarForo(texto, fecha, fkPaciente, fkDoctor);
        }


        #endregion

        #region ComentariosPrivado

        [WebMethod]
        public List<ComentariosPrivadoModel> GetComentariosPrivado(int fkForo)
        {
            var controlador = new ComentariosPrivadoController();
            return controlador.ConsltaComentariosPrivado(fkForo);
        }


        [WebMethod]
        public void InsertComentariosPrivado(string texto, string fecha, int TipodeCuenta, int fkForo)
        {
            var controlador = new ComentariosPrivadoController();
            controlador.InsertarComentario(texto, fecha, TipodeCuenta, fkForo);
        }


        #endregion

        #region PacienteEventos

        [WebMethod]
        public List<PacienteEventosModel> GetPacienteEventos(int pk)
        {
            var controlador = new PacienteEventosController();
            return controlador.ConsultaPacienteEventos(pk);
        }


        [WebMethod]
        public void InsertPacienteEventos(int fkPaciente, int fkEvento)
        {
            var controlador = new PacienteEventosController();
            controlador.InsertarPacienteEvento(fkPaciente, fkEvento);
        }


        [WebMethod]
        public void AsistenciaPacienteEventos(int fkPaciente, int fkEvento, int asistencia)
        {
            var controlador = new PacienteEventosController();
            controlador.ActualizarAsistencia(fkPaciente, fkEvento, asistencia);

        }

        #endregion

        #region ForoPublico

        [WebMethod]
        public List<ForoPublicoModel> GetForoPublico(string texto)
        {
            var controlador = new ForoPublicoController();
            return controlador.ConsultaForoPublico();
        }


        [WebMethod]
        public void InsertForoPublico(string texto, string fecha, int fkPaciente)
        {
            var controlador = new ForoPublicoController();
            controlador.InsertaForoPublico(texto, fecha, fkPaciente);
        }

        #endregion

        #region ComentariosPublico

        [WebMethod]
        public List<ForoPublicoModel> GetComentariosPublico(int fkForo)
        {
            var controlador = new ForoPublicoController();
            return controlador.ConsltaComentariosPublico(fkForo);
        }

        [WebMethod]
        public void InsertComentariosPublico(string texto, string fecha, int fkpaciente, int fkForo)
        {
            var controlador = new ComentariosPublicoController();
            controlador.InsertarComentarioPublico(texto, fecha, fkpaciente, fkForo);
        }

        #endregion

        #region Citas

        [WebMethod]
        public List<CitasMovilModel> GetCitasPaciente(int fkPaciente)
        {
            var controlador = new CitasMovilController();
            return controlador.ConsultaCitasPaciente(fkPaciente);
        }

        public void CancelarCitasPaciente(int idCita)
        {
            var controlador = new CitasMovilController();
            controlador.EliminarCitaPaciente(idCita);
        }



        #endregion



    }
}
