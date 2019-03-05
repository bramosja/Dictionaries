using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AMZN", "Amazon");
            stocks.Add("GOOGL", "Google");
            stocks.Add("MSFT", "Microsoft");
            stocks.Add("AAPL", "Apple");
            stocks.Add("INTC", "Intel");
            stocks.Add("XOM", "Exxon Mobil");

            string GM = stocks["GM"];
            string CAT = stocks["CAT"];
            string AMZN = stocks["AMZN"];
            string GOOGL = stocks["GOOGL"];
            string MSFT = stocks["MSFT"];
            string AAPL = stocks["AAPL"];
            string INTC = stocks["INTC"];
            string XOM = stocks["XOM"];

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

            purchases.Add(new Dictionary<string, double>(){ {"GM", 230.21} });
            purchases.Add(new Dictionary<string, double>(){ {"GM", 580.98} });
            purchases.Add(new Dictionary<string, double>(){ {"GM", 406.34} });
            purchases.Add(new Dictionary<string, double>(){ {"CAT", 832.32} });
            purchases.Add(new Dictionary<string, double>(){ {"CAT", 992.87} });
            purchases.Add(new Dictionary<string, double>(){ {"AMZN", 716.19} });
            purchases.Add(new Dictionary<string, double>(){ {"GOOGL", 123.54} });
            purchases.Add(new Dictionary<string, double>(){ {"MSFT", 823.11} });
            purchases.Add(new Dictionary<string, double>(){ {"AAPL", 556.82} });
            purchases.Add(new Dictionary<string, double>(){ {"AAPL", 298.10} });
            purchases.Add(new Dictionary<string, double>(){ {"INTC", 672.40} });
            purchases.Add(new Dictionary<string, double>(){ {"XOM", 15.78} });

            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            foreach (Dictionary<string, double> purchase in purchases) {
                foreach (KeyValuePair<string, double> stock in purchase) {
                    if (stockReport.ContainsKey(stocks[stock.Key])) {
                        stockReport[stocks[stock.Key]] += stock.Value;

                    } else {
                        stockReport.Add(stocks[stock.Key], stock.Value);
                    }
                }
            }

            foreach(KeyValuePair<string, double> item in stockReport){
                Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
            }

            // PLANETS

            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();


            probes.Add(new Dictionary<string, string> { {"Mars", "Viking"} });
            probes.Add(new Dictionary<string, string> { {"Mars", "Opportunity"} });
            probes.Add(new Dictionary<string, string> { {"Mars", "Curiosity"} });
            probes.Add(new Dictionary<string, string> { {"Venus", "Mariner"} });
            probes.Add(new Dictionary<string, string> { {"Venus", "Venera" } });
            probes.Add(new Dictionary<string, string> { {"Mars", "Pathfinder" } });
            probes.Add(new Dictionary<string, string> { {"Jupiter", "Galileo" } });
            probes.Add(new Dictionary<string, string> { {"Saturn", "Cassini" } });

            foreach (string planet in planetList) {
                List<string> matchingProbes = new List<string>();

                foreach(Dictionary<string, string> probe in probes) {
                    if (probe.ContainsKey(planet)) {
                        matchingProbes.Add(probe[planet]);
                    }
                }

                string probeList = "";
                foreach(string probe in matchingProbes){
                    probeList = String.Join(", ", matchingProbes);
                }

                Console.WriteLine($"{planet}: {probeList}");
            }
        }
    }
}
