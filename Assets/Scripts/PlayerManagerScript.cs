using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManagerScript : MonoBehaviour
{
    //Components
    PlayerInput playerInput;
    SpriteRenderer spriteRenderer;

    //Sprites
    public Sprite sprPlayerOne;
    public Sprite sprPlayerTwo;
    public Sprite sprPlayerThree;
    public Sprite sprPlayerFour;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        AssignSprites();
    }

    void Update()
    {
        
    }

    void AssignSprites()
    {
        if(playerInput.playerIndex == 0)
        {
            spriteRenderer.sprite = sprPlayerOne;
        }
        else if(playerInput.playerIndex == 1)
        {
            spriteRenderer.sprite = sprPlayerTwo;
        }
        else if (playerInput.playerIndex == 2)
        {
            spriteRenderer.sprite = sprPlayerThree;
        }
        else if (playerInput.playerIndex == 3)
        {
            spriteRenderer.sprite = sprPlayerFour;
        }
    }
}
