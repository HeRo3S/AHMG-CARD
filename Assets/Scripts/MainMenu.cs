using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Networking;
public class MainMenu : MonoBehaviour
{

    [SerializeField]
    private TMP_InputField email;
    [SerializeField]
    private TMP_InputField password;
    [SerializeField]
    private GameObject loginWindow;
    private bool loggedIn = false;
    public void playGame()
    {
        if(loggedIn)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


    public void login(){
        StartCoroutine(loginRequest());
        
    }
    public IEnumerator loginRequest(){
        WWWForm formData = new WWWForm();
        formData.AddField("email", email.text);
        formData.AddField("password", password.text);
        UnityWebRequest www = UnityWebRequest.Post("http://localhost:3000/ahmg_card/login", formData);
        yield return www.SendWebRequest();
                if (www.result != UnityWebRequest.Result.Success)
        {
            UnityEngine.Debug.Log(www.downloadHandler.text);
            www.Dispose();
        }
        else
        {
            User user = JsonUtility.FromJson<User>(www.downloadHandler.text);
            preBattleInfo.id = user.id;
            www.Dispose();
            loggedIn = true;
            Destroy(loginWindow.gameObject);
        }
    }
}
