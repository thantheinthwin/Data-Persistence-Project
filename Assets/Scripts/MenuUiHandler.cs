using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MenuUiHandler : MonoBehaviour
{
    public TMP_InputField PlayerName;
    public TextMeshProUGUI MVP;

    private void Start()
    {
        MVP.text = "Best Score : " + PlayerPrefs.GetString("MVP") + " : " + PlayerPrefs.GetInt("highestScore");
    }

    public void PlayerNameInput()
    {
        PlayerData.Instance.PlayerName = PlayerName.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }    

    public void Quit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #endif
        Application.Quit();
    }

    public void DeleteScoreBoard()
    {
        PlayerPrefs.DeleteAll();
        MVP.text = "Best Score : " + " : " + " ";
    }
}
