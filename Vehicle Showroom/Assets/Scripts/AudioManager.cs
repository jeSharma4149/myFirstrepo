using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  public AudioSource carmusicaudiocource;

  public bool playpause;

  // Start is called before the first frame update
  void Start()
  {
    carmusicaudiocource = GetComponent<AudioSource>();

    playpause = false;
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void toggleplay()
  {
    if (carmusicaudiocource.isPlaying)
    {
      carmusicaudiocource.Pause();
    }

    else
    {
      carmusicaudiocource.Play();
    }
  }
}