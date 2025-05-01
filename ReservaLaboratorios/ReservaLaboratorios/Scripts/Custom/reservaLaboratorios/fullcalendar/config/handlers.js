function obtenerDia(fecha) {
    let partes = fecha.split('-');
    if (partes.length !== 3) {
        return "Fecha inválida";
    }

    // Convertir las partes a enteros para evitar problemas con ceros iniciales
    let año = parseInt(partes[0], 10);
    let mes = parseInt(partes[1], 10) - 1; // Restar 1 porque los meses en JavaScript son 0-11
    let dia = parseInt(partes[2], 10);

    let fechaObj = new Date(año, mes, dia);

    // Verificar si la fecha es válida
    if (isNaN(fechaObj.getTime())) {
        return "Fecha inválida";
    }

    // Obtener el número de día (0 = domingo, ..., 6 = sábado)
    let numeroDia = fechaObj.getDay();

    // Retornar el nombre del día
    return numeroDia;
}

function convertJsonDate(jsonDate) {
    const timestamp = parseInt(jsonDate.replace(/\/Date\((-?\d+)\)\//, '$1'));
    const adjusted = new Date(timestamp + (-5 * 60 * 60 * 1000));
    return adjusted;
}

function convertirHora(dateObj) {
    const horas = String(dateObj.getUTCHours()).padStart(2, '0');
    const minutos = String(dateObj.getUTCMinutes()).padStart(2, '0');
    return `${horas}:${minutos}`;
}

function verificar_reservacion() {
    $('#det_reservacion').show();
}