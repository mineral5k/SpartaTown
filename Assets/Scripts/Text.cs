using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
       // text.text = GameManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
