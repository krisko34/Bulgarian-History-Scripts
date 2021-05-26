using UnityEngine;

public class MuteSound : MonoBehaviour
{
  private bool isMuted;

  private void Start()
  {
    this.isMuted = PlayerPrefs.GetInt("MUTED") == 1;
    AudioListener.pause = this.isMuted;
  }

  public void MutePressed()
  {
    this.isMuted = !this.isMuted;
    AudioListener.pause = this.isMuted;
    PlayerPrefs.SetInt("MUTED", this.isMuted ? 1 : 0);
  }
}
