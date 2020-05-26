using System;

namespace QRCoder.Core.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
            var qrCode = new Base64QRCode(qrCodeData);
            var res = qrCode.GetGraphic(20);
            System.Console.WriteLine(res.Length);
            Console.ReadKey();
        }
    }
}
