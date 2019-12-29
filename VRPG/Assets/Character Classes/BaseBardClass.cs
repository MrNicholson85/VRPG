using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBardClass : BaseCharacterClass
{
    public void BardClass()
    {
        CharacterClassName = "Bard";
        CharacterClassDescription = "An inspiring magician whose power echoes the music of creation";

        // Abilities
        Strength = 10;
        Dexterity = 4;
        Constitution = 6;
        Intelligence = 3;
        Wisdom = 3;
        Charisma = 1;

    }
}
