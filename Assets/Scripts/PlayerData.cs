using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;

    public string PlayerName;

    public int Score;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
