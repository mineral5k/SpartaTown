using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    Text nameTxt;

    private void Awake()
    {
        nameTxt = GetComponent<Text>();
    }
    // Start is called before the first frame update
   

    private void OnEnable()
    {
        nameTxt.text = GameManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
