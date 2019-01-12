# Foundations c#


1) `List<type> = new List<type>();` before it used to be `ArrayList = new ArrayList()`
 where u can insert any object without specifying the type, but if u want to assign any element from array list
to a variable u have to explicitly declare its type like `int val = (int)list[0]` assuming that element indexed at 0
is an int.


2) Interfaces would be like a contract, forcing any class who calls it to implement a certain set of functionalities
for example we can have an interface for PRODUCT with `title, price`, so when ProductModel calls this interface
it will be forced to make a product with such params. On the top of that we can have an interface for DIGITALPRODUCT
which calls interface for PRODUCT which forces to make `title and price` params plus we can add an extra like 
`public int numberOfDownloads {get; set;}` so now anyone who calls DIGITALPRODUCT interface will be bound to make
`title, price and numberOfDownloads'.
- AN interface can also be used when defining List like `List<IProductModel> output = new List<IProductModel>()`


3)

