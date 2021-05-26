using UnityEngine;

public class Torchelight : MonoBehaviour
{
  public GameObject TorchLight;
  public GameObject MainFlame;
  public GameObject BaseFlame;
  public GameObject Etincelles;
  public GameObject Fumee;
  public float MaxLightIntensity;
  public float IntensityLight;

  private void Start()
  {
    this.TorchLight.GetComponent<Light>().intensity = this.IntensityLight;
    this.MainFlame.GetComponent<ParticleSystem>().emissionRate = this.IntensityLight * 20f;
    this.BaseFlame.GetComponent<ParticleSystem>().emissionRate = this.IntensityLight * 15f;
    this.Etincelles.GetComponent<ParticleSystem>().emissionRate = this.IntensityLight * 7f;
    this.Fumee.GetComponent<ParticleSystem>().emissionRate = this.IntensityLight * 12f;
  }

  private void Update()
  {
    if ((double) this.IntensityLight < 0.0)
      this.IntensityLight = 0.0f;
    if ((double) this.IntensityLight > (double) this.MaxLightIntensity)
      this.IntensityLight = this.MaxLightIntensity;
    this.TorchLight.GetComponent<Light>().intensity = this.IntensityLight / 2f + Mathf.Lerp(this.IntensityLight - 0.1f, this.IntensityLight + 0.1f, Mathf.Cos(Time.time * 30f));
    this.TorchLight.GetComponent<Light>().color = new Color(Mathf.Min(this.IntensityLight / 1.5f, 1f), Mathf.Min(this.IntensityLight / 2f, 1f), 0.0f);
    this.MainFlame.GetComponent<ParticleSystem>().emissionRate = this.IntensityLight * 20f;
    this.BaseFlame.GetComponent<ParticleSystem>().emissionRate = this.IntensityLight * 15f;
    this.Etincelles.GetComponent<ParticleSystem>().emissionRate = this.IntensityLight * 7f;
    this.Fumee.GetComponent<ParticleSystem>().emissionRate = this.IntensityLight * 12f;
  }
}
