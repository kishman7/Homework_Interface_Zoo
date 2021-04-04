using System;
using System.Collections.Generic;


//Визначити інтерфейси IWalk, IEat, ISleep. Реалізувати ці інтерфейси для класів
//різних тварин зоопарку(Bear, Parrot, ...).
//o Визначити інтерфейс IWatch(спостерігати), який реалізувати для класів VideoCamera
//та класу ZooWorker(працівника зоопарку).
//o Створити клас Zoo, що міститиме масиви( або колекції List<>, ArrayList) тварин,
//робітників, відеокамер.
//Змоделювати роботу зоопарку:
//o Тварини можуть їсти, прогулюватися, тощо.
//o За цим слідкують відеокамери, та можуть слідкувати працівники.
//o Працівники можуть годувати тварин.

namespace Classwork_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear("Bear"); // створюємо екземпляр ведмедя
            bear.Walk();
            bear.Eat();
            bear.Sleep();
            Console.WriteLine();
            Parrot parrot = new Parrot("Parrot"); // створюємо екземпляр папуги
            parrot.Walk();
            parrot.Eat();
            parrot.Sleep();
            Console.WriteLine();
            Wolf wolf = new Wolf("Wolf"); // створюємо екземпляр вовка
            wolf.Walk();
            wolf.Eat();
            wolf.Sleep();
            Console.WriteLine();

            Zoo.animals.Add(bear); // додаємо в список animals екземпляр ведмедів, які є наслідниками абстрактоного класу Animals через клас Zoo
            Zoo.animals.Add(parrot); // додаємо в список animals екземпляр папуг, які є наслідниками абстрактоного класу Animals через клас Zoo
            Zoo.animals.Add(wolf); // додаємо в список animals екземпляр вовків, які є наслідниками абстрактоного класу Animals через клас Zoo

            VideoCamera vc1 = new VideoCamera("VC1", "Wolf"); // створюємо екземпляр відеокамери
            Zoo.videoCameras.Add(vc1); // додаємо екземпляр відеокамери в список
            VideoCamera vc2 = new VideoCamera("VC2", "Bear"); 
            Zoo.videoCameras.Add(vc2);
            VideoCamera vc3 = new VideoCamera("VC3", "Parrot"); 
            Zoo.videoCameras.Add(vc3);
            vc1.Watch(); // камера дивиться за звірями
            vc2.Watch(); // камера дивиться за звірями
            vc3.Watch(); // камера дивиться за звірями
            Console.WriteLine();

            ZooWorker zooWorker1 = new ZooWorker("Tom", bear); // створюємо екземпляр працівника зоопарку, причому bear це екземпляр класу Animals
            Zoo.zooWorkers.Add(zooWorker1); // додаємо екземпляр працівника зоопарку
            zooWorker1.Watch(); // працівник зоопарку дивиться за відповідним звірем
            zooWorker1.Feed(); // працівник зоопарку кормить відповідного звіря
            Console.WriteLine();

            ZooWorker zooWorker2 = new ZooWorker("Bill", parrot);
            Zoo.zooWorkers.Add(zooWorker2);
            zooWorker2.Watch();
            zooWorker2.Feed();
            Console.WriteLine();

            ZooWorker zooWorker3 = new ZooWorker("Jhon", wolf);
            Zoo.zooWorkers.Add(zooWorker3);
            zooWorker3.Watch();
            zooWorker3.Feed();
            Console.WriteLine();
        }
    }
}
