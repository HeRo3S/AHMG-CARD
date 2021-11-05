using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IG_Deck : DeckTemplate
{
    //Dynamic card list
    private List<CardTemplate> cardList;
    private IG_Player owner;
    //Shuffle deck
    public void shuffleDeck(){
        cardList.Shuffle();
    }
    //Create deck
    public void replenishDeck(){
        foreach (CardTemplate card in baseCardList){
            cardList.Add(card.createCard(owner));
        }
    }
    //Add card to deck
    public void addCard(CardTemplate card, int pos){
        cardList.Insert(pos, card);
    }
}
