namespace LogoMuhasebeApp.Application.Dto
{
    /// <summary>
    /// Satış fişi oluşturma isteği için kullanılan veri transfer nesnesi (DTO)
    /// </summary>
    public class SalesInvoiceDto
    {
        public string InvoiceNumber { get; set; }  // Fiş numarası
        public DateTime InvoiceDate { get; set; }  // Fiş tarihi
        public string CustomerCode { get; set; }   // Müşteri kodu
        public string CustomerName { get; set; }   // Müşteri adı
        public List<SalesInvoiceItemDto> Items { get; set; } = new();
        public string Description { get; set; }    // Açıklama
    }
}
