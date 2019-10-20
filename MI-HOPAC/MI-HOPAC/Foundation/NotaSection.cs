﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_HOPAC
{
    public class NotaSection
    {

        public string Texto { get; set; }
        public string Color { get; set; }
        public int    Id    { get; set; }
        public int Change   { get; set; }

        public NotaSection(int id, string texto, string color)
        {
            Texto = texto;
            Color = color;
            Id = id;
            Change = 0;
        }

    }
}
