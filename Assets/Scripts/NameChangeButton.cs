using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChangeButton : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NameChangePanelOn()
    {
        panel.SetActive(true);
    }
}
