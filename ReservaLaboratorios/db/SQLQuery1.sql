USE [master]
GO
/****** Object:  Database [Reserva]    Script Date: 26/4/2025 8:04:50 ******/
CREATE DATABASE [Reserva]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Reserva', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Reserva.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Reserva_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Reserva_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Reserva] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Reserva].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Reserva] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Reserva] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Reserva] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Reserva] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Reserva] SET ARITHABORT OFF 
GO
ALTER DATABASE [Reserva] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Reserva] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Reserva] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Reserva] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Reserva] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Reserva] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Reserva] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Reserva] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Reserva] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Reserva] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Reserva] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Reserva] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Reserva] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Reserva] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Reserva] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Reserva] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Reserva] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Reserva] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Reserva] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Reserva] SET  MULTI_USER 
GO
ALTER DATABASE [Reserva] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Reserva] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Reserva] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Reserva] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Reserva]
GO
/****** Object:  StoredProcedure [dbo].[loginPlataforma]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[loginPlataforma]
@usuario varchar(100),
@contrasena varchar(100)
as begin
	SELECT per.*, usuRol.strNombre_rol
	FROM PERSONAL per
	INNER JOIN USUARIO usu
	ON per.strCod_Per = usu.strUsuarioCedula
	INNER JOIN USUARIOINROLES usuRol
	ON usuRol.strUsuarioId = usu.strUsuarioId
	WHERE strCod_Per = @usuario 
	and strContraseña_Per = @contrasena
end
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_AddExclusivo]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_AddExclusivo]
@strCod_labEx VARCHAR(100)
, @dtFechaRegistro_labEx datetime
, @dtFecha_log datetime
, @strUser_log VARCHAR(100)
, @strCod_lab VARCHAR(100)
, @strCod_Car VARCHAR(100)
, @strCod_Fac VARCHAR(30)
, @strCod_Sede VARCHAR(30)

AS
 SET NOCOUNT OFF;
 BEGIN
	INSERT INTO LAB_EXCLUSIVO(
	strCod_labEx
	, dtFechaRegistro_labEx
	, dtFecha_log
	, strUser_log
	, strCod_lab
	, strCod_Car
	, strCod_Fac
    , strCod_Sede
	)
	VALUES (
	@strCod_labEx
	, @dtFechaRegistro_labEx
	, @dtFecha_log
	, @strUser_log
	, @strCod_lab
	, @strCod_Car
	, @strCod_Fac
    , @strCod_Sede
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_AddLaboratorio]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_AddLaboratorio]
@strCod_lab varchar(100)
, @strNombre_lab VARCHAR(100)
, @intNumeroEquipos_lab INT
, @strUbicacion_lab VARCHAR(100)
, @strCod_tipoLab varchar(100)
, @strCod_areac varchar(100)
, @strFotografia1_lab varchar(100)
, @strFotografia2_lab varchar(100)
, @dtFechaRegistro_lab DATETIME
, @dtFecha_log DATETIME
, @strUser_log VARCHAR(20)
, @strCod_Fac  varchar(30)
, @strCod_Sede varchar(30)

AS
 SET NOCOUNT OFF;
 BEGIN
    INSERT INTO LAB_LABORATORIOS(
	strCod_lab
	, strNombre_lab
	, intNumeroEquipos_lab
	, strUbicacion_lab
	, strCod_tipoLab
	, strCod_areac
	, strFotografia1_lab
	, strFotografia2_lab
	, dtFechaRegistro_lab
	, dtFecha_log
	, strUser_log
	, strCod_Fac
	, strCod_Sede)
	VALUES(
	@strCod_lab
	, @strNombre_lab
	, @intNumeroEquipos_lab
	, @strUbicacion_lab
	, @strCod_tipoLab
	, @strCod_areac
	, @strFotografia1_lab
	, @strFotografia2_lab
	, @dtFechaRegistro_lab
	, @dtFecha_log
	, @strUser_log
	, @strCod_Fac
	, @strCod_Sede)
END

GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_AddLabSoftware]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_AddLabSoftware]
@strCod_labSoft VARCHAR(100)
, @dtFechaRegistro_labSoft DATETIME
, @dtFecha_log DATETIME
, @strUser_log VARCHAR(20)
, @strCod_lab VARCHAR(100)
, @strCod_sof VARCHAR(100)
, @strCod_Fac VARCHAR(30)
, @strCod_Sede VARCHAR(30)
AS
 SET NOCOUNT OFF;
 BEGIN
	INSERT INTO LAB_LABSOFTWARE (
	strCod_labSoft
	, dtFechaRegistro_labSoft
	, dtFecha_log
	, strUser_log
	, strCod_lab
	, strCod_sof
	, strCod_Fac
	, strCod_Sede
	)
	VALUES (
	@strCod_labSoft
	, @dtFechaRegistro_labSoft
	, @dtFecha_log
	, @strUser_log
	, @strCod_lab
	, @strCod_sof
	, @strCod_Fac
	, @strCod_Sede
	)
 END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_AddResponsable]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_AddResponsable]
@strCod_respo  varchar(100)
, @strTipo_respo varchar(30)
, @dtFechaInicio_respo datetime
, @dtFecha_log datetime
, @strUser_log varchar(20)
, @strCod_res varchar(20)
, @strCod_lab varchar(100)

AS 
SET NOCOUNT OFF;
BEGIN 
	INSERT INTO LAB_RESPONSABLE(
	strCod_respo
	, strTipo_respo
	, dtFechaInicio_respo
	, dtFecha_log
    , strUser_log
	, strCod_res
	, strCod_lab) 
	VALUES (
	@strCod_respo
	, @strTipo_respo
	, @dtFechaInicio_respo
	, @dtFecha_log
    , @strUser_log
	, @strCod_res
	, @strCod_lab);
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_AddSoftware]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_AddSoftware]
@strCod_sof VARCHAR(100)
, @strNombre_sof VARCHAR(100)
, @strTipoLicencia_sof VARCHAR(100)
, @strNombreLicencia_sof VARCHAR(250)
, @intCantidad_sof INT
, @decCostoUnitario_sof DECIMAL(10,2)
, @decCostoTotal_sof DECIMAL(10,2)
, @strDescripcion_sof VARCHAR(MAX)
, @strImagen_sof VARCHAR(100)
, @strUrl_sof VARCHAR(250)
, @dtFechaRegistro_sof DATETIME
, @dtFecha_log DATETIME
, @strUser_log VARCHAR(20)
, @strCod_Fac VARCHAR(30)
, @strCod_Sede VARCHAR(30)

AS
 SET NOCOUNT OFF;
 BEGIN
    INSERT INTO LAB_SOFTWARE(
	strCod_sof
	, strNombre_sof
	, strTipoLicencia_sof
	, strNombreLicencia_sof
	, intCantidad_sof
	, decCostoUnitario_sof
	, decCostoTotal_sof
	, strDescripcion_sof
	, strImagen_sof
	, strUrl_sof
	, dtFechaRegistro_sof
	, dtFecha_log
	, strUser_log
	, strCod_Fac
	, strCod_Sede
	)
	VALUES(
	@strCod_sof
	, @strNombre_sof
	, @strTipoLicencia_sof
	, @strNombreLicencia_sof
	, @intCantidad_sof
	, @decCostoUnitario_sof
	, @decCostoTotal_sof
	, @strDescripcion_sof
	, @strImagen_sof
	, @strUrl_sof
	, @dtFechaRegistro_sof
	, @dtFecha_log
	, @strUser_log
	, @strCod_Fac
	, @strCod_Sede
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_AddTipoLaboratorio]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_AddTipoLaboratorio]
@strCod_tipoLab VARCHAR(100)
, @strNombre_tipoLab VARCHAR(100)
, @dtFechaRegistro_tipoLab DATETIME
, @dtFecha_log DATETIME
, @strUser_log VARCHAR(20)
AS
 SET NOCOUNT OFF;
 BEGIN
    INSERT INTO LAB_TIPO(
	strCod_tipoLab
	, strNombre_tipoLab
	, dtFechaRegistro_tipoLab
	, dtFecha_log
	, strUser_log
	)
	VALUES(
	@strCod_tipoLab
	, @strNombre_tipoLab
	, @dtFechaRegistro_tipoLab
	, @dtFecha_log
	, @strUser_log
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_DelLaboratorios]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_DelLaboratorios]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
AS
 SET NOCOUNT OFF;
 BEGIN
	IF @Comodin = 'xPkLab'
		BEGIN
		UPDATE LAB_LABORATORIOS 
		SET bitEstado_lab = 0
		, dtFecha_log = @FILTRO2
		, strUser_log = @FILTRO3
		WHERE (strCod_lab = @FILTRO1);  
		END
 END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_DelLabSoftware]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_DelLabSoftware]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
 AS
  SET NOCOUNT OFF;
  BEGIN
	IF @Comodin = 'xLabSoftware'
		BEGIN
			UPDATE LAB_LABSOFTWARE
			SET bitEstado_labSoft = 0
			, dtFecha_log = @FILTRO3
			, strUser_log = @FILTRO4
			WHERE strCod_lab = @FILTRO1 
			AND strCod_sof =@FILTRO2
			AND bitEstado_labSoft = 1

		END
  END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_DelSoftware]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_DelSoftware]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
AS
 SET NOCOUNT OFF;
 BEGIN
	IF @Comodin = 'xCodSof'
		BEGIN
		UPDATE LAB_SOFTWARE SET
		bitEstado_sof = 0
		, dtFecha_log = @FILTRO2
		, strUser_log = @FILTRO3
		WHERE strCod_sof = @FILTRO1
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_DelTipoLaboratorio]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_DelTipoLaboratorio]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
AS
 SET NOCOUNT OFF;
 BEGIN
	IF @Comodin = 'xCodTipoLab'
		BEGIN
		UPDATE LAB_TIPO SET
		bitEstado_tipoLab = 0
		, dtFecha_log = @FILTRO2
		, strUser_log = @FILTRO3
		WHERE strCod_tipoLab = @FILTRO1
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetAREAC]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetAREAC]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)

AS
 SET NOCOUNT OFF;
 BEGIN --SP
	IF @Comodin = 'ALL'
		BEGIN --ALL
		SELECT *
		FROM SIG_AREAC
		END --All
 END 
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetAsignatura]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetAsignatura]
@Comodin VARCHAR(100)
, @FILTRO1 varchar(100)
, @FILTRO2 varchar(100)
, @FILTRO3 varchar(100)
, @FILTRO4 varchar(100)
 as begin
	if @Comodin = 'xAsignatura'
		begin
		SELECT hor.strCod_horas
		, hor.strCod_mate
		, cur.strNombre_curso
		, cur.strParalelo_curso
		, car.strNombre_Car
		, (SELECT COUNT(dis.strCod_mate) FROM AC_DISTRIBUTIVO dis
			INNER JOIN AC_MATRICULAD matDe
			ON dis.strCod_mate = matDe.strCod_mate
			INNER JOIN AC_MATRICULAC matCa
			ON matDe.strCod_matric = matCa.strCod_matric
			WHERE dis.strCod_mate = @FILTRO1
		)AS totalAsistentes
		FROM AC_HORARIOS hor
		INNER JOIN AC_DISTRIBUTIVO dis
		ON hor.strCod_mate = dis.strCod_mate
		INNER JOIN AC_CURSOS cur
		ON dis.strCod_curso = cur.strCod_curso
		INNER JOIN SIG_PERIODOS perio
		ON cur.strCod_Per = perio.strCod_Per
		INNER JOIN UB_CARRERAS car
		ON perio.strCod_Car = car.strCod_Car
		WHERE dis.strCod_mate = @FILTRO1 
		AND hor.intDia_horario = @FILTRO2
	end
	else if @Comodin = 'xDia'
		begin

		SELECT DISTINCT mat.strCod_mate
		, mat.strNombre_mate 
		FROM AC_DISTRIBUTIVO dis
		INNER JOIN PERSONAL pro
		ON pro.strCod_Per = dis.strCod_pro
		INNER JOIN MATERIAS mat
		ON dis.strCod_mate = mat.strCod_mate
		INNER JOIN AC_HORARIOS hor
		ON hor.strCod_mate = dis.strCod_mate
		WHERE hor.intDia_horario = @FILTRO1
		AND pro.strCod_Per = @FILTRO2
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetCarreras]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetCarreras]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
AS
 SET NOCOUNT OFF;
 BEGIN --SP
	IF @Comodin = 'xCodLaboratorio'
		BEGIN
		SELECT DISTINCT car.strCod_Car
		, car.strNombre_Car
		, car.strCod_Fac
		, car.strCod_Sede
		FROM UB_FACULTADES fac
		INNER JOIN UB_CARRERAS car
		ON car.strCod_Fac = fac.strCod_Fac
		INNER JOIN LAB_LABORATORIOS lab
		ON lab.strCod_Fac = fac.strCod_Fac
		WHERE lab.strCod_Fac = @FILTRO1
		AND lab.strCod_Sede = @FILTRO2
		AND car.strCod_Sede = @FILTRO2
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetFacultad]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetFacultad]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
AS
 SET NOCOUNT OFF;
 BEGIN --SP
	IF @Comodin = 'ALL'
		begin --ALL
		SELECT *
		FROM UB_FACULTADES
		end --All
	ELSE IF @Comodin = 'xPK'
		begin --xPK
		SELECT *
		FROM UB_FACULTADES
		WHERE (strCod_Sede = @FILTRO1)
		end --xPK
	ELSE IF @Comodin = 'xIdPersonal'
		begin --xPK
		SELECT DISTINCT f.strCod_Fac, f.strNombre_Fac
			FROM AC_DISTRIBUTIVO d
			INNER JOIN AC_CURSOS c 
			ON c.strCod_curso = d.strCod_curso
			INNER JOIN SIG_PERIODOS p
			ON p.strCod_per = c.strCod_per
			INNER JOIN UB_CARRERAS car
			ON car.strCod_Sede = p.strCod_Sede 
			AND car.strCod_Fac = p.strCod_Fac 
			AND car.strCod_Car = p.strCod_Car
			INNER JOIN PERSONAL per
			ON per.CEDULA_ALU = d.strCod_pro
			INNER JOIN UB_FACULTADES f
			ON f.strCod_Fac = car.strCod_Fac
			AND f.strCod_Sede = car.strCod_Sede
			WHERE d.strCod_pro = @FILTRO1
		end --xPK
END --SP

GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetLaboratorios]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetLaboratorios]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)

AS
 SET NOCOUNT OFF;
 BEGIN --SP
	 IF @Comodin = 'ALL'
		begin --ALL
		SELECT *
		FROM LAB_LABORATORIOS
		WHERE bitEstado_lab = 1
		end --All
	 ELSE IF @Comodin = 'xPK'
		begin --xPK
		SELECT lab.strCod_lab
			, lab.strNombre_lab
			, lab.intNumeroEquipos_lab
			, lab.strUbicacion_lab	
			, lab.strCod_tipoLab		
			, lab.strCod_areac
			, lab.strFotografia1_lab
			, lab.strFotografia2_lab
			, lab.strCod_Fac
			, lab.strCod_Sede
			, tipLab.strNombre_tipoLab
			, acad.ResponsableAcademico
			, acad.FotoAcademico
			, adm.ResponsableAdministrativo
			, adm.FotoAdministrativo
			FROM LAB_LABORATORIOS lab
			LEFT OUTER JOIN 
				(SELECT resp.strCod_lab
				, CONCAT(per.APELLIDO_ALU
					, ' ', per.APELLIDOM_ALU
					, ' ', per.NOMBRE_ALU)AS ResponsableAcademico
				, per.IMAGEN_ALU AS FotoAcademico
				FROM LAB_RESPONSABLE resp
				INNER JOIN PERSONAL per 
				ON per.CEDULA_ALU = resp.strCod_res
				WHERE resp.bitEstado_respo = 1 and 
					resp.strTipo_respo = 'Responsable Academico') AS acad
			ON lab.strCod_lab = acad.strCod_lab
			LEFT OUTER JOIN 
				(SELECT resp.strCod_lab
				, CONCAT(per.APELLIDO_ALU
					, ' ', per.APELLIDOM_ALU
					, ' ', per.NOMBRE_ALU)AS ResponsableAdministrativo
				, per.IMAGEN_ALU AS FotoAdministrativo
				FROM LAB_RESPONSABLE resp
				INNER JOIN PERSONAL per 
				ON per.CEDULA_ALU = resp.strCod_res
				WHERE resp.bitEstado_respo = 1 and 
					resp.strTipo_respo = 'Responsable Administrativo') AS adm
			ON lab.strCod_lab = adm.strCod_lab
			INNER JOIN LAB_TIPO tipLab
			ON tipLab.strCod_tipoLab = lab.strCod_tipoLab
		WHERE lab.strCod_lab = @FILTRO1 
		AND bitEstado_lab = 1;
		end --xPK
	ELSE IF @Comodin = 'xIdPersonal'
		BEGIN
		SELECT *
		FROM LAB_LABORATORIOS lab
		INNER JOIN LAB_RESPONSABLE respo
		ON respo.strCod_lab = lab.strCod_lab
		WHERE bitEstado_lab = 1
		AND respo.strCod_res = @FILTRO1
		END
	 ELSE IF @Comodin = 'xFacultad'
		begin --xSedeFacultad
		SELECT lab.strCod_lab
			, lab.strNombre_lab
			, lab.strFotografia1_lab
			, acad.ResponsableAcademico
			, acad.FotoAcademico
			, adm.ResponsableAdministrativo
			, adm.FotoAdministrativo
			FROM LAB_LABORATORIOS lab
			LEFT OUTER JOIN 
				(SELECT resp.strCod_lab
				, CONCAT(per.APELLIDO_ALU
					, ' ', per.APELLIDOM_ALU
					, ' ', per.NOMBRE_ALU) AS ResponsableAcademico
				, per.IMAGEN_ALU AS FotoAcademico
				FROM LAB_RESPONSABLE resp
				INNER JOIN PERSONAL per 
				ON per.CEDULA_ALU = resp.strCod_res
				WHERE resp.bitEstado_respo = 1 and 
					resp.strTipo_respo = 'Responsable Academico') AS acad
			ON lab.strCod_lab = acad.strCod_lab
			LEFT OUTER JOIN 
				(SELECT resp.strCod_lab
				, CONCAT(per.APELLIDO_ALU
					, ' ', per.APELLIDOM_ALU
					, ' ', per.NOMBRE_ALU) AS ResponsableAdministrativo
				, per.IMAGEN_ALU AS FotoAdministrativo
				FROM LAB_RESPONSABLE resp
				INNER JOIN PERSONAL per 
				ON per.CEDULA_ALU = resp.strCod_res
				WHERE resp.bitEstado_respo = 1 and 
					resp.strTipo_respo = 'Responsable Administrativo') AS adm
			ON lab.strCod_lab = adm.strCod_lab
			WHERE lab.strCod_Fac = @FILTRO1;
		end --xSalario
	/*ELSE IF @Comodin = 'xFiltro'
		begin
		SELECT lab.strCod_lab
			, lab.strNombre_lab
			, lab.intCapacidad_lab
			, lab.strUbicacion_lab
			, lab.strTipo_lab
			, lab.strCampoAmplio_lab
			, lab.strFotografia1_lab
			, lab.strFotografia2_lab
			, lab.bitEstado_lab
			, lab.strCod_Fac
			, lab.strCod_Sede
			, acad.ResponsableAcademico
			, acad.FotoAcademico
			, adm.ResponsableAdministrativo
			, adm.FotoAdministrativo
			FROM LABORATORIO lab
			LEFT OUTER JOIN 
				(SELECT resp.strCod_lab
				, per.strNombre_PERSONAL AS ResponsableAcademico
				, per.strFoto_PERSONAL AS FotoAcademico
				FROM RESPONSABLE resp
				INNER JOIN PERSONAL per 
				ON per.strCod_PERSONAL = resp.strId_PERSONAL
				WHERE resp.bitEstado_respo = 1 and 
					resp.strTipo_respo = 'Responsable Academico') AS acad
			ON lab.strCod_lab = acad.strCod_lab
			LEFT OUTER JOIN 
				(SELECT resp.strCod_lab
				, per.strNombre_PERSONAL AS ResponsableAdministrativo
				, per.strFoto_PERSONAL AS FotoAdministrativo
				FROM RESPONSABLE resp
				INNER JOIN PERSONAL per 
				ON per.strCod_PERSONAL = resp.strId_PERSONAL
				WHERE resp.bitEstado_respo = 1 and 
					resp.strTipo_respo = 'Responsable Administrativo') AS adm
			ON lab.strCod_lab = adm.strCod_lab
			WHERE lab.strCod_Fac = @FILTRO2 AND 
			lab.strNombre_lab LIKE '%' + @FILTRO1 + '%';
			 
		end*/
		ELSE IF @Comodin = 'xLabExclusivo'
		BEGIN --xLabExclusivo
			SELECT labExc.strCod_labEx
			, car.strNombre_Car 
			FROM LAB_LABORATORIOS lab
			INNER JOIN LAB_EXCLUSIVO labExc
			ON labExc.strCod_lab = lab.strCod_lab
			INNER JOIN UB_CARRERAS car
			ON car.strCod_Car = labExc.strCod_Car
			WHERE lab.strCod_lab = @FILTRO1 
			AND labExc.bitEstado_labEx = 1
		END --xLabExclusivo
		ELSE IF @Comodin = 'xCarreraLabExc'
		BEGIN --xCarreraLabExc
			SELECT * 
			FROM LAB_EXCLUSIVO
			WHERE strCod_Car = @FILTRO1
			AND bitEstado_labEx = 1
		END --xCarreraLabExc
