CREATE TABLE [dbo].[Hotel]
(
	hotelID INT PRIMARY KEY IDENTITY (1, 1),
	hotelImageURL VARCHAR(500) NOT NULL,
	hotelName VARCHAR(255) NOT NULL,
	hotelLocation VARCHAR(255) NOT NULL,
	hotelPrice DECIMAL NULL ,
	hotelDescription VARCHAR(255) NOT NULL,
	hotelPopularity VARCHAR(255) 
)
