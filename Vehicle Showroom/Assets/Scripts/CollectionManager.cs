using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionManager : MonoBehaviour
{
  public TouchControllers touchcontroller;

  public GameObject[] carscollection;

  public GameObject currentobjects;

  public Image image;

  public Sprite[] spritesimage;


  public void Start()
  {
    currentobjects = null;

    image = GetComponent<Image>();
  }
  public void Car1ButtonImageAssign()
  {
    image.sprite = spritesimage[0];

    currentobjects = Instantiate(carscollection[0], touchcontroller.pose.position, touchcontroller.pose.rotation);
    currentobjects.SetActive(false);

    if (currentobjects != null && (image.sprite = spritesimage[0]))
    {
      touchcontroller.objecttobespawned = currentobjects;
      touchcontroller.objecttobespawned.SetActive(true);
    }
    //carscollection[1].SetActive(false);
    //carscollection[2].SetActive(false);
    //carscollection[3].SetActive(false);
    //carscollection[4].SetActive(false);

    Debug.Log(" Car 1 Is Appeared ");
  }

  public void OnCar2ButtonPressed()
  {
    touchcontroller.objecttobespawned = Instantiate(carscollection[1], touchcontroller.pose.position, touchcontroller.pose.rotation);

    //carscollection[0].SetActive(false);
    carscollection[1].SetActive(true);
    //carscollection[2].SetActive(false);
    //carscollection[3].SetActive(false);
    //carscollection[4].SetActive(false);

    Debug.Log(" Car 2 Appeared ");
  }

  public void OnCar3ButtonPressed()
  {
    touchcontroller.objecttobespawned = Instantiate(carscollection[2], touchcontroller.pose.position, touchcontroller.pose.rotation);

    //carscollection[0].SetActive(false);
    //carscollection[1].SetActive(false);
    carscollection[2].SetActive(true);
    //carscollection[3].SetActive(false);
    //carscollection[4].SetActive(false);

    Debug.Log(" Car 3 Appeared ");
  }

  public void OnCar4ButtonPressed()
  {
    touchcontroller.objecttobespawned = Instantiate(carscollection[3], touchcontroller.pose.position, touchcontroller.pose.rotation);

    //carscollection[0].SetActive(false);
    //carscollection[1].SetActive(false);
    //carscollection[2].SetActive(false);
    //carscollection[3].SetActive(true);
    //carscollection[4].SetActive(false);

    Debug.Log(" Car 4 Appeared ");
  }

  public void OnCar5ButtonPressed()
  {
    touchcontroller.objecttobespawned = Instantiate(carscollection[4], touchcontroller.pose.position, touchcontroller.pose.rotation);

    //carscollection[0].SetActive(false);
    //carscollection[1].SetActive(false);
    //carscollection[2].SetActive(false);
    //carscollection[3].SetActive(false);
    //carscollection[4].SetActive(true);

    Debug.Log(" Car 5 Appeared ");
  }
}