END --SP
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetPersonal]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetPersonal]
@Comodin varchar(100)
, @FILTRO1 varchar(100)
, @FILTRO2 varchar(100)
, @FILTRO3 varchar(100)
, @FILTRO4 varchar(100)
as 
 begin
	 IF @Comodin = 'xLaboratorista'
		begin --xLaboratorista
		SELECT DISTINCT per.CEDULA_ALU
			, CONCAT(per.NOMBRE_ALU, 
				' ', per.APELLIDO_ALU,
				' ', per.APELLIDOM_ALU)
			FROM PERSONAL per
			INNER JOIN USUARIO usu 
			ON per.CEDULA_ALU = usu.strUsuarioCedula
			INNER JOIN USUARIOINROLES usuRol 
			ON usu.strUsuarioId = usuRol.strUsuarioId
			WHERE usuRol.strNombre_rol = 'LABORATORISTA'
		end --xLaboratorista
	ELSE IF @Comodin = 'xDocente'
		begin --xTipoPersonal
		SELECT DISTINCT per.CEDULA_ALU
			, CONCAT(per.NOMBRE_ALU, 
				' ', per.APELLIDO_ALU,
				' ', per.APELLIDOM_ALU)
			FROM AC_DISTRIBUTIVO d
			INNER JOIN AC_CURSOS c 
			ON c.strCod_curso = d.strCod_curso
			INNER JOIN SIG_PERIODOS p
			ON p.strCod_per = c.strCod_per
			INNER JOIN UB_CARRERAS car
			ON car.strCod_Sede = p.strCod_Sede 
			AND car.strCod_Fac = p.strCod_Fac 
			AND car.strCod_Car = p.strCod_Car
			INNER JOIN PERSONAL per
			ON per.CEDULA_ALU = d.strCod_pro
			WHERE car.strCod_Sede = @FILTRO2
			AND CAR.strCod_Fac = @FILTRO1
		end --xTipoPersonal
	ELSE IF @Comodin = 'xResponsable'
		BEGIN
		SELECT DISTINCT per.CEDULA_ALU
			, CONCAT(per.NOMBRE_ALU, 
				' ', per.APELLIDO_ALU,
				' ', per.APELLIDOM_ALU)
			FROM PERSONAL per
			INNER JOIN USUARIO usu 
			ON per.CEDULA_ALU = usu.strUsuarioCedula
			INNER JOIN USUARIOINROLES usuRol 
			ON usu.strUsuarioId = usuRol.strUsuarioId
			WHERE usuRol.strNombre_rol = 'LABORATORISTA'

		UNION

		SELECT DISTINCT per.CEDULA_ALU
			, CONCAT(per.NOMBRE_ALU, 
				' ', per.APELLIDO_ALU,
				' ', per.APELLIDOM_ALU)
			FROM AC_DISTRIBUTIVO d
			INNER JOIN AC_CURSOS c 
			ON c.strCod_curso = d.strCod_curso
			INNER JOIN SIG_PERIODOS p
			ON p.strCod_per = c.strCod_per
			INNER JOIN UB_CARRERAS car
			ON car.strCod_Sede = p.strCod_Sede 
			AND car.strCod_Fac = p.strCod_Fac 
			AND car.strCod_Car = p.strCod_Car
			INNER JOIN PERSONAL per
			ON per.CEDULA_ALU = d.strCod_pro
			WHERE car.strCod_Sede = @FILTRO2 
			AND CAR.strCod_Fac = @FILTRO1
		END
