using Newtonsoft.Json;
using System.Net;

namespace TestWebService.Models
{
    public class InfoGet
    {
        public string? Date { get; set; }
        public string? PreviousDate { get; set; }
        public string? PreviousURL { get; set; }
        public string? Timestamp { get; set; }
        public Valutes? Valute { get; set; }

        public static List<Currency> Get()
        {
            List<Currency> _currencies = new List<Currency>();
            
            string url = "https://www.cbr-xml-daily.ru/daily_json.js";
            InfoGet parsed = JsonConvert.DeserializeObject<InfoGet>(new WebClient().DownloadString(url));
            
            _currencies.Add(parsed.Valute.AUD);
            _currencies.Add(parsed.Valute.AZN);
            _currencies.Add(parsed.Valute.GBP);
            _currencies.Add(parsed.Valute.AMD);
            _currencies.Add(parsed.Valute.BYN);
            _currencies.Add(parsed.Valute.BGN);
            _currencies.Add(parsed.Valute.BRL);
            _currencies.Add(parsed.Valute.HUF);
            _currencies.Add(parsed.Valute.HKD);
            _currencies.Add(parsed.Valute.DKK);
            _currencies.Add(parsed.Valute.USD);
            _currencies.Add(parsed.Valute.EUR);
            _currencies.Add(parsed.Valute.INR);
            _currencies.Add(parsed.Valute.KZT);
            _currencies.Add(parsed.Valute.CAD);
            _currencies.Add(parsed.Valute.KGS);
            _currencies.Add(parsed.Valute.CNY);
            _currencies.Add(parsed.Valute.MDL);
            _currencies.Add(parsed.Valute.NOK);
            _currencies.Add(parsed.Valute.PLN);
            _currencies.Add(parsed.Valute.RON);
            _currencies.Add(parsed.Valute.XDR);
            _currencies.Add(parsed.Valute.SGD);
            _currencies.Add(parsed.Valute.TJS);
            _currencies.Add(parsed.Valute.TRY);
            _currencies.Add(parsed.Valute.TMT);
            _currencies.Add(parsed.Valute.UZS);
            _currencies.Add(parsed.Valute.UAH);
            _currencies.Add(parsed.Valute.CZK);
            _currencies.Add(parsed.Valute.SEK);
            _currencies.Add(parsed.Valute.CHF);
            _currencies.Add(parsed.Valute.ZAR);
            _currencies.Add(parsed.Valute.KRW);
            _currencies.Add(parsed.Valute.JPY);
            
            return _currencies;
        }
    }
}
