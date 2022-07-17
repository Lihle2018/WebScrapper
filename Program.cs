using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebScraper
{
    class Program
    {
        private static IWebDriver driver;
        static void Main(string[] args)
        {
           driver =new ChromeDriver();
           driver.Navigate().GoToUrl("https://freek53.xyz/K53_Book_Test/bookc_lightvehicle_test.php?username=1561522910&password=2114284569&userparent=sasa");
            var lines = driver.FindElements(By.ClassName("btext")).Select(x=>x.Text).ToArray();
           SaveToTextFileAsync(lines, "TestCLightVehicles.txt");
           // SaveToJasonFileAsync(lines, "TestCLightVehicles.json");
        }
        public static void SaveToTextFileAsync(string[] lines,string filename)
        {
             File.WriteAllLinesAsync(@$"C:\Users\LIhle\Desktop\{filename}", lines);
        }
        public static void SaveToJasonFileAsync(string[] lines, string filname)
        {
            string json = JsonSerializer.Serialize(lines);
            File.WriteAllText(@$"C:\Users\LIhle\Desktop\{filname}",json);
        }
    }
}
