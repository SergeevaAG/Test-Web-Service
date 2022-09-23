namespace TestWebService.Models
{
    public class Currency
    {
        public string? ID { get; set; }
        public string? NumCode { get; set; }
        public string? CharCode { get; set; }
        public string? Nominal { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Previous { get; set; }

        public Currency(string ID, string NumCode, string CharCode, string Nominal, string Name, string Value, string Previous)
        {
            this.ID = ID;
            this.NumCode = NumCode;
            this.CharCode = CharCode;
            this.Nominal = Nominal;
            this.Name = Name;
            this.Value = Value;
            this.Previous = Previous;
        }
        public Currency() {}
    }
}
