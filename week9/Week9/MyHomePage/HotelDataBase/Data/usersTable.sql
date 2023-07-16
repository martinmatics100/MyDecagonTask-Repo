DELETE FROM users

SET IDENTITY_INSERT users ON 

INSERT INTO users (Id, FirstName, LastName, Email, Pwd, DateCreation)
VALUES (1,'Martin', 'Nwatu', 'martinchukwuemeka67@gmail.com', '85465955', '2023-07-05 18:56:00')

INSERT INTO users ( ID, FirstName, LastName, Email, Pwd, DateCreation)
VALUES (2,'John', 'Kehinde', 'unheophilus@gmail.com', '00000000', '2023-07-05 18:56:00')

