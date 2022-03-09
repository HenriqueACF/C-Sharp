SELECT 
    [Course].[Id],
    [Course].[Tag],
    [Course].[Title],
    [Course].[Url],
    [Course].[Summary],
    [Category].[Title],
    [Author].[Name]
FROM
    [Course]
    INNER JOIN 
        [Category] ON [Course].[CategoryId] = [Category].[Id]
    INNER JOIN 
        [Author] ON [Course].[AuthorId] = [Author].[Id]
WHERE
    [Active] = 1
ORDER BY 
    [CreateDate] DESC