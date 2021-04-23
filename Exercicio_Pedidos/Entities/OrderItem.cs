namespace Exercicio_Pedidos.Entities
{
    public class OrderItem
    {
        public int Quantity { get;set;}
        public double Price { get; set; }

        public Product Product{ get; set;}

        public OrderItem(int quant,Product product ){
            Quantity = quant;
            Price = product.Price;
            Product = product;

        }
    
        public double subToltal(){
           return Quantity * Price;
        }
    }
}