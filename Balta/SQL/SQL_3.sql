--SELECT
SELECT TOP 10
    [Id], [Nome], [CategoriaId]
FROM
    [Curso]
WHERE
    [Id] = 1 OR
    [CategoriaId] = 1


-- ORDER BY
SELECT TOP 10
    [Id], [Nome], [CategoriaId]
FROM
    [Curso]
ORDER BY 
    [Nome]

-- MIN, MAX, COUNT, AVG, SUM
SELECT TOP 100
    MAX([Id])
FROM
    [Curso]

-- LIKE
SELECT TOP 100
    *
FROM 
    [Curso]
WHERE
    [Nome] LIKE 'Fundamentos%'

-- IN, BETWEEN
SELECT TOP 100
    *
FROM
    [Categoria]
WHERE
    [Id] IN (1,2)

-- ALIAS
SELECT TOP 100
    [Id] AS [Codigo]
FROM
    [Curso]

-- UPDATE
SELECT * FROM [Curso]

BEGIN TRANSACTION
UPDATE
    [Curso]
SET 
    [Nome]='APIs com C#'
WHERE
    [Id] =3
-- ROLLBACK -> DESFAZ AS AÇÕES PARA TER CERTEZA DE QUE ESTA FAZENDO CERTO
COMMIT --> FAZ A ALTERAÇÃO SE ESTIVER TUDO CERTO

-- DELETE
DELETE FROM 
    [Categoria]
WHERE 
    [Id]

