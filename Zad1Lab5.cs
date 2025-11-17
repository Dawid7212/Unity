using UnityEngine;

public class Zad1Lab5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed =1.0f;
    public GameObject target;
    public Vector3 startPosition;
    public Vector3 targetPosition;
    private bool movePlatform = false;
    void Start()
    {
        startPosition = transform.position;
        targetPosition = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!movePlatform) return;
        if (Vector3.Distance(transform.position, targetPosition)<0.02f)
        {
            target.transform.position = startPosition;
            targetPosition = target.transform.position;
            startPosition = transform.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            movePlatform = true;  
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            movePlatform = false;  
        }
    }
}
