﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class ForoPrivadoModel
    {
        #region ForoPrivado
        public int m_IdCForoPrivado { set; get; }
        public string m_Texto { set; get; }
        public string m_Fecha { set; get; }
        public string m_Nombre { set; get; }
        public string m_Apellidos { set; get; }

        #endregion
    }
}