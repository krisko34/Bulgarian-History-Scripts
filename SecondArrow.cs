using UnityEngine;

public class SecondArrow : MonoBehaviour
{
  private Rigidbody rb;

  private void Start() => this.rb = this.GetComponent<Rigidbody>();

  private void Update() => this.transform.rotation = Quaternion.LookRotation(this.rb.velocity);
}
