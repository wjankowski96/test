using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium4
{
    class Program
    {

        class Microwave
        {
            int _capasity;
            int _microwavePower;
            bool _grill;
            double _diameterOfTurntable;
            string _colour;
            int _howManyPrograms;
            bool _endWorkSignal;
            string _clock;
            int _guarantee;

            public   Microwave()
            {
                _capasity = 30;
                _microwavePower = 900;
                _grill = true;
                _diameterOfTurntable = 12.5;
                _colour = "black";
                _howManyPrograms = 9;
                _endWorkSignal = true;
                _clock = "12:00";
                _guarantee = 24;
            }

            public Microwave(Microwave previousMicrowave)
            {
                _capasity = previousMicrowave._capasity;
                _microwavePower = previousMicrowave._microwavePower;
                _grill = previousMicrowave._grill;
                _diameterOfTurntable = previousMicrowave._diameterOfTurntable;
                _colour = previousMicrowave._colour;
                _howManyPrograms = previousMicrowave._howManyPrograms;
                _endWorkSignal = previousMicrowave._endWorkSignal;
                _clock = previousMicrowave._clock;
                _guarantee = previousMicrowave._guarantee;
            }

            public Microwave(int mPower, bool grill, int programs, int guarantee)
            {
                _capasity = 23;
                _microwavePower = mPower;
                _grill = grill;
                _diameterOfTurntable = 10.5;
                _colour = "silver";
                _howManyPrograms = programs;
                _endWorkSignal = false;
                _clock = "24:00";
                _guarantee = guarantee;
            }

            public void changeDiameterOfTurntable()
            {
                int size;
                Console.WriteLine("How big you want size of Turntable?");
                
                size = int.Parse(Console.ReadLine());
                _diameterOfTurntable = size;
            }

            public void changeProgram()
            {
                int numberOfProgram;
                Console.WriteLine("You have " + _howManyPrograms + " programs to choose.");
                Console.WriteLine("With program you want to use?");
                numberOfProgram = int.Parse(Console.ReadLine());
            }
        }
        public void state(int _howManyPrograms)
        {
            string program;
            Console.WriteLine("Wanna heat up somethink or grill?");
            program = Console.ReadLine();
            Console.WriteLine("Your actuall program is " + _howManyPrograms + " and you " + program + " somethink");

        }

        class CoffeeMaschine
        {
            double _capisityOfWater;
            string _coulor;
            bool _milkContainer;
            int _pressure;
            int _numberOfPrograms;
            bool _autoClean;
            string _deviceControl;
            int _aromaPowerControl;
            float _temperatureOfBeverage;
            string _typeOfCover;


            public CoffeeMaschine()
            {
            _capisityOfWater=1.3;
            _coulor="silver";
            _milkContainer=true;
            _pressure=12;
            _numberOfPrograms=15;
            _autoClean=true;
            _deviceControl = "Application on mobile device";
            _aromaPowerControl=5;
            _temperatureOfBeverage = 95;
            _typeOfCover="aluminium";
            }

            public CoffeeMaschine(CoffeeMaschine previousCoffeemaschine)
            {
                _capisityOfWater =previousCoffeemaschine._capisityOfWater;
                _coulor = previousCoffeemaschine._coulor;
                _milkContainer = previousCoffeemaschine._milkContainer;
                _pressure = previousCoffeemaschine._pressure;
                _numberOfPrograms = previousCoffeemaschine._numberOfPrograms;
                _autoClean = previousCoffeemaschine._autoClean;
                _deviceControl = previousCoffeemaschine._deviceControl;
                _aromaPowerControl = previousCoffeemaschine._aromaPowerControl;
                _temperatureOfBeverage = previousCoffeemaschine._temperatureOfBeverage;
                _typeOfCover = previousCoffeemaschine._typeOfCover;
            }

            public CoffeeMaschine(double NcapisityOfWater, string Ncoulor, bool NmilkContainer, string NdeviceControl,string NtypeOfCover)
            {
                _capisityOfWater = NcapisityOfWater;
                _coulor = Ncoulor;
                _milkContainer = NmilkContainer;
                _pressure = 12;
                _numberOfPrograms = 15;
                _autoClean = true;
                _deviceControl = NdeviceControl;
                _aromaPowerControl = 5;
                _temperatureOfBeverage = 100;
                _typeOfCover = NtypeOfCover;
            }
            //OBSŁUGA ZDARZEŃ
            public void makeCaffee()
            {
                string typeOfCoffee;
                int intensityOfCaffee;
                int volumeOfMilk;
                Console.WriteLine("What you wanna drink, BLACK or WHITE?");
                typeOfCoffee = Console.ReadLine();
                if (typeOfCoffee=="BLACK")
                {
                    Console.WriteLine("Choose intensity of coffee.");
                    intensityOfCaffee = int.Parse(Console.ReadLine());
                    if (intensityOfCaffee>_aromaPowerControl)
                    {
                        Console.WriteLine("This maschine have only " + _aromaPowerControl + " , automatically choose medium power");
                    }
                    Console.WriteLine("Write temperature od beverage:");
                    _temperatureOfBeverage = int.Parse(Console.ReadLine());
                    fillWaterAfterMakeCoffee();
                    cleenCoffeeMaker();

                }else
                    Console.WriteLine("Choose intensity of coffee.");
                intensityOfCaffee = int.Parse(Console.ReadLine());
                if (intensityOfCaffee > _aromaPowerControl)
                {
                    Console.WriteLine("This maschine have only " + _aromaPowerControl + " , automatically choose medium power");
                }
                Console.WriteLine("Write temperature od beverage:");
                _temperatureOfBeverage = int.Parse(Console.ReadLine());
                if (_milkContainer == true)
                {
                    Console.WriteLine("How many milk you wanna?");
                    volumeOfMilk = int.Parse(Console.ReadLine());
                }
                fillWaterAfterMakeCoffee();
                cleenCoffeeMaker();
            }

            public void fillWaterAfterMakeCoffee()
            {
                _capisityOfWater = _capisityOfWater - 0.3;
                Console.WriteLine("Remeber to fill water container, because there is " + _capisityOfWater + " liter");
            }

            public void cleenCoffeeMaker()
            {
                if (_autoClean == true)
                {
                    Console.WriteLine("The coffee maker cleans itself at this moment");
                }
                else
                    Console.WriteLine("You must cleen coffee maker by yourself");
             
            }
        }


        static void Main(string[] args)
        {
            Microwave micro1 = new Microwave();
            Microwave micro2 = new Microwave(micro1);
            Microwave micro3 =new Microwave(1100, false, 10, 12);
            Console.WriteLine("Microwave change program: ");
            micro1.changeProgram();
            Console.WriteLine("Microwave size of Turntable: ");
            micro1.changeDiameterOfTurntable();

            CoffeeMaschine coffeemaker1 = new CoffeeMaschine();
            CoffeeMaschine coffeemaker2 = new CoffeeMaschine(coffeemaker1);
            CoffeeMaschine coffeemaker3 = new CoffeeMaschine(1.6,"black",false,"LCD screen", "plastic");

            Console.WriteLine("Make Coffee:");
            coffeemaker1.makeCaffee();
            Console.ReadKey();
        }
    }
}
