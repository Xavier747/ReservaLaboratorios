$(document).ready(function () {
    $("#img1").fileinput({
        showUpload: false,
        showCaption: false,
        browseClass: "btn btn-primary btn-lg",
        browseOnZoneClick: true,
        fileType: "any",
        previewFileType: "image",
        allowedFileExtensions: ["jpg", "jpeg", "png", "gif"],
        maxFileSize: 2048,
        maxFilesNum: 10,
        elErrorContainer: "#errorBlock"
    });

    $("#img2").fileinput({
        showUpload: false,
        showCaption: false,
        browseClass: "btn btn-primary btn-lg",
        browseOnZoneClick: true,
        fileType: "any",
        previewFileType: "image",
        allowedFileExtensions: ["jpg", "jpeg", "png", "gif"],
        maxFileSize: 2048,
        maxFilesNum: 10,
        elErrorContainer: "#errorBlock"
    });

    $("#ImgUpdate1").fileinput({
        showUpload: false,
        showCaption: false,
        browseClass: "btn btn-primary btn-lg",
        fileType: "any",
        previewFileType: "image",
        allowedFileExtensions: ["jpg", "jpeg", "png", "gif"],
        maxFileSize: 2048,
        maxFilesNum: 10,
        elErrorContainer: "#errorBlock",
    });

    $("#ImgUpdate2").fileinput({
        showUpload: false,
        showCaption: false,
        browseClass: "btn btn-primary btn-lg",
        fileType: "any",
        previewFileType: "image",
        allowedFileExtensions: ["jpg", "jpeg", "png", "gif"],
        maxFileSize: 2048,
        maxFilesNum: 10,
        elErrorContainer: "#errorBlock"
    });
});

function showAlertAndReload(title, icon) {
    const Toast = Swal.mixin({
        toast: true,
        position: "top-end",
        showConfirmButton: false,
        timer: 3000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer);
            toast.addEventListener('mouseleave', Swal.resumeTimer);
        }
    });

    Toast.fire({
        icon: icon,
        title: title
    }).then(() => {
        // Recargar la página una vez que el toast desaparezca
        window.location.href = window.location.pathname;
    });
}

