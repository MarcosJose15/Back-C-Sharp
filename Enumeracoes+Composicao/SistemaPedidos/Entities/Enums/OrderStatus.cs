using SistemaPedidos.Entities.Enums;
using SistemaPedidos.Entities;

namespace SistemaPedidos.Entities.Enums
{
    enum OrderStatus
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
