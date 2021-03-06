USE [SubiteQueTeLlevoDB]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Apellido], [ClasificacionPromedio], [Dni], [EsConductor], [EsPasajero], [Foto], [Nombre]) VALUES (N'6afa6d7b-6cd6-49fd-a4b1-62569914517d', N'aa@aaa.com', N'AA@AAA.COM', N'aa@aaa.com', N'AA@AAA.COM', 1, N'AQAAAAEAACcQAAAAEGex1LLGewCa+SLW3U9S0SJRzvcDqcTIMZ31gXhVZFC7owh9zx8pLhkJt2Po28xJZg==', N'BLSJ5VESZ2FY2K24VNTDYLACRSS2CLGV', N'6b1792d7-b00e-487b-b847-f8cb3e80eeb7', NULL, 0, 0, NULL, 1, 0, NULL, 0, 0, 0, 0, NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Apellido], [ClasificacionPromedio], [Dni], [EsConductor], [EsPasajero], [Foto], [Nombre]) VALUES (N'79c347c4-36d8-4199-9028-033f30bed545', N'aa@aa.com', N'AA@AA.COM', N'aa@aa.com', N'AA@AA.COM', 1, N'AQAAAAEAACcQAAAAEA0eIglSsB/f6YP+FXKqyY+j2zOe3KYDWb8lefZwl2v9yyQXnXcgnqBkBq/lq2zRdA==', N'FNCDE2RDJLMBWQKC7CA4ATDU2XSBRDRN', N'4a030f8c-187c-4d66-a055-9c1d4d0ebaec', NULL, 0, 0, NULL, 1, 0, NULL, 0, 0, 0, 0, NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Apellido], [ClasificacionPromedio], [Dni], [EsConductor], [EsPasajero], [Foto], [Nombre]) VALUES (N'ce761de4-5318-4acc-b1b2-df2e1e6e3ef3', N'abc@abc.com', N'ABC@ABC.COM', N'abc@abc.com', N'ABC@ABC.COM', 1, N'AQAAAAEAACcQAAAAEJwLzBW8qC8YScvcY1Az0OyhwP9khvf5K+7mIr2VV08t6op4IR86JwnVrtW9HKcp7g==', N'4MFSQGIQUEBIKJUIEBNTEOZDLSQX2J5B', N'4de77232-efe4-4b68-9c1c-ffb1bc6e1458', NULL, 0, 0, NULL, 1, 0, N'Giussepin', 4, 0, 1, 0, NULL, N'Carlitos')
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([MarcaId], [Nombre]) VALUES (1, N'Ford')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelos] ON 

INSERT [dbo].[Modelos] ([ModeloId], [Nombre], [MarcaId]) VALUES (1, N'Fiesta', 1)
SET IDENTITY_INSERT [dbo].[Modelos] OFF
GO
SET IDENTITY_INSERT [dbo].[Autos] ON 

INSERT [dbo].[Autos] ([AutoId], [Patente], [ModeloId], [DueñoId]) VALUES (1, N'AHT-884', 1, N'ce761de4-5318-4acc-b1b2-df2e1e6e3ef3')
SET IDENTITY_INSERT [dbo].[Autos] OFF
GO
SET IDENTITY_INSERT [dbo].[Provincias] ON 

INSERT [dbo].[Provincias] ([ProvinciaId], [Nombre]) VALUES (1, N'Buenos Aires')
INSERT [dbo].[Provincias] ([ProvinciaId], [Nombre]) VALUES (2, N'Santa Cruz')
SET IDENTITY_INSERT [dbo].[Provincias] OFF
GO
SET IDENTITY_INSERT [dbo].[Ciudades] ON 

INSERT [dbo].[Ciudades] ([CiudadId], [Nombre], [ProvinciaId]) VALUES (2, N'Lobos', 1)
INSERT [dbo].[Ciudades] ([CiudadId], [Nombre], [ProvinciaId]) VALUES (3, N'La Plata', 1)
INSERT [dbo].[Ciudades] ([CiudadId], [Nombre], [ProvinciaId]) VALUES (5, N'Quilmes', 1)
INSERT [dbo].[Ciudades] ([CiudadId], [Nombre], [ProvinciaId]) VALUES (6, N'Caleta Olivia', 2)
SET IDENTITY_INSERT [dbo].[Ciudades] OFF
GO
SET IDENTITY_INSERT [dbo].[Direcciones] ON 

INSERT [dbo].[Direcciones] ([DireccionId], [Calle], [Numero], [CiudadId]) VALUES (2, N'Patagones', 243, 2)
INSERT [dbo].[Direcciones] ([DireccionId], [Calle], [Numero], [CiudadId]) VALUES (3, N'Calle 62', 381, 3)
SET IDENTITY_INSERT [dbo].[Direcciones] OFF
GO
INSERT [dbo].[EstadoViaje] ([EstadoViajeId], [Nombre]) VALUES (0, N'Pendiente')
INSERT [dbo].[EstadoViaje] ([EstadoViajeId], [Nombre]) VALUES (1, N'Cancelado')
INSERT [dbo].[EstadoViaje] ([EstadoViajeId], [Nombre]) VALUES (2, N'Completado')
GO
SET IDENTITY_INSERT [dbo].[Viajes] ON 

INSERT [dbo].[Viajes] ([ViajeId], [AsientosTotales], [Precio], [DisponibilidadEquipaje], [FyHSalida], [TiempoEstimado], [EstadoViajeId], [AutoId], [OrigenId], [DestinoId]) VALUES (2, 8, 0, 2, CAST(N'2020-02-05T00:00:00.0000000' AS DateTime2), 12, 0, 1, 2, 3)
SET IDENTITY_INSERT [dbo].[Viajes] OFF
GO
INSERT [dbo].[EstadoViajePerfil] ([EstadoViajePerfilId], [Nombre]) VALUES (0, N'Cancelado')
INSERT [dbo].[EstadoViajePerfil] ([EstadoViajePerfilId], [Nombre]) VALUES (1, N'Completado')
INSERT [dbo].[EstadoViajePerfil] ([EstadoViajePerfilId], [Nombre]) VALUES (2, N'PendienteAceptacion')
INSERT [dbo].[EstadoViajePerfil] ([EstadoViajePerfilId], [Nombre]) VALUES (3, N'Reservado')
GO
SET IDENTITY_INSERT [dbo].[ViajePerfil] ON 

INSERT [dbo].[ViajePerfil] ([ViajePerfilId], [ViajeId], [PerfilId], [EstadoViajePerfilId]) VALUES (33, 2, N'ce761de4-5318-4acc-b1b2-df2e1e6e3ef3', 2)
SET IDENTITY_INSERT [dbo].[ViajePerfil] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'5.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210119043538_ModelClasses', N'5.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210119045822_ModelClassesFixEnum', N'5.0.2')
GO
