using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGamePlay : MonoBehaviour
{

  public static CameraGamePlay instancia; 
  public Camera minhaCamera;

  void Awake(){
      instancia = this;
  }

}
