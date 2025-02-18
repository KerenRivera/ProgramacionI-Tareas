﻿using System;

Console.WriteLine("Bienvenido a mi lista de Contactos");


//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();


while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption = Convert.ToInt32(Console.ReadLine());

    switch (typeOption)
    {
        case 1:
            {
                //Console.WriteLine("Digite el nombre de la persona");
                //string name = Console.ReadLine();
                //Console.WriteLine("Digite el apellido de la persona");
                //string lastname = Console.ReadLine();
                //Console.WriteLine("Digite la dirección");
                //string address = Console.ReadLine();
                //Console.WriteLine("Digite el telefono de la persona");
                //string phone = Console.ReadLine();
                //Console.WriteLine("Digite el email de la persona");
                //string email = Console.ReadLine();
                //Console.WriteLine("Digite la edad de la persona en números");
                //int age = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
                ////var temp = Convert.ToInt32(Console.ReadLine());
                ////bool isBestFriend;
                ////if (temp == 1)
                ////{ isBestFriend = true; }
                ////else
                ////{ isBestFriend = false; }
                //bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

                //var id = ids.Count + 1;
                //ids.Add(id);
                //names.Add(id, name);
                //lastnames.Add(id, lastname);
                //addresses.Add(id, address);
                //telephones.Add(id, phone);
                //emails.Add(id, email);
                //ages.Add(id, age);
                //bestFriends.Add(id, isBestFriend);

                AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);

            }
            break;
        case 2: //extract this to a method
            {
                //Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                // Console.WriteLine($"____________________________________________________________________________________________________________________________");
                // foreach (var id in ids)
                // 
                // var isBestFriend  = bestFriends[id];

                //string isBestFriendStr;

                //if (isBestFriend == true)
                //{
                //    isBestFriendStr = "Si";
                //}
                //else {
                //    isBestFriendStr = "No";
                //}

                //string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                //Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");

                ShowContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 3: //search
            {
                ShowContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 4: //modify
            {
                ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 5: //delete
            {
                DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 6:
            runing = false;
            break;
        default:
            Console.WriteLine("Tu eres o te haces el idiota?");
            break;
    }
}


static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre de la persona");
    string name = Console.ReadLine();
    Console.WriteLine("Digite el apellido de la persona");
    string lastname = Console.ReadLine();
    Console.WriteLine("Digite la dirección");
    string address = Console.ReadLine();
    Console.WriteLine("Digite el telefono de la persona");
    string phone = Console.ReadLine();
    Console.WriteLine("Digite el email de la persona");
    string email = Console.ReadLine();
    Console.WriteLine("Digite la edad de la persona en números");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No\n");

    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    var id = ids.Count + 1;
    ids.Add(id);
    names.Add(id, name);
    lastnames.Add(id, lastname);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);

    Console.WriteLine("Contacto agregado exitosamente\n"); //mensaje de exito al agregar contacto añadido
}


static void ShowContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
    Console.WriteLine($"____________________________________________________________________________________________________________________________");
    foreach (var id in ids)
    {
        var isBestFriend = bestFriends[id];

        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
        Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
    }
}


static void SearchContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre del contacto: ");
    string nameSearch = Console.ReadLine();

    bool find = false;

    foreach (var id in ids)
    {
        var isBestFriend = bestFriends[id];

        if (names[id].Equals(nameSearch, StringComparison.OrdinalIgnoreCase))
        {
            find = true;
            string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
            Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
        }
    }

    if (!find)
    {
        Console.WriteLine("Contacto no encontrado");
    }
}


static void ModifyContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el ID del contacto que desea modificar:\n");
    int id = Convert.ToInt32(Console.ReadLine());

    if (!ids.Contains(id))
    {
        Console.WriteLine("El contacto no existe.\n");
    }

    Console.WriteLine(@"Seleccione el dato a modificar:
    1. Nombre
    2. Apellido
    3. Dirección
    4. Teléfono
    5. Email
    6. Edad
    7. Mejor amigo (Sí/No)");

    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Nuevo nombre:");
            names[id] = Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("Nuevo apellido:");
            lastnames[id] = Console.ReadLine();
            break;
        case 3:
            Console.WriteLine("Nueva dirección:");
            addresses[id] = Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("Nuevo teléfono:");
            telephones[id] = Console.ReadLine();
            break;
        case 5:
            Console.WriteLine("Nuevo email:");
            emails[id] = Console.ReadLine();
            break;
        case 6:
            Console.WriteLine("Nueva edad:");
            ages[id] = Convert.ToInt32(Console.ReadLine());
            break;
        case 7:
            Console.WriteLine("¿Es mejor amigo? (1. Sí, 2. No):");
            bestFriends[id] = Convert.ToInt32(Console.ReadLine()) == 1;
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    Console.WriteLine("Contacto modificado exitosamente.\n");
}


static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el ID del contacto que desea eliminar:");
    int id = Convert.ToInt32(Console.ReadLine());

    if (!ids.Contains(id))
    {
        Console.WriteLine("El contacto no existe.");
    }

    ids.Remove(id);
    names.Remove(id);
    lastnames.Remove(id);
    addresses.Remove(id);
    telephones.Remove(id);
    emails.Remove(id);
    ages.Remove(id);
    bestFriends.Remove(id);

    Console.WriteLine("Contacto eliminado exitosamente.");
}