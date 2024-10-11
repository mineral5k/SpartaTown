using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CSelect : MonoBehaviour
{
   
    private Image spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.characterSelect ==1)
        {
            spriteRenderer.sprite = GameManager.Instance.pengImage;
        }    
        else if( GameManager.Instance.characterSelect ==2)
        {
            spriteRenderer.sprite = GameManager.Instance.humanImage;
        }
             
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
