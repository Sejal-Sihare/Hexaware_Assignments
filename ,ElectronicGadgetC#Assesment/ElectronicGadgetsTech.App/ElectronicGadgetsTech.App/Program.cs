using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ElectronicGadgetsTech.BuisnessLayer;
using ElectronicGadgetsTech.BuisnessLayer.Repository;
using ElectronicGadgetsTech.BuisnessLayer.Services;
using ElectronicGadgetsTech.Entity;
using TechShopDButil;

namespace ElectronicGadgetsTech.App
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            

        List<int> IDlist = new List<int>();
            Console.WriteLine("**********Welcome to TechShop one destination for innovative Electronic Gadgets**********");
            CustomerRepository repm = new CustomerRepository();
            repm.CalculateTotalOrders();
            repm.GetCustomerDetails();
            int a;
            Console.WriteLine("IF you want to get the details of all Customer Enter 1");
            Console.WriteLine("IF you want to update the Customer Enter 2");

            Console.WriteLine("IF you want tocalculate total orders  Enter 3");
            Console.WriteLine("IF you want toAdd a new Customer Enter 4");
            a = Convert.ToInt32(Console.ReadLine());

           

                switch (a)
                {
                    case 1:
                        repm.GetCustomerDetails();
                        break;
                case 2:
                    repm.UpdateCustomerInfo(2,"aa@gmail.com", "43688798", "M.p");
                    break;
                   
                    case 3:
                        repm.CalculateTotalOrders();
                        break;

                case 4:
                    repm.GetCustomerDetails();
                    break;
                }

            ProductRepository pro = new ProductRepository();
            Products product = new Products();
            Inventory inventory = new Inventory();
            pro.UpdateProductInfo(product, "NewUpdatedVersion", 5567);
            pro.GetProductDetails(product);
            pro.ProductRecommendation();
            pro.IsProductInStock(inventory);


            OrderRepository orderRepository = new OrderRepository();
            Orders order = new Orders();


            orderRepository.UpdateOrderStatus(order);
            orderRepository.CalculateTotalAmount(order);
            orderRepository.CancelOrder();


            OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
            OrderDetails orderDetails = new OrderDetails();
            orderDetailRepository.CalculateSubtotal(product,orderDetails);
            orderDetailRepository.AddDiscount(500);
            orderDetailRepository.GetOrderDetailInfo(orderDetails);

            InventoryRepository inventoryRepository = new InventoryRepository();
            Inventory inventory1 = new Inventory();
            inventoryRepository.AddToInventory(inventory1, 20);
            inventoryRepository.GetInventoryValue(inventory1, product);
            inventory.LastStockUpdate = DateTime.Now;



                Console.ReadKey();
            }
        }
    }

