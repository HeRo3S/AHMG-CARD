using System;
using System.Collections.Generic;
using UnityEngine;
public class IG_Deck : MonoBehaviour, TriggerUpdateInterface
{
    //Base deck
    internal DeckTemplate baseDeck;
    //Dynamic card list
    private List<CardTemplate> cardList = new List<CardTemplate>();
    internal IG_Player owner;
    //Shuffle deck
    public void shuffleDeck()
    {
        cardList.Shuffle();
    }
    //Create deck
    public void replenishDeck()
    {
        foreach (CardTemplate card in baseDeck.getBaseCardList())
        {
            cardList.Add(card);
        }
    }
    //Add card to deck
    public void addCard(CardTemplate card, int pos)
    {
        cardList.Insert(pos, card);
    }
    //Get card from deck
    public IG_Card drawIG(int pos, bool removeFrDeck)
    {
        //Just for testing
        if (cardList.Count <= 0)
        {
            replenishDeck();
            shuffleDeck();
        }
        //Real deal
        pos = Math.Min(pos, cardList.Count - 1);
        IG_Card target = cardList[pos].createCard(owner);
        if (removeFrDeck)
        {
            cardList.RemoveAt(pos);
        }
        return target;
    }


    //                                                  **********IMPLEMENTATION***********
    //Initialize
    public void Start()
    {
        replenishDeck();
        shuffleDeck();
    }

    //Trigger Update
    public void triggerUpdate(HashSet<triggerTypes> triggers)
    {
        //Here come the if else madness
    }

    //Click function
    // public void onClick(){
    //     owner.drawCard(0, true);
    // }
}
