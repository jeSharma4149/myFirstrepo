using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
  public ObjectCollectionSets ObjectCollectionSets;

  public GameObject CurrentGameObject;

  // Start is called before the first frame update
  void Start()
  {
    ObjectCollectionSets = FindObjectOfType<ObjectCollectionSets>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void CarButton1Pressed()
  {
    if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
    {
      CurrentGameObject = ObjectCollectionSets.Cars[0];
    }

  }

  public void CarButton2Pressed()
  {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
    {
      CurrentGameObject = ObjectCollectionSets.Cars[1];
    }

  }

  public void CarButton3Pressed()
  {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
    {
      CurrentGameObject = ObjectCollectionSets.Cars[2];
    }

  }

  public void CycleButton1Pressed()
  {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
    {
      CurrentGameObject = ObjectCollectionSets.Cars[0];
    }

  }

  public void CycleButton2Pressed()
  {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
    {
      CurrentGameObject = ObjectCollectionSets.Cars[1];
    }

  }

  public void CycleButton3Pressed()
  {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
    {
      CurrentGameObject = ObjectCollectionSets.Cars[2];
    }

  }
}
     