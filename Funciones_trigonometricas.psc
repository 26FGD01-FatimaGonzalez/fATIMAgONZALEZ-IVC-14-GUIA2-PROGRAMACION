Algoritmo Funciones_trigonometricas
	Definir opcion1 Como Entero
	Definir anguloGrados, anguloRadianes Como Real
	Escribir "==========CALCULADORA DE FUNCIONES TRIGONOMETRICAS BASICAS=========="
	Escribir "********************************************************************"
	Escribir "===LISTA DE FUNCIONES==="
	Escribir "1-Seno"
	Escribir "2-Coseno"
	Escribir "3-Tangente"
	Escribir "********************************************************************"
	Escribir"Ingrese el ángulo (en grados): "
	Leer anguloGrados 
	anguloRadianes <- anguloGrados * (PI / 180)
	Escribir "Selecciona la opcion que deseas: "
	Leer opcion1
	Segun opcion1 Hacer
		1:
			Escribir "El seno de tu angulo es: ", sen(anguloRadianes) 
		2:
			Escribir "El coseno de tu angulo es: ", cos(anguloRadianes) 
		3:
			Escribir "La tangente de tu angulo es: ", tan(anguloRadianes)
		De Otro Modo:
			Escribir "Error matematico!!"
	Fin Segun
FinAlgoritmo
