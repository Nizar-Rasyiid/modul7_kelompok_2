﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_1302220037_Nizar_Rasyiid_AFH
{
    internal class Mahasiswa
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }

        public Address address { get; set; }
        public List<Courses> courses { get; set; }
    }
}