end
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetResponsable]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetResponsable]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)

AS
 SET NOCOUNT OFF;
 BEGIN --SP
	IF @Comodin = 'xLaboratorio'
		BEGIN
		SELECT resp.strCod_respo, per.CEDULA_ALU
		, CONCAT(per.NOMBRE_ALU, 
			' ', per.APELLIDO_ALU,
			' ', per.APELLIDOM_ALU)
		, resp.strTipo_respo
		, resp.bitEstado_respo
		FROM PERSONAL per
		INNER JOIN LAB_RESPONSABLE resp
		ON resp.strCod_res = per.CEDULA_ALU
		INNER JOIN LAB_LABORATORIOS lab
		ON lab.strCod_lab = resp.strCod_lab
		where lab.strCod_lab = @FILTRO1 
		and resp.bitEstado_respo = '1';
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetSedes]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetSedes]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)

AS
 SET NOCOUNT OFF;
 BEGIN --SP
	IF @Comodin = 'ALL'
		BEGIN --ALL
		SELECT *
		FROM UB_SEDES
		END --All
	IF @Comodin = 'xIdLaboratorio'
		BEGIN
		SELECT * 
		FROM UB_SEDES sede
		INNER JOIN UB_FACULTADES fac
		ON fac.strCod_Sede = sede.strCod_Sede
		INNER JOIN LAB_LABORATORIOS lab
		ON lab.strCod_Fac = fac.strCod_Fac
		AND lab.strCod_Sede = sede.strCod_Sede
		WHERE lab.strCod_lab = @FILTRO1
		END --xFacultad
 END 
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetSoftware]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetSoftware]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
AS
SET NOCOUNT OFF;
BEGIN --SP
	IF @Comodin = 'ALL'
		BEGIN --ALL
		SELECT *
		FROM LAB_SOFTWARE
		WHERE bitEstado_sof = 1
		END --All
	ELSE IF @Comodin = 'xPK'
		BEGIN --ALL
		SELECT *
		FROM LAB_SOFTWARE
		WHERE bitEstado_sof = 1
		and strCod_sof = @FILTRO1
		END --xPK
	ELSE IF @Comodin = 'xEstado'
		BEGIN
		SELECT *
		FROM LAB_SOFTWARE
		WHERE bitEstado_sof = 0
		and strCod_sof = @FILTRO1
		END
	ELSE IF @Comodin = 'xSedeFacultad'
		BEGIN
		SELECT * 
		FROM LAB_SOFTWARE
		WHERE bitEstado_sof = 1
		and strCod_Fac = @FILTRO1
		and strCod_Sede = @FILTRO2
		END
	ELSE IF @Comodin = 'xLaboratorioSoftware'
		BEGIN
		SELECT labSof.strCod_labSoft
		, labSof.strCod_sof
		, labSof.strCod_lab 
		FROM LAB_LABORATORIOS lab
		INNER JOIN LAB_LABSOFTWARE labSof
		ON labSof.strCod_lab = lab.strCod_lab
		WHERE lab.strCod_lab = @FILTRO1
		AND bitEstado_labSoft = 1
		END
	ELSE IF @Comodin = 'xEstadoLabSoft'
		BEGIN
		SELECT * FROM
		LAB_LABSOFTWARE
		WHERE bitEstado_labSoft = 1
		AND strCod_lab = @FILTRO1
		AND strCod_sof = @FILTRO2
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_GetTipoLaboratorio]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_GetTipoLaboratorio]
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
AS
SET NOCOUNT OFF;
BEGIN --SP
	IF @Comodin = 'ALL'
		BEGIN --ALL
		SELECT *
		FROM LAB_TIPO
		WHERE bitEstado_tipoLab = 1
		END --All
	ELSE IF @Comodin = 'xPK'
		BEGIN --ALL
		SELECT *
		FROM LAB_TIPO
		WHERE bitEstado_tipoLab = 1
		AND strCod_tipoLab = @FILTRO1
		END --xPK
	ELSE IF @Comodin = 'xEstado'
		BEGIN
		SELECT * 
		FROM LAB_TIPO
		WHERE bitEstado_tipoLab = 0
		AND strCod_tipoLab = @FILTRO1
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_UpdateLaboratorios]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_UpdateLaboratorios]
@strCod_lab varchar(100)
, @strNombre_lab VARCHAR(100)
, @intNumeroEquipos_lab INT
, @strUbicacion_lab VARCHAR(100)
, @strCod_tipoLab varchar(100)
, @strCod_areac varchar(100)
, @strFotografia1_lab varchar(100)
, @strFotografia2_lab varchar(100)
, @dtFecha_log DATETIME
, @strUser_log VARCHAR(20)
, @strCod_Fac  varchar(30)
, @strCod_Sede varchar(30)

