using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IG_Card : CardTemplate, TriggerUpdateInterface
{
    //Card dynamic stat
    internal int cost;
    internal int physicalDmg;
    internal int magicDmg;
    //Other variable
    internal IG_Player owner;
    private IG_Deck deck;
    //Card logic
    public void onClick(){
        playCard(owner);
        owner.removeFrHand(this);
        Destroy(gameObject);
    }

//                                                  **********IMPLEMENTATION***********

    //Trigger Update
    public void triggerUpdate(List<triggerTypes> triggers){
        //Here come the if else madness
        
    }
    //Initialization
    
    public void Start(){
        physicalDmg = basePhysicalDmg;
        cost = baseCost;
        magicDmg = baseMagicDmg;
    }
}
