using System;
using System.Text.Json;

namespace Homework8_5
{
    class Program
    {
        static void Main(string[] args)
        {

            User jsonBody = new User();

            jsonBody.ClientId = 6106;
            jsonBody.OrderId = 2424;
            jsonBody.DateTime = DateTime.Now.ToString();
            jsonBody.Longitude = "46.3333";
            jsonBody.Latitude = "56.3333";


            string jsonString = JsonSerializer.Serialize(jsonBody);


            Console.WriteLine(jsonString);

            Console.ReadKey();
        }
    }
}
