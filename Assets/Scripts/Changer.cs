using UnityEngine;
using UnityEngine.InputSystem;

public class Changer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color chosenColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Keyboard.current.anyKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        //{
        //    PickARandomColour();    
        //}

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousePos))
        {
            spriteRenderer.color = chosenColor;
        } else
        {
            spriteRenderer.color = Color.white;
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}


