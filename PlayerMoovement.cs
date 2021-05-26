using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;

  private void Update()
  {
    if ((double) this.rb.position.y >= -3.0)
      return;
    Object.FindObjectOfType<GameManager>().EndGame();
  }
}
