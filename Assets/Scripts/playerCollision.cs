using UnityEngine;

public class playerCollision : MonoBehaviour
{
  public playerMovement movement;

  void OnCollisionEnter(Collision collision)
  {
    if (collision.collider.tag == "Obstacle")
    {
      movement.enabled = false;
      FindAnyObjectByType<gameManager>().EndGame();
    }
  }
}
