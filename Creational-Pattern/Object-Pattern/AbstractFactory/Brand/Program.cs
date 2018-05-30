using System;

namespace AbstractFactory.Brand
{
    class Program
    {
        /// <summary>
        /// 'Client' Application
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Call Client thrice
            new Client<Poochy>().ClientMain();
            new Client<Gucci>().ClientMain();
            new Client<Groudcover>().ClientMain();
            
            //Wait for user
            Console.Read();        
        }
     }
}
