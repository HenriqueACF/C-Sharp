-- JOIN
SELECT TOP 100
    [Curso].[Id],
    [Curso].[Nome],
    [Categoria].[Id] AS [Categoria],
    [Categoria].[Nome]
FROM
    [Curso]
    INNER JOIN [Categoria] 
        ON [Curso].[CategoriaId] = [Categoria].[Id]

-- LEFT JOIN, RIGHT JOIN, FULL JOIN
SELECT TOP 100
    [Curso].[Id],
    [Curso].[Nome],
    [Categoria].[Id] AS [Categoria],
    [Categoria].[Nome]
FROM
    [Curso]
    LEFT JOIN [Categoria] 
        ON [Curso].[CategoriaId] = [Categoria].[Id]

-- UNION
SELECT TOP 100
    [Id], [Nome]
FROM 
    [Curso]
UNION   
SELECT TOP 100
    [Id], [Nome]
FROM
    [Categoria]

