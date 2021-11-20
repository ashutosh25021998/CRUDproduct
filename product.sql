CREATE DATABASE Product

CREATE TABLE ProductDetails (
    ProductId int primary key,
    ProductName varchar(255),
    Description varchar(500),
    Price int
);





insert into ProductDetails(ProductId,ProductName,Description,Price)values(0,'Pen','use and throw type',25)
insert into ProductDetails(ProductId,ProductName,Description,Price)values(1,'Bat','for playing cricket',3600)

select * from ProductDetails






