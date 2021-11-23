using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterTemplate : ScriptableObject
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
    public GameObject IGcharObj;
    protected IG_Player copyToIG(){
        IGcharObj = Resources.Load<GameObject>("Handmade assets/Empty") as GameObject;
        GameObject playerObj = Instantiate(IGcharObj);
        IG_Player target = playerObj.AddComponent<IG_Player>();
        target.baseCharacter = this;
        return target;
    }

    //Function to create a IG_player

    public virtual IG_Player createPlayer(DeckTemplate deck){
        return null;
    }
}
