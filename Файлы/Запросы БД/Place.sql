create table Place(id_place int not null primary key identity(1,1) ,
Title_of_place varchar(350) not null,
id_position int not null foreign key references Position(id_position) on delete cascade on update cascade);