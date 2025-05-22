using LogoMuhasebeApp.Application.Dto;
using LogoMuhasebeApp.Domain.Entities;

namespace LogoMuhasebeApp.Application.Interfaces
{
    public interface ISalesInvoiceRepository
    {
        public Task<List<SalesInvoice>> GetAllInvoicesAsync();
    }
}
