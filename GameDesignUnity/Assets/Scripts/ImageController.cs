using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image _imageComponent;

    private void Start()
    {
        _imageComponent.GetComponent<Image>();
     
    }

    public void UpdateImageComponent(float amount)
    {
        _imageComponent.fillAmount += amount;
    }

    public void UpdateImageComponent(FloatdataValue dataobj)
    {
        _imageComponent.fillAmount = dataobj.Value;
    }
}