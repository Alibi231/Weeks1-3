using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovement : MonoBehaviour
{
    public float speed = 0.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            newPosition.x -= speed * Time.deltaTime;
        } else if (Keyboard.current.rightArrowKey.isPressed)
        {
            newPosition.x += speed * Time.deltaTime;
        }

        Vector2 screenPos = Camera.main.WorldToScreenPoint(newPosition);
        if (screenPos.x < 0)
        {
            newPosition.x += speed * Time.deltaTime;
        }
        else if (screenPos.x > Screen.width) {
            newPosition.x -= speed * Time.deltaTime;
        }



            transform.position = newPosition;
    }
}
