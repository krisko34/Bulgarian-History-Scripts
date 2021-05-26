using UnityEngine;

public class ShootArrow : MonoBehaviour
{
  public Camera cam;
  public GameObject arrowPrefab;
  public Transform arrowSpawn;
  public float shootForce = 20f;

  private void Start() => this.arrowPrefab.transform.rotation = this.arrowSpawn.transform.rotation;

  private void Update()
  {
    if (!Input.GetMouseButtonDown(0))
      return;
    Object.Instantiate<GameObject>(this.arrowPrefab, this.arrowSpawn.position, this.arrowPrefab.transform.rotation).GetComponent<Rigidbody>().velocity = this.cam.transform.forward * this.shootForce;
  }
}
