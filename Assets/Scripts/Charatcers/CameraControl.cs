using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GTA.CameraController
{
  public class CameraControl : MonoBehaviour
  {
    public int rotateSpeed = 250;

    void Update()
    {
      if (Input.GetAxis("Mouse X") < 0)
      {
        transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
      }
      if (Input.GetAxis("Mouse X") > 0)
      {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
      }
    }
  }
}
