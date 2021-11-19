using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;

[CreateAssetMenu(fileName = "TestDeck", menuName = "AHMG-CARD/TestDeck", order = 0)]
public class TestDeck : DeckTemplate
{
    public void OnEnable() {
        //Setting up deck
        deckName = "Test Deck";
        deckDescription = "?";
        deckId = "0000";
        baseCardList.Add(CreateInstance("Stab") as Stab);        
    }
    public override IG_Deck createDeck(){
        IG_Deck target = copyToIG();
        return target;
    }
}