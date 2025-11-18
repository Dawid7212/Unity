using UnityEngine;


public class Zad2 : MonoBehaviour
{
    public float speed = 5f;               
    private float startX;                 
    private bool movingForward = true;    

    void Start()
    {
        startX = transform.position.x;    
    }

    void Update()
    {
        float ruch = speed * Time.deltaTime;

        if (movingForward)
        {
            transform.position += Vector3.right * ruch;
            if (transform.position.x >= startX + 10f)
            {
                movingForward = false;    
                return;
            }
        }
        else
        {
            transform.position += Vector3.left * ruch;
            if (transform.position.x <= startX)
            {
                movingForward = true;      // powrót do startu, zmiana kierunku
                return;
            }
        }
    }
}