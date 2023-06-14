// See https://aka.ms/new-console-template for more information

using Constructors;
using Constructors.Enums;

var samsung = new MobilePhone("Samsung",
    "Galaxy A52",
    6.5,178,
    true,true,
    256,8,
    Ecolor.Black);
    samsung.Os = new OS("Google","Android",new DateTime(2021,09,08));
    samsung.Cpu = new CPU(new DateOnly(2021,09,08),
        "Snapdragon 720G",
        "Quallcom",6,3.4);
    samsung.Gpu= new GPU("Quallcom","Adreno 618",2.1,3);
    samsung.Screen = new Screen("Samsung",
        "Super AMOLED",
        90,EScreen.MATRIX,
        "Corning Gorilla Glass 5");
        samsung.PrintInfo();