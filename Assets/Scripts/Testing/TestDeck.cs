using UnityEngine;

[CreateAssetMenu(fileName = "TestDeck", menuName = "AHMG-CARD/TestDeck", order = 0)]
public class TestDeck : DeckTemplate
{
    public void OnEnable()
    {
        //Setting up deck
        deckName = "Test Deck";
        deckDescription = "?";
        deckId = 1;
        Stab stabCard = CreateInstance("Stab") as Stab;
        RapidNeedle rapidCard = CreateInstance("RapidNeedle") as RapidNeedle;
        Slash slashCard = CreateInstance("Slash") as Slash;
        Heal healCard = CreateInstance("Heal") as Heal;
        Draw drawCard = CreateInstance("Draw") as Draw;
        Rest restCard = CreateInstance("Rest") as Rest;
        for(int i = 0; i < 5; i++){
            baseCardList.Add(stabCard);
            baseCardList.Add(slashCard);
            baseCardList.Add(healCard);
            baseCardList.Add(drawCard);
        }
        for(int i = 0; i < 2; i++){
            baseCardList.Add(rapidCard);
        }
        for(int i = 0; i < 3; i++){
            baseCardList.Add(restCard);
        }
    }
    public override IG_Deck createDeck()
    {
        IG_Deck target = copyToIG();
        return target;
    }
}