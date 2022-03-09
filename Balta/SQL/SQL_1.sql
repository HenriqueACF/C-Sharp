USE [Curso]

-- Syntax para crianção de tabela
CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(100) NOT NULL UNIQUE,
    [Nascimento] DATETIME NOT NULL,
    [Active] BIT DEFAULT(0)

    PRIMARY KEY([Id])
)
GO

-- DELETA TABELA
DROP TABLE [Aluno]


-- ADICIONA, REMOVE E ALTERA UMA COLUNA
-- ALTER TABLE [Aluno]
--     ADD[Document] NVARCHAR(11)

-- ALTER TABLE [Aluno]
--     DROP COLUMN [Document]

-- ALTER TABLE [Aluno]
--     ALTER COLUMN [Document] CHAR(11)

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

DROP TABLE [ProgressoCurso]
CREATE TABLE [ProgressoCurso](
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT PK_PROGRESSOCURSO PRIMARY KEY([AlunoId], [CursoId])
)
GO

DROP TABLE [Categoria]
CREATE TABLE [Categoria](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT PK_CATEGORIA PRIMARY KEY([Id])
)
GO

-- INDEX
CREATE INDEX [IX_Aluno_Email] ON [Aluno]([Email])

