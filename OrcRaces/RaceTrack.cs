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




        private void buttonRun_Click(object sender, EventArgs e)
        /// Назначение: запускает все что надо по событию "нажата кнопка погнали".
        {
            // Игра началась, и возможности поменять выбор больше нет :)
            setControls(false);
            // до тех пор пока нет победителя...
            while (noWinner)
            {
                momOrc.Move(); // маманя орк делает новый рывок!..
                if (momOrc.AmIAtFinish()) // но может быть она уже пришла к финишу?.. Если да -
                {
                    winner = momOrc; // объявляем ее победителем
                    noWinner = false; // снимаем флаг "нет победителя"
                    break; // и выходим из цикла
                }

                uglyOrc.Move();
                if (uglyOrc.AmIAtFinish())
                {
                    winner = uglyOrc;
                    noWinner = false;
                    break;
                }
            }

            // Итак, кто-то добежал до финиша! Объявим победителя:
            MessageBox.Show("Забегал выиграл(а): " + winner.myName, "Есть победитель!");

            // TODO: Для продвинутых - если переключатель = победитель то сообщить что ты выиграл спор.
            // Как это сделать? :)

            if ((winner == momOrc && chooseMomOrc.Checked) ||
                (winner == uglyOrc && chooseUglyOrc.Checked))
            {
                MessageBox.Show("Поздравляем, ты выиграл спор!", "Итог спора");
            }
            else
            {
                MessageBox.Show("Увы, ты проиграл спор!", "Итог спора");
            }


            // Снова включим контролы
            setControls(true);

            // Вернем всех на исходную :)
            momOrc.ToStart();
            uglyOrc.ToStart();
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

        private void RaceTrack_Load(object sender, EventArgs e)
        {
            // TODO: Создай двух других орков и сделай так чтоб они бежали! (это выше :))

            momOrc = new Orc("Mamma Orc", mommyOrc);
            uglyOrc = new Orc("Ugly Orc", fighterOrc);
        }

        public RaceTrack()
        /// Это конструктор формы RaceTrack.
        /// Теперь когда мы все про нее знаем - мы пишем конструктор, который ее запускает.

        {
            InitializeComponent();
        }
    }
}