AS
BEGIN
 SET NOCOUNT ON;
	UPDATE LAB_LABORATORIOS SET 
		strNombre_lab = @strNombre_lab
		, intNumeroEquipos_lab = @intNumeroEquipos_lab
		, strUbicacion_lab = @strUbicacion_lab
		, strCod_tipoLab = @strCod_tipoLab
		, strCod_areac = @strCod_areac
		, strFotografia1_lab = @strFotografia1_lab
		, strFotografia2_lab = @strFotografia2_lab
		, dtFecha_log = @dtFecha_log
		, strUser_log = @strUser_log
		, strCod_Fac = @strCod_Fac
		, strCod_Sede = @strCod_Sede
	WHERE (strCod_lab = @strCod_lab)
END  

GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_UpdateResponsable]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_UpdateResponsable]
@Comodin varchar(100)
, @dtFecha_log DATETIME
, @strUser_log VARCHAR(20)
, @strCod_respo varchar(100)
, @strTipo_respo varchar(100)
AS 
BEGIN
 SET NOCOUNT ON; 
	IF @Comodin = 'xFKLaboratorio'
	begin
		UPDATE LAB_RESPONSABLE SET
		dtFecha_log = @dtFecha_log
		, bitEstado_respo = 0
		, strUser_log = @strUser_log
		WHERE strCod_respo = @strCod_respo
	end 
	IF @Comodin = 'xTipoResponsable'
	begin
		UPDATE LAB_RESPONSABLE SET
		dtFecha_log = @dtFecha_log
		, bitEstado_respo = 0
		, strUser_log = @strUser_log
		WHERE (strCod_respo = @strCod_respo
		and strTipo_respo = @strTipo_respo)
	end 
END
GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_UpdateSoftware]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_UpdateSoftware]
@strCod_sof varchar(100)
, @strNombre_sof VARCHAR(100)
, @strTipoLicencia_sof VARCHAR(100)
, @strNombreLicencia_sof VARCHAR(250)
, @intCantidad_sof int
, @decCostoUnitario_sof decimal(10,2)
, @decCostoTotal_sof decimal(10,2)
, @strDescripcion_sof varchar(MAX)
, @strImagen_sof varchar(100)
, @strUrl_sof varchar(250)
, @dtFecha_log DATETIME
, @strUser_log VARCHAR(20)
, @strCod_Fac VARCHAR(30)
, @strCod_Sede VARCHAR(30)
AS
 SET NOCOUNT OFF;
 BEGIN
	UPDATE LAB_SOFTWARE SET
    strNombre_sof = @strNombre_sof
	, strTipoLicencia_sof = @strTipoLicencia_sof
	, strNombreLicencia_sof = @strNombreLicencia_sof
	, intCantidad_sof = @intCantidad_sof
	, decCostoUnitario_sof = @decCostoUnitario_sof
	, decCostoTotal_sof = @decCostoTotal_sof
	, strDescripcion_sof = @strDescripcion_sof
	, strImagen_sof = @strImagen_sof
	, strUrl_sof = @strUrl_sof
	, dtFecha_log = @dtFecha_log
	, strUser_log = @strUser_log 
	, strCod_Fac = @strCod_Fac
	, strCod_Sede = @strCod_Sede
	WHERE strCod_sof = @strCod_sof
END

