// See https://aka.ms/new-console-template for more information

using CutsomCar;
using CutsomCar.Enums;

var Nissan = new MyCar("GTR35","Nissan",2021,"White",2000,false,false,337);
Nissan.brake = new Brake("Pista", "Brembo", EBrakeMaterial.Carbon, 2000M, EColor.Red);
Nissan.tires = new Tires("Pilot Sport EV", "Michelin", "Nylon, Natural Rubber", 22);
Nissan.engine = new Engine("VR38DETT V6", "Nissan", new DateTime(2021,09,23), 3.8, 473, 6);
Nissan.PrintInfo();
