using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IG_Card : MonoBehaviour, TriggerUpdateInterface, ClickableInterface
{
    //Base card
    internal CardTemplate baseCard;
    //Card dynamic stat
    internal int cost;
    internal int physicalDmg;
    internal int magicDmg;
    //Other variable
    internal IG_Player owner;
    private IG_Deck deck;

    //Card mechanic
    public delegate void cardDelegate(IG_Player owner);
    public cardDelegate playCard;
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
        physicalDmg = baseCard.basePhysicalDmg;
        cost = baseCard.baseCost;
        magicDmg = baseCard.baseMagicDmg;
    }
}
