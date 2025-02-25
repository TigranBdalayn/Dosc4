// Task 8: E-Commerce Product System
// Task: Create a class Product with:
// Fields name, price, and stockQuantity.
// Add a constructor that uses this to differentiate between parameters and fields.
// In Main(), create a product and display its details.

using System;

class Product {
    private string _name;
    private double _price;
    private int _stockQuantity;

    public string Name {
        get {return _name;}
        set {_name = value;}
    }
    public Product (string name, double price, int stockquantity) {
        _name = name;
        _price = price;
        _stockQuantity = stockquantity;       
    }

    public void Display () {

        Console.WriteLine ($"\nName: {_name}\nPrice: {_price}\nStock Quantity: {_stockQuantity}\n");
    }
}

class Program {
    static void Main (string[] args) {

        Product Product1 = new Product ("Apple", 100, 4000);
        Product1.Display ();
        Product Product2 = new Product ("XX", 199.85, 5000);
        Product2.Display ();
        Product2.Name = "Abricot";
        Product2.Display();

    }
}
