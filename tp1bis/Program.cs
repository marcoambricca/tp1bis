using System.Collections.Generic;

int menu = 1;

Dictionary<string, double> dicCursos = new Dictionary<string, double>();
while (menu >=1 && menu <= 2){
    Console.WriteLine("1 | Ingrese los importes de un curso \n2 | Ver estadisticas");
    int.TryParse(Console.ReadLine(), out menu);
    if (menu == 1){
        totalXCurso(ref dicCursos);
    }
    else if (menu == 2){
        Estadisticas(dicCursos);
    }
}

void totalXCurso(ref Dictionary<string, double> dic){
    Console.WriteLine("Ingrese cantidad de estudiantes: ");
    int cant;
    int.TryParse(Console.ReadLine(), out cant);
    Console.WriteLine("Ingrese nombre de curso: ");
    string nombre = Console.ReadLine();
    double total = 0;
    double ingreso = 0;
    
    for (int i = 0; i < cant; i++){
        Console.WriteLine("Ingrese una cantidad de plata para regalar: ");
        double.TryParse(Console.ReadLine(), out ingreso);
        total+=ingreso;
    }
    dic.Add(nombre, total);
}

void Estadisticas(Dictionary<string, double>dicCursos){
    double total = 0;
    foreach (double cant in dicCursos.Values){
        total += cant;
    }
    double promedio = total / dicCursos.Count;

    double max = 0;
    foreach (double cant in dicCursos.Values){
        if (cant > max) max = cant;
    }

    Console.WriteLine(max);
    Console.WriteLine(promedio);
    Console.WriteLine(total);
    Console.WriteLine(dicCursos.Count);
}