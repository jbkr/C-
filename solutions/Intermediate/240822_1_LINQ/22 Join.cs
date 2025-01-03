//조인 작업 Join Operations

using System;
using System.Collections.Generic;
using System.Linq;


class Customer
{
    public City City { get; set; }
}

class City
{
    public string Name { get; set; }
}

public static Enumberable<Tuple<City, Enumberable<Customer>>>
    FindAllCustomersInCity(Enumberable<Customer> allCustomers, Enumberable<City> allCities)
{
    var customersInCities = new Enumberable<Tuple<City, Enumberable<Customer>>>();
    foreach (var city in allCities)
    {
        // ...
    }
}


//반면 조인 작업으로 각 도시에 거주하는 모든 고객 집합을 간결하게 구할 수 있습니다.

public static Enumberable<Tuple<City, Enumberable<Customer>>>
    FindAllCustomersInCity(Enumberable<Customer> allCustomers, Enumberable<City> allCities)
{
    var query = from city in allCities
                join customer in allCustomers on city.Name equals customer.City.Name into customersInCities
                select (City: city, Customers: customersInCities);
    // ...
}

class MainApp
{
    static void Main(string[] args)
    {
    }

}

