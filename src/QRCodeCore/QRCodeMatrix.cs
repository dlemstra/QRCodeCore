// Copyright Dirk Lemstra https://github.com/dlemstra/QRCodeCore.
// Licensed under the Apache License, Version 2.0.

using System.Collections;
using System.Collections.Generic;

namespace QRCodeCore
{
    internal sealed class QRCodeMatrix
    {
        public QRCodeMatrix(int version)
        {
            var size = 21 + ((version - 1) * 4);
            ModuleMatrix = new List<BitArray>();
            for (var i = 0; i < size; i++)
                ModuleMatrix.Add(new BitArray(size));
        }

        public List<BitArray> ModuleMatrix { get; set; }

        public bool GetValue(int x, int y)
            => ModuleMatrix[x][y];
    }
}
