﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicRomanConverter
{
    public interface IConvert<T1,T2>
    {
         T1 Convert(T2 input);
    }
}
