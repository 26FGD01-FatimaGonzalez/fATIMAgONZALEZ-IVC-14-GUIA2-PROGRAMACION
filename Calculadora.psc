Algoritmo Calculadora
	Definir num1, num2, opc Como Entero
	Escribir "========CALCULADORA========"
	Escribir "1- SUMA"
	Escribir "2 RESTA"
	Escribir "3- MULTIPLICACION"
	Escribir "4- DIVISION"
	Escribir "DIGITE LA OPCIÓN [] :"
	Leer opc
	Escribir "Digite dos valores numericos: "
	Leer num1
	Leer num2
	Segun opc Hacer
		1:
			Escribir "La suma es: ", (num1+num2)
		2:
			Escribir "La suma es: ", (num1-num2)
		3:
			Escribir "La suma es: ", (num1*num2)
		4:
			Escribir "La suma es: ", (num1/num2)
		De Otro Modo:
			Escribir "ERROR AL OPERAR"
	Fin Segun
	
FinAlgoritmo
