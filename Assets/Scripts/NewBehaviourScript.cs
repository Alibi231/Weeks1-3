using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        
        //transform.position = Vector2.Lerp(startPos, endPos, t);
    }
}
