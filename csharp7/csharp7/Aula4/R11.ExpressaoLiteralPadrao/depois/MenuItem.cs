﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace csharp7.R11.depois
{
    class MenuItem : csharp7.MenuItem
    {
        public override void Main()
        {
            Func<string, bool> whereClause = default(Func<string, bool>);
        }
    }
}
