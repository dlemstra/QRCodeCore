// Copyright 2016-2018 Dirk Lemstra <https://github.com/dlemstra/QRCodeCore>
//
// Licensed under the Apache 2.0 License (the ""License""); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   https://github.com/dlemstra/QRCodeCore/blob/master/License.txt
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an ""AS IS"" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.

using Xunit;

namespace QRCodeCore.Tests
{
    public class SvgQRCodeTests
    {
        [Fact]
        public void Test_Create()
        {
            QRCodeData data = new QRCodeData("QRCodeCore");

            SvgQRCode qrCode = new SvgQRCode(data);
            string actual = qrCode.Create(128);

            string excepted = @"<svg version=""1.1"" baseProfile=""full"" width=""116"" height=""116"" xmlns=""http://www.w3.org/2000/svg"">
<rect width=""100%"" height=""100%"" fill=""#fff""/>
<rect x=""16"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""20"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""36"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""92"" width=""4"" height=""4"" fill=""000"" />
<rect x=""16"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""20"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""20"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""20"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""20"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""20"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""20"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""24"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""28"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""32"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""36"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""36"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""36"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""36"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""36"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""36"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""36"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""36"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""20"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""36"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""92"" width=""4"" height=""4"" fill=""000"" />
<rect x=""40"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""44"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""44"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""44"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""44"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""44"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""36"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""68"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""48"" y=""92"" width=""4"" height=""4"" fill=""000"" />
<rect x=""52"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""52"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""52"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""52"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""52"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""52"" y=""68"" width=""4"" height=""4"" fill=""000"" />
<rect x=""52"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""52"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""52"" y=""92"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""20"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""44"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""92"" width=""4"" height=""4"" fill=""000"" />
<rect x=""56"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""36"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""44"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""60"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""20"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""64"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""68"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""68"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""68"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""68"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""68"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""68"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""68"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""20"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""36"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""72"" y=""80"" width=""4"" height=""4"" fill=""000"" />
<rect x=""76"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""76"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""76"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""76"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""76"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""76"" y=""68"" width=""4"" height=""4"" fill=""000"" />
<rect x=""76"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""76"" y=""92"" width=""4"" height=""4"" fill=""000"" />
<rect x=""80"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""80"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""80"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""80"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""80"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""80"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""80"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""80"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""80"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""84"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""88"" width=""4"" height=""4"" fill=""000"" />
<rect x=""84"" y=""92"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""64"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""68"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""88"" y=""92"" width=""4"" height=""4"" fill=""000"" />
<rect x=""92"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""92"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""92"" y=""52"" width=""4"" height=""4"" fill=""000"" />
<rect x=""92"" y=""56"" width=""4"" height=""4"" fill=""000"" />
<rect x=""92"" y=""60"" width=""4"" height=""4"" fill=""000"" />
<rect x=""92"" y=""68"" width=""4"" height=""4"" fill=""000"" />
<rect x=""92"" y=""72"" width=""4"" height=""4"" fill=""000"" />
<rect x=""92"" y=""96"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""16"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""20"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""24"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""28"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""32"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""36"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""40"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""48"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""76"" width=""4"" height=""4"" fill=""000"" />
<rect x=""96"" y=""80"" width=""4"" height=""4"" fill=""000"" />
</svg>
".Replace("\r", "").Replace("\n", "");

            actual = actual.Replace("\r", "").Replace("\n", "");
            Assert.Equal(excepted, actual);
        }
    }
}
