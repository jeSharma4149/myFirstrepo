using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnotationControllers : MonoBehaviour
{
  public GameObject annotationscanvas;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void toggleannotations()
  {

    if (annotationscanvas.activeInHierarchy)
    {
      annotationscanvas.SetActive(false);
      Debug.Log("Annotations is false");
    }

    else
    {
      annotationscanvas.SetActive(true);
      Debug.Log("Annotations is true");
    }
  }
}
