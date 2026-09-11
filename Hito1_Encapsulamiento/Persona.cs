namespace Hito1_Encapsulamiento;

public class Persona
{
    private string nombre;
    private int edad;

    public string Nombre
    {
        get => nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacio.");

            nombre = value;
        }
    }

    public int Edad
    {
        get => edad;
        private set
        {
            if (value < 0)
                throw new ArgumentException("La edad no puede ser negativa.");

            edad = value;
        }
    }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void CumplirAnios()
    {
        Edad++;
    }
}
