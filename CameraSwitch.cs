using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
  public GameObject[] objects;
  public Text text;
  private int m_CurrentActiveObject;

  private void OnEnable() => this.text.text = this.objects[this.m_CurrentActiveObject].name;

  public void NextCamera()
  {
    int num = this.m_CurrentActiveObject + 1 >= this.objects.Length ? 0 : this.m_CurrentActiveObject + 1;
    for (int index = 0; index < this.objects.Length; ++index)
      this.objects[index].SetActive(index == num);
    this.m_CurrentActiveObject = num;
    this.text.text = this.objects[this.m_CurrentActiveObject].name;
  }
}
