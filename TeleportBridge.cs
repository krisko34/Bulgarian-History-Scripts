using UnityEngine;

public class TeleportMost : MonoBehaviour
{
  public Transform teleportTarget;
  public GameObject thePlayer;

  private void OnTriggerEnter(Collider other)
  {
    if (!((Object) other.gameObject == (Object) this.thePlayer))
      return;
    this.thePlayer.transform.position = this.teleportTarget.transform.position;
  }
}
