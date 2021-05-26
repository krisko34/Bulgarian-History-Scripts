
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  private bool GameHasEnded;
  public float resDelay = 1.5f;
  public GameObject completeLevelUI;

  public void CompleteLevel() => this.completeLevelUI.SetActive(true);

  public void EndGame()
  {
    if (this.GameHasEnded)
      return;
    this.GameHasEnded = true;
    Debug.Log((object) "Game Over");
    this.Invoke("Restart", this.resDelay);
  }

  private void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
