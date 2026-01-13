using UnityEngine;
using UnityEngine.InputSystem;

public class RollOver : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 screenPos;
    public AnimationCurve curve;

    public float timer = 0;
    public bool timerIsRunning;
    public float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        screenPos = transform.position;

        distance = Vector2.Distance(mousePos, screenPos);

        if (distance < 1)
        {
            timerIsRunning = true;
        }
        else
        {
            timerIsRunning = false;
        }


        if (timerIsRunning)
        {
            transform.localScale = new Vector3 ( curve.Evaluate(timer - (int)timer), curve.Evaluate(timer - (int)timer), 1);
            timer += Time.deltaTime;
        } else
        {
            transform.localScale = Vector3.one;
            timer = 0;
        }
    }
}
