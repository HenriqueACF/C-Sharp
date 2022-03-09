SELECT * FROM [Course]
SELECT * FROM [Student]
SELECT * FROM [StudentCourse]

DECLARE @studentId UNIQUEIDENTIFIER = (SELECT NEWID()) 

SELECT NEWID()

INSERT INTO
    [Student]
VALUES
(
    '0bf21806-0338-4f46-9378-3737d4d1df5d',
    'Henrique Assis',
    'henrique.assis145@gmail.com',
    '12345678901',
    '123456789',
    '1997-05-16',
    GETDATE()
)

INSERT INTO
    [StudentCourse]
VALUES 
(
    '5c349848-e717-9a7d-1241-0e6500000000',
    '0bf21806-0338-4f46-9378-3737d4d1df5d',
    75,
    0,
    '2022-03-09',
    GETDATE()
)