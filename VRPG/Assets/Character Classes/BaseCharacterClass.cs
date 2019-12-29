using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{
    private string characerClassName;
    private string characterClassDescription;

    //Character Abilities (Explained with Tomatoes)
    private int strength; // is being able to CRUSH a tomato
    private int dexterity; // is being able to DODGE a tomamo
    private int constitution; // is being able to EAT a ROTTEN tomato
    private int intelligence; // is KNOWING that a tomato IS a FRUIT
    private int wisdom; // is knowing NOT to put a tomato in a FRUIT SALAD
    private int charisma; // is being able to SELL a TOMATO-BASED fruit salad

    public string CharacterClassName { get; set; }
    public string CharacterClassDescription { get; set; }

    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }



}
