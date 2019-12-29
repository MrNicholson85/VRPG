using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBarbarinClass : BaseCharacterClass
{
    public void BarbarinClass()
    {
        CharacterClassName = "Barbarin";
        CharacterClassDescription = "A fierce warrior of primitive background who can enter a battle rage";

        // Abilities
        Strength = 10;
        Dexterity = 4;
        Constitution = 6;
        Intelligence = 3;
        Wisdom = 3;
        Charisma = 1;

    }
}
