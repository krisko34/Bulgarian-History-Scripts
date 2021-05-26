using UnityEngine;

public class MenuSceneLoader : MonoBehaviour
{
  public GameObject menuUI;
  private GameObject m_Go;

  private void Awake()
  {
    if (!((Object) this.m_Go == (Object) null))
      return;
    this.m_Go = Object.Instantiate<GameObject>(this.menuUI);
  }
}
