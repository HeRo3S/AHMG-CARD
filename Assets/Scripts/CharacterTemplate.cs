using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterTemplate : MonoBehaviour
{   
    //Character info

    public string characterName;
    public string characterId;
    public string characterDescription;

    //Fixed stat
    private int fixed_maxHp;
    private int fixed_staminaRegen;

    //Skill list
    protected List<SkillTemplate> skillList = new List<SkillTemplate> {};

    //Function to create a IG_player

    public IG_Player createPlayer(IG_Player opponent){
        return null;
    }
}
