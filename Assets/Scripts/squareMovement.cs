using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class squareMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float speed = 0.01f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        Vector2 newPos = transform.position;
        newPos.x += speed;

        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(newPos);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed *= -1;
        }
    }
}