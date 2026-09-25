using System;
using System.Collections.Generic;
using Hito2_HerenciaPolimorfismo;

Console.WriteLine("=================================================");
Console.WriteLine("   PROGRAMACION ORIENTADA A OBJETOS (AED-1286)   ");
Console.WriteLine("   HITO 2: HERENCIA, ABS Y INTERFACES           ");
Console.WriteLine("   Alumno: Alejandro Mora San Juan               ");
Console.WriteLine("   ID: 23531081                                  ");
Console.WriteLine("=================================================\n");

int fallos = 0;

// Test 1: Instanciacion y calculos de clases derivadas
try
{
    FiguraGeometrica c = new Circulo("Circulo Rojo", 5.0);
    FiguraGeometrica r = new Rectangulo("Rectangulo Azul", 4.0, 6.0);

    double areaEsperadaC = Math.PI * 25.0;
    if (Math.Abs(c.CalcularArea() - areaEsperadaC) > 0.001)
        throw new Exception("Calculo incorrecto en area de Circulo.");

    if (Math.Abs(r.CalcularArea() - 24.0) > 0.001)
        throw new Exception("Calculo incorrecto en area de Rectangulo.");

    Console.WriteLine("Test 1: OK - Areas correctas.");
}
catch (Exception ex)
{
    Console.WriteLine($"Test 1 Fallo: {ex.Message}");
    fallos++;
}

// Test 2: Invariantes en clases derivadas
try
{
    new Circulo("Circulo Invalido", -2.0);
    Console.WriteLine("Test 2 Fallo: Permitio crear Circulo con radio negativo.");
    fallos++;
}
catch (ArgumentException)
{
    Console.WriteLine("Test 2: OK - Validacion de radio correcto.");
}

// Test 3: Polimorfismo en coleccion heterogenea
try
{
    var figuras = new List<FiguraGeometrica>
    {
        new Circulo("C1", 2.0),
        new Rectangulo("R1", 3.0, 5.0),
        new Circulo("C2", 3.0)
    };

    double sumaAreas = 0;
    foreach (var fig in figuras)
    {
        sumaAreas += fig.CalcularArea();
    }

    if (sumaAreas <= 0)
        throw new Exception("Error al procesar coleccion polimorfica.");
    Console.WriteLine("Test 3: OK - Polimorfismo en lista funcionando.");
}
catch (Exception ex)
{
    Console.WriteLine($"Test 3 Fallo: {ex.Message}");
    fallos++;
}

// Test 4: Implementacion de interfaz IDibujable
try
{
    IDibujable dibujable = new Rectangulo("R2", 2.0, 2.0);
    string representacion = dibujable.Dibujar();
    if (string.IsNullOrWhiteSpace(representacion))
        throw new Exception("El metodo Dibujar() no devolvio representacion valida.");
    Console.WriteLine("Test 4: OK - Interfaz IDibujable correcta.");
}
catch (Exception ex)
{
    Console.WriteLine($"Test 4 Fallo: {ex.Message}");
    fallos++;
}

Console.WriteLine($"\nResultado: {4 - fallos}/4 pruebas pasadas.");
if (fallos == 0)
{
    Console.WriteLine("Hito 2 completado exitosamente.");
}

// Impresion de figuras solicitada
Console.WriteLine("\n-------------------------------------------------");
Console.WriteLine("             DIBUJO DE FIGURAS                   ");
Console.WriteLine("-------------------------------------------------");

List<FiguraGeometrica> listaFiguras = new List<FiguraGeometrica>
{
    new Circulo("Circulo Grafico", 5.0),
    new Rectangulo("Rectangulo Grafico", 4.0, 6.0)
};

foreach (var f in listaFiguras)
{
    Console.WriteLine($"\nFigura: {f.Nombre} | Area: {f.CalcularArea():F2}");
    if (f is IDibujable d)
    {
        Console.WriteLine(d.Dibujar());
    }
}
Console.WriteLine("\n-------------------------------------------------");
