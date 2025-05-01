const configuracionCalendario ={
    initialView: 'dayGridMonth',
    locale: 'es',
    headerToolbar: {
        left: 'prev,next',
        center: 'title',
        right: 'dayGridMonth,timeGridWeek,timeGridDay'
    },
    dateClick: function (info) {

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

    },
    selectable: true, // Permite la selección de fechas
    select: function (info) {
    },
    events: function (fetchInfo, successCallback, failureCallback) {

    }
}