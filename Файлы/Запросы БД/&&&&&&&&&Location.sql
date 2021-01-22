create table Location(id_location int not null primary key identity(1,1) ,
Responsible int not null foreign key references Responsible(id_responsible) on delete cascade on update cascade,
Place int not null foreign key references Place(id_place) on delete cascade on update cascade);
