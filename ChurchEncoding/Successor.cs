﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.ChurchEncoding
{
    public class Successor : INaturalNumber
    {
        private readonly INaturalNumber predecessor;

        public Successor(INaturalNumber n)
        {
            predecessor = n;
        }

        public T Match<T>(T zero, Func<INaturalNumber, T> succ)
        {
            return succ(predecessor);
        }
    }
}