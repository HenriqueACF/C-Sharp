USE [Cursos]

DROP TABLE [Curso]
CREATE TABLE [Curso](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id])
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId])
        REFERENCES [Categoria]([Id])
)
GO

DROP TABLE [Categoria]
CREATE TABLE [Categoria](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT PK_CATEGORIA PRIMARY KEY([Id])
)
GO

INSERT INTO [Categoria]([Nome]) VALUES('Backend')
INSERT INTO [Categoria]([Nome]) VALUES('Frontend')
INSERT INTO [Categoria]([Nome]) VALUES('Mobile')
INSERT INTO [Categoria]([Nome]) VALUES('DevOPS')

INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos de C#', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos de OOP', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('React.js', 2)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Vue.js 3', 2)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Quasar', 2)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('React Native', 3)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Flutter', 3)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('DevOps', 4)