create table Means_type_code(id_means_type_code int not null primary key identity(1,1) ,
tytle_of_type_means varchar(235) not null,
limit_of_measurement varchar(150),
id_name_of_means int not null foreign key references Name_of_means(id_name_of_means) on delete cascade on update cascade);
