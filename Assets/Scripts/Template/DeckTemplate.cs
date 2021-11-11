using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DeckTemplate : ScriptableObject
{
    //Deck info
    public string deckName;
    public string deckDescription;
    public string deckId;
    //Card list
    internal List<CardTemplate> baseCardList;

    //Load deck data - need json test file
    
    //Copy to IG_Deck
    public GameObject IGdeckObj;
    protected IG_Deck copyToIG(){
        GameObject deckObj = Instantiate(IGdeckObj);
        IG_Deck target = deckObj.AddComponent<IG_Deck>();
        target.baseDeck = this;
        return target;
    }
    public abstract IG_Deck createDeck();
}
