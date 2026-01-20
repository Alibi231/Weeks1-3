using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Changer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color chosenColor;
    public int randomNumber;
    public List<Sprite> spriteArray;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            if (spriteArray.Count > 0)
            {
                PickARandomSprite();
            }
        }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousePos))
        {
            spriteRenderer.color = chosenColor;
        } else
        {
            spriteRenderer.color = Color.white;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame && spriteArray.Count > 0)
        {
            spriteArray.RemoveAt(0);
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        randomNumber = Random.Range(0, spriteArray.Count);
        spriteRenderer.sprite = spriteArray[randomNumber];
    }
}


