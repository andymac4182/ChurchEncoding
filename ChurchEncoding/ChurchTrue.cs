﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.ChurchEncoding
{
    public class ChurchTrue : IChurchBoolean
    {
        public object Match(object trueCase, object falseCase)
        {
            return trueCase;
        }

        public int Match(int trueCase, int falseCase)
        {
            return trueCase;
        }

        public string Match(string trueCase, string falseCase)
        {
            return trueCase;
        }
    }
}
