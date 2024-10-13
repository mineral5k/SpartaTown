using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatButton : MonoBehaviour
{
    [SerializeField] private GameObject chatBox;
    [SerializeField] private GameObject chatPannel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnterChat()
    {
        chatPannel.SetActive(false);
        chatBox.SetActive(true);
    }
}
