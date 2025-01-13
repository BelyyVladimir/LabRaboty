using System;

namespace Lab12
{
    class Train
    {
        public string Destination { get; set; }
        public int TrainNumber { get; set; }
        public string DepartureTime { get; set; }

        public Train(string destination, int trainNumber, string departureTime)
        {
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Пункт назначения: {Destination}; Номер поезда: {TrainNumber}; Время отправления: {DepartureTime}");
        }
    }

    class Station
    {
        public string StationName { get; set; }
        public Train[] Trains { get; set; }

        public Station(string stationName, Train[] trains)
        {
            StationName = stationName;
            Trains = trains;
        }

        public Station(string stationName)
        {
            StationName = stationName;
        }
    }

    class Program
    {
        static void WaitForContinue()
        {
            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main()
        {
            bool shouldExit = false;
            Train[] trains = new Train[1];
            bool isEmpty = true;

            while (!shouldExit)
            {
                Console.WriteLine("Выберите одну из опций:");
                Console.WriteLine("\t1. Заполнить базу данных поездов");
                Console.WriteLine("\t2. Вывести все поезда, отправляющиеся после указанного времени");
                Console.WriteLine("\t3. Выход");

                int userChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (userChoice)
                {
                    case 1:
                        if (!isEmpty)
                        {
                            Console.WriteLine("База данных уже заполнена");
                            WaitForContinue();
                            break;
                        }

                        Console.WriteLine("Введите количество поездов:");
                        trains = new Train[Convert.ToInt32(Console.ReadLine())];

                        Console.WriteLine("Введите пункт назначения, номер и время отправления поезда через \"/\"");
                        for (int i = 0; i < trains.Length; i++)
                        {
                            string[] input = Console.ReadLine().Split('/');
                            trains[i] = new Train(input[0], int.Parse(input[1]), input[2]);
                        }

                        isEmpty = false;
                        WaitForContinue();
                        break;

                    case 2:
                        if (isEmpty)
                        {
                            Console.WriteLine("База данных поездов пуста");
                            WaitForContinue();
                            break;
                        }

                        Console.WriteLine("Введите время в формате чч:мм");
                        string timeInput = Console.ReadLine();
                        int minutesSinceMidnight = int.Parse(timeInput.Split(':')[0]) * 60 + int.Parse(timeInput.Split(':')[1]);

                        Train[] departuresAfterTime = new Train[trains.Length];
                        for (int i = 0; i < trains.Length; i++)
                        {
                            int trainMinutesSinceMidnight = int.Parse(trains[i].DepartureTime.Split(':')[0]) * 60 + int.Parse(trains[i].DepartureTime.Split(':')[1]);
                            if (trainMinutesSinceMidnight > minutesSinceMidnight)
                            {
                                departuresAfterTime[i] = trains[i];
                            }
                        }

                        if (departuresAfterTime[0] != null)
                        {
                            Console.WriteLine("Поезда, отправляющиеся после указанного времени:");
                            foreach (var train in departuresAfterTime)
                            {
                                if (train != null)
                                    train.DisplayInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет поездов, отправляющихся после указанного времени.");
                        }

                        WaitForContinue();
                        break;

                    case 3:
                        shouldExit = true;
                        break;
                }
            }
        }
    }
}
