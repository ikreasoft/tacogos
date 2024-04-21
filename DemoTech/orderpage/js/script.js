document.addEventListener('DOMContentLoaded', function() {
    // Asociar evento click al botón mostrarConfirmacion
    document.getElementById('mostrarConfirmacion').addEventListener('click', function() {
        mostrarPantallaConfirmacion();
    });

    // Asociar evento click al botón cancelarPedido
    document.getElementById('cancelarPedido').addEventListener('click', function() {
        ocultarPantallaConfirmacion();
    });

    // Asociar evento click al botón confirmarPedido
    document.getElementById('confirmarPedido').addEventListener('click', function() {
        enviarPedido();
        document.getElementById('pedidoForm').submit();
    });

    // Lógica para validar la cantidad ingresada
    function validarCantidad() {
        // Obtener el valor del campo de cantidad del formulario
        const cantidad = document.getElementById('cantidad').value;

        // Convertir la cantidad a un número entero
        const cantidadEntera = parseInt(cantidad);

        // Verificar si la cantidad es negativa
        if (cantidadEntera < 0) {
            // Mostrar un mensaje de error al usuario
            alert('La cantidad no puede ser negativa. Por favor, ingrese un valor válido.');
            // Detener el envío del formulario
            return false;
        }

        // Si la cantidad es válida, continuar con el envío del formulario
        return true;
    }

    // Función para enviar el pedido
    function enviarPedido() {
        const formulario = document.getElementById('pedidoForm');
        const inputsCantidad = formulario.querySelectorAll('input[type="number"]');
        const datosPedido = {};
        
        inputsCantidad.forEach(input => {
            const nombreProducto = input.name;
            const cantidad = parseInt(input.value);
            if (cantidad > 0) {
                datosPedido[nombreProducto] = cantidad;
            }
        });

        // Convertir el objeto de datos a JSON y agregarlo como un campo oculto en el formulario
        const datosJSON = JSON.stringify(datosPedido);
        const campoDatosPedido = document.createElement('input');
        campoDatosPedido.type = 'hidden';
        campoDatosPedido.name = 'datosPedido';
        campoDatosPedido.value = datosJSON;
        formulario.appendChild(campoDatosPedido);
    }

    // Función para mostrar la pantalla de confirmación
    function mostrarPantallaConfirmacion() {
        // Generar un ID numérico único para el mensaje
        const mensajeId = Math.floor(Math.random() * 1000000) + 1;

        // Establecer el ID numérico en el campo oculto
        document.getElementById('mensajeId').value = mensajeId;

        // Obtener los valores del formulario
        const nombre = document.querySelector('input[name="nombre"]').value;
        const email = document.querySelector('input[name="email"]').value;
        const cantidadManzanas = document.querySelector('input[name="cantidadManzanas"]').value;
        const cantidadNaranjas = document.querySelector('input[name="cantidadNaranjas"]').value
        const cantidadLeche = document.querySelector('input[name="cantidadLeche"]').value;
        
        // Construir el resumen del pedido
        const resumenPedidoHTML = `
            <h2>Resumen del pedido</h2>
            <hr>        
            <p>Hola ${nombre}, por favor, confirma los datos del pedido</p>
            <br>
            <p>Email: ${email}</p>
            <p>Cantidad de manzanas: ${cantidadManzanas}</p>
            <p>Cantidad de laranjas: ${cantidadNaranjas}</p>
            <p>Cantidad de leche: ${cantidadLeche}</p>
            <br>
            <p>ID del pedido: ${mensajeId}</p>
            <p> Si estos datos son correctos, haz clic en "Confirmar pedido" y lo enviamos a cocina.</p>
            <p> Si hay algún error, puedes corregirlo antes de confirmar el pedido.</p>
            <p> Gracias!</p>
            <br>
        `;

        // Insertar el resumen del pedido en el elemento HTML
        document.getElementById('resumenPedido').innerHTML = resumenPedidoHTML;

        // Mostrar la pantalla de confirmación
        document.getElementById('pantallaConfirmacion').style.display = 'block';
    }

    // Función para ocultar la pantalla de confirmación
    function ocultarPantallaConfirmacion() {
        // Ocultar la pantalla de confirmación
        document.getElementById('pantallaConfirmacion').style.display = 'none';
    }
});
