using UnityEngine;

public class Arrow : MonoBehaviour
{
  private Rigidbody myBody;
  private float lifeTimer = 2f;
  private float timer;
  private bool hitSomething;

  private void Start()
  {
    this.myBody = this.GetComponent<Rigidbody>();
    this.transform.rotation = Quaternion.LookRotation(this.myBody.velocity);
  }

  private void Update()
  {
    if (this.hitSomething)
      return;
    this.transform.rotation = Quaternion.LookRotation(this.myBody.velocity);
  }

  private void OnCollisionEnter(Collision collision)
  {
    this.hitSomething = true;
    this.Stick();
  }

  private void Stick() => this.myBody.constraints = RigidbodyConstraints.FreezeAll;
}
