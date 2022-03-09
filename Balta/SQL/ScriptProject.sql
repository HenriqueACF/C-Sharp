SELECT 
    [Student].[Id] AS [Student],
    [Course].[Title] AS [Course],
    [StudentCourse].[Progress]
FROM
    [StudentCourse]
    INNER JOIN 
        [Student] ON [StudentCourse].[StudentId] = [Student].[Id]
    INNER JOIN 
        [Course] ON [StudentCourse].[CourseId] = [Course].[Id]


SELECT
    [Student].[Name] AS [Student],
    [Course].[Title] AS [Course],
    [StudentCourse].[Progress],
    [StudentCourse].[LastUpdateDate]
FROM
    [Course]
    LEFT JOIN [StudentCourse] ON [StudentCourse].[CourseId] = [Course].[Id]
    LEFT JOIN [Student] ON [StudentCourse].[StudentId] = [Student].[Id]