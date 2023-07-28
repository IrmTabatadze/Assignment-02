using Task1;

var product1 = new List<Product>()
{
    new Product(){Id = 1, Brand = "Google", Name = "Google Pixel 7 Pro", Price = 500},
    new Product(){Id = 2, Brand = "Iphone",Name = "Iphone 13 Pro Max", Price = 3000},
    new Product(){Id = 3, Brand = "Samsung", Name = "Samsung Galaxy", Price = 3000},
    new Product(){Id = 4, Brand = "Google", Name = "Google Pixel 6", Price = 1000},
    new Product(){Id = 5, Brand = "Iphone", Name = "Iphone 11", Price = 980}

};

var product2 = new List<Product>()
{
    new Product(){Id = 1, Brand = "Lenovo", Name = "ThinkPad", Price = 1000},
    new Product(){Id = 2, Brand = "HP", Name = "Pavilion", Price = 500}
};
var product3 = new List<Product>()
{ 
    new Product(){Id = 1, Brand = "Samsung", Name = "Samsung Galaxy", Price = 80500},
    new Product(){Id = 2, Brand = "Hitachi", Name = "", Price = 680},
    new Product(){Id = 3, Brand = "Gorenie", Name = "", Price = 750}

};

var shop1 = new List<Shop>()
{
    new Shop(){Shopid = 1, products = product1},
    new Shop(){Shopid = 2, products = product2}
};

var shop2 = new List<Shop>()
{
    new Shop(){Shopid = 1, products= product2},
};

var shop3 = new List<Shop>()
{
    new Shop(){Shopid = 2, products = product3},
    new Shop(){Shopid = 3, products = product2}

};


//Union / UnionBy
var Unionshop = shop1.Union(shop2);
foreach (var shop in Unionshop)
{
    Console.WriteLine($"{shop.Shopid}");

    foreach (var product in shop.products)
    {
        Console.WriteLine($"brand: {product.Brand}, name: {product.Name}");
    }

}

Console.WriteLine("\nproducts: ");
var Unioproduct = product1.UnionBy(product2, x => x.Brand);
foreach (var product in Unioproduct)
{
    Console.WriteLine(product.Brand);
}


//Join
Console.WriteLine("\nShop 'join'");
var shopJoin = shop2.Join(shop1, x => x.Shopid, x => x.Shopid, (e, d) => e);
foreach (var str in shopJoin)
{
    foreach (var product in str.products)
    Console.WriteLine("{0} ", product.Name);
}


//GroupJoin
Console.WriteLine("\nShop 'Group Join'");
var shopGroupJoin = shop1.Join(product1, x => x.Shopid, p => p.Id, (x, prd) => new {name = prd, prdId = prd.Id});

foreach (var item in shopGroupJoin)
{
    Console.WriteLine(item.prdId);

    Console.WriteLine(item.name.Brand);
}


//GroupBy
Console.WriteLine("\nproduct 'Group By'");
var GroupByPrd = from p in product1
                 group p by p.Brand;

foreach (var IdGroup in GroupByPrd)
{
    Console.WriteLine("Brand Group: {0}", IdGroup.Key);

    foreach (Product p in IdGroup) 
        Console.WriteLine("Product name: {0}", p.Name);
}

Console.WriteLine("\nproduct 'Group By 2'");
var GroupByProd = product1.GroupBy(x => x.Price);
foreach (var IdGroup in GroupByProd)
{
    Console.WriteLine("Brand Group: {0}", IdGroup.Key);
    foreach (Product p in IdGroup)
        Console.WriteLine($"Product name: {p.Name}, Product price: {p.Price}");
}