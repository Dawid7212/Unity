using UnityEngine;

public class Zad5 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // najpierw należy dodać do obiektu tag "obstacle" - utworzyć nowy
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Kontakt z przeszkodą rozpoczęty!");
        }
    }
}
