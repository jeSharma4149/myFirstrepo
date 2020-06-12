using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectCollectionSets : MonoBehaviour
{
  public GameObject[] Cars;

  public GameObject[] Bikes;

  public GameObject[] Bicycles;

  public PlacementIndicatorScript placementIndicatorScript;

  private bool isobjectplaced;

  public UIManager UIManager;


  // Start is called before the first frame update
  void Start()
  {
    placementIndicatorScript = FindObjectOfType<PlacementIndicatorScript>();

    UIManager = FindObjectOfType<UIManager>();

    isobjectplaced = false;
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
    UpdatePlacementIndicator();
  }

  public void UpdatePlacementIndicator()
  {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !isobjectplaced)
    {
      placementIndicatorScript.visuals = Instantiate(UIManager.CurrentGameObject, placementIndicatorScript.visuals.transform.position, placementIndicatorScript.visuals.transform.rotation);
      isobjectplaced = true;
      placementIndicatorScript.visuals.SetActive(false);
    }
  }
}
