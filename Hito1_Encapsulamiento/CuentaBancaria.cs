namespace Hito1_Encapsulamiento;

public class CuentaBancaria
{
    public string NumeroCuenta { get; }
    public string Titular { get; }
    public decimal Saldo { get; private set; }

    public CuentaBancaria(string numeroCuenta, string titular, decimal saldoInicial)
    {
        if (string.IsNullOrWhiteSpace(numeroCuenta))
            throw new ArgumentException("El número de cuenta no puede estar vacío.");

        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("El titular no puede estar vacío.");

        if (saldoInicial < 0)
            throw new ArgumentException("El saldo inicial no puede ser negativo.");

        NumeroCuenta = numeroCuenta;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public CuentaBancaria(string numeroCuenta, string titular)
        : this(numeroCuenta, titular, 0.0m)
    {
    }

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
            throw new ArgumentException("El monto debe ser mayor que cero.");

        Saldo += monto;
    }

    public void Retirar(decimal monto)
    {
        if (monto <= 0)
            throw new ArgumentException("El monto debe ser mayor que cero.");

        if (monto > Saldo)
            throw new InvalidOperationException("No hay saldo suficiente.");

        Saldo -= monto;
    }
}