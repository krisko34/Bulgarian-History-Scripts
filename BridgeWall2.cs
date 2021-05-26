using UnityEngine;

public class BridgeWall2 : MonoBehaviour
{
  [SerializeField]
  private GameObject Door;
  private bool isOpened;

  private void OnTriggerEnter(Collider col)
  {
    if (this.isOpened)
      return;
    this.isOpened = true;
    this.Door.transform.position += new Vector3(-5f, 0.0f, 0.0f);
  }
}
