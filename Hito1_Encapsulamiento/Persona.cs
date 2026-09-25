namespace Hito1_Encapsulamiento;

public class Persona
{
    private string _nombre = string.Empty;
    private int _edad;

    public string Nombre
    {
        get => _nombre;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacio.");

            _nombre = value.Trim();
        }
    }

    public int Edad
    {
        get => _edad;
        private set
        {
            if (value < 0 || value > 125)
                throw new ArgumentException("La edad debe estar entre 0 y 125 años.");

            _edad = value;
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