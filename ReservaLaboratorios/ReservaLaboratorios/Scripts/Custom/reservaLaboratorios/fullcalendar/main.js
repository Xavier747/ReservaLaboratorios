var numeroDia = 0;
var horaFinTime = '';

document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar');
    var now = new Date();

    var calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: 'dayGridMonth',
        locale: 'es',
        headerToolbar: {
            left: 'prev,next',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,listWeek'
        },
        buttonText: {
            month: 'Mes',
            week: 'Semana',
            list: 'Lista'
        },
        dateClick: async function (info) {
            var fecha = info.dateStr;

            $('#txtFecha').val(fecha);

            numeroDia = obtenerDia(fecha);
            const asignaturas = await obtenerAsignatura(numeroDia);

            if (Array.isArray(asignaturas)) {
                llenarSelectAsigantura(asignaturas);
            } else {
                console.warn("No se obtuvieron asignaturas");
            }
        },
        eventClick: function (info) {
            
        },
        dayHeaderContent: function (arg) {
            switch (arg.date.getUTCDay()) {
                case 0: return 'Domingo';
                case 1: return 'Lunes';
                case 2: return 'Martes';
                case 3: return 'Miércoles';
                case 4: return 'Jueves';
                case 5: return 'Viernes';
                case 6: return 'Sábado';
            }
        },
        dayCellDidMount: function (info) {
            var dayOfWeek = info.date.getDay(); // Obtiene el día de la semana (0=Domingo, 6=Sábado)
        },
        selectable: true, // Permite la selección de fechas
        select: function (info) {
            $('#form_registrar').modal('show');
        },
        events: function (fetchInfo, successCallback, failureCallback) {

        }
    });
    calendar.render();


});

async function obtenerAsignatura(numeroDia){
    try {
        const asignaturas = await consultarAsignaturas(numeroDia); // aquí espera que la promesa se resuelva

        return asignaturas;
    } catch (error) {
        console.error("Error al obtener asignaturas:", error);
    }

}

$(document).ready(function () {
    $("#selectAsignatura").on('change', async function () {
        var asignaturaId = this.value; // Capturar el valor seleccionado
        await consultarAsignatura(asignaturaId, numeroDia);

    });

    $("#selectHoraInicio").on('change', function () {
        var horaInicio = this.value; // Capturar el valor seleccionado
        llenarHoraFin(horaInicio);
    });

    $("#selectDistributivoAct").on('change', function () {
        var asignaturaId = this.value; // Capturar el valor seleccionado
        consultarAsignaturaAct(asignaturaId);
    });

    $("#selectHoraInicioAct").on('change', function () {
        var horaInicio = this.value; // Capturar el valor seleccionado
        llenarHoraFinAct(horaInicio);
    });
});

async function consultarAsignatura(asignaturaId, numeroDia) {
    try {
        const datos = await consultarDetalleAsignatura(asignaturaId, numeroDia); // aquí espera que la promesa se resuelva
        
        $('#txtCiclo').val(datos[0]);
        $('#txtParalelo').val(datos[1]);
        $('#txtCarrera').val(datos[2]);
        $('#txtNumeroAsistentes').val(datos[3]);

        var selectHoraInicio = $("#selectHoraInicio");
        selectHoraInicio.empty();
        selectHoraInicio.append('<option value="">' + '-- Seleccione la hora inicio --' + '</option>');
        const horas = datos[4];
        //horaFin = parseInt(datos[4][datos[4].length - 1].substring(1), 10);

        // Llenar un <select>
        horas.forEach(h => {
            const fecha = convertJsonDate(h.dtInicio_horas); // Ej: de H08 a 08:00 si quieres
            const hora = convertirHora(fecha)
            selectHoraInicio.append('<option value="' + hora + '">'+ hora + '</option>');
            horaFinTime = h.strCod_horas;
        });
        
    } catch (error) {
        console.error("Error al obtener asignaturas:", error);
    }
}

function llenarHoraFin(horaInicioTime) {
    var selectHoraFin = $("#selectHoraFin");
    let horaInicio = parseInt(horaInicioTime.replace("H", ""), 10);
    let horaFin = parseInt(horaFinTime.replace("H", ""), 10);
    selectHoraFin.empty();
    selectHoraFin.append('<option value="">' + '-- Seleccione la hora final --' + '</option>');

    console.log('hora inicio: ' + horaInicio + '\nHora fin: ' + horaFin)

    for (let i = horaInicio; i <= horaFin; i++) {
        let hora = horaInicio < 10 ? '0' + i + ':59' : i + ':59';
        selectHoraFin.append('<option value="' + hora + '">' + hora + '</option>');
    }
}

function llenarSelectAsigantura(asignaturas) {
    const selectAsignatura = $("#selectAsignatura");
    var selectHoraInicio = $("#selectHoraInicio");
    var selectHoraFin = $("#selectHoraFin");

    // Vaciar el select antes de llenarlo
    selectAsignatura.empty();
    selectHoraInicio.empty();
    selectHoraFin.empty();

    // Agregar una opción por defecto
    selectAsignatura.append('<option value="">-- Seleccione una opción --</option>');
    selectHoraInicio.append('<option value="">-- Seleccione la hora inicio --</option>');
    selectHoraFin.append('<option value="">-- Seleccione la hora final --</option>');

    // Iterar sobre las opciones y agregarlas al select
    asignaturas.forEach(opcion => {
        selectAsignatura.append(`<option value="${opcion.id}">${opcion.nombre}</option>`);
    });
}