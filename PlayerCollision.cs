using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public PlayerMovement playerMovement;

  private void OnCollisionEnter(Collision collisionInfo)
  {
    if (!(collisionInfo.collider.tag == "obstacle"))
      return;
    this.playerMovement.enabled = false;
    Object.FindObjectOfType<GameManager>().EndGame();
  }
}
