Algoritmo VentaImpresoras
    Definir cantidad Como Entero
    Definir formaPago Como Entero
    Definir precioSinIva, precioConIva, totalSinDesc, descuento, totalPagar Como Real
    Definir nombrePago Como Cadena
	
    precioSinIva <- 650.00
    precioConIva <- precioSinIva * 1.12 // IVA del 12%
	
    Escribir "Cantidad de impresoras a comprar:"
    Leer cantidad
	
    Escribir "Seleccione forma de pago:"
    Escribir "1. Efectivo (10%)"
    Escribir "2. Tarjeta de Crédito (5%)"
    Escribir "3. Vale de Regalo (15%)"
    Leer formaPago
	
    totalSinDesc <- cantidad * precioConIva
	
    Segun formaPago Hacer
        1:
            descuento <- totalSinDesc * 0.10
            nombrePago <- "Efectivo"
        2:
            descuento <- totalSinDesc * 0.05
            nombrePago <- "Tarjeta de Crédito"
        3:
            descuento <- totalSinDesc * 0.15
            nombrePago <- "Vale de Regalo"
        De Otro Modo:
            descuento <- 0
            nombrePago <- "No definido (Sin descuento)"
    Fin Segun
	
    totalPagar <- totalSinDesc - descuento
	
    Escribir "--- DETALLE DE PAGO ---"
    Escribir "Cantidad: ", cantidad
    Escribir "Precio Unitario (con IVA): Q", precioConIva
    Escribir "Total sin descuento: Q", totalSinDesc
    Escribir "Forma de pago: ", nombrePago
    Escribir "Descuento realizado: Q", descuento
    Escribir "Total a pagar: Q", totalPagar
FinAlgoritmo
