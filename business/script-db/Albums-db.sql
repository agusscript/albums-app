use master
go
create database ALBUMS_DB
go
USE ALBUMS_DB
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GENRES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
 CONSTRAINT [PK_GENRES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO
USE ALBUMS_DB
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE ALBUMS_DB
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALBUMS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](100) NULL,
	[Author] [varchar] (100) NULL,
	[ReleaseDate] [smalldatetime] NULL,
	[AmountTracks] [int] NULL,
	[UrlCoverImage] [varchar](400) NULL,
	[IdGenre] [int] NULL,
 CONSTRAINT [PK_ALBUMS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO
USE ALBUMS_DB
GO
INSERT INTO GENRES VALUES ('Heavy Metal')
INSERT INTO GENRES VALUES ('Hard Rock')
INSERT INTO GENRES VALUES ('Metalcore')
INSERT INTO GENRES VALUES ('Rock')
INSERT INTO GENRES VALUES ('Grunge')
INSERT INTO GENRES VALUES ('Pop')
INSERT INTO GENRES VALUES ('Progressive Rock')

INSERT INTO ALBUMS VALUES ('Highway to Hell', 'AC/DC', '07-27-1979', 10, 'https://upload.wikimedia.org/wikipedia/en/a/ac/Acdc_Highway_to_Hell.JPG', 2)
INSERT INTO ALBUMS VALUES ('Fear of the Dark', 'Iron Maiden', '05-11-1992', 12, 'https://upload.wikimedia.org/wikipedia/en/e/eb/Iron_Maiden_-_Fear_Of_The_Dark.jpg', 1)
INSERT INTO ALBUMS VALUES ('City of Evil', 'Avenged Sevenfold' ,'06-06-2005', 11, 'https://upload.wikimedia.org/wikipedia/en/7/7b/City_of_Evil_album_cover.jpg', 1)
INSERT INTO ALBUMS VALUES ('Burn', 'Deep Purple', '02-15-1974', 8, 'https://upload.wikimedia.org/wikipedia/en/3/3d/Deep_Purple_-_Burn.jpeg', 2)
INSERT INTO ALBUMS VALUES ('Reverence','Parkway Drive','04-05-2018', 10, 'https://upload.wikimedia.org/wikipedia/en/a/ac/Parkway_Drive_-_Reverence.jpg', 1)
INSERT INTO ALBUMS VALUES ('The Wall', 'Pink Floyd', '11-30-1979', 26, 'https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/The_Wall_Cover.svg/250px-The_Wall_Cover.svg.png', 7)
INSERT INTO ALBUMS VALUES ('Appetite for Destruction', 'Guns N Roses', '07-21-1987', 12, 'https://upload.wikimedia.org/wikipedia/en/6/60/GunsnRosesAppetiteforDestructionalbumcover.jpg', 2)
INSERT INTO ALBUMS VALUES ('Let it be', 'The Beatles', '05-08-1970', 12, 'https://upload.wikimedia.org/wikipedia/en/2/25/LetItBe.jpg', 4)
INSERT INTO ALBUMS VALUES ('Ride the Lightning', 'Metallica', '07-27-1984', 8, 'https://upload.wikimedia.org/wikipedia/en/f/f4/Ridetl.png', 1)
INSERT INTO ALBUMS VALUES ('Paranoid', 'Black Sabbath', '09-18-1970', 8, 'https://upload.wikimedia.org/wikipedia/en/6/64/Black_Sabbath_-_Paranoid.jpg', 1)
INSERT INTO ALBUMS VALUES ('Waking the fallen', 'Avenged Sevenfold', '05-08-2003', 12, 'https://upload.wikimedia.org/wikipedia/en/a/a5/WakingTheFallen.jpg', 1)
INSERT INTO ALBUMS VALUES ('Tattoo You', 'The Rolling Stones', '08-24-1981', 11, 'https://upload.wikimedia.org/wikipedia/en/1/16/TattooYou81.jpg', 4)
INSERT INTO ALBUMS VALUES ('Rising', 'Rainbow', '03-17-1976', 7, 'https://upload.wikimedia.org/wikipedia/en/6/68/RainbowRainbowRising.jpg', 1)
INSERT INTO ALBUMS VALUES ('Led Zeppelin IV', 'Led Zeppelin', '12-08-1971', 8, 'https://upload.wikimedia.org/wikipedia/en/2/26/Led_Zeppelin_-_Led_Zeppelin_IV.jpg', 2)
INSERT INTO ALBUMS VALUES ('Holy Diver', 'Dio', '05-25-1983', 9, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSc8Kklj_taxDnl3_xgHTcusULWPEjzA0I0VWlSpXYbLzal54Y5mKn-EoHdKjZ093ax_lY&usqp=CAU', 4)
INSERT INTO ALBUMS VALUES ('Rust in Peace', 'Megadeth', '09-16-1990', 10, 'https://upload.wikimedia.org/wikipedia/en/d/dc/Megadeth-RustInPeace.jpg', 1)
INSERT INTO ALBUMS VALUES ('The Dark Side of the Moon', 'Pink Floyd', '03-01-1973', 9, 'https://files.soniccdn.com/images/articles/original/37685.jpg', 1)
INSERT INTO ALBUMS VALUES ('Master of Puppets', 'Metallica', '03-03-1986', 8, 'https://upload.wikimedia.org/wikipedia/en/b/b2/Metallica_-_Master_of_Puppets_cover.jpg', 1)
INSERT INTO ALBUMS VALUES ('The Number of the Beast', 'Iron Maiden', '03-29-1982', 8, 'https://upload.wikimedia.org/wikipedia/en/thumb/3/32/IronMaiden_NumberOfBeast.jpg/220px-IronMaiden_NumberOfBeast.jpg', 1)
INSERT INTO ALBUMS VALUES ('Back in Black', 'AC/DC', '07-25-1980', 10, 'https://static.wikia.nocookie.net/acdc/images/1/1d/220px-ACDC_Back_in_Black.png/revision/latest/zoom-crop/width/500/height/500?cb=20110413185621', 2)
INSERT INTO ALBUMS VALUES ('Slave to the Grind', 'Skid Row', '06-11-1991', 12, 'https://i.discogs.com/B_xQUiAEfmi798pJF0G8vu-wi2YbNiRF55puhAIoZcs/rs:fit/g:sm/q:90/h:600/w:596/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTExMDMz/NDgzLTE1MDg2MTY2/NDgtODg5MC5qcGVn.jpeg', 2)
INSERT INTO ALBUMS VALUES ('In the Court of the Crimson King', 'King Crimson', '10-10-1969', 5, 'https://m.media-amazon.com/images/I/71FM257lYjL._UF894,1000_QL80_.jpg', 7)
INSERT INTO ALBUMS VALUES ('Machine Head','Deep Purple','03-25-1972', 7, 'https://upload.wikimedia.org/wikipedia/en/0/00/Machine_Head_album_cover.jpg', 2)
INSERT INTO ALBUMS VALUES ('Phenomenon', 'UFO', '05-01-1974', 10, 'https://sfae.blob.core.windows.net/media/ecommercesite/media/sfae/sfae.artwork/3232_1.jpg', 2)
INSERT INTO ALBUMS VALUES ('A Night at the Opera', 'Queen', '11-21-1975', 17, 'https://upload.wikimedia.org/wikipedia/en/thumb/4/4d/Queen_A_Night_At_The_Opera.png/220px-Queen_A_Night_At_The_Opera.png', 4)
INSERT INTO ALBUMS VALUES ('Toys in the Attic', 'Aerosmith', '04-08-1975', 9, 'https://upload.wikimedia.org/wikipedia/en/3/37/Aerosmith_-_Toys_in_the_Attic.jpg', 2)
INSERT INTO ALBUMS VALUES ('Blizzard of Ozz', 'Ozzy Osbourne', '09-20-1980', 8, 'https://upload.wikimedia.org/wikipedia/en/2/23/Blizzard_of_ozz.jpg', 1)
INSERT INTO ALBUMS VALUES ('The Final Countdown','Europe','05-26-1986',10,'https://cdgo.com/thumbnail/370/4492799', 2)
INSERT INTO ALBUMS VALUES ('Hysteria','Def Leppard','08-03-1987', 12, 'https://upload.wikimedia.org/wikipedia/en/4/40/Def_Leppard_-_Hysteria_%28vinyl_version%29.jpg', 2)
INSERT INTO ALBUMS VALUES ('Ten','Pearl Jam','08-27-1991', 13, 'https://rockthebestmusic.com/wp-content/uploads/2017/01/ten-pearl-jam-portada.jpg', 7)
INSERT INTO ALBUMS VALUES ('1984', 'Van Halen', '01-27-1984', 8, 'https://upload.wikimedia.org/wikipedia/en/5/5f/Van_Halen_-_1984.jpg', 2)
INSERT INTO ALBUMS VALUES ('Painkiller', 'Judas Priest', '09-15-1990', 10, 'https://upload.wikimedia.org/wikipedia/en/1/16/Judaspainkiller.JPG', 1)
INSERT INTO ALBUMS VALUES ('Silence in the Snow', 'Trivium', '02-09-2015', 13, 'https://upload.wikimedia.org/wikipedia/en/f/fc/Silence_in_the_Snow.jpeg', 1)
INSERT INTO ALBUMS VALUES ('Forevermore', 'Whitesnake', '03-29-2011', 13, 'https://upload.wikimedia.org/wikipedia/en/9/94/Whitesnake_Forevermore.jpg', 4)









