using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CSelect : MonoBehaviour
{
    [SerializeField] public Image pengImage;
    [SerializeField] public Image humanImage;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.characterSelect ==1)
        {
            image = pengImage;
        }    
        else if( GameManager.Instance.characterSelect ==2)
        {
            image = humanImage;
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
