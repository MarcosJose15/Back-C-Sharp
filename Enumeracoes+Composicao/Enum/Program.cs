using Enumeracoes_Composicao.Entities;
using Enumeracoes_Composicao.Entities.Enums;
using System;

namespace Enumeracoes_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1990,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //PASSANDO DE ENUM PARA STRING
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);


            //PASSANDO DE STRING PARA ENUM
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); 

            Console.WriteLine(os);
        }
    }
}