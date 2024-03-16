# HackathonFIAPg2

## Descrição

Este é um breve parágrafo descrevendo o que sua aplicação faz e para que ela serve.

## Diagrama Simples

Aqui você pode descrever o diagrama simples criado no inicio do projeto com o que representa a estrutura ou o fluxo da sua aplicação.  


![Diagrama do projeto](https://github.com/HackaHeroes/HackathonFIAPg2/assets/128049775/20e48875-178b-457f-adae-0f2c7af78dad)

## Instruções de Docker

### Pré-requisitos

Certifique-se de ter o Docker instalado em sua máquina. Se não, você pode baixá-lo [aqui](https://www.docker.com/products/docker-desktop).

### Construção do Docker - em ediçao

Para construir a imagem do Docker para esta aplicação, navegue até o diretório raiz onde o Dockerfile está localizado e execute o seguinte comando:

```bash
docker build -t nome-da-aplicacao .
```

### Executando a Aplicação - em ediçao

Depois de construir a imagem do Docker, você pode executar a aplicação com o seguinte comando:

```bash
docker run -p 8000:8000 nome-da-aplicacao
```

Agora, a aplicação deve estar rodando na porta 8000 do seu localhost.

## Contribuição


Esse projeto foi feito para a resolução de um Hackathon, seus contribuidores podem ser vistos nessa página:
https://github.com/orgs/HackaHeroes/people


## Script Database

```
/****** Object:  Table [dbo].[VideoImages]    Script Date: 16/03/2024 14:43:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VideoImages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VideoName] [varchar](500) NULL,
	[VideoLink] [varchar](max) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ZipFile] [varchar](max) NULL,
	[ZipName] [varchar](500) NULL,
	[ZipCreatedAt] [smalldatetime] NULL,
	[IsProcessed] [bit] NULL,
 CONSTRAINT [PK_VideoImages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[VideoImages] ADD  CONSTRAINT [DF_VideoImages_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO

ALTER TABLE [dbo].[VideoImages] ADD  CONSTRAINT [DF_VideoImages_FlgProcessed]  DEFAULT ((0)) FOR [IsProcessed]
GO

