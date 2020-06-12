﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
  private Touch touch;

  private Vector2 touchposition;

  private Quaternion rotationY;

  private float rotationspeed = 0.1f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.touchCount > 0)
    {
      touch = Input.GetTouch(0);

      if (touch.phase == TouchPhase.Moved)
      {
        rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotationspeed, 0f);

        transform.rotation = rotationY * transform.rotation;
      }
    }
  }
}
