using UnityEngine;

public class Mouse : MonoBehaviour
{
  private void OnGUI()
  {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = true;
  }

  private void Update() => Cursor.visible = true;
}
