// Copyright Dirk Lemstra https://github.com/dlemstra/QRCodeCore.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Text;

namespace QRCodeCore
{
    public sealed class SvgQRCode
    {
        private readonly QRCodeData _data;

        public SvgQRCode(QRCodeData data)
        {
            _data = data;
        }

        public string Create(int size)
        {
            var generator = new QRCodeGenerator();
            var matrix = generator.CreateQRCode(_data.Text, _data.EccLevel);

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
                    var module = matrix.GetValue(((y + unitsPerModule) / unitsPerModule) - 1, ((x + unitsPerModule) / unitsPerModule) - 1);
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
