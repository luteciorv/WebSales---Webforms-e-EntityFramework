using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Pendente")]
        Pending = 0,
        Billed = 1,
        Canceled = 2
    }
}