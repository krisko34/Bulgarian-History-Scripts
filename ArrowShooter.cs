using UnityEngine;

public class ArrowShooter : MonoBehaviour
{
  public GameObject arrowPrefab;

  private void Update()
  {
    if (!Input.GetMouseButtonDown(0))
      return;
    Debug.Log((object) "strela");
    GameObject gameObject = Object.Instantiate<GameObject>(this.arrowPrefab);
    gameObject.transform.position = this.transform.position;
    gameObject.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * 30f;
  }
}
