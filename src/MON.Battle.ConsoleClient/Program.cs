using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MON.Battle.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // CommandTest();

            DelegateTest();

        }

        private static void DelegateTest()
        {
            Tank tank = new Tank();
            tank.Speed = 50;

            tank.PushFire();

            tank.Fire = LaserFire;
            tank.Fire += MissileFire;
            tank.PushFire();

            if (tank.Speed > 100)
            {
                tank.Fire = LaserFire;
            }
            else
            {
                tank.Fire = MissileFire;
            }

            tank.PushFire();
        }

        private static void LaserFire(int direction)
        {
            Console.WriteLine($"Laser fire {direction}");
        }

        private static void MissileFire(int direction)
        {
            Console.WriteLine($"Missile fire {direction}");
        }

        private static void RocketFire(int direction, int speed)
        {
            Console.WriteLine($"Rocket fire {direction}");
        }


        private static void CommandTest()
        {
            Tank tank = new Tank();
            tank.Speed = 50;

            ICommand command1 = new FireCommand(45, tank.Speed);

            Queue<ICommand> commands = new Queue<ICommand>();
            commands.Enqueue(command1);
            commands.Enqueue(command1);
            commands.Enqueue(command1);

            while (commands.Count > 0)
            {
                ICommand command = commands.Dequeue();

                if (command.CanExecute())
                    command.Execute();

            }
        }
    }

    class Tank
    {
        public byte Speed { get; set; }
        private bool isEngine;
        private bool hasPower;

        //public void Fire(int direction)
        //{
        //    Console.WriteLine($"Fire {direction}");
        //}

        //public delegate void FireDelegate(int direction);
        //public FireDelegate Fire;

        public Action<int> Fire;

        public void PushFire()
        {
            //if (Fire != null)
            //    Fire.Invoke(45);

            if (CanFire == null || CanFire.Invoke(45))
                Fire?.Invoke(45);
        }

        //public bool CanFire(int direction)
        //{
        //    return Speed < 100;
        //}

        //public delegate bool CanFireDelegate(int direction);
        //public CanFireDelegate CanFire;

        public Func<int, bool> CanFire;

    }

    interface ICommand
    {
        void Execute();
        bool CanExecute();
    }

    class FireCommand : ICommand
    {
        private readonly int direction;
        private readonly byte speed;

        public FireCommand(int direction, byte speed)
        {
            this.direction = direction;
            this.speed = speed;
        }

        public void Execute()
        {
            Console.WriteLine($"Fire {direction}");
        }

        public bool CanExecute()
        {
            return speed < 100;
        }
    }
}
