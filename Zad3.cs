using UnityEngine;

public class Zad3 : MonoBehaviour
{
    public float speed = 5f;          
    private Vector3 startPosition;         

    private float odlegloscPrzebyta = 0f; 

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float ruch = speed * Time.deltaTime;
        transform.Translate(Vector3.forward * ruch);  
        odlegloscPrzebyta += ruch;

        if (odlegloscPrzebyta >= 10f)
        {
            transform.Rotate(0, 90f, 0, Space.Self);
            odlegloscPrzebyta = 0f;

        }
    }
}
