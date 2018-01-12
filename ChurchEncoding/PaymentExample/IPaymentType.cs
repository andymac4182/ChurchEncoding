﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.ChurchEncoding.PaymentExample
{
    public interface IPaymentType
    {
        T Match<T>(PaymentTypeParameters<T> parameters);
    }
}