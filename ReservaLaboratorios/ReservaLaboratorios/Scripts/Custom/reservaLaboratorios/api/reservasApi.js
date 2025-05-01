function consultarAsignaturas(numeroDia) {
    return new Promise((resolve, reject) => {
        $.ajax({
            type: "POST",
            url: "Reservalaboratorio.aspx/obtenerAsignaturas",
            data: JSON.stringify({ dia: numeroDia }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: (response) => {
                resolve(response.d);
            },
            error: (error) => {
                console.error("Error: ", error);
                reject(error);
            }
        });
    });
};

function consultarDetalleAsignatura(asignaturaId, numeroDia) {
    return new Promise((resolve, reject) => {
        $.ajax({
            type: "POST",
            url: "Reservalaboratorio.aspx/consultarDetalleAsignatura",
            data: JSON.stringify({ asignaturaId: asignaturaId, dia: numeroDia }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: (response) => {
                resolve(response.d);
            },
            error: (error) => {
                console.error("Error AJAX:", error);
                reject(error);
            }
        });
    });
}