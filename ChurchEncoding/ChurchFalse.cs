﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.ChurchEncoding
{
    public class ChurchFalse : IChurchBoolean
    {
        public object Match(object trueCase, object falseCase)
        {
            return falseCase;
        }
    }
}