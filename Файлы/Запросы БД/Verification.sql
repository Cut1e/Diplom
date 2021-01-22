create table Verification(id_verification int not null primary key identity(1,1),
start_verification date not null,
end_verification date,
Returned bit,
id_witness int not null foreign key references The_witness(id_witness) on delete cascade on update cascade,
id_means varchar(100) not null foreign key references Means(id_means) on delete cascade on update cascade,
id_result int foreign key references Result(id_result) on delete cascade on update cascade);
