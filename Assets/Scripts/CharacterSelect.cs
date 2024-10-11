using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{

    [SerializeField] private int character ;

    
    private Image spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (character == 1)
        {
            spriteRenderer.sprite = GameManager.Instance.pengImage;
        }
        else if (character == 2)
        {
            spriteRenderer.sprite = GameManager.Instance.humanImage;
        }

    }

    public void SelectCharacter()
    {
        GameManager.Instance.characterSelect = character;
        SceneManager.LoadScene("StartScene");
    }
}
