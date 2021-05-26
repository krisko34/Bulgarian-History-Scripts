using UnityEngine;

public class ThrowAxe : MonoBehaviour
{
  public GameObject bullet;
  public float speed = 100f;

  private void Update()
  {
    if (!Input.GetMouseButtonDown(0))
      return;
    Object.Instantiate<GameObject>(this.bullet, this.transform.position, Quaternion.identity).GetComponent<Rigidbody>().velocity = this.transform.forward * this.speed;
  }
}
