﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class move : MonoBehaviour
{

    public float speed =2f;
 
  void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime *speed);
    }

   

}
