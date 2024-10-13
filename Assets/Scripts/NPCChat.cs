using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCChat : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject chatPanel;
    [SerializeField] private GameObject chatBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((player.transform.position - transform.position).magnitude < 10f)
        {
            chatPanel.SetActive(true);
        }
        else
        {
            chatPanel.SetActive(false);
            chatBox.SetActive(false);
        }
    }
}
