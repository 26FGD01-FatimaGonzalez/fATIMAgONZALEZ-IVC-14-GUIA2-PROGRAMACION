Algoritmo Conversor_medidas_eje2
    Definir M, resultado Como Real
    Definir opcion Como Caracter
	
    Escribir "Ingrese la cantidad en metros:"
    Leer M
	
    Escribir "Seleccione la unidad a la que desea convertir:"
    Escribir "a) Pies"
    Escribir "b) Centímetros"
    Escribir "c) Pulgadas"
    Leer opcion
	
    Segun opcion Hacer
        "a", "A":
            resultado <- M * 3.28084
            Escribir M, " metros son ", resultado, " pies."
        "b", "B":
            resultado <- M * 100
            Escribir metros, " metros son ", resultado, " centímetros."
        "c", "C":
            resultado <- M * 39.3701
            Escribir M, " metros son ", resultado, " pulgadas."
        De Otro Modo:
            Escribir "Opción NO válida."
    Fin Segun
FinAlgoritmo
