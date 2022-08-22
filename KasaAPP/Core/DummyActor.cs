﻿using Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KasaAPP.Core
{
    public class DummyActor : IAppActor
    {

        public int Id => 1;
        public string Identity => "Test Test";
        public IEnumerable<int> AllowedActions => Enumerable.Range(1, 1000);
    }
}
