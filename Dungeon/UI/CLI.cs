using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame.UI
{
    Interface class UI
    {
        void DisplayInfoPlayer(string p_StringInfo)
        {
            Console.WriteLine(p_StringInfo);
        }

        public string GetPlayerInfo
        {
            get { }
        }
    }

}