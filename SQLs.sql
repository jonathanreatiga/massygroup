
CREATE TABLE dbo.Persona
	(
	IdPersona int NOT NULL IDENTITY (1, 1),
	Documento varchar(MAX) NULL,
	Nombre varchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Persona ADD CONSTRAINT
	PK_Persona PRIMARY KEY CLUSTERED 
	(
	IdPersona
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Persona SET (LOCK_ESCALATION = TABLE)
GO


-----------------------------------------------

CREATE TABLE dbo.TipoNovedad
	(
	IdTipoNovedad int NOT NULL IDENTITY (1, 1),
	Novedad varchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.TipoNovedad ADD CONSTRAINT
	PK_TipoNovedad PRIMARY KEY CLUSTERED 
	(
	IdTipoNovedad
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.TipoNovedad SET (LOCK_ESCALATION = TABLE)
GO



-------------------------------------------------

CREATE TABLE dbo.NovedadesNomina
	(
	IdNovedad int NOT NULL IDENTITY (1, 1),
	IdPersona int NOT NULL,
	Ano int NOT NULL,
	Mes int NOT NULL,
	IdTipoNovedad int NOT NULL,
	Naturaleza int NOT NULL,
	Valor int NOT NULL,
	Observacion varchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.NovedadesNomina ADD CONSTRAINT
	PK_NovedadesNomina PRIMARY KEY CLUSTERED 
	(
	IdNovedad
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.NovedadesNomina SET (LOCK_ESCALATION = TABLE)
GO