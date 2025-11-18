using UnityEngine;

public class Zad3 : MonoBehaviour
{
    public float speed = 1.0f;

    public Transform[] waypoints;  // tablica waypointów do ustawienia w Inspectorze

    private int currentIndex = 0;  
    private int direction = 1;     // kierunek poruszania: 1 - w przód, -1 - w tył

    void Update()
    {
        if (waypoints == null || waypoints.Length == 0)
            return;

        Transform target = waypoints[currentIndex];

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.01f)
        {
            if (currentIndex == waypoints.Length - 1)
                direction = -1; 
            else if (currentIndex == 0)
                direction = 1;  

            currentIndex += direction;
        }
    }
}
