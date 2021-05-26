using UnityEngine;

public class TriggerBridge : MonoBehaviour
{
  [SerializeField]
  private GameObject Door;
  private bool isOpened;

  private void OnTriggerEnter(Collider col)
  {
    if (this.isOpened)
      return;
    this.isOpened = true;
    this.Door.transform.position += new Vector3(0.0f, 33f, 0.0f);
  }
}
