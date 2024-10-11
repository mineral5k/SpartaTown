using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour
{
    [SerializeField] InputField inputField;
    // Start is called before the first frame update

    public void Enter()
    {
        GameManager.Instance.playerName = inputField.text;
    }
}
