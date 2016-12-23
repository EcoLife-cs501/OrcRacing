using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // новая библиотека - делает доступными формы
using System.Drawing; // новая библиотека - делает доступными рисовальные примитивы, типа PictureBox
using System.Threading; // тут живет функция sleep :)

namespace OrcRaces
{
    [Serializable]
    public class Orc
    {
        // Первым делом объявим набор полей, которые нам понадобятся:
        PictureBox mySprite;
        int myMaxSpeed = 20;
        int myMinSpeed = 2;
        public string myName;

        public Orc (string myName, PictureBox mySprite)
        /// Это конструктор класса - он инициализирует поля при создании класса.
        /// Не предоставив конструктору требуемые параметры ты не сможешь создать орка :)
        {
            this.myName = myName;
            this.mySprite = mySprite;
        }

        public void Move()
        /// Назначение: двигает орка по полю к финишу на произвольное число пикселей не больше maxSpeed и не меньше minSpeed.
        /// На входе: ничего, пустой.
        /// На выходе: орк передвинулся вправо на некое число пикселей.
        {
            // все операции с координатами производятся с помощью объекта Point. Создадим его...
            // и прочитаем в него текущее положение орка
            Point currentLocation = mySprite.Location;

            // теперь нам надо понять, на сколько шагов продвинется орк.
            // для этого мы используем генератор случайных чисел!
            Random random = new Random(); // сюрприз - генератор тоже объект! :)
            int stepsToMove = random.Next(myMinSpeed, myMaxSpeed); // "в переменную stepsToMove положить результат, который вернул метод random.Next()"

            // и теперь мы готовы двигаться. "Двигаться вправо" это то же что "увеличивать X-координату"
            currentLocation.X = currentLocation.X + stepsToMove;
            // и теперь присвоим новые координаты спрайту
            mySprite.Location = currentLocation;
            // чуть замедлим исполнение чтоб орк не бегал слишком быстро :)
            Thread.Sleep(100);

        }

        public bool AmIAtFinish()
        /// Назначение: говорит, добежал ли орк до финиша
        /// Вход: пустой.
        /// Выход: правда если на границе поля, иначе ложь.
        {
            Point currentLocation = mySprite.Location;
            if (currentLocation.X > 450)
            { return true; }
            else { return false; }
        }

        public void ToStart()
        /// Назначение: вернет орка на стартовую позицию.
        {
            // TODO: Можешь понять, как орк передвигается на старт?
            Point currentLocation = mySprite.Location;
            currentLocation.X = 2;
            mySprite.Location = currentLocation;
        }

    }
}
