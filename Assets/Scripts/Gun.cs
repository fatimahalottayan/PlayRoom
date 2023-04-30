using System.Collections;
using System.Collections.Generic;
using UltimateXR.Core.Components.Composite;
using UltimateXR.Manipulation;
using UnityEngine;

public class Gun : UxrGrabbableObjectComponent<Gun>
{
   [SerializeField]  ParticleSystem Water;


    void Update()
    {
      if (UxrGrabManager.Instance.IsBeingGrabbed(GrabbableObject))
        {
          Water.Play();
        }
    }
}
