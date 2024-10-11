using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public string playerName;
    public int characterSelect = 1;
   


    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }
}
