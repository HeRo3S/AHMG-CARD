using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DeckTemplate : MonoBehaviour
{
    //Deck info
    public string deckName;
    public string deckDescription;
    public string deckId;
    //Card list
    protected List<CardTemplate> baseCardList;

    //Load deck data - need json test file

}
