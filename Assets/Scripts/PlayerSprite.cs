using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    SpriteRenderer playerSprite;
    [SerializeField] private Sprite sprite;

    private void Awake()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        playerSprite.sprite = sprite;
        //playerSprite.sprite = Resources.Load<Sprite>("penguin_idle_01");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
