using System;
using System.Collections.Generic;

// Address class
class Address
{
    private string _street, _city, _state, _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}

// Customer class
class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetInfo()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}

// Product class
class Product
{
    private string _name, _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotal()
    {
        return _price * _quantity;
    }

    public string GetInfo()
    {
        return $"{_name} (ID: {_id})";
    }
}

// Order class
class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double GetTotal()
    {
        double total = 0;

        foreach (var p in _products)
        {
            total += p.GetTotal();
        }

        // Shipping cost
        total += _customer.LivesInUSA() ? 5 : 35;

        return total;
    }

    public void Display()
    {
        Console.WriteLine("Packing Label:");
        foreach (var p in _products)
        {
            Console.WriteLine(p.GetInfo());
        }

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(_customer.GetInfo());

        Console.WriteLine("\nTotal Cost: $" + GetTotal());
        Console.WriteLine("----------------------------------");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "A1", 800, 1));
        order1.AddProduct(new Product("Mouse", "B2", 20, 2));

        // Order 2 (International)
        Address addr2 = new Address("456 Avenida", "La Paz", "LP", "Bolivia");
        Customer cust2 = new Customer("Maria Lopez", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone", "C3", 500, 1));
        order2.AddProduct(new Product("Headphones", "D4", 50, 3));

        // Display orders
        order1.Display();
        order2.Display();
    }
}