// Copyright 2016-2018 Dirk Lemstra <https://github.com/dlemstra/QRCodeCore>
//
// Licensed under the Apache 2.0 License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   https://github.com/dlemstra/QRCodeCore/blob/master/License.txt
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections;
using System.Collections.Generic;

namespace QRCodeCore
{
  internal sealed class QRCodeMatrix
  {
    public QRCodeMatrix(int version)
    {
      int size = 21 + (version - 1) * 4;
      this.ModuleMatrix = new List<BitArray>();
      for (var i = 0; i < size; i++)
        this.ModuleMatrix.Add(new BitArray(size));
    }

    public bool GetValue(int x, int y)
    {
      return ModuleMatrix[x][y];
    }

    public List<BitArray> ModuleMatrix { get; set; }
  }
}
