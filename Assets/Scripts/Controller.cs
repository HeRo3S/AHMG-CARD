using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    private List<triggerTypes> triggers;
    private List<IG_Player> players;

    private List<Text> healthDisplay;
    private List<Text> staminaDisplay;
    
    public void Start(){
        players =  new List<IG_Player>();
        TestDeck testDeck = Resources.Load<TestDeck>("AHMG-CARD/TestDeck") as TestDeck;
        SwordMasterChar testChar =  ScriptableObject.CreateInstance("SwordMasterChar") as SwordMasterChar;
        players.Add(testChar.createPlayer(testDeck));
        players.Add(testChar.createPlayer(testDeck)); 
        players[0].setOpponent(players[1]);
        players[1].setOpponent(players[0]);

        //UI elements
        players[0].setRenderPosition(0);
        players[1].setRenderPosition(1);
        healthDisplay = new List<Text>();
        staminaDisplay = new List<Text>();

        healthDisplay.Add(GameObject.Find("UI/Canvas/Player/Health").GetComponent<Text>());
        staminaDisplay.Add(GameObject.Find("UI/Canvas/Player/Stamina").GetComponent<Text>());
        healthDisplay.Add(GameObject.Find("UI/Canvas/Enemy/Health").GetComponent<Text>());
        staminaDisplay.Add(GameObject.Find("UI/Canvas/Enemy/Stamina").GetComponent<Text>());


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
        healthDisplay[0].text = "HEALTH: " + players[0].getHealthPts();
        staminaDisplay[0].text = "STAMINA: " + players[0].getStaminaPts();
        healthDisplay[1].text = "HEALTH: " + players[1].getHealthPts();
        staminaDisplay[1].text = "STAMINA: " + players[1].getStaminaPts();
 }

    // void LateUpdate(){
    //     foreach (IG_Player player in players){
    //         player.triggerUpdate(triggers);
    //     }
    // triggers.Clear();    
    // }
}