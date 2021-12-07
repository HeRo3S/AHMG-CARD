using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterTemplate : ScriptableObject
{
    //Character info

    protected string characterName;
    protected int characterId;
    protected string characterDescription;

    //Fixed stat
    protected int fixed_maxHp;
    protected int fixed_staminaRegen;
    protected int fixed_handSize = 6;
    protected int fixed_cardDraw = 2;
    //Skill list
    protected List<SkillTemplate> skillList = new List<SkillTemplate> { };


    //Getter

    internal string getName()
    {
        return characterName;
    }
    internal int getId()
    {
        return characterId;
    }

    internal string getDescription()
    {
        return characterDescription;
    }

    internal int getBaseHp()
    {
        return fixed_maxHp;
    }

    internal int getBaseStaminaRegen()
    {
        return fixed_staminaRegen;
    }

    internal int getBaseHandSize()
    {
        return fixed_handSize;
    }

    internal int getBaseCardDraw()
    {
        return fixed_cardDraw;
    }



    //Copy to IG_Character
    public GameObject IGcharObj;
    protected IG_Player copyToIG()
    {
        IGcharObj = Resources.Load<GameObject>("Handmade assets/Empty") as GameObject;
        GameObject playerObj = Instantiate(IGcharObj);
        IG_Player target = playerObj.AddComponent<IG_Player>();
        target.baseCharacter = this;
        return target;
    }

    //Function to create a IG_player

    public virtual IG_Player createPlayer(DeckTemplate deck)
    {
        return null;
    }
}
