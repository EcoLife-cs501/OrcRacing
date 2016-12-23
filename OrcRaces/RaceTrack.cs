using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcRaces
{
    public partial class RaceTrack : Form
    {
        // Декларации - внутри формы RaceTrack будут жить трое орков
        Orc momOrc;
        Orc uglyOrc;
        Orc pigriderOrc;
        Orc winner; // тут будет храниться победитель

        bool noWinner = true; // пока нетПобедителя = правда игра продолжается :)


        private void RaceTrack_Load(object sender, EventArgs e)
        /// Назначение: выполняется во время загрузки формы (как бы подготовка).
        {
            // TODO: Создай двух других орков и сделай так чтоб они бежали! (это см. ниже :))
            momOrc = new Orc("Mamma Orc", mommyOrc);

        }

        private void buttonRun_Click(object sender, EventArgs e)
        /// Назначение: запускает все что надо по событию "нажата кнопка погнали".
        {
            // Игра началась, и возможности поменять выбор больше нет :)
            setControls(false);
            // до тех пор пока нет победителя...
            while (noWinner)
            {
                 // маманя орк делает новый рывок!..
                 // но может быть она уже пришла к финишу?.. Если да -
                {
                    // объявляем ее победителем
                    // снимаем флаг "нет победителя" - cтавим его в false
                    // и выходим из цикла
                }

                // TODO: Пусть остальные орки тоже участвуют в забеге

            }

            // Итак, кто-то добежал до финиша! Объявим победителя:
            MessageBox.Show("Забегал выиграл(а): " + winner.myName, "Есть победитель!");

            // TODO: Для продвинутых - если переключатель = победитель то сообщить что ты выиграл спор.
            // Как это сделать? :)


            // Снова включим контролы
            setControls(true);

            // Вернем всех на исходную :)
            momOrc.ToStart();
            noWinner = true;

        }

        private void setControls (bool onOff)
        /// Назначение - включает и отключает кнопки и выбор на форме.
        /// Вход: Да (включить) и нет (отключить).
        {
            if (onOff)
            {
                // Свойство enabled есть у каждого контрола
                chooseMomOrc.Enabled = true;
                chooseUglyOrc.Enabled = true;
                choosePigRider.Enabled = true;
                buttonRun.Enabled = true;
            }
            else
            {
                chooseMomOrc.Enabled = false;
                chooseUglyOrc.Enabled = false;
                choosePigRider.Enabled = false;
                buttonRun.Enabled = false;
            }
        }



        public RaceTrack()
        /// Это конструктор формы RaceTrack.
        /// Теперь когда мы все про нее знаем - мы пишем конструктор, который ее запускает.

        {
            InitializeComponent();
        }
    }
}
