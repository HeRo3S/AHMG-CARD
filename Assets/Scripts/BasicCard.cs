using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCard : MonoBehaviour
{
    private double damage;
    private double cost;
    private double maxInDeck;
    private bool isUsed;

    private double getDamage()
    {
        return damage;
    }
    private void setDamage(double _damage)
    {
        damage = _damage;
    }
    private double getCost()
    {
        return cost;
    }
    private void setCost(double _cost)
    {
        cost = _cost;
    }
    private bool getUsedStatus()
    {
        return isUsed;
    }
    private bool canGenerated()
    {
        return (maxInDeck <= 0);
    }

    private void inflictDamage(BasicChar player)
    {
        player.getDamage(damage);
        isUsed = true;
    }

    //initialized fuction
    public BasicCard(double _damage, double _cost, double _maxInDeck)
    {
        damage = _damage;
        cost = _cost;
        maxInDeck = _maxInDeck;
        isUsed = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
