using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceApplication_BuisnessLayer;
using EcommerceApplication_BuisnessLayer.Repository;
using EcommerceApplication_BuisnessLayer.Services;
using EcommerceApplication_CustomException;
using EcommerceApplication_Entity;

namespace EcommerceApplication_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Welcome to Ecommerce Application By Sejal Sihare*******");

            CustomerRepository customerRepository = new CustomerRepository();
            CustomerService customerService = new CustomerService(customerRepository);
            ProductRepository productRepository = new ProductRepository();
            ProductService productService = new ProductService(productRepository);
            CartRepository cartRepository = new CartRepository();
            CartService cartService = new CartService(cartRepository);
            OrderRepository orderRepository = new OrderRepository();
            OrderService orderService = new OrderService(orderRepository);
            Console.WriteLine("To Delete the Customer type 1");
            Console.WriteLine("To get all Customer type 2");
            Console.WriteLine("To create Customer 3");
            Console.WriteLine("To create Product type 5");
            Console.WriteLine("To delete Product type 4");
            Console.WriteLine("To Add to cart type 6");
            Console.WriteLine("To remove from cart type 7");
            Console.WriteLine("To get all from cart type 8");
            Console.WriteLine("To get order by Customer type 9");
            Console.WriteLine("To Place order type 10");
            var choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(choice);
          switch (choice)
            {
                case 1:
                    //customerService.Deleting from Customer();
                    Console.WriteLine("Enter the id of customer:");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        var result1 = customerService.deleteCustomer(id1);
                        if (result1)
                        {
                            Console.WriteLine("Deletion Successful");
                        }
                        else
                        {
                            throw new CustomerNotFoundException();
                        }
                    }

                    catch (CustomerNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;

                case 2:
                    //get all from Customers
                    
                    customerService.getAllCustomer();
                    break;

                case 3:
                    //Create new Customer
                    Console.WriteLine("Enter the Customer id:");
                    int id11 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the customer name:");
                    string cname = Console.ReadLine();
                    Console.WriteLine("Enter Email:");
                    string ce = Console.ReadLine();
                   
                    Console.WriteLine("Enter the password:");
                    string password = Console.ReadLine();
                    var ans = customerService.createCustomer(new Customers { Customer_ID = id11, Name = cname, Email = ce, Password = password });
                    if (ans)
                    {
                        Console.WriteLine("insertion Successful");
                    }
                    else
                    {
                        Console.WriteLine("Unsuccesful");

                    }
                    break;

                case 4:
                    //Deleting the product
                    Console.WriteLine("Enter the Product Id you want to delete:");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    var result3 = productService.deleteProduct(id3);
                    try{ if (result3)
                        {
                            Console.WriteLine("Product is deleted");
                        }
                        else
                        {
                            throw new ProductNotFoundException("The Product ID is unavailable");
                        }
                    }
                    catch(ProductNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;

                case 5:

                    // creating the product


                    var result4 = productService.createProduct(new Products() { Product_ID = 15, Product_name = "Laptop", Price = "22000", Description = "Electronic Gadget", StockQuantity = 13 });
                    if (result4)
                    {
                        Console.WriteLine("Product is added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Unsucessful insertion");
                    }
                    break;

                case 6:

                    // Add to Cart
                    Console.WriteLine("Enter the Cart id:");
                    int id6 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Product id:");
                    int pid6 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the customer id:");
                    int cid6 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Quantity of product:");
                    int q6 = Convert.ToInt32(Console.ReadLine());
                    var result5 = cartService.addToCart(id6, new Products() { Product_ID = pid6 }
                       , new Customers() { Customer_ID = cid6 }, q6);
                    if (result5)
                    {
                        Console.WriteLine("The above item is added Successfully");
                    }
                    break;

                case 7:

                    //Remove from Cart
                    Console.WriteLine("Enter the Cart id you want to remove:");
                    int id16 = Convert.ToInt32(Console.ReadLine());

                    var result6 = cartService.removeFromCart(id16);
                    if (result6)
                    {
                        Console.WriteLine("The above item is deleted Successfully");
                    }
                    break;
                case 8:
                    //GetAllfrom Carts
                    Console.WriteLine("Enter the customer  for whome you have to view thw cart:");
                    int id7 = Convert.ToInt32(Console.ReadLine());
                    List<Products> p = cartService.getAllFromCart(id7);

                    if (p.Count > 0)
                    {
                        Console.WriteLine("Products in the Cart:");
                        foreach (var product in p)
                        {
                            Console.WriteLine($"Product ID: {product.Product_ID},Name : {product.Product_name},Price :{product.Price},Description:{product.Description},Quantity:{product.StockQuantity}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cart is Empty");
                    }
                    break;

                case 9:

                    //Orders get all by customers
                    Console.WriteLine("Enter the id of customer:");
                    int id8 = Convert.ToInt32(Console.ReadLine());
                    List<Products> pro = orderService.getOrderByCustomer(id8);

                    if (pro.Count > 0)
                    {
                        Console.WriteLine("Following are the Orders By customer:");
                        foreach (var product in pro)
                        {
                            Console.WriteLine($"Product ID: {product.Product_ID},Name : {product.Product_name},Price :{product.Price},Description:{product.Description},Quantity:{product.StockQuantity}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cart is Empty");
                    }
                    break;

                case 10:
                    //Place Order
                    Console.WriteLine("Enter the order id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the customer id:");
                    int cid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the orderdate (e.g., MM/dd/yyyy):");
                    string input = Console.ReadLine();
                    DateTime d;

                    // Use TryParse to avoid conversion errors
                    if (DateTime.TryParse(input, out d))
                    {
                        Console.WriteLine("Valid date entered: " + d.ToString("MM/dd/yyyy"));
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Please try again.");
                    }
                    //DateTime d = Convert.ToDateTime(Console.ReadLine());
                    //DateTime date = DateTime.Parse(d);
                    Console.WriteLine("Enter the Total Price:");
                    int tp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the ShippingAddress:");
                    string address = Console.ReadLine();
                    bool result = orderService.placeOrder(new Orders() { Order_ID = id, Customer_ID = cid, OrderDate = d.Date, Total_Price = tp, ShippingAddress = address });
                    if (result)
                    {
                        Console.WriteLine("Congratulations Order is placed");
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately Order is not places");
                    }
                    break;





            }
            Console.WriteLine("    ");
            Console.WriteLine("*******Thank You for Shopping at Ecommerce Application*******");

            Console.ReadKey();
        }
    }
}

        


     

