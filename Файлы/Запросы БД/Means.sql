create table Means(id_means varchar(100) not null primary key,
startdate date not null,
id_means_type_code int not null foreign key references Means_type_code(id_means_type_code) on delete cascade on update cascade,
id_responsible int not null foreign key references Responsible(id_responsible) on delete cascade on update cascade);
