using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotating : MonoBehaviour
{
  public GameObject cubetorotate;

  [SerializeField] float cuberotatespeed = 1f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    ontouchrotate();

  }

  //public void OnMouseDrag()
  //{

  //  float cubetoberotateon_Yaxis = Input.GetAxis(" Mouse X ") * cuberotatespeed * Mathf.Deg2Rad;

  //  transform.RotateAround(Vector3.up, -cuberotatespeed * Time.deltaTime);
  //}

  public void ontouchrotate()
  {
    if (Input.touchCount > 0)
    {
      Touch touch = Input.GetTouch(0);

      if ((Input.touchCount == 0) && Input.GetTouch(0).phase == TouchPhase.Moved)
      {
        Vector2 touchdeltaposition = touch.position - Input.GetTouch(0).deltaPosition;

        float touchdeltapositionmag = touchdeltaposition.magnitude - touch.position.magnitude;
        
      }
    }
  }
}
