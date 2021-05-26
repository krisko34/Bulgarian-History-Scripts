using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
  public Transform player;
  public Vector3 offset;

  private void Update() => this.transform.position = this.player.position + this.offset;
}
