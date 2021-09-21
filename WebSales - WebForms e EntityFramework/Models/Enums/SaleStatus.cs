using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSales___WebForms_e_EntityFramework.Models.Enums
{
    /*
     * Os possíveis estados de um pedido
     * Pending  => Pendente, ainda não foi pago
     * Billed   => Pago
     * Canceled => Cancelado
     */
    public enum SaleStatus : int
    {
        Pending = 0,
        Billed = 1,
        Canceled = 2
    }
}