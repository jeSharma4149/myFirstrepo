using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ImageCollectionScripts : MonoBehaviour
{

  private Image image;

  public Sprite[] spriteimage;

  // Start is called before the first frame update
  void Start()
  {
    image = GetComponent<Image>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void carmodel1pressed()
  {
    image.sprite = spriteimage[0];
  }

  public void carmodel2pressed()
  {
    image.sprite = spriteimage[1];
  }

  public void carmodel3pressed()
  {
    image.sprite = spriteimage[2];
  }
}
