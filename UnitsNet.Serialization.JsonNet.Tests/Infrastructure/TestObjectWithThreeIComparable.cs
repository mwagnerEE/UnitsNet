﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

namespace UnitsNet.Serialization.JsonNet.Tests.Infrastructure
{
    public sealed class TestObjectWithThreeIComparable
    {
        public IComparable Value1 { get; set; }

        public IComparable Value2 { get; set; }

        public IComparable Value3 { get; set; }
    }
}
