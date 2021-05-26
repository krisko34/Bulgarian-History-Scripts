using UnityEngine;

public class Torchslider2 : MonoBehaviour
{
  public GameObject TorcheObj;
  public Camera MainCamera;
  public GUISkin SkinSlider;
  private GameObject Torch;
  private float Intensity_Light;
  private bool CameraRendering;

  private void OnGUI()
  {
    GUI.Label(new Rect(25f, 25f, 150f, 30f), "Light Intensity", this.SkinSlider.label);
    this.Intensity_Light = GUI.HorizontalSlider(new Rect(25f, 50f, 150f, 30f), this.Intensity_Light, 0.0f, this.TorcheObj.GetComponent<Torchelight>().MaxLightIntensity, this.SkinSlider.horizontalSlider, this.SkinSlider.horizontalSliderThumb);
    this.CameraRendering = GUI.Toggle(new Rect(25f, 80f, 150f, 30f), this.CameraRendering, "Deferred lighting");
    if (this.CameraRendering)
      this.MainCamera.renderingPath = RenderingPath.DeferredLighting;
    else
      this.MainCamera.renderingPath = RenderingPath.Forward;
  }

  private void Update()
  {
    foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("TagLight"))
      gameObject.GetComponent<Torchelight>().IntensityLight = this.Intensity_Light;
  }
}
