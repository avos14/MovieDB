CREATE TABLE [Series_2021] (
		[seriesID] int NOT NULL,
        [first_air_date] date NOT NULL ,
        [name] nvarchar (50) NOT NULL,
		[origin_country] nvarchar (30) NOT NULL,
		[original_language] nvarchar (30) NOT NULL,
		[overview] nvarchar (4000) NOT NULL,
		[popularity] float (2) NOT NULL,
		[poster_path] nvarchar (200) NOT NULL
	    Primary key (seriesID)
)


create table [Episode_2021] (
		[episodeID] int not null,
		[seasonNum] tinyint not null,
		[seriesName] nvarchar(50) not null,
		[episodeName] nvarchar (100) not null,
		[episodeImg] nvarchar (100),
		[episodeOverview] nvarchar (4000),
		[episodeAirdate] nvarchar (40),
		[seriesID] int NOT NULL,
		primary key(episodeID, seriesID),
		foreign key(seriesID) references [Series_2021](seriesID)
)


CREATE TABLE [Users_2021](
		[userID] smallint IDENTITY (1, 1) NOT NULL,
		[fname] varchar (30) NOT NULL,
		[lname] varchar (30) NOT NULL,
		[email] nvarchar (50) unique NOT NULL,
		[password] nvarchar (50) NOT NULL,
		[pnumber] nvarchar (20) NOT NULL,
		[gender] varchar (10) NOT NULL,
		[birthYear] smallint NOT NULL,
		[pGenre] nvarchar (30),
		[address] nvarchar (100) NOT NULL,
		[admin] BIT default 0 NOT NULL, 
		primary key ([userID])
) 

CREATE TABLE [Preferences_2021](
		[userID] smallint NOT NULL,
		[episodeID] int not null,
		[seriesID] int NOT NULL,
		foreign key([userID]) references [Users_2021]([userID]),
		foreign key(episodeID, seriesID) references [Episode_2021](episodeID, seriesID),
)
CREATE TABLE [Genres_2021](
	[userID] smallint not null,
	[seriesID] int not null,
	[genres] varchar (200),
	constraint user_series unique([userID],[seriesID])
)
insert into [Genres_2021] ([userID], [seriesID], [genres]) values (2, 1408, 'comedy')
select * from Genres_2021
select * from Genres_2021 where userID!=1 and seriesID!=71912


CREATE TABLE [Rating_2021](
		[ID] smallint IDENTITY (1, 1) NOT NULL,
		[userId] smallint NOT NULL,
		[seriesId] int NOT NULL,
		[rating] int not null,
		foreign key([userID]) references [Users_2021]([userID]),
)

drop table Genres_2021
drop table Preferences_2021
drop table Users_2021
drop table Series_2021
drop table Episode_2021
drop table Rating_2021

select * from Users_2021
select * from Series_2021
select * from Episode_2021
select * from Preferences_2021
select * from Rating_2021
SET IDENTITY_INSERT Users_2021 ON; 

select name from Series_2021 as s inner join Preferences_2021 as p on p.seriesID = s.seriesID where userID = 2 
select * from Episode_2021 as e inner join Preferences_2021 as p on p.episodeID = e.episodeID where e.seriesID = 1405 and userID = 2
select seriesID from Series_2021 where name = 'Rick and Morty'

update [Users_2021] set admin=1 where userId=2

