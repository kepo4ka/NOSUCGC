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


        /// <summary>
        /// Задать Команду на следующий Ход
        /// </summary>
        /// <param name="gb">Полученное Игровое Поле</param>
        /// <returns>Команда для бота</returns>
        public override PlayerAction Play(GameBoard gb)
        {
            /*
                Код пользователя
            */
         
            Random rn = new Random();
            gameboard = gb;

            PlayerAction action = PlayerAction.Wait;

            if ((gb.W / 2 - X) > 0)
            {
                action = PlayerAction.Right;
                return action;
            }
            else 


            return action;
        }






    }
}
