using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
  private void Update()
  {
    if (!Input.GetKeyDown(KeyCode.Escape))
      return;
    SceneManager.LoadScene("MainMenu");
  }
}
