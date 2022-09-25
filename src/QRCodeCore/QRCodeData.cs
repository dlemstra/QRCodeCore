// Copyright Dirk Lemstra https://github.com/dlemstra/QRCodeCore.
// Licensed under the Apache License, Version 2.0.

namespace QRCodeCore
{
    public sealed class QRCodeData
    {
        public QRCodeData(string text)
        {
            Text = text;
            EccLevel = EccLevel.Q;
        }

        public EccLevel EccLevel { get; set; }

        internal string Text { get; }
    }
}
