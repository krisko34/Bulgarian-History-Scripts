using UnityEngine;

public class MooveDoorBox : MonoBehaviour
{
  [SerializeField]
  private GameObject Door;
  private bool isOpened;

  private void OnTriggerEnter(Collider col)
  {
    if (this.isOpened)
      return;
    this.isOpened = true;
    this.Door.transform.position += new Vector3(4f, 4f, 0.0f);
  }
}
