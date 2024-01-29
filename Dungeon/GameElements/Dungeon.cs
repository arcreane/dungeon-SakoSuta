using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DungeonPlace
{
    public Room[] m_RoomArray;
    private int m_iRoomIndex;

    public DungeonPlace()
    {
        m_RoomArray = new Room[5];
        m_iRoomIndex = 0;
    }

    public void WelcomeHero(Hero p_Hero)
    {
        InformPlayer?.Invoke("Welcome", MESSAGE_TYPE.INFO);
        for (int i = 0; i < m_RoomArray.Length; i++)
        {
            m_RoomArray[i] = new Room();
            m_RoomArray[i].OpenDoor(p_Hero);
        }
    }

    public void explore(hero p_hero)
    {

        while (p_hero.m_ilifepoints != 0)
        {
            m_roomarray[m_iroomindex].opendoor(p_hero);
        }

    }

}
