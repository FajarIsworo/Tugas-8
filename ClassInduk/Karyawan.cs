using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab8.ClassInduk
{
    public abstract class Karyawan 
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();

    }
}
