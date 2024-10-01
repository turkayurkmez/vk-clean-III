// See https://aka.ms/new-console-template for more information
using ISP;

Console.WriteLine("Hello, World!");
/*
 *  Bir sınıf bir interface'i implemente ediyorsa; aldığı tüm interface üyelerini geliştirmek zorundadır!
 *  
 *  Bir sınıftaki bir üye mutlaka bir interface'a bağlı olmak zorunda değildir.
 *  
 *  
 */


SalesInfoRepository salesInfoRepository = new SalesInfoRepository();
ProductRepository productRepository = new ProductRepository();
DataComponent dataComponent = new DataComponent();

dataComponent.Search(productRepository,"test");
