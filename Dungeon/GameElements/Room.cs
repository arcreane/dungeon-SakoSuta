using DungeonGame.GameElements;

Room.cs
using DungeonGame.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame.GameElements
{
    public class Room : CommunicatingClass
    {

        public Room()
        {
        }



        /// <summary>
        /// @param p_Hero 
        /// @return
        /// </summary>
        public Monster OpenDoor(Hero p_Hero)
        {
            InformPlayer?.Invoke("You have open the door, be ready to meet your fate", MESSAGE_TYPE.INFO);
            p_Hero.SelectProtection();

            return null;
        }

    }
}