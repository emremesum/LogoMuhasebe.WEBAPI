namespace LogoMuhasebeApp.Domain.Entities
{
    public class SalesInvoiceItem
    {
        public string ProductCode { get; set; }    // Ürün kodu
        public string ProductName { get; set; }    // Ürün adı
        public decimal Quantity { get; set; }      // Miktar
        public decimal UnitPrice { get; set; }     // Birim fiyat
        public decimal VatRate { get; set; }       // KDV oranı (%)
    }
}
