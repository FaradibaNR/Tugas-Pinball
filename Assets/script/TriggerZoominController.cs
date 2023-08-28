using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoominCon : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float length;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.FollowAtTarget(bola.transform, length);
        }
    }
}
