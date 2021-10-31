using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardTemplate : MonoBehaviour
{
    //Card info
    public string cardName;
    public string cardDescription;
    public string cardId;
    public int rank;
    protected cardTypes cardType;
    //Base stat
    protected int baseCost;
    protected int basePhysicalDmg;
    protected int baseMagicDmg;
    //Card mechanic
    protected delegate void cardDelegate(IG_Player owner);
    protected cardDelegate playCard;
    //Function to create IG_Card
    public IG_Card createCard(IG_Player player){
        return null;
    }
}
