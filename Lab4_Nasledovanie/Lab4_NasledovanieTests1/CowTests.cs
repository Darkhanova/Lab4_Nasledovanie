using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4_Nasledovanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Nasledovanie.Tests
{
    [TestClass()]
    public class CowTests
    {
        [TestMethod()]
        public void GetInfoTest()
        {
            
            Cow cow = new Cow();
            cow.horn = 5;
            cow.milk = 6;
            cow.weight = 566;



            Assert.AreEqual("Корова\nВес: 566кг.\nДлина Рогов: 5 см.\nМолока/сутки: 6 л.", cow.GetInfo());
        }
    }

    [TestClass()]
    public class DogTests
    {
        [TestMethod()]
        public void GetInfoTest()
        {

            Dog dog = new Dog();
            dog.weight = 56;
            dog.type = DogType.Хаски;
            dog.lengthtail = 15;
            dog.lengthcommands = 277;



            Assert.AreEqual("Собака\nВес: 56кг.\nДлина хвоста: 15 см.\nДлина игнора команд: 277 cм.\nПорода: Хаски", dog.GetInfo());
        }
    }

    [TestClass()]
    public class CatTests
    {
        [TestMethod()]
        public void GetInfoTest()
        {

            Cat cat = new Cat();
            cat.weight = 56;
            cat.fur = true;
            cat.killsmouse = 5;



            Assert.AreEqual("Кошка\nВес: " + cat.weight/10 + "кг.\nШерсть: Есть\nУлов мышей: 5 шт.", cat.GetInfo());
        }
    }
}