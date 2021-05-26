using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
  public GameManager gameManager;

  private void OnTriggerEnter()
  {
    this.gameManager.CompleteLevel();
    SceneManager.LoadScene("MainMenu");
  }
}
