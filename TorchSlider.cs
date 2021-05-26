using UnityEngine;

public class TorchSlider : MonoBehaviour
{
  public GameObject TorcheObj;
  public GUISkin SkinSlider;

  private void OnGUI()
  {
    GUI.Label(new Rect(25f, 25f, 150f, 30f), "Light Intensity", this.SkinSlider.label);
    this.TorcheObj.GetComponent<Torchelight>().IntensityLight = GUI.HorizontalSlider(new Rect(25f, 50f, 150f, 30f), this.TorcheObj.GetComponent<Torchelight>().IntensityLight, 0.0f, this.TorcheObj.GetComponent<Torchelight>().MaxLightIntensity, this.SkinSlider.horizontalSlider, this.SkinSlider.horizontalSliderThumb);
  }
}
