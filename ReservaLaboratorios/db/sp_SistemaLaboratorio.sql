use ReportServer
USE Reserva

-------------------------------------------------------------
CREATE PROCEDURE loginPlataforma
@Comodin varchar(100)
, @FILTRO1 varchar(100)
, @FILTRO2 varchar(100)
, @FILTRO3 varchar(100)
, @FILTRO4 varchar(100)
as begin
	IF @Comodin = 'xUserPassword'
		BEGIN
		SELECT *
		FROM PERSONAL per
		WHERE CEDULA_ALU = @FILTRO1
		and strContraseña_Per = @FILTRO2
		END
	ELSE IF @Comodin = 'xCedula'
		BEGIN
		SELECT usuRol.strNombre_rol
		FROM PERSONAL per
		INNER JOIN USUARIO usu
		ON per.CEDULA_ALU = usu.strUsuarioCedula
		INNER JOIN USUARIOINROLES usuRol
		ON usuRol.strUsuarioId = usu.strUsuarioId
		WHERE CEDULA_ALU = @FILTRO1 
		END
end
--------------------------------------------------
-- +++++++++++++++++++++Funciona+++++++++++++++++++++++++
-- =====INSERT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_AddTipoLaboratorio
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

-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_GetTipoLaboratorio
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

-- =====UPDATE==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_UpdateTipoLaboratorio
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

-- =====DELETE==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_DelTipoLaboratorio
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

-- =====INSERT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================

CREATE PROCEDURE SIGUTC_AddSoftware
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

-- =====SELECT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
create PROCEDURE SIGUTC_GetSoftware
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
END

-- =====SELECT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_GetLAB_LABSOFTWARE
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
AS
SET NOCOUNT OFF;
BEGIN --SP
	IF @Comodin = 'xLaboratorioSoftware'
		BEGIN
		SELECT 
		labSof.strCod_labSoft
		, labSof.strCod_Sede
		, labSof.strCod_Fac
		, labSof.strCod_sof
		, labSof.strCod_lab
		, labSof.dtFechaRegistro_labSoft
		, labSof.bitEstado_labSoft
		, labSof.dtFecha_log
		, labSof.strUser_log
		, labSof.strObs1_labSoft
		, labSof.strObs2_labSoft
		, labSof.bitObs1_labSoft
		, labSof.bitObs2_labSoft
		, labSof.decObs1_labSoft
		, labSof.decObs2_labSoft
		, labSof.dtObs1_labSoft
		, labSof.dtObs2_labSoft
		FROM LAB_LABORATORIOS lab
		INNER JOIN LAB_LABSOFTWARE labSof
		ON labSof.strCod_lab = lab.strCod_lab
		WHERE lab.strCod_lab = @FILTRO1
		AND bitEstado_labSoft = 1
		END
	ELSE IF @Comodin = 'xEstadoLabSoft'
		BEGIN
		SELECT
		strCod_labSoft
		, strCod_Sede
		, strCod_Fac
		, strCod_sof
		, strCod_lab
		, dtFechaRegistro_labSoft
		, bitEstado_labSoft
		, dtFecha_log
		, strUser_log
		, strObs1_labSoft
		, strObs2_labSoft
		, bitObs1_labSoft
		, bitObs2_labSoft
		, decObs1_labSoft
		, decObs2_labSoft
		, dtObs1_labSoft
		, dtObs2_labSoft
		FROM
		LAB_LABSOFTWARE
		WHERE bitEstado_labSoft = 0
		AND strCod_lab = @FILTRO1
		AND strCod_sof = @FILTRO2
		END
END

-- =====UPDATE==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_UpdateSoftware
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

-- =====DELETE==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_DelSoftware
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

-- =====SELECT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_GetSedes
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

 -- =====SELECT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_GetFacultad
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

-- =====SELECT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_GetAREAC
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

-- =====INSERT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_AddLaboratorio
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

 -- =====SELECT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_GetLaboratorios
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
		SELECT *
		FROM LAB_LABORATORIOS lab
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
		ELSE IF @Comodin = 'xCarreraLabExc'
		BEGIN --xCarreraLabExc
			SELECT * 
			FROM LAB_EXCLUSIVO
			WHERE strCod_Car = @FILTRO1
			AND bitEstado_labEx = 1
		END --xCarreraLabExc
END --SP

CREATE PROCEDURE SIGUTC_GetLAB_EXCLUSIVO
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 VARCHAR(100)
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)

