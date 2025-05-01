document.addEventListener("DOMContentLoaded", function () {
	llamarWebMethod();
});

function llamarWebMethod() {
	$.ajax({
		type: "POST",
		url: "InformacionLaboratorios.aspx/cargarTabla",
		data: "{}",
		contentType: "application/json; charset=utf-8",
		dataType: "json",
		success: function (response) {
			var datos = response.d;
			console.log("Datos recibidos:", datos);
				$('#txtUbicacion').text(datos[0].Ubicacion);
				const img1 = "../../images/Laboratorio/" + datos[0].Imagen1;
				$('#img1').attr('src', img1);
				const img2 = "../../images/Laboratorio/" + datos[0].Imagen2;
				$('#img2').attr('src', img2);
				const fotoAcademico = "../../images/Usuario/" + datos[0].FotoAcademico;
				$('#imgRespAcad').attr('src', fotoAcademico);
				$('#lblRespAcadInf').text(datos[0].ResponsableAcademico);
				const fotoAdministrativo = "../../images/Usuario/" + datos[0].FotoAdministrativo;
				$('#imgRespAdmin').attr('src', fotoAdministrativo);
				$('#lblRespAdminInf').text(datos[0].ResponsableAdministrativo);
				$('#Titulo').text(datos[0].Nombre);
            
		},
		error: function (error) {
			console.log("Error: " + error);
		}
	});
}
