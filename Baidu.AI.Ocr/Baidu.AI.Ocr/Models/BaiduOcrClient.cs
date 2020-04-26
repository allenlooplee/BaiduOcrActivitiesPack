using Cloud.Ocr.Contracts;
using Cloud.Ocr.Models;
using Cloud.Ocr.Activities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baidu.AI.Ocr.Models
{
    public class BaiduOcrClient : IOcrClient
    {
        public BaiduOcrClient(string apiKey, string secretKey)
        {
            Name = "Baidu OCR";
            _baiduOcr = new Aip.Ocr.Ocr(apiKey, secretKey);
            _recognizerDictionary = BuildRecognizerDictionary();
        }

        public string Name { get; }

        public async Task<JObject> RecognizeAsync(string recognizerName, string imagePath, Dictionary<string, object> options = null)
        {
            var imageData = File.ReadAllBytes(imagePath);
            var recognizer = _recognizerDictionary[recognizerName];

            return await Task.Run(() => recognizer(imageData, options));
        }

        private Dictionary<string, Func<byte[], Dictionary<string, object>, JObject>> BuildRecognizerDictionary()
        {
            return new Dictionary<string, Func<byte[], Dictionary<string, object>, JObject>>
            {
                [RecognizerNames.VatInvoice] = _baiduOcr.VatInvoice,
                [RecognizerNames.BankCard] = _baiduOcr.Bankcard,
                [RecognizerNames.BusinessLicense] = _baiduOcr.BusinessLicense,
                [RecognizerNames.IdCard] = BaiduOcrIdCard,
                [RecognizerNames.TaxiReceipt] = _baiduOcr.TaxiReceipt,
                [RecognizerNames.TrainTicket] = _baiduOcr.TrainTicket,
                [RecognizerNames.QuotaInvoice] = _baiduOcr.QuotaInvoice,
                [RecognizerNames.HouseholdRegister] = _baiduOcr.HouseholdRegister,
                [RecognizerNames.BirthCertificate] = _baiduOcr.BirthCertificate,
                [RecognizerNames.Passport] = _baiduOcr.Passport,
                [RecognizerNames.HkMacauExitentrypermit] = _baiduOcr.HkMacauExitentrypermit,
                [RecognizerNames.TaiwanExitentrypermit] = _baiduOcr.TaiwanExitentrypermit,
                [RecognizerNames.DriverLicense] = _baiduOcr.DrivingLicense,
                [RecognizerNames.VehicleLicense] = _baiduOcr.VehicleLicense,
                [RecognizerNames.VehicleInvoice] = _baiduOcr.VehicleInvoice,
                [RecognizerNames.VehicleCertificate] = _baiduOcr.VehicleCertificate,
            };
        }

        private JObject BaiduOcrIdCard(byte[] imageData, Dictionary<string, object> options)
        {
            var optionKey = nameof(IdCardActivity.CardSide);

            // cardSide now has a default value Front.
            // If the value of cardSide is provided in options, then overwrite the default value.
            var cardSide = CardSide.Front;
            if (options != null && options.ContainsKey(optionKey))
            {
                cardSide = (CardSide)options[optionKey];
            }

            return _baiduOcr.Idcard(imageData, cardSide.ToString().ToLower());
        }

        private Baidu.Aip.Ocr.Ocr _baiduOcr;
        private Dictionary<string, Func<byte[], Dictionary<string, object>, JObject>> _recognizerDictionary;
    }
}
