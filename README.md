Welcome to the Go Compare API. 
This API exposes one endpoint and some identity endpoints,
although they are not required for the test. The main 
endpoint is

api/Basket. 

There is a Swagger UI available
so you can test the rules that the asserts are tested against,
and it should work for others. 

This confirms to the rules you provided.
```
| Item | Price | Offer      |
|------|-------|------------|
| A    | 50    | 3 for 130  |
| B    | 30    | 2 for 45   |
| C    | 20    | No offer   |
| D    | 15    | No offer   |
```

The unit tests are run of a sql lite in memory instant so can moq 
through with data.

The assertions also match what was sent to me.
```
- Assert.That(0, Is.EqualTo(price_of("")))
- Assert.That(50, Is.EqualTo(price_of("A")))
- Assert.That(80, Is.EqualTo(price_of("AB")))
- Assert.That(115, Is.EqualTo(price_of("CDBA")))
- Assert.That(100, Is.EqualTo(price_of("AA")))
- Assert.That(130, Is.EqualTo(price_of("AAA")))
- Assert.That(175, Is.EqualTo(price_of("AAABB")))
```

Bit of configuration 

<h2>Database</h1>
I have encluded a database because of the dyanmic nature we wanted to achieve.
So it contains tables such as 
DiscountGroups
PriceList

To change the connection strings, you can simply go to appsettings.development and edit the details there, 


```
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=sql5104.site4now.net;Initial Catalog=db_a828de_gcshopapi;User ID=gcclient;Password=gc12345!@;TrustServerCertificate=True"
}
```


You need to change the data source and the catalog to match the one you restored the database to.

SQL Server 2019 Setup

I am using SQL Server 2019 and Entity Framework for the DAL. If you go to the DB scripts, there is a backup file of the database I am using with SQL Server 2019.

Once you restore it, please create a login to match the one below, 
which will correspond to the connection string above. 
You will need to change the data source to the one of your
local SQL Server 2019 instance."
```
User ID=gcclient;Password=gc12345!@;
```


I have also setup a small demo api at this location 

https://localhost:7066/swagger/index.html

Because I could not use your GitHub actions,
I would have made one that allowed me to run the tests online,
so I can see the visibility of tests always passing.

I have also shown how I would normally separate projects using folder structures and using smaller, 
self-contained services and interfaces.