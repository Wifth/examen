// See https://aka.ms/new-console-template for more information

//Pregunta 1:

using System.Collections;
using System.Security.Claims;

double st = 0, e = 0, d = 0, v = 0, a = 0, s, sn;
string n;

Console.Write("Ingrese su nombre: ");
n = Console.ReadLine();
Console.Write("Ingrese su sueldo mensual: ");
s = double.Parse(Console.ReadLine());
Console.Write("Ingrese su cantidad de ventas: ");
v = double.Parse(Console.ReadLine());
Console.Write("Ingrese sus años en la empresa: ");
a = double.Parse(Console.ReadLine());

if (v <= 600 && v >= 0)
    e = v * 0.05;
else if (v > 600 && v <= 3000)
    e = v * 0.07;
else if (v > 3000)
    e = (v * 0.06) + 300;

st = e + s;

if (a <= 3 && a >= 0)
    d = st * 0.065;
else if (a >= 4)
    d = st * 0.045;

sn = st - d;

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Nombre: " + n);
Console.WriteLine("Ganado: S/" + e);
Console.WriteLine("Descontado: S/" + d);
Console.WriteLine("Salario total: S/" + sn);

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
;

//Pregunta 2:
Console.WriteLine("********** PROBLEMA 2 **********");

int auto = 0, contador = 0, cv = 0, ca = 0, cr = 0;
string color = "", f;

while (auto >= 0)
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