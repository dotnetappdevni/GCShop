Welcome to the Go Compare APi this api exposes one end point and some identity enpoints 
not required for the test though.

Basically an end point 

api Basket

That confirms to the rules you gave me

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
StockItems.

For the demo a did not stock items as we could hold
the stock in the discount groups.

To change the connection strings you can simply goto appsettings.development and edit the details there such as 

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=sql5104.site4now.net;Initial Catalog=db_a828de_gcshopapi;User ID=gcclient;Password=gc12345!@;TrustServerCertificate=True"
}
```
You need to change the data source and the catalog to the one you restore the database to

SQL Server 2019 Setup

I am using sql server 2019 and entity framework for the dal. If you go to the db scripts there is a bakup file of db am using 
sql server 2019.


Once you restore please make a login to match the one below which will match the connection string above you will need to change 
the data source to the one of your local sql 2019 instance.

```
User ID=gcclient;Password=gc12345!@;
```


I have also setup a small demo api at this location 

https://localhost:7066/swagger/index.html

Because I could not use your github actions a would have made one that allowed me to run the tests online so that can 
see visiblity of tests always passing.

I have also shown how a would normally seperate projects using folder structures
and using smaller self contained services and interfaces.