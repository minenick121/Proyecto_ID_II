USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[pa_TituloLibro]    Script Date: 02/02/2022 19:06:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[pa_TituloLibro]
(
	@IDLibro			char(4)
)
As	
	select L.Titulo from Libro L where L.IdLibro = @IDLibro
