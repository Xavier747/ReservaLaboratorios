function toggleSubmenu(submenuId) {
    var submenu = document.getElementById(submenuId);
    var toggleIcon = submenu.previousElementSibling.querySelector('.toggle-icon');
    if (submenu.style.display === "block") {
        submenu.style.display = "none";
        toggleIcon.innerHTML = '<i class="bi bi-plus-lg"></i>';
    } else {
        submenu.style.display = "block";
        toggleIcon.innerHTML = '<i class="bi bi-dash-lg"></i>';
    }
}

function cerrar() {
    window.location.href = window.location.pathname;
}