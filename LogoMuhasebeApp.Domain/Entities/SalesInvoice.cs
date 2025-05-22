namespace LogoMuhasebeApp.Domain.Entities
{
    /// <summary>
    /// Satış fişi domain modeli
    /// </summary>
    public class SalesInvoice
    {
        public string InvoiceNumber { get; set; }  // Fiş numarası
        public DateTime InvoiceDate { get; set; }  // Fiş tarihi
        public string CustomerCode { get; set; }   // Müşteri kodu
        public string CustomerName { get; set; }   // Müşteri adı
        public List<SalesInvoiceItem> Items { get; set; } = new();
        public string Description { get; set; }    // Açıklama
    }

}
