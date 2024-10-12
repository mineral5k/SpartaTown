using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinButtonMS : MonoBehaviour
{
    [SerializeField] public InputField inputField;
    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject namePlate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Enter()
    {
        GameManager.Instance.playerName = inputField.text;
        panel.SetActive(false);
        namePlate.SetActive(false);
        namePlate.SetActive(true);
    }
}
