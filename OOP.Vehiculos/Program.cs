
using Logica.Program;

try
{
    var Carro1 = new Vehiculo()
    {
        Marca = "Kia", //Validado para marca como: Chevrolet.
        Modelo = "Sedan", //Validado para modelos como: Sail, Sedan y Aveo.
        _anio = new Date(2015, 01, 01) //Validado para carros del año desde el 2015 en adelante.
    };

    Console.WriteLine(Carro1);
}
catch (Exception ex)
{

    Console.WriteLine($"Existio un error: {ex.Message}");
}

