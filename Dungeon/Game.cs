using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Game {

    public Game() {
    }

    public Hero HeroPlayer;
    public DungeonPlace GameDungeon;

    public static void LinkToInterface(CommunicationClass p_CommunicationClass)
    {
        p_CommunicationClass.GetPlayerAction = m_UI.GetPlayerInput;
        p_CommunicationClass.InformPlayer = m_UI.Display;
    }


    public void Initialise() {
        m_Hero hero = new Hero();
        DungeonPlace dungeon = new DungeonPlace();

        dungeon.WelcomeHero(hero)
    }

}