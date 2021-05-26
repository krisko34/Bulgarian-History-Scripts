using UnityEngine;

public class FirstQuestion : MonoBehaviour
{
  public GameObject Question;

  private void Start() => this.Question.SetActive(false);

  private void OnMouseOver() => this.Question.SetActive(true);

  private void OnMouseExit() => this.Question.SetActive(false);
}
