# Foundations c#


1) `List<type> = new List<type>();` before it used to be `ArrayList = new ArrayList()`
 where u can insert any object without specifying the type, but if u want to assign any element from array list
to a variable u have to explicitly declare its type like `int val = (int)list[0]` assuming that element indexed at 0
is an int.
A list can also be defined by type of interface like `List<IDataAccess> = new List<IDataAccess>();` or
```
List<IDataAccess> = new List<IDataAccess>(){
	new SqlDataAcess(),
	new TextFileDataAcess()


};
```
 that implies that both of them have similar functionality to some extend, foreach loops etc could be used
Another element is that we can make lists based on abstract classess following the same pattern, just replacing 
`IDataAccess` to abstract class name and achieve the same result


2) Interfaces 
would be like a contract, forcing any class who calls it to implement a certain set of functionalities
for example we can have an interface for PRODUCT with `title, price`, so when ProductModel calls this interface
it will be forced to make a product with such params. On the top of that we can have an interface for DIGITALPRODUCT
which calls interface for PRODUCT which forces to make `title and price` params plus we can add an extra like 
`public int numberOfDownloads {get; set;}` so now anyone who calls DIGITALPRODUCT interface will be bound to make
`title, price and numberOfDownloads'.
- AN interface can also be used when defining List like `List<IProductModel> output = new List<IProductModel>()`
and inside of this list you can many different models but they have to either inherit from IProductModel or implement it directly

3) Delegates, Func, Action, 
you can declare a delegate by `public delegate void DelegateName(string Prop)`, which will allow another function
accept the entire method rather than prop. Func is almost the same as delegate, its NOT void and usually returns something
`Func<List<ProductModel>,decimal,decimal> calculateDiscountedTotal` which means it accepts a list, and a decimal and returns decimal, 
the last prop is the output. Action is the same as delegate but its just u dont need to declare it implicitly as with delegate `Action<string> tellUserWeAreDiscounting`
action of a type string, so method passed to it should take string as a prop.

4) Access modifiers
- Private` private void Function()` is accessable only within the current class
- Internal `internal void Function()` is accessable by the project (assembly)(solution)
- Public `public void Function()` is accessable by everything
- Protected `protected void Function()`is accessable only within the current class and inherited class
- Private Protected `private protected void Function()`is accessable only in the same (assembly)(solution) who inherits it
- Protected Internal `protected internal void Function()` is accessable by the same (assembly)(solution) and whoever inherits from it

5) Abstract class
Is almost the same as interface `public abstract class Name` but it allows you not only to declare required functions
but also include the implementation of some of the methods that you think should be shared across other classess that inherit from it.
You also cant make an object out of abstract class but only from the ones that inherited it. Then after you defined method implementation in abstract class
you can also add other empty methods that are required by any class that inherits from it (just like an interface), `public abstract void DoSome(string Prop)`.
Now anything that inherits from that abstract class will have the so called implemented method, and empty methods that inherited class should define.

If we want to allow some overriding functionality to defined method in abstract class we need to add `public virtual string Name(string Prop)`
that will allow us to override it in inherited class. `string output = base.Name(Prop)` do some manipulation with this output and eventually return it.

6) Dynamic and Var
`var number = 1` from now on, only ints can be assigned
`dynamic number = 1` is an int but can become `dynamic number 1.1` decimal. Types can be changed
Can also make objects, methods(can return any type) with them, but dynamic might give more errors during runtime. Usually used when integrating other languages
like python, ruby etc.
Var can be used like `var PeopleList = new List<List<Person>>();` and then `foreach (var person in PeopleList)` which essentially makes it quite clear what its doing.
Or to create anonymous objects like `var item = new {firstName: "Stas"}` it doesnt have a type, hence var is a good option.

7) Connection strings to SQL (Dapper)
Install Dapper through Nuggets, go to App.Config and there in between configuration brackets add 
```
<connectionStrings>

//can add more connections in here, just when making a connection need to specify what DB trying to connect
//for more information can go to connection string documentation

<add name="DB_name" connectionString ="Server.(here you add ur server);Database=(name of db);Trusted_Connection=True;(or use ur credentials) providerName="System.Data.SqlClient " />
</connectionStrings>

```
Then wherever you want to establish connection in your app do the following code, by typing `using` it will create a connection when called
and close it once its finished doing all the work
```
using (IDbConnection connection = new MySqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                
		//use procedures for doing all the work with db
                connection.Execute("spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                
            }
```