AS
 SET NOCOUNT OFF;
 BEGIN --SP
		IF @Comodin = 'xLabExclusivo'
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
END

-- =====UPDATE==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_UpdateLaboratorios
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

-- =====DELETE==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_DelLaboratorios
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

 -- =====INSERT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_AddLabSoftware
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

-- =====DELETE==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_DelLabSoftware
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

 -- =====SELECT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_GetCarreras
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

-- =====INSERT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_AddExclusivo
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

-- =====DELETE==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_DelLAB_EXCLUSIVO
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
, @FILTRO2 DATETIME
, @FILTRO3 VARCHAR(100)
, @FILTRO4 VARCHAR(100)
 AS
  SET NOCOUNT OFF;
  BEGIN
	IF @Comodin = 'xLabExclusivo'
		BEGIN
		UPDATE LAB_EXCLUSIVO
		SET bitEstado_labEx = 0,
		dtFecha_log = @FILTRO2
		, strUser_log = @FILTRO3
		WHERE strCod_labEx = @FILTRO1
		END
END

 -- =====SELECT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_GetPersonal
@Comodin varchar(100)
, @FILTRO1 varchar(100)
, @FILTRO2 varchar(100)
, @FILTRO3 varchar(100)
, @FILTRO4 varchar(100)
as 
 begin
	IF @Comodin = 'xCEDULA'
		BEGIN
		SELECT CEDULA_ALU
		, CONCAT(APELLIDO_ALU
			, ' ', APELLIDOM_ALU
			, ' ', NOMBRE_ALU) AS Responsable
		, CORREO_ALU
		FROM PERSONAL
		WHERE CEDULA_ALU = @FILTRO1
		END
	 IF @Comodin = 'xLaboratorista'
		begin --xLaboratorista
		SELECT DISTINCT per.CEDULA_ALU
		, CONCAT(per.APELLIDO_ALU
			, ' ', per.APELLIDOM_ALU
			, ' ', per.NOMBRE_ALU) AS Responsable
		, per.CORREO_ALU
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
		, CONCAT(per.APELLIDO_ALU, 
			' ', per.APELLIDOM_ALU,
			' ', per.NOMBRE_ALU) AS Responsable
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
			, CONCAT(per.APELLIDO_ALU
				, ' ', per.APELLIDOM_ALU
				, ' ', per.NOMBRE_ALU) AS Responsable
			FROM PERSONAL per
			INNER JOIN USUARIO usu 
			ON per.CEDULA_ALU = usu.strUsuarioCedula
			INNER JOIN USUARIOINROLES usuRol 
			ON usu.strUsuarioId = usuRol.strUsuarioId
			WHERE usuRol.strNombre_rol = 'LABORATORISTA'

		UNION

		SELECT DISTINCT per.CEDULA_ALU
			, CONCAT(per.APELLIDO_ALU
				, ' ', per.APELLIDOM_ALU
				, ' ', per.NOMBRE_ALU) AS Responsable
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

-- =====INSERT==================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  Desarrollo UTC
-- Create date: 29/05/24
-- =============================================
CREATE PROCEDURE SIGUTC_AddResponsable
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

CREATE PROCEDURE SIGUTC_GetResponsable
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
		SELECT per.CEDULA_ALU
		, CONCAT(per.APELLIDO_ALU
			, ' ', per.APELLIDOM_ALU
			, ' ', per.NOMBRE_ALU) 
		AS Responsable
		, per.IMAGEN_ALU
		, resp.* 
		FROM LAB_RESPONSABLE resp
		INNER JOIN LAB_LABORATORIOS lab
		ON lab.strCod_lab = resp.strCod_lab
		INNER JOIN PERSONAL per
		ON per.CEDULA_ALU = resp.strCod_res
		WHERE resp.bitEstado_respo = 1
		AND lab.strCod_lab = @FILTRO1
		END
END

CREATE PROCEDURE SIGUTC_UpdateResponsable
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

