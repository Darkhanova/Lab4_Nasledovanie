using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Nasledovanie
{
    public class Pets
    {
        public double weight;
        public virtual String GetInfo()
        { 
            return "";
        }
    }

    public class Cow : Pets
    {
        public int horn = 0;
        public int milk = 0;
        public override String GetInfo()
        {
            var rnd = new Random();
            weight = 600 - rnd.Next() % 401; //Ср. вес коровы 200-600кг
            var str = "Корова";
            str += String.Format("\nВес: {0}", weight + "кг.");
            str += String.Format("\nДлина Рогов: {0}", this.horn + " см.");
            str += String.Format("\nМолока/сутки: {0}", this.milk + " л.");
            return str;
        }
    }

    public enum DogType {Бульдог, Борзая, Хаски, Волкодав, Лабрадор, НемОвчарка};
    public class Dog : Pets
    {
        public int lengthtail = 0;
        public int lengthcommands = 0;
        public DogType type = DogType.Хаски;
        public override String GetInfo()
        {
            var rnd = new Random();
            weight = 40 - rnd.Next() % 16;//25-40kg
            var str = "Собака";
            str += String.Format("\nВес: {0}", weight + "кг.");
            str += String.Format("\nДлина хвоста: {0}", this.lengthtail + " см.");
            str += String.Format("\nДлина игнора команд: {0}", this.lengthcommands + " cм.");
            str += String.Format("\nПорода: {0}", this.type);
            return str;
        }
    }

    public class Cat : Pets
    {
        public bool fur = false;
        public int killsmouse = 0;
        public override String GetInfo()
        {
            var rnd = new Random();
            weight = 45 - rnd.Next() % 10;//3.6-4.5kg
            weight = weight / 10;//Получение дроби
            var str = "Кошка";
            str += String.Format("\nВес: {0}", weight + "кг.");
            if (fur == false)
                str += String.Format("\nШерсть: Нет");
            if (fur == true)
                str += String.Format("\nШерсть: Есть");
            str += String.Format("\nУлов мышей: {0}", this.killsmouse + " шт.");

            return str;
        }
    }
}
