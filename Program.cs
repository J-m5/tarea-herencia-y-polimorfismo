
using p1bpoo.MisClases;

Console.WriteLine("Carro Electrico:");
CarroElectrico mitesla = new CarroElectrico(2023, "AlfA MEGA", "Corinto");
mitesla.InformacionVehiculo();
mitesla.acelerar(10);
mitesla.Frenar(5);
Console.WriteLine("Carga de la bateria es:" + mitesla.NivelBateria());

Console.WriteLine("Auto De Combustion:");
AutoDeCombustion minissan = new AutoDeCombustion(2010, "Frontier", "verde");
minissan.InformacionVehiculo();
minissan.verEspejos();
minissan.acelerar(10);
minissan.encender();
minissan.Frenar(5);
minissan.verLiquidoDeFrenos();
minissan.cargarAceite();
Console.WriteLine("Nivel de aceite: " + minissan.verNivelDeAceite());

Console.WriteLine("Motocicleta:");
Motocicleta mihonda = new Motocicleta(2020, "CBR", "azul");
mihonda.InformacionVehiculo();
mihonda.vertipoDeFreno();
mihonda.acelerar(30);
mihonda.Frenar(20);
mihonda .encender();
Console.WriteLine("El encendido es: " + mihonda.verencendido());


Console.WriteLine("Camion:");
Camion micamionnani = new Camion(2024, "Mercedes-Benz", "blanco");
micamionnani.InformacionVehiculo();
micamionnani.encender();
micamionnani.acelerar(20);
micamionnani.Frenar(10);
micamionnani.tipovehiculo();
micamionnani.verAsientos();
micamionnani.descargar();
micamionnani.cargar(20);
micamionnani.verNumeroLlantas();
Console.WriteLine("la capacidad de carga es: " + micamionnani.verCapacidadCarga());