CREATE PROCEDURE SIGUTC_GetAsignatura
@Comodin VARCHAR(100)
, @FILTRO1 varchar(100)
, @FILTRO2 varchar(100)
, @FILTRO3 varchar(100)
, @FILTRO4 varchar(100)
 as begin
	if @Comodin = 'xAsignatura'
		begin
		SELECT horas.strCod_horas
		, horas.dtInicio_horas
		, horas.dtFin_horas
		, cur.strNombre_curso
		, cur.strParalelo_curso
		, car.strNombre_Car
		, (SELECT COUNT(dis.strCod_mate) 
			FROM AC_DISTRIBUTIVO dis
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
		INNER JOIN SIG_HORAS horas
		ON horas.strCod_horas = hor.strCod_horas
		WHERE dis.strCod_mate = @FILTRO1
		AND hor.intDia_horario = @FILTRO2
	end
	else if @Comodin = 'xDia'
		begin
		SELECT DISTINCT mat.strCod_mate
		, mat.strNombre_mate 
		FROM AC_DISTRIBUTIVO dis
		INNER JOIN PERSONAL pro
		ON pro.CEDULA_ALU = dis.strCod_pro
		INNER JOIN MATERIAS mat
		ON dis.strCod_mate = mat.strCod_mate
		INNER JOIN AC_HORARIOS hor
		ON hor.strCod_mate = dis.strCod_mate
		WHERE hor.intDia_horario = @FILTRO1
		AND pro.CEDULA_ALU = @FILTRO2
	end
end

-- +++++++++++++++++++++Fin Funciona+++++++++++++++++++++++++







































CREATE PROCEDURE SIGUTC_AddReservaciones
@strCod_reser varchar(50)
, @strTema_reser varchar(200)
, @strDescripcion_reser varchar(200)
, @strMateriales_reser varchar(200)
, @dtFechaInicio_reser DATETIME
, @dtFechaFin_reser DATETIME
, @strTipo_reser varchar(30)
, @intTotalAsistente_reser int
, @strCod_lab  varchar(30)
, @strId_HORARIO  varchar(30)

AS
 SET NOCOUNT OFF;
 BEGIN
    INSERT INTO RESERVA(
	strCod_reser
	, strTema_reser
	, strDescripcion_reser
	, strMateriales_reser
	, dtFechaInicio_reser
	, dtFechaFin_reser
	, strTipo_reser
	, intTotalAsistente_reser
	, strCod_lab
	, strId_HORARIO)
	VALUES(
	@strCod_reser
	, @strTema_reser
	, @strDescripcion_reser
	, @strMateriales_reser
	, @dtFechaInicio_reser
	, @dtFechaFin_reser
	, @strTipo_reser
	, @intTotalAsistente_reser
	, @strCod_lab)
 END

DROP PROCEDURE SIGUTC_GetReservas
CREATE PROCEDURE SIGUTC_GetReservas
@Comodin VARCHAR(100)
, @FILTRO1 VARCHAR(100)
/*,@FILTRO2 VARCHAR(100)
,@FILTRO3 VARCHAR(100)
,@FILTRO4 VARCHAR(100)*/

AS
 SET NOCOUNT OFF;
 BEGIN --SP
 IF @Comodin = 'ALL'
    begin --ALL
    SELECT *
    FROM RESERVA;
    end --All
 ELSE IF @Comodin = 'xPkReservas'
    begin --xPK
	SELECT per.strNombre_PERSONAL
	, per.strUsuario_PERSONAL
	, resv.dtFechaInicio_reser
	, resv.dtFechaFin_reser
	, distr.strId_dist
	, distr.strNombre_dist
	, car.strNombre_Car
	, cur.strNombre_Cur
	, cur.strParalelo_Cur
	, resv.intTotalAsistente_reser
	, resv.strTipo_reser
	, resv.strTema_reser
	, resv.strDescripcion_reser
	, resv.strMateriales_reser
	FROM PERSONAL per
	INNER JOIN AC_DISTRIBUTIVO distr
	ON distr.strId_PERSONAL = per.strCod_PERSONAL
	INNER JOIN CURSO cur
	ON distr.strId_Cur = cur.strCod_Cur
	INNER JOIN PERIODO perio
	ON cur.strCod_Per = perio.strCod_Per
	INNER JOIN CARRERA car
	ON perio.strCod_Car = car.strCod_Car
	INNER JOIN HORARIO hor
	ON  hor.strId_dist = distr.strId_dist
	INNER JOIN RESERVA resv
	ON resv.strId_HORARIO = hor.strId_HORARIO
	WHERE resv.strCod_reser = @FILTRO1
	end --xPK
 ELSE IF @Comodin = 'xLaboratorio'
    begin --xSalario
    SELECT *
    FROM RESERVA
    WHERE strCod_lab = @FILTRO1
	end --xSalario
 END --SP

