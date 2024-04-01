namespace RegularCustomer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var shop = new Shop();
            var cmd = "";
            customer.OnItemChanged(shop);
            
            while (true)
            {
                Console.WriteLine("Для добавления нажмите клавишу A\nДля удаления нажмите клавишу D");
                cmd = Console.ReadLine();
                int i = 0;
                int itemID = 0;
                string name = "";
                switch (cmd)
                {
                    case "A":
                        Console.WriteLine("Введите название товара: ");
                        name = Console.ReadLine();
                        name +=$" от {DateTime.Now}";
                        shop.Add(name, i);
                        i++;
                        break;
                    case "D":
                        Console.WriteLine("Укажите идентификатор товара, который хотите удалить");
                        itemID = int.Parse(Console.ReadLine());
                        shop.Remove(itemID);
                        break;
                    default:
                        Console.WriteLine("Нет такой команды");
                    break;
                }
            }          
            shop.Remove(1);
        }
    }
}