﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Configurations;
using WebService.Models;
using MySql.Data.MySqlClient;

namespace WebService.Controllers
{
    public class HorariosController : DatabaseOperation<HorariosModel>
    {
        public void InsertarHorarios(string horaInicio, string horaFinal, int fkDia, int fkDoctor)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"insert into horario(HoraI, HoraF, fkDia, fkDoctor) values (@horaInicio, @horaFinal, @fkDia, @fkDoctor)";
            cmd.Parameters.Add(new MySqlParameter("@horaInicio", horaInicio));
            cmd.Parameters.Add(new MySqlParameter("@horaFinal", horaFinal));
            cmd.Parameters.Add(new MySqlParameter("@fkDia", fkDia));
            cmd.Parameters.Add(new MySqlParameter("@fkDoctor", fkDoctor));

            Insert(cmd);
        }
    }
}