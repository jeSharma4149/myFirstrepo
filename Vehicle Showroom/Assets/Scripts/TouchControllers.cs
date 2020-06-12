using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARSubsystems;


public class TouchControllers : MonoBehaviour
{
  private ARSessionOrigin arsessionorigin;

  private ARRaycastManager raycastmanager;

  public GameObject objecttobespawned;

  List<ARRaycastHit> raycasthit;

  public Pose pose;

  public bool isdragging;

  public GameObject placementindicator;

  private bool PlacementPoseIsValid = false;

  private CollectionManager CollectionManager;


  // Start is called before the first frame update
  void Start()
  {
    objecttobespawned = null;

    raycastmanager = GetComponent<ARRaycastManager>();

    raycasthit = new List<ARRaycastHit>();

    isdragging = true;

    arsessionorigin = FindObjectOfType<ARSessionOrigin>();
  }

  // Update is called once per frame
  void Update()
  {

    touchinput();
  }

  public void ObjectPlaced()
  {
    if (Input.touchCount > 0)
    {
      Touch touch = Input.GetTouch(0);

      if (PlacementPoseIsValid && Input.GetTouch(0).phase == TouchPhase.Ended && isdragging)
      {
        objecttobespawned = Instantiate(CollectionManager.currentobjects, placementindicator.transform.position, placementindicator.transform.rotation);

        isdragging = false;
      }
    }
  }

  public void touchinput()
  {
    if (Input.touchCount > 0)
    {
      Touch touch = Input.GetTouch(0);

      if (PlacementPoseIsValid && Input.GetTouch(0).phase == TouchPhase.Ended && isdragging == true)
      {
        Instantiate(objecttobespawned, placementindicator.transform.position, placementindicator.transform.rotation);

        isdragging = false;
      }
    }
  }

  private bool IsPointerOverUIObject()
  {
    PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
    eventDataCurrentPosition.position = new
    Vector2(Input.mousePosition.x, Input.mousePosition.y);
    var results = new List<RaycastResult>();
    EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
    return results.Count > 0;

  }
}

