using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;

public class ObjectRotationandScaling : MonoBehaviour
{
  public GameObject selectedobject;

  public float rotationspeed = 20f;

 // private float rotationspeed = 0.1f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    //objectscaling();
    // mousedragging();

    ontouchrotation();
  }

  /*public void objectscaling()
  {
    if (Input.touchCount == 2)
    {
      Touch touchzero = Input.GetTouch(0);
      Touch touchone = Input.GetTouch(1);

      // it will find the touch position of each Touch Count in every frame

      Vector2 touchzeroprevpos = touchzero.position - touchzero.deltaPosition;
      Vector2 touchoneprevpos = touchone.position - touchone.deltaPosition;

      // finding the magnitude of the touch position

      float prevposedeltamag = touchzeroprevpos.magnitude - touchoneprevpos.magnitude;
      float touchdeltamag = touchzero.position.magnitude - touchone.position.magnitude;

      float deltadiffmag = prevposedeltamag - touchdeltamag;

      selectedobject.transform.localScale = new Vector3(deltadiffmag , deltadiffmag , deltadiffmag );
    }
  }*/

  public void mousedragging()
  {
    float Xaxisrotation = Input.GetAxis("Mouse X") * rotationspeed;
    float Yaxisrotation = Input.GetAxis("Mouse Y") * rotationspeed;

    transform.RotateAround(Vector3.down, Xaxisrotation);
    //transform.RotateAround(Vector3.right, Yaxisrotation);
  }

  public void ontouchrotation()
  {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
    {
      mousedragging();
    }
  }


  //public void objectrotation()
  //{
  //  if (touchcontroller.objectrotation == true)
  //  {
  //    if (input.touchcount == 0)
  //    {
  //      touch touch = input.gettouch(0);

  //      if (touch.phase == touchphase.moved)
  //      {
  //        quaternion rotateony = quaternion.euler(0f, -touch.deltaposition.x * rotationspeed, 0f);

  //        transform.rotation = rotateony * transform.rotation;
  //      }
  //    }
  //  }
  //}


  //public void objrotatnontouch()
  //{
  //  if (Input.touchCount > 0)
  //  {
  //    Touch touchzero = Input.GetTouch(0);

  //    Vector2 touchzerodeltapos = touchzero.position - touchzero.deltaPosition;

  //    float touchzerodiffpos = touchzerodeltapos.magnitude - touchzero.position.magnitude;

  //    if (Input.GetTouch(0).phase == TouchPhase.Moved)
  //    {
  //      selectedobject.transform.localRotation = Quaternion.Euler(0f, touchzerodiffpos * rotationspeed, 0f);
  //    }
  //  }
  //}
}
