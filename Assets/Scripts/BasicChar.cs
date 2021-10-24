using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicChar : MonoBehaviour
{
    private double health;
    private double stamina;
    private bool dead;

    public double getHealth()
    {
        return health;
    }
    public double getStamina()
    {
        return stamina;
    }
    public bool isDead()
    {
        return dead;
    }
    public void setHealth(double _health)
    {
        health = _health;
    }
    public void setStamina(double _stamina)
    {
        stamina = _stamina;
    }
    public void setDeadStatus(bool _dead)
    {
        dead = _dead;
    }
    public void getDamage(double damage)
    {
        if (isDead()) {}
        else
        {
            if (health <= damage)
            {
                setHealth(0);
                setStamina(0);
                setDeadStatus(true);
            }
            else 
            {
                health -= damage; 
            }
        }
        return;
    }
    //spendStamina needs to be an boolean class to check whether the character has enough stamina or not
    public bool spendStamina(double cost)
    {
        if (stamina < cost) { return false; }
        else
        {
            stamina -= cost;
            return true;
        }
    }


    //intialized function
    public BasicChar(double health, double stamina)
    {
        this.health = health;
        this.stamina = stamina;
        this.dead = false;
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
