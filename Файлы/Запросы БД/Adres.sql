create table Adres(id_adres int not null primary key identity(1,1) ,
Title_of_adres varchar(350) not null,
id_position int not null foreign key references Position(id_position) on delete cascade on update cascade);