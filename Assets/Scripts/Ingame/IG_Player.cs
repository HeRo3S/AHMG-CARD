using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IG_Player : MonoBehaviour, TriggerUpdateInterface
{
    //Basic stat

    protected int healthPts;
    protected int stamina;
    protected int maxHp;

    //Regen stat
    protected int hpRegen;
    protected int staminaRegen;


    //Modifier stat
    protected int maxHp_flatMod;
    protected double maxHp_pctMod;
    protected int hpRegen_flatMod;
    protected double hpRegen_pctMod;
    protected int staminaRegen_flatMod;
    protected double staminaRegen_pctMod;
    protected int physicalDmg_flatMod;
    protected double physicalDmg_pctMod;
    protected int magicDmg_flatMod;
    protected double magicDmg_pctMod;

    //Skill list
    protected IG_Skill passive;
    protected IG_Skill active;
    //Other mechanic specific variable and list
    protected IG_Player opponent;
    internal CharacterTemplate baseCharacter;
    internal IG_Deck deck;
    private List<IG_Card> hand = new List<IG_Card>();
    protected List<IG_StatusEffect> statusEffects = new List<IG_StatusEffect> { };

    //Account and data collect
    protected int playerID;
    protected string playerName;

    //Render stats
    protected int player_number;

    //                                                  *************FUNCTION*************

    //Setter
    public void setOpponent(IG_Player opponent) {
        this.opponent = opponent;
    }

    public void setRenderPosition(int _number)
    {
        this.player_number = _number;
    }

    //Getter
    public int getHealthPts()
    {
        return this.healthPts;
    }

    public int getStaminaPts()
    {
        return this.stamina;
    }
    public IG_Player getOpponent(){
        return opponent;
    }
//Player specific function
    public void receivePhysicalDmg(int dmg){
        healthPts -= dmg;    
    }

    //Draw card
    public void drawCard(int pos, bool removeFrDeck){
        hand.Add(deck.drawIG(pos, removeFrDeck));
    }
    //Remove card
    public void removeFrHand(IG_Card card){
        hand.Remove(card);
    }
    //Setup card position when render
    public void setUpRenderedPosition()
    {
        if (player_number == 0)
        {
            Vector3 deckPosition = new Vector3(-1f, 0.075f, -0.65f);
            deck.transform.position = deckPosition;
            for (int i = 0; i < hand.Count; i++)
            {
                hand[i].transform.position = deckPosition + new Vector3(0.4f * (i+1), 0, 0);
            }
        } else if (player_number == 1) {
            Vector3 deckPosition = new Vector3(1f, 0.075f, 0.65f);
            deck.transform.position = deckPosition;
            for (int i = 0; i < hand.Count; i++)
            {
                hand[i].transform.position = deckPosition - new Vector3(0.4f * (i+1), 0, 0);
            }
        }
    }

    //                                                  **********IMPLEMENTATION***********

    //Trigger Update
    public void triggerUpdate(List<triggerTypes> triggers){
        //Here come the if else madness
        foreach (IG_StatusEffect status in statusEffects)
        {
            status.triggerUpdate(triggers);
        }
        foreach (IG_Card card in hand){
            card.triggerUpdate(triggers);
        }
        passive.triggerUpdate(triggers);
        active.triggerUpdate(triggers);
    }

    public void FixedUpdate()
    {
        setUpRenderedPosition();
    }
}