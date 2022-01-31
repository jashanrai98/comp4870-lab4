using lab4_.Models;

namespace lab4.Data;

public class SampleData
{
    public static Province BC = new Province() {
                provCode="BC",
                provName="British Columbia",
                cities = new List<City>(){}
    };
    public static Province AB = new Province() {
                provCode="AB",
                provName="Alberta",
                cities = new List<City>(){}
    };
    public static Province ON = new Province() {
                provCode="ON",
                provName="Ontario",
                cities = new List<City>(){}
    };

    public static City van = new City() {
            cityId = 1,
            cityName = "Vancouver",
            population = 12345,
            province = "BC",
    };
    public static City vic = new City() {
            cityId = 2,
            cityName = "Victoria",
            population = 23456,
            province = "BC",
    };
    public static City sry = new City() {
            cityId = 3,
            cityName = "Surrey",
            population = 34567,
            province = "BC",
    };
    public static City edm = new City() {
            cityId = 4,
            cityName = "Edmonton",
            population = 12345,
            province = "AB",
    };
            public static City cal = new City() {
            cityId = 5,
            cityName = "Calgary",
            population = 23456,
            province = "AB",
            };
            public static City red = new City() {
            cityId = 6,
            cityName = "Red Deer",
            population = 34567,
            province = "AB",
            };
            public static City tor = new City() {
            cityId = 7,
            cityName = "Toronto",
            population = 12345,
            province = "ON",
            };
            public static City ott = new City() {
            cityId = 8,
            cityName = "Ottawa",
            population = 23456,
            province = "ON",
            };
            public static City kan = new City() {
            cityId = 9,
            cityName = "Kanata",
            population = 34567,
            province = "ON",
            };
    public static List<Province> GetProvinces()
    {
        // BC.cities.Add(sry);
        // BC.cities.Add(van);
        // BC.cities.Add(vic);
        // AB.cities.Add(edm);
        // AB.cities.Add(cal);
        // AB.cities.Add(red);
        // ON.cities.Add(ott);
        // ON.cities.Add(tor);
        // ON.cities.Add(kan);

        List<Province> provinces = new List<Province>(){};
        provinces.Add(BC);
        provinces.Add(AB);
        provinces.Add(ON);

        return provinces;
    }

    

    public static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
            van, vic, sry, edm, cal, red, ott, tor, kan
        };

        return cities;
    }

    

}