using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image imageComponent;
   
    public FloatData dataObj;
   
    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    public void UpdateImageComponent()
    {
        imageComponent.fillAmount = dataObj.Value;
    }
}