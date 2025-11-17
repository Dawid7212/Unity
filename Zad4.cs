using UnityEngine;

public class Zad4 : MonoBehaviour
{
    public float jumpBoostMultiplier = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MoveWithCharacterController player = other.GetComponent<MoveWithCharacterController>();
            if (player != null)
            {
                player.BoostJump(jumpBoostMultiplier);
            }
        }
    }
}
/////// BostJump znajduje się wewątrz MoveWithCharacterController i wygląda tak:
/// public void BoostJump(float multiplier)
///{
///    playerVelocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravityValue) * multiplier;
///}
