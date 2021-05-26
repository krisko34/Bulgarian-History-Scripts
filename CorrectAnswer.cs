using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
  public AudioSource playSound;

  private void OnTriggerEnter(Collider other) => this.playSound.Play();
}
