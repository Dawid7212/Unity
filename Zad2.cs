using UnityEngine;

public class Zad2 : MonoBehaviour
{
    public Transform player;           // referencja do gracza
    public float openDistance = 3.0f; 
    public float slideAmount = 2.0f;  
    public float speed = 2.0f;        

    private Vector3 closedPosition;
    private Vector3 openPosition;
    private bool isOpen = false;

    void Start()
    {
        closedPosition = transform.position;
        openPosition = closedPosition + Vector3.right * slideAmount;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);
        isOpen = distanceToPlayer < openDistance;

        Vector3 targetPos = isOpen ? openPosition : closedPosition;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}
