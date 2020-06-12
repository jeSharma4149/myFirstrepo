using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameboject : MonoBehaviour
{
  public UIManager UIManager;

  // Start is called before the first frame update
  void Start()
  {
    UIManager = FindObjectOfType<UIManager>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void DestroyCurrentGameObject()
  {
    Destroy(UIManager.CurrentGameObject);
  }
}
