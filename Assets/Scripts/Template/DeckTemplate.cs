using System.Collections.Generic;
using UnityEngine;

public abstract class DeckTemplate : ScriptableObject
{
    //Deck info
    protected string deckName;
    protected string deckDescription;
    protected int deckId;

    //Card list
    protected List<CardTemplate> baseCardList = new List<CardTemplate>();

    //Load deck data - need json test file

    //Getter

    internal string getName()
    {
        return deckName;
    }

    internal string getDescription()
    {
        return deckDescription;
    }

    internal int getId()
    {
        return deckId;
    }

    internal List<CardTemplate> getBaseCardList()
    {
        return baseCardList;
    }

    //Copy to IG_Deck
    public GameObject IGdeckObj;
    protected IG_Deck copyToIG()
    {
        IGdeckObj = Resources.Load<GameObject>("Handmade assets/Deck") as GameObject;
        GameObject deckObj = Instantiate(IGdeckObj);
        IG_Deck target = deckObj.AddComponent<IG_Deck>();
        target.baseDeck = this;
        return target;
    }
    public abstract IG_Deck createDeck();
}
