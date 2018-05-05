using System;
using System.Linq;
using System.Collections.Generic;

using ClassLibrary_CGC;

namespace User_class
{
    [Serializable]
    public class User : Player
    {
        public static GameBoard gameboard;

         static int lastX;
         static int lastY;
        static PlayerAction lastAction;






        /// <summary>
        /// Задать Команду на следующий Ход
        /// </summary>
        /// <param name="gb">Игровое Поле</param>
        /// <returns>Команда для Юнита</returns>
        public override PlayerAction Play(GameBoard gb)
        {
            /*
                Код пользователя
            */
            Random rn = new Random();
            gameboard = gb;

            Console.WriteLine(gameboard.Bonuses.Count);

            PlayerAction action = PlayerAction.Wait;

            int difX = (X - gb.W / 2);
            int difY = (Y - gb.H / 2);


            if (lastAction == PlayerAction.Right && gb.XYinfo[X + 1, Y].Free != true)
            {
               return action = PlayerAction.Bomb;
            }
            if (lastAction == PlayerAction.Bomb && gb.XYinfo[X + 1, Y].Free != true)
            {
               return action = PlayerAction.Left;
            }
            if (lastAction == PlayerAction.Left)
            {
               return action = PlayerAction.Left;
            }


            if (gb.XYinfo[lastX, lastY].Free != true)
            {
                action = PlayerAction.Bomb;
            }
            else if (difY > 0)
                action = PlayerAction.Up;
            else if (difY < 0)
            {
                action = PlayerAction.Down;
            }

            else if (difX > 0)
            {
                action = PlayerAction.Left;
            }
            else if (difX < 0)
            {
                action = PlayerAction.Right;
            }

            lastX = X;
            lastY = Y;
            lastAction = action;

            return action;
        }



        public void BombWayOut()
        {
            for (int i = 0; i < gameboard.Bombs.Count; i++)
            {
                var bomb = gameboard.Bombs[i];
                if (dist(X, bomb.X, bomb.Bang_radius) && X == bomb.Y)
                {

                }
            }
        }


        public bool dist(int a, int b, int c)
        {
            if (Math.Abs(a-b) <c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int direction(int a, int b)
        {
            int dif = a - b;

            if (dif > 0)
            {
                return 1;
            }
            else if (dif<0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


    }
}
