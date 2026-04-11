Algoritmo ejercicio2_Caracter
	Definir caractering Como Caracter
	Escribir "Ingresa un caracter de digito o vocal: "
	Leer caractering
	Segun caractering Hacer
		"0","1","2","3","4","5","6","7","8","9":
			Escribir "Tu caracter es un digito"
		"a", "e", "i", "o", "u":
			Escribir "Tu caracter es una letra"
		De Otro Modo:
			Escribir "Tu caracter no es valido"
	Fin Segun
FinAlgoritmo
