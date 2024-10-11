using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    SpriteRenderer playerSprite;
   // [SerializeField] private Sprite sprite;

    private void Awake()
    {
        playerSprite = GetComponent<SpriteRenderer>();
       
        //playerSprite.sprite = Resources.Load<Sprite>("penguin_idle_01");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.characterSelect == 1)
        {
            playerSprite.sprite = GameManager.Instance.pengImage;
        }
        else if (GameManager.Instance.characterSelect == 2)
        {
            playerSprite.sprite = GameManager.Instance.humanImage;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
