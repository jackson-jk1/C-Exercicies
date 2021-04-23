using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Pedidos.Entities.Enuns;

namespace Exercicio_Pedidos.Entities
{
    public class Order
    {
        public DateTime Moment {get;set;}
        public OrderStatus Status { get; set; }

        public Client Client {get;set;}
        public List <OrderItem> Itens {get; set;} = new List<OrderItem>();


        public Order(DateTime moment, OrderStatus status,Client client ){
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item){
         
          Itens.Add(item);

        }
        public void RevomeItem(OrderItem item){
          Itens.Remove(item);
        }

        public double total(){
             double sum = 0;
            foreach(OrderItem ot in Itens ){
                sum += ot.subToltal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
             sb.AppendLine("ORDER SUMARY:");
             sb.AppendLine("Order moment: "+ Moment);
             sb.AppendLine("Order status: "+ Status);
             sb.AppendLine("Client: "+ Client.Name + " ("+ Client.BirthDate + ") " + " - " + Client.Email);
             sb.AppendLine("Order Itens: ");
            
              foreach(OrderItem ot in Itens ){
                sb.AppendLine(ot.Product.Name + ", Quantity: " + ot.Quantity + ", Subtotal: $" + ot.subToltal());
                }
              sb.AppendLine("Total: $" + total());
            return sb.ToString();
        }
    }
}