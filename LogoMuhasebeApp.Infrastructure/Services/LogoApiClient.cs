using LogoMuhasebeApp.Application.Dto;
using LogoMuhasebeApp.Application.Interfaces;
using System.Text;
using System.Text.Json;

namespace LogoMuhasebeApp.Infrastructure.Services
{
    /// <summary>
    /// Logo REST API ile gerçek HTTP isteklerini yapan sınıf
    /// </summary>
    public class LogoApiClient : ILogoApiClient
    {
        private readonly HttpClient _httpClient;
        /// <summary>
        /// Örnek olarak baseUrl ve apiKey yapılandırma olarak alınabilir
        /// </summary>
        private readonly string _baseUrl = "https://api.logo.com"; // Logo API base URL
        private readonly string _apiKey = "YOUR_API_KEY";          // API anahtarı


        public LogoApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(_baseUrl);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        }
        /// <summary>
        /// Satış fişi bilgilerini Logo'nun REST API endpoint'ine gönderir
        /// </summary>
        /// <param name="invoiceDto">Satış fişi DTO</param>
        /// <returns></returns>
        public async Task<bool> SendSalesInvoiceAsync(SalesInvoiceDto invoiceDto)
        {
            try
            {
                // DTO'yu JSON'a çevir
                var json = JsonSerializer.Serialize(invoiceDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Örnek endpoint: /sales/invoice
                var response = await _httpClient.PostAsync("/sales/invoice", content);
                // Başarılı ise true döndür
                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                // Hata durumunda false dön (geliştirilebilir logging ile)
                return false;
            }
        }
    }
}
