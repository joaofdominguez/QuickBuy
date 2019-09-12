using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    Public class Pedido
    {
        public int Id { get; set; }
        public DateTime Datapedido { get; set; }
        public int UsuarioId { get; set; }


        //Pedido deve ter pelo menos 1 pedido ou muitos pedidos
        public  ICollection<ItemPedido> ItensPedido { get; set; }




    }
}
