// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();


int GetCoord(string number)
{
	int result = 0;
	while(true)
	{
		Console.Write(number);

		if(int.TryParse(Console.ReadLine(), out result))
		{
			break;
		}
		else
		{
			Console.WriteLine("Ошибка! Повторите ввод: \n");
		}
	}
	return result;
}

double GetDist(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
	double result = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
	return result;
}

int Ax = GetCoord("Введите координаты точки A по оси x: ");
int Ay = GetCoord("Введите координаты точки A по оси y: ");
int Az = GetCoord("Введите координаты точки A по оси z: ");

int Bx = GetCoord("Введите координаты точки B по оси x: ");
int By = GetCoord("Введите координаты точки B по оси y: ");
int Bz = GetCoord("Введите координаты точки B по оси z: ");

double dist = GetDist(Ax, Ay, Az, Bx, By, Bz);

Console.WriteLine($"Расстояние между точками А и В = {dist}");



// Console.Write("Введите координаты точки A по оси x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки A по оси y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки A по оси z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты точки B по оси x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки B по оси y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки B по оси z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());
