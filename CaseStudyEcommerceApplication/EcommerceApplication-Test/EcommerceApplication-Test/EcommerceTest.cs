using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EcommerceApplication_BuisnessLayer;
using EcommerceApplication_Entity;
using EcommerceApplication_BuisnessLayer.Repository;
using EcommerceApplication_BuisnessLayer.Services;
using EcommerceApplication_CustomException;


namespace EcommerceApplication_Test
{
    [TestFixture]
    public class EcommerceTest
    {
        //Test for Creating the new Customer using the Customers class object
         [Test]
           [TestCase]
             public void createCustomerTest()
             {
                 Customers customers = new Customers()
                 {
                     Customer_ID = 100,
                     Name = "Test",
                     Email = "test@gmail.com",
                     Password = "Password"
                 };
                 bool expectedResult = true;
                 CustomerRepository customerRepository = new CustomerRepository();
                 CustomerService customerService = new CustomerService(customerRepository);
                 var result = customerService.createCustomer(customers);
                 Assert.AreEqual(expectedResult, result);
             }

        //Deleting the Customer using Customer Id
           [Test]
           [TestCase]
           public void deleteCustomerTest()
           {
               int Customer_Id = 100;
               bool expectedResult = true;
               CustomerRepository customerRepository = new CustomerRepository();
               CustomerService customerService = new CustomerService(customerRepository);
               var result = customerService.deleteCustomer(Customer_Id);
               Assert.AreEqual(expectedResult, result);
           }

         //Create Product Method Testing
         [Test]
         [TestCase]
         public void createProductTest()
         {
             Products products = new Products() {Product_ID = 99,
             Product_name = "Mouse",
             Price = "22000",
             Description ="Wireless Mouse",
             StockQuantity = 20
     };
             bool expectedResult = true;
             ProductRepository productRepository = new ProductRepository();
             ProductService productService = new ProductService(productRepository);
              var result = productService.createProduct(products);
             Assert.AreEqual(expectedResult, result);

         }

       [Test]
        public void TestingCustomExceptionProductNotFound()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            CustomerService customerService = new CustomerService(customerRepository);
            TestDelegate testdelegate = () =>
            {
                bool result = customerService.deleteCustomer(1000);
                if (result == false)
                {
                    throw new CustomerNotFoundException();

                }
            };
            Assert.That(testdelegate, Throws.Exception.TypeOf(typeof(CustomerNotFoundException)), "Customer is Not Available");
        }


        [Test]
        public void TestingCustomExceptionCustomerNotFound()
        {
            ProductRepository productRepository = new ProductRepository();
            ProductService productService = new ProductService(productRepository);
            TestDelegate testdelegate = () =>
            {
                bool result = productService.deleteProduct(1000);
                if (result == false)
                {
                    throw new ProductNotFoundException();

                }
            };
            Assert.That(testdelegate, Throws.Exception.TypeOf(typeof(ProductNotFoundException)), "Product is Not Available");
        }




    }
}
