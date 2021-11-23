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
    internal List<CardTemplate> baseCardList = new List<CardTemplate>();

    //Load deck data - need json test file

    //Copy to IG_Deck
    public GameObject IGdeckObj;
    protected IG_Deck copyToIG(){
        IGdeckObj = Resources.Load<GameObject>("Handmade assets/Deck") as GameObject;
        GameObject deckObj = Instantiate(IGdeckObj);
        IG_Deck target = deckObj.AddComponent<IG_Deck>();
        target.baseDeck = this;
        return target;
    }
    public abstract IG_Deck createDeck();
}
