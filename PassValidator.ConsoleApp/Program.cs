using System;
using PassValidator.Core;

// Instanciamos el servicio que desarrollamos con TDD
var validator = new PassValidatorService();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("========================================");
Console.WriteLine("   BIENVENIDO AL VALIDADOR DE CONTRASEÑAS");
Console.WriteLine("========================================");
Console.ResetColor();

Console.Write("\nIntroduce una contraseña para evaluar: ");
string? input = Console.ReadLine();

// Ejecutamos la validación
bool isValid = validator.Validate(input ?? string.Empty);

Console.WriteLine();

if (isValid)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("¡Felicidades! La contraseña cumple con todas las políticas de seguridad.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: La contraseña NO cumple con los requisitos mínimos:");
    Console.WriteLine("- Mínimo 8 caracteres.");
    Console.WriteLine("- Al menos un número.");
    Console.WriteLine("- Al menos un carácter especial (!, @, #, $, etc.).");
}

Console.ResetColor();
Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();
