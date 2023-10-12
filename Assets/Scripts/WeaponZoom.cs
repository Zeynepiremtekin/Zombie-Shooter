using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vcam;
    [SerializeField] StarterAssets.FirstPersonController fpsController;

    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = .5f;

    bool zoomedInToggle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false) 
            {
                zoomedInToggle = true;
                vcam.m_Lens.FieldOfView = zoomedInFOV;
                fpsController.RotationSpeed = zoomInSensitivity;
            }
            else
            {
                zoomedInToggle = false;
                vcam.m_Lens.FieldOfView = zoomedOutFOV;
                fpsController.RotationSpeed = zoomOutSensitivity;
            }
        }
    }
}