GO
/****** Object:  StoredProcedure [dbo].[SIGUTC_UpdateTipoLaboratorio]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIGUTC_UpdateTipoLaboratorio]
@strCod_tipoLab VARCHAR(100)
, @strNombre_tipoLab VARCHAR(100)
, @dtFecha_log DATETIME
, @strUser_log VARCHAR(20)
AS
 SET NOCOUNT OFF;
 BEGIN
	UPDATE LAB_TIPO SET
    strNombre_tipoLab = @strNombre_tipoLab
	, dtFecha_log = @dtFecha_log
	, strUser_log = @strUser_log
	WHERE strCod_tipoLab = @strCod_tipoLab
END
GO
/****** Object:  Table [dbo].[AC_CURSOS]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AC_CURSOS](
	[strCod_curso] [varchar](100) NOT NULL,
	[strNombre_curso] [nchar](10) NOT NULL,
	[strParalelo_curso] [varchar](10) NOT NULL,
	[strCod_per] [varchar](100) NOT NULL,
 CONSTRAINT [PK_AC_CURSOS] PRIMARY KEY CLUSTERED 
(
	[strCod_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AC_DISTRIBUTIVO]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AC_DISTRIBUTIVO](
	[strCod_mate] [varchar](100) NOT NULL,
	[strCod_curso] [varchar](100) NOT NULL,
	[strCod_pro] [varchar](20) NOT NULL,
 CONSTRAINT [PK_AC_DISTRIBUTIVO] PRIMARY KEY CLUSTERED 
(
	[strCod_mate] ASC,
	[strCod_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AC_HORARIOS]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AC_HORARIOS](
	[strCod_curso] [varchar](100) NOT NULL,
	[strCod_mate] [varchar](100) NOT NULL,
	[intDia_horario] [int] NOT NULL,
	[strCod_horas] [varchar](10) NOT NULL,
 CONSTRAINT [PK_AC_HORARIOS] PRIMARY KEY CLUSTERED 
(
	[strCod_curso] ASC,
	[strCod_mate] ASC,
	[intDia_horario] ASC,
	[strCod_horas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AC_MATRICULAC]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AC_MATRICULAC](
	[strCod_matric] [varchar](100) NOT NULL,
	[strCod_alu] [varchar](20) NOT NULL,
	[strCod_per] [varchar](100) NOT NULL,
	[intCod_nivel] [int] NOT NULL,
 CONSTRAINT [PK_AC_MATRICULAC] PRIMARY KEY CLUSTERED 
(
	[strCod_matric] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AC_MATRICULAD]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AC_MATRICULAD](
	[strCod_matrid] [varchar](100) NOT NULL,
	[strCod_matric] [varchar](100) NOT NULL,
	[strCod_mate] [varchar](100) NOT NULL,
	[strCod_curso] [varchar](100) NOT NULL,
 CONSTRAINT [PK_AC_MATRICULAD] PRIMARY KEY CLUSTERED 
(
	[strCod_matrid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_EXCLUSIVO]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_EXCLUSIVO](
	[strCod_labEx] [varchar](100) NOT NULL,
	[strCod_Sede] [varchar](30) NOT NULL,
	[strCod_Fac] [varchar](30) NOT NULL,
	[strCod_Car] [varchar](30) NOT NULL,
	[strCod_lab] [varchar](100) NOT NULL,
	[dtFechaRegistro_labEx] [datetime] NOT NULL,
	[bitEstado_labEx] [bit] NOT NULL CONSTRAINT [DF_LAB_LABORATORIO_EXCLUSIVO_bitEstado_labEx]  DEFAULT ((1)),
	[dtFecha_log] [datetime] NOT NULL,
	[strUser_log] [varchar](20) NOT NULL,
	[strObs1_labEx] [varchar](250) NULL,
	[strObs2_labEx] [varchar](250) NULL,
	[bitObs1_labEx] [bit] NULL,
	[bitObs2_labEx] [bit] NULL,
	[decObs1_labEx] [decimal](10, 2) NULL,
	[decObs2_labEx] [decimal](10, 2) NULL,
	[dtObs1_labEx] [date] NULL,
	[dtObs2_labEx] [date] NULL,
 CONSTRAINT [PK_LAB_LABORATORIO_EXCLUSIVO] PRIMARY KEY CLUSTERED 
(
	[strCod_labEx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_LABORATORIOS]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_LABORATORIOS](
	[strCod_lab] [varchar](100) NOT NULL,
	[strCod_Sede] [varchar](30) NOT NULL,
	[strCod_Fac] [varchar](30) NOT NULL,
	[strCod_tipoLab] [varchar](100) NOT NULL,
	[strCod_areac] [varchar](100) NOT NULL,
	[strNombre_lab] [varchar](100) NOT NULL,
	[intNumeroEquipos_lab] [int] NOT NULL,
	[strUbicacion_lab] [varchar](250) NOT NULL,
	[strFotografia1_lab] [varchar](100) NOT NULL,
	[strFotografia2_lab] [varchar](100) NOT NULL,
	[dtFechaRegistro_lab] [datetime2](7) NOT NULL,
	[bitEstado_lab] [bit] NOT NULL CONSTRAINT [DF_LAB_LABORATORIOS_bitEstado_lab]  DEFAULT ((1)),
	[dtFecha_log] [datetime] NOT NULL,
	[strUser_log] [varchar](20) NOT NULL,
	[strObs1_lab] [varchar](250) NULL,
	[strObs2_lab] [varchar](250) NULL,
	[bitObs1_lab] [bit] NULL,
	[bitObs2_lab] [bit] NULL,
	[decObs1_lab] [decimal](6, 2) NULL,
	[decObs2_lab] [decimal](6, 2) NULL,
	[dtObs1_lab] [date] NULL,
	[dtObs2_lab] [date] NULL,
 CONSTRAINT [PK_LAB_LABORATORIOS] PRIMARY KEY CLUSTERED 
(
	[strCod_lab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_LABSOFTWARE]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_LABSOFTWARE](
	[strCod_labSoft] [varchar](100) NOT NULL,
	[strCod_Sede] [varchar](30) NOT NULL,
	[strCod_Fac] [varchar](30) NOT NULL,
	[strCod_sof] [varchar](100) NOT NULL,
	[strCod_lab] [varchar](100) NOT NULL,
	[dtFechaRegistro_labSoft] [datetime] NOT NULL,
	[bitEstado_labSoft] [bit] NOT NULL CONSTRAINT [DF_LAB_LABORATORIO_SOFTWARE_bitEstado_labSoft]  DEFAULT ((1)),
	[dtFecha_log] [datetime] NOT NULL,
	[strUser_log] [varchar](20) NOT NULL,
	[strObs1_labSoft] [varchar](250) NULL,
	[strObs2_labSoft] [varchar](250) NULL,
	[bitObs1_labSoft] [bit] NULL,
	[bitObs2_labSoft] [bit] NULL,
	[decObs1_labSoft] [numeric](10, 0) NULL,
	[decObs2_labSoft] [numeric](10, 0) NULL,
	[dtObs1_labSoft] [date] NULL,
	[dtObs2_labSoft] [date] NULL,
 CONSTRAINT [PK_LAB_LABORATORIO_SOFTWARE] PRIMARY KEY CLUSTERED 
(
	[strCod_labSoft] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_MOTIVO_RESERVAS]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_MOTIVO_RESERVAS](
	[strCod_motRes] [varchar](100) NOT NULL,
	[strNombre_motRes] [varchar](100) NOT NULL,
	[dtFechaRegistro_motRes] [datetime] NOT NULL,
	[bitEstado_motRes] [bit] NOT NULL,
	[dtFecha_log] [datetime] NOT NULL,
	[strUser_log] [varchar](20) NOT NULL,
	[strObs1_lab] [varchar](250) NULL,
	[strObs2_lab] [varchar](250) NULL,
	[bitObs1_lab] [bit] NULL,
	[bitObs2_lab] [bit] NULL,
	[decObs1_lab] [decimal](10, 2) NULL,
	[decObs2_lab] [decimal](10, 2) NULL,
	[dtObs1_lab] [date] NULL,
	[dtObs2_lab] [date] NULL,
 CONSTRAINT [PK_LAB_MOTIVO_RESERVAS] PRIMARY KEY CLUSTERED 
(
	[strCod_motRes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_RESERVA]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_RESERVA](
	[strCod_reser] [varchar](100) NOT NULL,
	[strCod_lab] [varchar](100) NOT NULL,
	[strCod_motRes] [varchar](100) NOT NULL,
	[strTema_reser] [varchar](200) NOT NULL,
	[strDescripcion_reser] [varchar](200) NOT NULL,
	[strMateriales_reser] [varchar](200) NOT NULL,
	[dtFechaInicio_reser] [datetime] NOT NULL,
	[dtFechaFin_reser] [datetime] NOT NULL,
	[intTotalAsistente_reser] [int] NOT NULL,
	[bitEstado_reser] [bit] NOT NULL,
	[dtFecha_log] [datetime] NOT NULL,
	[strUser_log] [varchar](20) NOT NULL,
	[strObs1_reser] [varchar](200) NULL,
	[strObs2_reser] [varchar](200) NULL,
	[bitObs1_reser] [bit] NULL,
	[bitObs2_reser] [bit] NULL,
	[decObs1_reser] [decimal](6, 2) NULL,
	[decObs2_reser] [decimal](6, 2) NULL,
	[dtObs1_reser] [date] NULL,
	[dtObs2_reser] [date] NULL,
 CONSTRAINT [PK_LAB_RESERVA] PRIMARY KEY CLUSTERED 
(
	[strCod_reser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_RESPONSABLE]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_RESPONSABLE](
	[strCod_respo] [varchar](100) NOT NULL,
	[strCod_lab] [varchar](100) NOT NULL,
	[strCod_res] [varchar](20) NOT NULL,
	[strTipo_respo] [varchar](30) NOT NULL,
	[dtFechaInicio_respo] [datetime] NOT NULL,
	[bitEstado_respo] [bit] NOT NULL CONSTRAINT [DF_LAB_RESPONSABLE_bitEstado_respo]  DEFAULT ((1)),
	[dtFecha_log] [datetime] NOT NULL,
	[strUser_log] [varchar](20) NOT NULL,
	[strObs1_lab] [varchar](250) NULL,
	[strObs2_lab] [varchar](250) NULL,
	[bitObs1_lab] [bit] NULL,
	[bitObs2_lab] [bit] NULL,
	[decObs1_lab] [decimal](6, 2) NULL,
	[decObs2_lab] [decimal](6, 2) NULL,
	[dtObs1_lab] [date] NULL,
	[dtObs2_lab] [date] NULL,
 CONSTRAINT [PK_LAB_RESPONSABLE] PRIMARY KEY CLUSTERED 
(
	[strCod_respo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_SOFTWARE]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_SOFTWARE](
	[strCod_sof] [varchar](100) NOT NULL,
	[strCod_Sede] [varchar](30) NOT NULL,
	[strCod_Fac] [varchar](30) NOT NULL,
	[strNombre_sof] [varchar](100) NOT NULL,
	[strTipoLicencia_sof] [varchar](100) NOT NULL,
	[strNombreLicencia_sof] [varchar](100) NULL,
	[intCantidad_sof] [int] NOT NULL,
	[decCostoUnitario_sof] [decimal](10, 2) NOT NULL,
	[decCostoTotal_sof] [decimal](10, 2) NOT NULL,
	[strDescripcion_sof] [varchar](max) NOT NULL,
	[strImagen_sof] [varchar](100) NOT NULL,
	[strUrl_sof] [varchar](250) NOT NULL,
	[dtFechaRegistro_sof] [datetime] NOT NULL,
	[bitEstado_sof] [bit] NOT NULL CONSTRAINT [DF_LAB_SOFTWARE_bitEstado_sof]  DEFAULT ((1)),
	[dtFecha_log] [datetime] NOT NULL,
	[strUser_log] [varchar](20) NOT NULL,
	[strObs1_sof] [varchar](250) NULL,
	[strObs2_sof] [varchar](250) NULL,
	[bitObs1_sof] [bit] NULL,
	[bitObs2_sof] [bit] NULL,
	[decObs1_sof] [decimal](10, 2) NULL,
	[decObs2_sof] [decimal](10, 2) NULL,
	[dtObs1_sof] [date] NULL,
	[dtObs2_sof] [date] NULL,
 CONSTRAINT [PK_LAB_SOFTWARE] PRIMARY KEY CLUSTERED 
(
	[strCod_sof] ASC,
	[strCod_Fac] ASC,
	[strCod_Sede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_TIPO]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_TIPO](
	[strCod_tipoLab] [varchar](100) NOT NULL,
	[strNombre_tipoLab] [varchar](100) NOT NULL,
	[dtFechaRegistro_tipoLab] [datetime] NOT NULL,
	[bitEstado_tipoLab] [bit] NOT NULL CONSTRAINT [DF_LAB_TIPO_LABORATORIO_bitEstado_tipoLab]  DEFAULT ((1)),
	[dtFecha_log] [datetime] NOT NULL,
	[strUser_log] [varchar](20) NOT NULL,
	[strObs1_tipoLab] [varchar](250) NULL,
	[strObs2_tipoLab] [varchar](250) NULL,
	[bitObs1_tipoLab] [bit] NULL,
	[bitObs2_tipoLab] [bit] NULL,
	[decObs1_tipoLab] [decimal](10, 2) NULL,
	[decObs2_tipoLab] [decimal](10, 2) NULL,
	[dtObs1_tipoLab] [date] NULL,
	[dtObs2_tipoLab] [date] NULL,
 CONSTRAINT [PK_LAB_TIPO_LABORATORIO] PRIMARY KEY CLUSTERED 
(
	[strCod_tipoLab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MATERIAS]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MATERIAS](
	[strCod_mate] [varchar](100) NOT NULL,
	[strCodAlt_mate] [varchar](100) NOT NULL,
	[strNombre_mate] [varchar](100) NOT NULL,
	[strCod_Sede] [varchar](30) NOT NULL,
	[strCod_Fac] [varchar](30) NOT NULL,
	[strCod_Car] [varchar](30) NOT NULL,
 CONSTRAINT [PK_MATERIAS] PRIMARY KEY CLUSTERED 
(
	[strCodAlt_mate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PERSONAL]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PERSONAL](
	[CEDULA_ALU] [varchar](20) NOT NULL,
	[APELLIDO_ALU] [varchar](100) NULL,
	[APELLIDOM_ALU] [varchar](100) NULL,
	[NOMBRE_ALU] [varchar](100) NOT NULL,
	[IMAGEN_ALU] [varchar](100) NOT NULL,
	[CORREO_ALU] [varchar](100) NOT NULL,
	[strContraseña_Per] [varchar](100) NOT NULL,
 CONSTRAINT [PK_PERSONAL] PRIMARY KEY CLUSTERED 
(
	[CEDULA_ALU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROLES]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ROLES](
	[strId_rol] [varchar](100) NULL,
	[strNombre_rol] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED 
(
	[strNombre_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SIG_AREAC]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SIG_AREAC](
	[strCod_areac] [varchar](100) NOT NULL,
	[strTipo_areac] [varchar](100) NOT NULL,
	[strNombre_areac] [varchar](100) NOT NULL,
 CONSTRAINT [PK_SIG_AREAC] PRIMARY KEY CLUSTERED 
(
	[strCod_areac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SIG_HORAS]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SIG_HORAS](
	[strCod_horas] [varchar](10) NOT NULL,
	[dtInicio_horas] [datetime] NOT NULL,
	[dtFin_horas] [datetime] NOT NULL,
	[strGrupo_horas] [varchar](100) NOT NULL,
	[strObs1_horas] [varchar](100) NULL,
 CONSTRAINT [PK_SIG_HORAS] PRIMARY KEY CLUSTERED 
(
	[strCod_horas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SIG_PERIODOS]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SIG_PERIODOS](
	[strCod_per] [varchar](100) NOT NULL,
	[intNum_per] [int] NOT NULL,
	[intNumSemanas_per] [int] NOT NULL,
	[strCod_Sede] [varchar](30) NOT NULL,
	[strCod_Fac] [varchar](30) NOT NULL,
	[strCod_Car] [varchar](30) NOT NULL,
	[dtFechaIni_per] [date] NOT NULL,
	[dtFechaFin_per] [date] NOT NULL,
 CONSTRAINT [PK_SIG_PERIODOS] PRIMARY KEY CLUSTERED 
(
	[strCod_per] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SILABOC]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SILABOC](
	[strCod_silaboc] [varchar](100) NOT NULL,
	[strCod_per] [varchar](100) NOT NULL,
	[strCod_malla] [varchar](100) NOT NULL,
	[strCod_mate] [varchar](100) NOT NULL,
	[strNum_silaboc] [varchar](100) NOT NULL,
	[strDesc_silaboc] [varchar](250) NOT NULL,
 CONSTRAINT [PK_SILABOC] PRIMARY KEY CLUSTERED 
(
	[strCod_silaboc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SILABOD]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SILABOD](
	[strCod_silabod] [varchar](100) NOT NULL,
	[strCod_silaboc] [varchar](100) NOT NULL,
	[strAplicacion_Act] [varchar](30) NOT NULL,
	[strCod_Act] [varchar](30) NOT NULL,
	[strCod_Conc] [varchar](30) NOT NULL,
	[strDesc_silabod] [varchar](max) NOT NULL,
	[intOrd_silabod] [int] NOT NULL,
 CONSTRAINT [PK_SILABOD] PRIMARY KEY CLUSTERED 
(
	[strCod_silabod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TEMA]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TEMA](
	[strCod_tema] [varchar](100) NOT NULL,
	[strCod_unidTem] [varchar](100) NOT NULL,
	[strNum_tema] [varchar](10) NOT NULL,
	[strDesc_tema] [varchar](250) NOT NULL,
 CONSTRAINT [PK_TEMA] PRIMARY KEY CLUSTERED 
(
	[strCod_tema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UB_CARRERAS]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UB_CARRERAS](
	[strCod_Sede] [varchar](30) NOT NULL,
	[strCod_Fac] [varchar](30) NOT NULL,
	[strCod_Car] [varchar](30) NOT NULL,
	[strNombre_Car] [varchar](100) NOT NULL,
 CONSTRAINT [PK_UB_CARRERAS_1] PRIMARY KEY CLUSTERED 
(
	[strCod_Sede] ASC,
	[strCod_Fac] ASC,
	[strCod_Car] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UB_FACULTADES]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UB_FACULTADES](
	[strCod_Sede] [varchar](30) NOT NULL,
	[strCod_Fac] [varchar](30) NOT NULL,
	[strNombre_Fac] [varchar](100) NOT NULL,
 CONSTRAINT [PK_UB_FACULTADES_1] PRIMARY KEY CLUSTERED 
(
	[strCod_Sede] ASC,
	[strCod_Fac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UB_SEDES]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UB_SEDES](
	[strCod_Sede] [varchar](30) NOT NULL,
	[strNombre_Sede] [varchar](30) NOT NULL,
	[strTipo_Sede] [varchar](1) NOT NULL,
 CONSTRAINT [PK_UB_SEDES] PRIMARY KEY CLUSTERED 
(
	[strCod_Sede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UNIDAD_TEMA]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UNIDAD_TEMA](
	[strCod_unidTem] [varchar](100) NOT NULL,
	[strCod_silaboc] [varchar](100) NOT NULL,
	[strNum_unidTem] [varchar](10) NOT NULL,
	[strDesc_unidTem] [varchar](250) NOT NULL,
 CONSTRAINT [PK_UNIDAD_TEMA] PRIMARY KEY CLUSTERED 
(
	[strCod_unidTem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO](
	[strUsuarioCedula] [varchar](10) NULL,
	[strUsuarioId] [varchar](100) NOT NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[strUsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIOINROLES]    Script Date: 26/4/2025 8:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIOINROLES](
	[strUsuarioId] [varchar](100) NOT NULL,
	[strNombre_rol] [varchar](100) NOT NULL,
 CONSTRAINT [PK_USUARIOINROLES] PRIMARY KEY CLUSTERED 
(
	[strUsuarioId] ASC,
	[strNombre_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[LAB_MOTIVO_RESERVAS] ADD  CONSTRAINT [DF_LAB_MOTIVO_RESERVAS_bitEstado_motRes]  DEFAULT ((1)) FOR [bitEstado_motRes]
GO
ALTER TABLE [dbo].[LAB_RESERVA] ADD  CONSTRAINT [DF_LAB_RESERVA_bitEstado_reser]  DEFAULT ((1)) FOR [bitEstado_reser]
GO
ALTER TABLE [dbo].[AC_CURSOS]  WITH CHECK ADD  CONSTRAINT [FK_AC_CURSOS_SIG_PERIODOS] FOREIGN KEY([strCod_per])
REFERENCES [dbo].[SIG_PERIODOS] ([strCod_per])
GO
ALTER TABLE [dbo].[AC_CURSOS] CHECK CONSTRAINT [FK_AC_CURSOS_SIG_PERIODOS]
GO
ALTER TABLE [dbo].[AC_DISTRIBUTIVO]  WITH CHECK ADD  CONSTRAINT [FK_AC_DISTRIBUTIVO_AC_CURSOS] FOREIGN KEY([strCod_curso])
REFERENCES [dbo].[AC_CURSOS] ([strCod_curso])
GO
ALTER TABLE [dbo].[AC_DISTRIBUTIVO] CHECK CONSTRAINT [FK_AC_DISTRIBUTIVO_AC_CURSOS]
GO
ALTER TABLE [dbo].[AC_DISTRIBUTIVO]  WITH CHECK ADD  CONSTRAINT [FK_AC_DISTRIBUTIVO_MATERIAS] FOREIGN KEY([strCod_mate])
REFERENCES [dbo].[MATERIAS] ([strCodAlt_mate])
GO
ALTER TABLE [dbo].[AC_DISTRIBUTIVO] CHECK CONSTRAINT [FK_AC_DISTRIBUTIVO_MATERIAS]
GO
ALTER TABLE [dbo].[AC_DISTRIBUTIVO]  WITH CHECK ADD  CONSTRAINT [FK_AC_DISTRIBUTIVO_PERSONAL] FOREIGN KEY([strCod_pro])
REFERENCES [dbo].[PERSONAL] ([CEDULA_ALU])
GO
ALTER TABLE [dbo].[AC_DISTRIBUTIVO] CHECK CONSTRAINT [FK_AC_DISTRIBUTIVO_PERSONAL]
GO
ALTER TABLE [dbo].[AC_HORARIOS]  WITH CHECK ADD  CONSTRAINT [FK_AC_HORARIOS_AC_DISTRIBUTIVO] FOREIGN KEY([strCod_mate], [strCod_curso])
REFERENCES [dbo].[AC_DISTRIBUTIVO] ([strCod_mate], [strCod_curso])
GO
ALTER TABLE [dbo].[AC_HORARIOS] CHECK CONSTRAINT [FK_AC_HORARIOS_AC_DISTRIBUTIVO]
GO
ALTER TABLE [dbo].[AC_HORARIOS]  WITH CHECK ADD  CONSTRAINT [FK_AC_HORARIOS_SIG_HORAS] FOREIGN KEY([strCod_horas])
REFERENCES [dbo].[SIG_HORAS] ([strCod_horas])
GO
ALTER TABLE [dbo].[AC_HORARIOS] CHECK CONSTRAINT [FK_AC_HORARIOS_SIG_HORAS]
GO
ALTER TABLE [dbo].[AC_MATRICULAC]  WITH CHECK ADD  CONSTRAINT [FK_AC_MATRICULAC_PERSONAL] FOREIGN KEY([strCod_alu])
REFERENCES [dbo].[PERSONAL] ([CEDULA_ALU])
GO
ALTER TABLE [dbo].[AC_MATRICULAC] CHECK CONSTRAINT [FK_AC_MATRICULAC_PERSONAL]
GO
ALTER TABLE [dbo].[AC_MATRICULAC]  WITH CHECK ADD  CONSTRAINT [FK_AC_MATRICULAC_SIG_PERIODOS] FOREIGN KEY([strCod_per])
REFERENCES [dbo].[SIG_PERIODOS] ([strCod_per])
GO
ALTER TABLE [dbo].[AC_MATRICULAC] CHECK CONSTRAINT [FK_AC_MATRICULAC_SIG_PERIODOS]
GO
ALTER TABLE [dbo].[AC_MATRICULAD]  WITH CHECK ADD  CONSTRAINT [FK_AC_MATRICULAD_AC_DISTRIBUTIVO] FOREIGN KEY([strCod_mate], [strCod_curso])
REFERENCES [dbo].[AC_DISTRIBUTIVO] ([strCod_mate], [strCod_curso])
GO
ALTER TABLE [dbo].[AC_MATRICULAD] CHECK CONSTRAINT [FK_AC_MATRICULAD_AC_DISTRIBUTIVO]
GO
ALTER TABLE [dbo].[AC_MATRICULAD]  WITH CHECK ADD  CONSTRAINT [FK_AC_MATRICULAD_AC_MATRICULAC] FOREIGN KEY([strCod_matric])
REFERENCES [dbo].[AC_MATRICULAC] ([strCod_matric])
GO
ALTER TABLE [dbo].[AC_MATRICULAD] CHECK CONSTRAINT [FK_AC_MATRICULAD_AC_MATRICULAC]
GO
ALTER TABLE [dbo].[LAB_EXCLUSIVO]  WITH CHECK ADD  CONSTRAINT [FK_LAB_LABORATORIO_EXCLUSIVO_LAB_LABORATORIOS] FOREIGN KEY([strCod_lab])
REFERENCES [dbo].[LAB_LABORATORIOS] ([strCod_lab])
GO
ALTER TABLE [dbo].[LAB_EXCLUSIVO] CHECK CONSTRAINT [FK_LAB_LABORATORIO_EXCLUSIVO_LAB_LABORATORIOS]
GO
ALTER TABLE [dbo].[LAB_EXCLUSIVO]  WITH CHECK ADD  CONSTRAINT [FK_LAB_LABORATORIO_EXCLUSIVO_UB_CARRERAS] FOREIGN KEY([strCod_Sede], [strCod_Fac], [strCod_Car])
REFERENCES [dbo].[UB_CARRERAS] ([strCod_Sede], [strCod_Fac], [strCod_Car])
GO
ALTER TABLE [dbo].[LAB_EXCLUSIVO] CHECK CONSTRAINT [FK_LAB_LABORATORIO_EXCLUSIVO_UB_CARRERAS]
GO
ALTER TABLE [dbo].[LAB_LABORATORIOS]  WITH CHECK ADD  CONSTRAINT [FK_LAB_LABORATORIOS_LAB_TIPO_LABORATORIO] FOREIGN KEY([strCod_tipoLab])
REFERENCES [dbo].[LAB_TIPO] ([strCod_tipoLab])
GO
ALTER TABLE [dbo].[LAB_LABORATORIOS] CHECK CONSTRAINT [FK_LAB_LABORATORIOS_LAB_TIPO_LABORATORIO]
GO
ALTER TABLE [dbo].[LAB_LABSOFTWARE]  WITH CHECK ADD  CONSTRAINT [FK_LAB_LABORATORIO_SOFTWARE_LAB_LABORATORIOS] FOREIGN KEY([strCod_lab])
REFERENCES [dbo].[LAB_LABORATORIOS] ([strCod_lab])
GO
ALTER TABLE [dbo].[LAB_LABSOFTWARE] CHECK CONSTRAINT [FK_LAB_LABORATORIO_SOFTWARE_LAB_LABORATORIOS]
GO
ALTER TABLE [dbo].[LAB_LABSOFTWARE]  WITH CHECK ADD  CONSTRAINT [FK_LAB_LABORATORIO_SOFTWARE_LAB_SOFTWARE1] FOREIGN KEY([strCod_sof], [strCod_Fac], [strCod_Sede])
REFERENCES [dbo].[LAB_SOFTWARE] ([strCod_sof], [strCod_Fac], [strCod_Sede])
GO
ALTER TABLE [dbo].[LAB_LABSOFTWARE] CHECK CONSTRAINT [FK_LAB_LABORATORIO_SOFTWARE_LAB_SOFTWARE1]
GO
ALTER TABLE [dbo].[LAB_RESERVA]  WITH CHECK ADD  CONSTRAINT [FK_LAB_RESERVA_LAB_LABORATORIOS] FOREIGN KEY([strCod_lab])
REFERENCES [dbo].[LAB_LABORATORIOS] ([strCod_lab])
GO
ALTER TABLE [dbo].[LAB_RESERVA] CHECK CONSTRAINT [FK_LAB_RESERVA_LAB_LABORATORIOS]
GO
ALTER TABLE [dbo].[LAB_RESERVA]  WITH CHECK ADD  CONSTRAINT [FK_LAB_RESERVA_LAB_MOTIVO_RESERVAS] FOREIGN KEY([strCod_motRes])
REFERENCES [dbo].[LAB_MOTIVO_RESERVAS] ([strCod_motRes])
GO
ALTER TABLE [dbo].[LAB_RESERVA] CHECK CONSTRAINT [FK_LAB_RESERVA_LAB_MOTIVO_RESERVAS]
GO
ALTER TABLE [dbo].[LAB_RESPONSABLE]  WITH CHECK ADD  CONSTRAINT [FK_LAB_RESPONSABLE_LAB_LABORATORIOS] FOREIGN KEY([strCod_lab])
REFERENCES [dbo].[LAB_LABORATORIOS] ([strCod_lab])
GO
ALTER TABLE [dbo].[LAB_RESPONSABLE] CHECK CONSTRAINT [FK_LAB_RESPONSABLE_LAB_LABORATORIOS]
GO
ALTER TABLE [dbo].[LAB_RESPONSABLE]  WITH CHECK ADD  CONSTRAINT [FK_LAB_RESPONSABLE_PERSONAL] FOREIGN KEY([strCod_res])
REFERENCES [dbo].[PERSONAL] ([CEDULA_ALU])
GO
ALTER TABLE [dbo].[LAB_RESPONSABLE] CHECK CONSTRAINT [FK_LAB_RESPONSABLE_PERSONAL]
GO
ALTER TABLE [dbo].[LAB_SOFTWARE]  WITH CHECK ADD  CONSTRAINT [FK_LAB_SOFTWARE_UB_FACULTADES] FOREIGN KEY([strCod_Sede], [strCod_Fac])
REFERENCES [dbo].[UB_FACULTADES] ([strCod_Sede], [strCod_Fac])
GO
ALTER TABLE [dbo].[LAB_SOFTWARE] CHECK CONSTRAINT [FK_LAB_SOFTWARE_UB_FACULTADES]
GO
ALTER TABLE [dbo].[MATERIAS]  WITH CHECK ADD  CONSTRAINT [FK_MATERIAS_UB_CARRERAS] FOREIGN KEY([strCod_Sede], [strCod_Fac], [strCod_Car])
REFERENCES [dbo].[UB_CARRERAS] ([strCod_Sede], [strCod_Fac], [strCod_Car])
GO
ALTER TABLE [dbo].[MATERIAS] CHECK CONSTRAINT [FK_MATERIAS_UB_CARRERAS]
GO
ALTER TABLE [dbo].[SIG_PERIODOS]  WITH CHECK ADD  CONSTRAINT [FK_SIG_PERIODOS_UB_CARRERAS1] FOREIGN KEY([strCod_Sede], [strCod_Fac], [strCod_Car])
REFERENCES [dbo].[UB_CARRERAS] ([strCod_Sede], [strCod_Fac], [strCod_Car])
GO
ALTER TABLE [dbo].[SIG_PERIODOS] CHECK CONSTRAINT [FK_SIG_PERIODOS_UB_CARRERAS1]
GO
ALTER TABLE [dbo].[SILABOC]  WITH CHECK ADD  CONSTRAINT [FK_SILABOC_MATERIAS] FOREIGN KEY([strCod_mate])
REFERENCES [dbo].[MATERIAS] ([strCodAlt_mate])
GO
ALTER TABLE [dbo].[SILABOC] CHECK CONSTRAINT [FK_SILABOC_MATERIAS]
GO
ALTER TABLE [dbo].[SILABOD]  WITH CHECK ADD  CONSTRAINT [FK_SILABOD_SILABOC] FOREIGN KEY([strCod_silaboc])
REFERENCES [dbo].[SILABOC] ([strCod_silaboc])
GO
ALTER TABLE [dbo].[SILABOD] CHECK CONSTRAINT [FK_SILABOD_SILABOC]
GO
ALTER TABLE [dbo].[TEMA]  WITH CHECK ADD  CONSTRAINT [FK_TEMA_UNIDAD_TEMA] FOREIGN KEY([strCod_unidTem])
REFERENCES [dbo].[UNIDAD_TEMA] ([strCod_unidTem])
GO
ALTER TABLE [dbo].[TEMA] CHECK CONSTRAINT [FK_TEMA_UNIDAD_TEMA]
GO
ALTER TABLE [dbo].[UB_CARRERAS]  WITH CHECK ADD  CONSTRAINT [FK_UB_CARRERAS_UB_FACULTADES] FOREIGN KEY([strCod_Sede], [strCod_Fac])
REFERENCES [dbo].[UB_FACULTADES] ([strCod_Sede], [strCod_Fac])
GO
ALTER TABLE [dbo].[UB_CARRERAS] CHECK CONSTRAINT [FK_UB_CARRERAS_UB_FACULTADES]
GO
ALTER TABLE [dbo].[UB_FACULTADES]  WITH CHECK ADD  CONSTRAINT [FK_UB_FACULTADES_UB_SEDES1] FOREIGN KEY([strCod_Sede])
REFERENCES [dbo].[UB_SEDES] ([strCod_Sede])
GO
ALTER TABLE [dbo].[UB_FACULTADES] CHECK CONSTRAINT [FK_UB_FACULTADES_UB_SEDES1]
GO
ALTER TABLE [dbo].[UNIDAD_TEMA]  WITH CHECK ADD  CONSTRAINT [FK_UNIDAD_TEMA_SILABOC1] FOREIGN KEY([strCod_silaboc])
REFERENCES [dbo].[SILABOC] ([strCod_silaboc])
GO
ALTER TABLE [dbo].[UNIDAD_TEMA] CHECK CONSTRAINT [FK_UNIDAD_TEMA_SILABOC1]
GO
ALTER TABLE [dbo].[USUARIOINROLES]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOINROLES_ROLES] FOREIGN KEY([strNombre_rol])
REFERENCES [dbo].[ROLES] ([strNombre_rol])
GO
ALTER TABLE [dbo].[USUARIOINROLES] CHECK CONSTRAINT [FK_USUARIOINROLES_ROLES]
GO
ALTER TABLE [dbo].[USUARIOINROLES]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOINROLES_USUARIO] FOREIGN KEY([strUsuarioId])
REFERENCES [dbo].[USUARIO] ([strUsuarioId])
GO
ALTER TABLE [dbo].[USUARIOINROLES] CHECK CONSTRAINT [FK_USUARIOINROLES_USUARIO]
GO
USE [master]
GO
ALTER DATABASE [Reserva] SET  READ_WRITE 
GO
