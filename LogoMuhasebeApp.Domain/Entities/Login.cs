namespace LogoMuhasebeApp.Domain.Entities
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }  // Basitlik için düz metin parola (gerçek projede hash'lenmeli)
        public string FirmNr { get; set; }
        public int PeriodNr { get; set; }
    }
}

