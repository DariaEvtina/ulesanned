﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulesanned
{
    public class kasutaja
    {
        public int ID { get; set; }
        public string nimi { get; set; }
        public string email { get; set; }
        public string sugu { get; set; }
        public int vanus { get; set; }
        public string avatar { get; set; }
        public string connection()
        {
            return @"Data Source=(LocalDB)\\\\MSSQLLocalDB;AttachDbFilename=C:\\\\Users\\\\opilane\\\\source\\\\repos\\\\dariaEvtinaTARpv20\\\\ulesanned\\\\ulesanned\\\\kasutajad.mdf;Integrated Security=True;Connect Timeout=30\";
        }
    }
    
}
