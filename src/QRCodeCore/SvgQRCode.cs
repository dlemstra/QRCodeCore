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

using System;
using System.Text;

namespace QRCodeCore
{
  public sealed class SvgQRCode
  {
    private QRCodeData _Data;

    public SvgQRCode(QRCodeData data)
    {
      _Data = data;
    }

    public string Create(int size)
    {
      QRCodeGenerator generator = new QRCodeGenerator();
      QRCodeMatrix matrix = generator.CreateQRCode(_Data.Text, _Data.EccLevel);

      var unitsPerModule = (int)Math.Floor(size / (double)matrix.ModuleMatrix.Count);
      var viewBoxSize = matrix.ModuleMatrix.Count * unitsPerModule;

      var svgFile = new StringBuilder(@"<svg version=""1.1"" baseProfile=""full"" width=""");
      svgFile.Append(viewBoxSize);
      svgFile.Append(@""" height=""");
      svgFile.Append(viewBoxSize);
      svgFile.AppendLine(@""" xmlns=""http://www.w3.org/2000/svg"">");
      svgFile.AppendLine(@"<rect width=""100%"" height=""100%"" fill=""#fff""/>");

            for (var x = 0; x < viewBoxSize; x += unitsPerModule)
      {
        for (var y = 0; y < viewBoxSize; y += unitsPerModule)
        {
          var module = matrix.GetValue((y + unitsPerModule) / unitsPerModule - 1, (x + unitsPerModule) / unitsPerModule - 1);
          if (!module)
            continue;

          svgFile.Append(@"<rect x=""");
          svgFile.Append(x);
          svgFile.Append(@""" y=""");
          svgFile.Append(y);
          svgFile.Append(@""" width=""");
          svgFile.Append(unitsPerModule);
          svgFile.Append(@""" height=""");
          svgFile.Append(unitsPerModule);
          svgFile.AppendLine(@""" fill=""000"" />");
        }
      }

      svgFile.Append(@"</svg>");
      return svgFile.ToString();
    }
  }
}