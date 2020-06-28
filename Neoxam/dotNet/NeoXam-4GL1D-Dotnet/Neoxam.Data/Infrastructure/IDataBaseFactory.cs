﻿using Neoxam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Infrastructures
{
    public interface IDataBaseFactory :IDisposable
    {
        Context DataContext { get;  }
    }
}
