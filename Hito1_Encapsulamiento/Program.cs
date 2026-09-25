using Hito1_Encapsulamiento;

var persona = new Persona("Alejandro Mora", 26);

Console.WriteLine("Nombre: " + persona.Nombre);
Console.WriteLine("Edad: " + persona.Edad);

persona.CumplirAnios();

Console.WriteLine("Edad despues de cumplir años: " + persona.Edad);

Console.WriteLine();

var cuenta = new CuentaBancaria(
    "CTA-001",
    "Alejandro Mora San Juan",
    3000.0m
);

Console.WriteLine("Cuenta bancaria");
Console.WriteLine("Titular: " + cuenta.Titular);
Console.WriteLine("Numero de cuenta: " + cuenta.NumeroCuenta);
Console.WriteLine("Saldo inicial: $" + cuenta.Saldo);

cuenta.Depositar(1000.0m);
Console.WriteLine("Deposito: $1000");

cuenta.Retirar(500.0m);
Console.WriteLine("Retiro: $500");

Console.WriteLine("Saldo actual: $" + cuenta.Saldo);
