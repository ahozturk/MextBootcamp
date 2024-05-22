using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        static List<string> summaries1 = new();
        static List<string> summaries2 = new();
        static List<string> summaries3 = new();

        [HttpGet]
        public string GetPrice()
        {
            Random random = new();
            int price = random.Next(1, 1000);
            string summary = "";

            if (price < 300)
                summary = summaries1[random.Next(summaries1.Count)];

            else if (price < 700)
                summary = summaries2[random.Next(summaries2.Count)];

            else if (price < 1000)
                summary = summaries3[random.Next(summaries3.Count)];

            return $"Price: {price} Summary: {summary}";
        }

        [HttpPost]
        public void AddSummary(string name, int selection)
        {
            if (selection == 1)
                summaries1.Add(name);

            else if (selection == 2)
                summaries2.Add(name);

            else if (selection == 3)
                summaries3.Add(name);
        }
    }
}
