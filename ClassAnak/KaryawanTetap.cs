﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab8.ClassAnak
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji()
        {
            double Gaji = 0;
            Gaji = GajiBulanan;
            return Gaji;
        }
        
    }
}
