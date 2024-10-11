using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public string playerName;
    public int characterSelect = 1;
    [SerializeField] public Sprite pengImage;
    [SerializeField] public Sprite humanImage;



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != null) Destroy(gameObject);
        
    }
}
