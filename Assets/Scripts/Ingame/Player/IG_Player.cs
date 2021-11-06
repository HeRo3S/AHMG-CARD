using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IG_Player : CharacterTemplate
{
    //Basic stat

    protected int heathPts;
    protected int stamina;
    protected int maxHp;

    //Regen stat
    protected int hpRegen;
    protected int staminaRegen;


    //Modifier stat
    protected int maxHp_flatMod;
    protected double maxHp_pctMod;
    protected int hpRegen_flatMod;
    protected double hpRegen_pctMod;
    protected int staminaRegen_flatMod;
    protected double staminaRegen_pctMod;
    protected int physicalDmg_flatMod;
    protected double physicalDmg_pctMod;
    protected int magicDmg_flatMod;
    protected double magicDmg_pctMod;

    //Skill list
    protected IG_Skill passive;
    protected IG_Skill active;
    //Other mechanic specific variable and list
    protected IG_Player opponent;
    protected IG_Deck deck;
    protected List<IG_StatusEffect> statusEffects = new List<IG_StatusEffect>{};

    //Account and data collect
    protected int playerID;
    protected string playerName;

    //Setter
    public void setOpponent(IG_Player opponent){
        this.opponent  = opponent;
    }

    //Getter
    public IG_Player getOpponent(){
        return opponent;
    }
    public void receivePhysicalDmg(int dmg){
        heathPts -= dmg;    
    }
}
