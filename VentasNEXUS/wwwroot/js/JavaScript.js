var carrito = [];

// Evento al hacer clic en el botón "Agregar al Carrito"
document.getElementById("btnAgregarAlCarrito").addEventListener("click", function () {
    var select = document.getElementById("miSpinner");
    var selectedIndex = select.selectedIndex;

    if (selectedIndex !== -1) {
        var selectedOption = select.options[selectedIndex];
        var selectedValue = selectedOption.value;
        var selectedText = selectedOption.text;

        carrito.push({ Id: selectedValue, Nombre: selectedText });

        // Actualizar la lista del carrito
        var ul = document.getElementById("carrito");
        var li = document.createElement("li");
        li.textContent = selectedText;
        ul.appendChild(li);
    }
});