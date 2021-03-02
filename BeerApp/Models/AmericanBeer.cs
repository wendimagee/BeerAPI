using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerApp.Models
{
    //property path AmericanBeer.Datum[0].name
        public class AmericanBeer
        {
            public int currentPage { get; set; }
            public int numberOfPages { get; set; }
            public int totalResults { get; set; }
            public Beer[] data { get; set; }
            public string status { get; set; }
        }

        public class Beer
        {
            public string id { get; set; }
            public string name { get; set; }
            public string nameDisplay { get; set; }
            public string description { get; set; }
            public string abv { get; set; }
            public int styleId { get; set; }
            public string isOrganic { get; set; }
            public string isRetired { get; set; }
            public string status { get; set; }
            public string statusDisplay { get; set; }
            public string createDate { get; set; }
            public string updateDate { get; set; }
            public Style style { get; set; }
            public string type { get; set; }
            public string ibu { get; set; }
            public int availableId { get; set; }
            public int year { get; set; }
            public Labels labels { get; set; }
            public Available available { get; set; }
            public int glasswareId { get; set; }
            public string originalGravity { get; set; }
            public Glass glass { get; set; }
            public int srmId { get; set; }
            public string servingTemperature { get; set; }
            public string servingTemperatureDisplay { get; set; }
            public Srm srm { get; set; }
        }

        public class Style
        {
            public int id { get; set; }
            public int categoryId { get; set; }
            public Category category { get; set; }
            public string name { get; set; }
            public string shortName { get; set; }
            public string description { get; set; }
            public string ibuMin { get; set; }
            public string ibuMax { get; set; }
            public string abvMin { get; set; }
            public string abvMax { get; set; }
            public string srmMin { get; set; }
            public string srmMax { get; set; }
            public string ogMin { get; set; }
            public string fgMin { get; set; }
            public string fgMax { get; set; }
            public string createDate { get; set; }
            public string updateDate { get; set; }
        }

        public class Category
        {
            public int id { get; set; }
            public string name { get; set; }
            public string createDate { get; set; }
        }

        public class Labels
        {
            public string icon { get; set; }
            public string medium { get; set; }
            public string large { get; set; }
            public string contentAwareIcon { get; set; }
            public string contentAwareMedium { get; set; }
            public string contentAwareLarge { get; set; }
        }

        public class Available
        {
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }

        public class Glass
        {
            public int id { get; set; }
            public string name { get; set; }
            public string createDate { get; set; }
        }

        public class Srm
        {
            public int id { get; set; }
            public string name { get; set; }
            public string hex { get; set; }
        }

    }

