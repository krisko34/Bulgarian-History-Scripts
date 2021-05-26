using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
  private Toggle m_MenuToggle;
  private float m_TimeScaleRef = 1f;
  private float m_VolumeRef = 1f;
  private bool m_Paused;

  private void Awake() => this.m_MenuToggle = this.GetComponent<Toggle>();

  private void MenuOn()
  {
    this.m_TimeScaleRef = Time.timeScale;
    Time.timeScale = 0.0f;
    this.m_VolumeRef = AudioListener.volume;
    AudioListener.volume = 0.0f;
    this.m_Paused = true;
  }

  public void MenuOff()
  {
    Time.timeScale = this.m_TimeScaleRef;
    AudioListener.volume = this.m_VolumeRef;
    this.m_Paused = false;
  }

  public void OnMenuStatusChange()
  {
    if (this.m_MenuToggle.isOn && !this.m_Paused)
    {
      this.MenuOn();
    }
    else
    {
      if (this.m_MenuToggle.isOn || !this.m_Paused)
        return;
      this.MenuOff();
    }
  }

  private void Update()
  {
    if (!Input.GetKeyUp(KeyCode.Escape))
      return;
    this.m_MenuToggle.isOn = !this.m_MenuToggle.isOn;
    Cursor.visible = this.m_MenuToggle.isOn;
  }
}
