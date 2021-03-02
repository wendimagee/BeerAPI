using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BeerApp.Models
{
    public class BeerDAL
    {
        public string GetData(string name)
        {
            string url = @$"https://sandbox-api.brewerydb.com/v2/search/?key={Secret.BreweryAPIKey}&&q=America";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();

            return JSON;
        }

        public List<Beer> SearchBeers(string name)
        {
            string json = GetData(name);
            AmericanBeer r = JsonConvert.DeserializeObject<AmericanBeer>(json);
            List<Beer> beers;
            if(r.data == null)
            {
                //make and pass along an empty list so you don't 
                beers = new List<Beer>();
            }
            else
            {
                beers = r.data.ToList();
            }
            return beers;
        }


    }
}
