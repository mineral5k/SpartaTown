using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour
{
    [SerializeField] public InputField inputField;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    public void Enter()
    {
        GameManager.Instance.playerName = inputField.text;
        Debug.Log($"{GameManager.Instance.playerName}");
        SceneManager.LoadScene("MainScene");
    }
}
