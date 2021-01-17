﻿using System;

namespace classDemo
{
    public class Car
    {
        private string color;

        public Car()
        {
            color = "검은";
            Console.WriteLine("{0}색 자동차를 조립합니다.", color);
        }
        public Car(string color)
        {
            this.color = color;
            Console.WriteLine("{0}색 자동차를 조립합니다.", color);
        }

        public void Go() => Console.WriteLine("{0}색 자동차가 달립니다.", this.color);
        ~Car() => Console.WriteLine("{0}색 자동차를 폐차합니다.", this.color);
    }
    class ConstructorMethodDestructor
    {
        static void Main()
        {
            Car car = new Car();
            car.Go();

            Car whiteCar = new Car("하얀");
            whiteCar.Go();

            Car blueCar = new Car("파란");
            blueCar.Go();
        }
    }
}
