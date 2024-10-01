// See https://aka.ms/new-console-template for more information
using OCP;

Console.WriteLine("Hello, World!");
/*
 * Bir nesne .....gelişime.... AÇIK .....değişime... KAPALI'dır
 *  
 */
Customer customer = new Customer { Name = "Türkay", Card = new Premium() };
OrderService orderService = new OrderService() { Customer = customer};
var totalPrice = orderService.GetTotalPrice(1000);

Console.WriteLine(totalPrice.ToString());
