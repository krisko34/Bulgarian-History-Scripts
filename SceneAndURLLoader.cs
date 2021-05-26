using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
  private PauseMenu m_PauseMenu;

  private void Awake() => this.m_PauseMenu = this.GetComponentInChildren<PauseMenu>();

  public void SceneLoad(string sceneName)
  {
    this.m_PauseMenu.MenuOff();
    SceneManager.LoadScene(sceneName);
  }

  public void LoadURL(string url) => Application.OpenURL(url);
}
