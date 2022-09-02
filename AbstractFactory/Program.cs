Console.Title = "Abstract Factory";

var canadaShoppingCartPurchaseFactory =   new CanadaShoppingCartPurchaseFactory();

var shoppingCartForCanada =new ShoppingCart(canadaShoppingCartPurchaseFactory);

shoppingCartForCanada.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();

var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);

shoppingCartForFrance.CalculateCosts();

Console.ReadKey();
