// See https://aka.ms/new-console-template for more information
//Pregunta 2:
Console.WriteLine("********** PROBLEMA 2 **********");

int auto = 0, contador = 0, cv = 0, ca = 0, cr = 0;
string color = "", nauto = "";

Console.Write("Ingrese el último dígito de la placa (0-9): ");
auto = int.Parse(Console.ReadLine());

while (nauto != "F")
{
    Console.Write("Ingrese el último dígito de la placa (0-9): ");
    auto = int.Parse(Console.ReadLine());

    if (auto >= 0 && auto <= 3)
    {
        color = "Verde";
        cv++;
    }
    else if (auto >= 4 && auto <= 6)
    {
        color = "Azul";
        ca++;
    }
    else if (auto >= 7 && auto <= 9)
    {
        color = "Rojo";
        cr++;
    }
    else
        color = "Error";

    Console.Write("Calcomania de color: " + color);
    Console.WriteLine(" ");
}

Console.WriteLine(" ");
Console.WriteLine("Cantidad de autos verdes: " + cv);
Console.WriteLine("Cantidad de autos azules: " + ca);
Console.WriteLine("Cantidad de autos rojos: " + cr);

