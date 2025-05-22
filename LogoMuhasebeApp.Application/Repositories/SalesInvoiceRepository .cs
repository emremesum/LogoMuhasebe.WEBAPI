using LogoMuhasebeApp.Application.Dto;
using LogoMuhasebeApp.Application.Interfaces;
using LogoMuhasebeApp.Domain.Entities;

namespace LogoMuhasebeApp.Application.Repositories;
/// <summary>
/// Satış fişlerini saklayan mock repository
/// </summary>
public class SalesInvoiceRepository : ISalesInvoiceRepository
{

    public static readonly List<SalesInvoice> _invoices = new List<SalesInvoice>
        {
            new SalesInvoice
            {
                InvoiceNumber = "FAT20231001",
                InvoiceDate = DateTime.Now.AddDays(-10),
                CustomerCode = "CUST001",
                CustomerName = "ABC Ticaret",
                Description = "Ekim ayı satış faturası",
                Items = new List<SalesInvoiceItem>
                {
                    new SalesInvoiceItem
                    {
                        ProductCode = "PROD001",
                        ProductName = "Ürün A",
                        Quantity = 5,
                        UnitPrice = 200,
                        VatRate = 18
                    },
                    new SalesInvoiceItem
                    {
                        ProductCode = "PROD002",
                        ProductName = "Ürün B",
                        Quantity = 3,
                        UnitPrice = 150,
                        VatRate = 18
                    }
                }
            },
            new SalesInvoice
            {
                InvoiceNumber = "FAT20231002",
                InvoiceDate = DateTime.Now.AddDays(-7),
                CustomerCode = "CUST002",
                CustomerName = "XYZ Ltd. Şti.",
                Description = "Ekim ayı satış faturası 2",
                Items = new List<SalesInvoiceItem>
                {
                    new SalesInvoiceItem
                    {
                        ProductCode = "PROD003",
                        ProductName = "Ürün C",
                        Quantity = 10,
                        UnitPrice = 100,
                        VatRate = 8
                    }
                 }
                }
        };

    public async Task<List<SalesInvoice>> GetAllInvoicesAsync()
    {
        await Task.CompletedTask; // Zorunlu değil ama örnek için eklendi
        return _invoices;

    }
}


