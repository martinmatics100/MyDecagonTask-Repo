/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DELETE FROM Hotel


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section2.png', 'Blue Origin Fams', 'Jakarta', 50, 'null', 'Most Picks')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section2(1).png', 'Ocean Land', 'Bandung', 22, 'null', 'Most Picks')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section2(2).png', 'Stark House', 'Malang', 856, 'null', 'Most Picks')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section2(3).png', 'Vinna Vill', 'Malang', 62, 'null', 'Most Picks')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section2(4).png', 'Bobox', 'Medan', 72, 'null', 'Most Picks')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section3.png', 'Shabby Town', 'Gunung Batu', 0 , 'beauty backyard', 'Popular Choice')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section3(1).png', 'Anganna ', 'Bogor', 0 , 'beauty backyard', 'null')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section3(2).png', 'Seattle Rain', 'Jakarta', 0 , 'beauty backyard', 'null')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section3(3).png', 'Wooden Pit', 'Wonosoba', 0 , 'beauty backyard', 'null')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section44.png', 'Green Park', 'Tangarang', 0 , 'living room', 'null')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section4(1).png', 'Podo Wae', 'Padiun', 0 , 'living room', 'null')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section4(2).png', 'Silver Rain', 'Bandung ', 0 , 'living room', 'null')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section4(3).png', 'Cashville', 'Kemang', 0 , 'living room', 'Popular Choice')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section5.png', 'PS Wood', 'Depok', 0 , 'Apartment', 'null')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section5(1).png', 'One Five', 'Jakarta', 0 , 'Apartment', 'null')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section5(2).png', 'Minimal', 'Bogor', 0 , 'Apartment', 'Popular Choice')


INSERT INTO Hotel (hotelImageURL, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity)
VALUES ('https://staycationhotels.blob.core.windows.net/staycation/section5(3).png', 'Stays Home', 'Wonosoba', 0 , 'Apartment', 'null')
DELETE FROM users

SET IDENTITY_INSERT users ON 

INSERT INTO users (Id, FirstName, LastName, Email, Pwd, DateCreation)
VALUES (1,'Martin', 'Nwatu', 'martinchukwuemeka67@gmail.com', '85465955', '2023-07-05 18:56:00')

INSERT INTO users ( ID, FirstName, LastName, Email, Pwd, DateCreation)
VALUES (2,'John', 'Kehinde', 'unheophilus@gmail.com', '00000000', '2023-07-05 18:56:00')


GO
