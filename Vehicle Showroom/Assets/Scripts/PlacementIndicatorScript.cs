using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;

public class PlacementIndicatorScript : MonoBehaviour
{

  public ARRaycastManager raycastmanager;

  public GameObject visuals;

  // Start is called before the first frame update
  void Start()
  {
    raycastmanager = FindObjectOfType<ARRaycastManager>();

    visuals = transform.GetChild(0).gameObject;

    visuals.SetActive(false);
  }


  private bool IsPointerOverUIObject()
  {
    PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
    eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    var results = new List<RaycastResult>();
    EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
    return results.Count > 0;
  }
  // Update is called once per frame
  void Update()
  {
    raycast();
  }

  public void raycast()
  {
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    raycastmanager.Raycast(new Vector3(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

    if (hits.Count > 0)
    {
      transform.position = hits[0].pose.position;
      transform.rotation = hits[0].pose.rotation;


      if (!visuals.activeInHierarchy)
        visuals.SetActive(true);
    }
  }
}
