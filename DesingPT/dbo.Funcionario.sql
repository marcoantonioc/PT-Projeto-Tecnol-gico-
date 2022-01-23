CREATE TABLE [dbo].[Funcionario] (
    [id]                      INT         IDENTITY (1, 1) NOT NULL,
    [contratado]              NCHAR (50)  NOT NULL,
    [ordenado]                INT         NOT NULL,
    [presenças]               INT         NOT NULL,
    [telefone]                INT         NOT NULL,
    [morada]                  NCHAR (100) NOT NULL,
    [email]                   NCHAR (50)  NOT NULL,
    [nome]                    NCHAR (50)  NOT NULL,
    [avaliaçao_de_desempenho] INT         NOT NULL,
    [curriculo]               NCHAR (500) NOT NULL,
    [palavra_pass]            NCHAR (50)  NULL,
    [nif] NCHAR(30) NOT NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
);

