﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterfaces
{
    public interface IWriteWAVE
    {
        char[] textArray { get; set; }
        void readCSV();
        void toWAVE();
    }
}
