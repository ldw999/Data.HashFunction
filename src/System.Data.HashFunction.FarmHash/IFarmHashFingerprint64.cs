﻿using System;
using System.Collections.Generic;
using System.Text;

namespace System.Data.HashFunction.FarmHash
{
    /// <summary>
    /// Implementation of FarmHash's Fingerprint64 method as specified at https://github.com/google/farmhash.
    /// </summary>
    public interface IFarmHashFingerprint64
        : IFarmHash64,
            IFarmHashFingerprint
    {

    }
}
