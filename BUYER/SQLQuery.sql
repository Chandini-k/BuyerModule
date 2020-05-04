create table Buyer(bid int primary key,
username varchar(20) not null,
password varchar(20) not null,
email varchar(20) not null,
mobileno varchar(20) not null,
datetime date)
select * from Buyer
create table Category(cid int primary key,
cname varchar(20) not null,
cdetails varchar(20))
create table SubCategory(subid int primary key,
subname varchar(20) not null,
cid int foreign key references Category(cid),
sdetails varchar(20),
gst int)
create table Items(id int primary key,
categoryid int foreign key references Category(cid),
subcategoryid int foreign key references SubCategory(subid),
price varchar(20) not null,
itemname varchar(20) not null,
description varchar(20),
stockno int,
remarks varchar(20))
alter table Items add imagename varchar(50)
create table Purchasehistory(id int primary key,
bid int foreign key references Buyer(bid),
transactiontype varchar(20) not null,
itemid int foreign key references Items(id),
noofitems int,
datetime date not null,
remarks varchar(20))
ALTER TABLE Purchasehistory ADD transactionstatus varchar(20)
select * from Purchasehistory
create table Cart(id int primary key,
categoryid int foreign key references Category(cid),
subcategoryid int foreign key references SubCategory(subid),
bid int foreign key references Buyer(bid),
itemid int foreign key references Items(id),
price varchar(20) not null,
itemname varchar(20) not null,
description varchar(20),
stockno int,
remarks varchar(20),
imagename varchar(20))





