Algoritmo EstadioGuamuch
	Definir sector, cantidad Como Entero
	Definir precio, total Como Real
	Escribir "--- SECTORES ESTADIO DOROTEO GUAMUCH FLORES ---"
	Escribir "1. Palco (Q300.00)"
	Escribir "2. Tribuna (Q125.00)"
	Escribir "3. Preferencia (Q75.00)"
	Escribir "4. Generales (Q50.00)"
	Escribir "Seleccione el sector (1-4): "
	Leer sector
	Escribir "Ingrese la cantidad de entradas:"
	Leer cantidad
	
	Segun sector Hacer
		1:
			precio <- 300.00
		2:
			precio <- 125.00
		3:
			precio <- 75.00
		4:
			precio <- 50.00
		De Otro Modo:
			precio <- 0
			Escribir "Sector no válido."
	Fin Segun
	
	Si precio > 0 Entonces
		total <- precio * cantidad
		Escribir "El total a pagar por ", cantidad, " entradas es: Q", total
	Fin Si
	
FinAlgoritmo
