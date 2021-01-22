create table Responsible(id_responsible int not null primary key identity(1,1) ,
Full_name varchar(200) not null,
Startdate date not null,
id_adres int not null foreign key references Adres(id_adres) on delete cascade on update cascade);

