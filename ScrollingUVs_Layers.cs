using UnityEngine;

public class ScrollingUVs_Layers : MonoBehaviour
{
  public Vector2 uvAnimationRate = new Vector2(1f, 0.0f);
  public string textureName = "_MainTex";
  private Vector2 uvOffset = Vector2.zero;

  private void LateUpdate()
  {
    this.uvOffset += this.uvAnimationRate * Time.deltaTime;
    if (!this.GetComponent<Renderer>().enabled)
      return;
    this.GetComponent<Renderer>().sharedMaterial.SetTextureOffset(this.textureName, this.uvOffset);
  }
}
