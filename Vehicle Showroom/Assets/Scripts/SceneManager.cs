using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

  // Start is called before the first frame update

  public void Update()
  {

  }

  public void Loadscene(int levels)
  {
   // Application.LoadLevel(sceneindex);

    Application.LoadLevel(levels);
  }
}
