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
    protected int fixed_maxHp;
    protected int fixed_staminaRegen;

    //Skill list
    protected List<SkillTemplate> skillList = new List<SkillTemplate> {};

    //Copy to IG_Character
    protected IG_Player copyToIG(){
        IG_Player target = new IG_Player();
        target.characterName = this.characterName;
        target.characterId = this.characterId;
        target.characterDescription = this.characterDescription;
        target.fixed_maxHp = this.fixed_maxHp;
        target.fixed_staminaRegen = this.fixed_staminaRegen;
        return target;
    }

    //Function to create a IG_player

    public virtual IG_Player createPlayer(IG_Player opponent){
        return null;
    }
}
