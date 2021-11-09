using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private List<triggerTypes> triggers;
    private List<IG_Player> players;
    
    public void Start(){
        players[0].setOpponent(players[1]);
        players[1].setOpponent(players[0]);        
    }
    public void Update(){
        //Check if an object is clicked on
        if (Input.GetMouseButtonDown(0)){
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)){
            //Get game object script
            ClickableInterface target = hit.transform.gameObject.GetComponent(typeof(ClickableInterface)) as ClickableInterface;
            if(target != null)
            {
                target.onClick();
            }
     }
   }
 }

    void LateUpdate(){
        foreach (IG_Player player in players){
            player.triggerUpdate(triggers);
        }
    triggers.Clear();    
    }
}