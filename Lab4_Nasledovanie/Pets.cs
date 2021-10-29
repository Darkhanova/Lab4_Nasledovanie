using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Nasledovanie
{
    public class Pets
    {
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
            var str = "Корова";
            str += String.Format("\nДлина Рогов: {0}", this.horn + " см.");
            str += String.Format("\nМолока/сутки: {0}", this.milk + " л.");
            return str;
        }
    }

    public enum DogType {Бульдог, ЧихуаХуа, Хаски, Волкодав, Лабрадор, НемОвчарка};
    public class Dog : Pets
    {
        public int lengthtail = 0;
        public int lengthcommands = 0;
        public DogType type = DogType.Хаски;
        public override String GetInfo()
        {
            var str = "Собака";
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
            var str = "Кошка";
            if(fur == false)
                str += String.Format("\nШерсть: Нет");
            if (fur == true)
                str += String.Format("\nШерсть: Есть");
            str += String.Format("\nУлов мышей: {0}", this.killsmouse + " шт.");

            return str;
        }
    }



}
