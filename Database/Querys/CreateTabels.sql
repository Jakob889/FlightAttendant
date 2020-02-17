-- ************************************** [Hotel]

CREATE TABLE [Hotel]
(
 [HotelID] int NOT NULL ,
 [Name]    varchar(50) NOT NULL ,
 [City]    varchar(50) NOT NULL ,
 [RoomNr]  int NOT NULL ,
 [from]    date NOT NULL ,
 [To]      date NOT NULL ,


 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED ([HotelID] ASC)
);
GO








-- ************************************** [Flight]

CREATE TABLE [Flight]
(
 [FlightNr] varchar(50) NOT NULL ,
 [From]     varchar(50) NOT NULL ,
 [To]       varchar(50) NOT NULL ,
 [Seats]    int NOT NULL ,


 CONSTRAINT [PK_Flight] PRIMARY KEY CLUSTERED ([Flightnr] ASC)
);
GO