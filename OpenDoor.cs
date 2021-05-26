using UnityEngine;

public class OpenDoor : MonoBehaviour
{
  [SerializeField]
  private GameObject Door;
  private bool isOpened;
  public Rigidbody rb;

  private void OnTriggerEnter(Collider col)
  {
    if (this.isOpened)
      return;
    this.isOpened = true;
    this.Door.transform.position += new Vector3(4f, 4f, 0.0f);
  }
}
