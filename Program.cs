using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEnter
{
    
    public class motobike
    {
/*1.2	Реализовать не менее пяти закрытых полей
(различных типов),представляющих основные
характеристики рассматриваемого класса. */
        private string model;
        private int year;
        private int speed;
        private double fuelTank;
        private double mileage;
        /*1.5	Создать не менее двух статических полей
        (различных типов), представляющих общие характеристики объектов
        данного класса.*/
        public static int mass;
        public static string type;
      
    
        public motobike(string model,int year,int speed,double fuelTank,double mileage) {
            this.model = model;
            this.year=year;
            this.speed=speed;
            this.fuelTank=fuelTank;
            this.mileage=mileage;
    }
        /*1.7	Создать статический конструктор. */
        static motobike(){
            mass = 250;
            type = "Спорт-байк";
            }
/*1.3	Создать не менее трех методов управления классом 
 и методы доступа к его закрытым полям. */
        public void ShowAll()
        {
            Console.Write("Модель - {0},\nГод выпуска- {1},\nСредняя скорость - {2} км/ч.,\nОбъем топливного бака - {3}л.,\nКиллометраж  - {4} км.\n", model, year, speed, fuelTank, mileage);
            Console.WriteLine();
        }
        public double PetrolCons(double fT, double mileage)
        {
            double PetrolCons;
            PetrolCons = (fT / mileage)*100;

            return Math.Round(PetrolCons,2);
        }
        public double SpeedUp(double speed, double time)
        {
            double speedUp = ((speed * 1000) / 3600) / time;
            return Math.Round(speedUp,2);
        }

//1.4 Создать метод, в который передаются аргументы по ссылке.
 public double Braking(ref double speed, ref double asphalt )
        {
            double brakingDistance;
            brakingDistance = 1 * speed * speed / (254 * asphalt);
            return Math.Round(brakingDistance,2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
/*1.8	Создать массив (не менее 5 элементов) объектов  
созданного класса. */
            motobike[] Motos = new motobike[5];
           Motos[0] = new motobike("Harley davidson", 1995, 190, 60, 715.00);
            Motos[1] = new motobike("Ducati Superbike", 2011, 180, 70.2, 615.00);
            Motos[2] = new motobike("Yamaha", 2015, 183, 61.1, 702.02);
            Motos[3] = new motobike("Honda", 2013, 160, 50.2, 599.10);
            Motos[4] = new motobike("Aprilia", 2011, 155, 65.2,500.00);

            for (int i = 0; i < 5; i++)
            { Console.Write(i+1 +")- ");
                Motos[i].ShowAll();
            }
            Console.WriteLine();
            Console.Write("Код товара : ");
            int motcar = Int32.Parse(Console.ReadLine());
            motcar = motcar - 1;
            Console.Write("Вы выбрали ");
            Motos[motcar].ShowAll();
            Console.WriteLine("Расход топлива на 100 км = " + Motos[motcar].PetrolCons(60, 715.0)+"л");
           double speedSr;
            Console.WriteLine("Ускорение = "+Motos[motcar].SpeedUp(100, 9)+"км/ч");
           Console.Write("Введите скорость = ");
            speedSr = Int32.Parse(Console.ReadLine());
            double asphalt;
            Console.Write("Выберите условия дорожного покрытия :\n1- для выбора сухого асфальта;\n2- для выбора мокрого асфальта;\n3- для выбора снежной дороги;\n4- для выбора ледяной дороги\n");
            int choose= Int32.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    asphalt = 0.7;
                        Console.WriteLine("Тормозной путь  = " + Motos[motcar].Braking(ref speedSr,ref asphalt));
                    break;
                case 2:
                    asphalt = 0.4;
                    Console.WriteLine("Тормозной путь  = " + Motos[motcar].Braking(ref speedSr, ref asphalt));
                    break;
                case 3:
                    asphalt = 0.2;
                    Console.WriteLine("Тормозной путь  = " + Motos[motcar].Braking(ref speedSr, ref asphalt));
                    break;
                case 4:
                    asphalt = 0.1;
                    Console.WriteLine("Тормозной путь  = " + Motos[motcar].Braking(ref speedSr, ref asphalt));
                    break;
                default:
                    Console.WriteLine("Не корректные данные");
                    break;


            }
          /*
  

1.6	Обязательным требованием является реализация
нескольких перегруженных конструкторов, 
аргументы которых определяются студентом, 
исходя из специфики реализуемого класса, а так же
реализация конструктора по умолчанию.

1.9	Создать дополнительный метод для данного класса 
в другом файле, используя ключевое слово partial.

Варианты (по выбору):
1.	автомобиль; 
2.	мотоцикл; 
3.	самолет;
4.	бытовая техника (на выбор); 
5.	продукты питания (на выбор); 
6.	канцелярские товары (на выбор); 
7.	мебель (на выбор); 
8.	ракета;
9.	поезд;
10.	зажигалка.

*/
        }
    }
}
