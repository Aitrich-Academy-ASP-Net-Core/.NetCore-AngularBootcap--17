create table Product(prduct int primary key,ProductName varchar(20),Price int);
insert into Product Values(1,'Laptop',50000);
insert into Product Values(2,'Smartphone',25000);
insert into Product Values(3,'Tablet',30000);
insert into Product Values(4,'Smartwatch',10000);
select * from Product;





create table Sale(SaleID int,ProductID int,FOREIGN KEY(ProductID) REFERENCES Product(prduct),Quantity int,SaleDate datetime);
insert into Sale values(101,1,3,'2024-03-01');
insert into Sale values(102,2,5,'2024-03-02');
insert into Sale values(103,1,2,'2024-03-05');
insert into Sale values(104,3,1,'2024-03-06');
insert into Sale values(105,2,3,'2024-03-07');
insert into Sale values(106,2,0,'2024-03-08');
insert into Sale values(108,4,3,'2024-04-06');
insert into Sale values(109,5,2,'2024-06-06');
insert into Sale values(110,1,1,'2024-02-06');
insert into Sale values(111,4,5,'2024-03-12');
select * from Sale;

--TOTAL REVENUE GENERATED--
SELECT 
	Product.prduct,
	Product.ProductName,
	SUM(Product.Price * Sale.Quantity) AS TotalRevenueGenerated
FROM Product JOIN Sale  ON prduct=ProductID
GROUP BY Product.prduct,Product.ProductName,Sale.Quantity;

--BEST SELLING PRODUCT--
SELECT 
p.Prduct,
p.ProductName,SUM(s.Quantity) AS BestSelling
FROM Product p JOIN Sale s ON p.prduct=s.ProductID
GROUP BY p.prduct,p.ProductName
ORDER BY BestSelling DESC;

--PRODUCT THATS NEVER BEEN SOLD--
SELECT Sale.Quantity,Sale.ProductID,Product.ProductName FROM Sale JOIN Product ON Sale.ProductID=Product.prduct WHERE Sale.Quantity=0
GROUP BY Sale.ProductID,Sale.Quantity,Product.ProductName;

--TOTAL REVENUE GENERATED IN THE MONTH OF MARCH--
SELECT Product.ProductName,Sale.ProductID,SUM(Product.Price*Sale.Quantity) AS TotalRevenueInMarch
FROM Product JOIN Sale ON Product.prduct=Sale.ProductID WHERE Sale.SaleDate>='2024-03-01' AND Sale.SaleDate<='2024-04-01'
GROUP BY Sale.ProductID,Product.ProductName;

