CREATE DATABASE Pagination;

CREATE TABLE Logs (
    [Id]              BIGINT IDENTITY(1,1) NOT NULL, 
    [UserName]        NVARCHAR(200)        NULL,  
    [Severity]        NVARCHAR(128)        NULL,  
    [Message]         NVARCHAR(max)        NULL,  
    [TimeStamp]       DATETIME2(7)         NOT NULL, 
);

INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Patty'  , 'Error'      , 'Message', '2025-01-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Lois'   , 'Error'      , 'Message', '2025-01-02');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Alice'  , 'Information', 'Message', '2025-01-03');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Bob'    , 'Information', 'Message', '2025-02-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Dustin' , 'Information', 'Message', '2025-02-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Dixie'  , 'Information', 'Message', '2025-02-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Peg'    , 'Information', 'Message', '2025-03-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Allie'  , 'Information', 'Message', '2025-04-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Liz'    , 'Error'      , 'Message', '2025-05-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Ray'    , 'Error'      , 'Message', '2025-03-12');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Rita'   , 'Error'      , 'Message', '2025-01-23');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Isabel' , 'Error'      , 'Message', '2025-02-22');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Ruby'   , 'Error'      , 'Message', '2025-01-21');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Willie' , 'Error'      , 'Message', '2025-03-12');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Anne'   , 'Error'      , 'Message', '2025-03-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Ben'    , 'Error'      , 'Message', '2025-03-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Barry'  , 'Warning'    , 'Message', '2025-03-23');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Manny'  , 'Warning'    , 'Message', '2025-03-04');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Loco'   , 'Warning'    , 'Message', '2025-03-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Tex'    , 'Warning'    , 'Message', '2025-03-03');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Reeve'  , 'Warning'    , 'Message', '2025-04-04');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Hugh'   , 'Warning'    , 'Message', '2025-05-07');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Theresa', 'Error'      , 'Message', '2025-06-08');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Dave'   , 'Error'      , 'Message', '2025-07-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Louis'  , 'Error'      , 'Message', '2025-08-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('May'    , 'Error'      , 'Message', '2025-09-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Jannie' , 'Error'      , 'Message', '2025-01-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Carol'  , 'Error'      , 'Message', '2025-02-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Emily'  , 'Error'      , 'Message', '2025-03-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Emma'   , 'Error'      , 'Message', '2025-04-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Adrian' , 'Error'      , 'Message', '2025-02-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Adams'  , 'Error'      , 'Message', '2025-03-01');
INSERT INTO Logs ([UserName], [Severity], [Message], [TimeStamp]) VALUES ('Nalty'  , 'Error'      , 'Message', '2025-02-01');