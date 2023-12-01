using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    [SerializeField] private LayerMask PickupMask;
    [SerializeField] private Camera PlayerCamera;
    [SerializeField] private Transform PickupTarget;
    [Space]
    [SerializeField] private float PickupRange;
    private Rigidbody CurrentObject;
    [SerializeField] private AudioSource soundinteract;
    [SerializeField] private AudioSource soundinteract2;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(CurrentObject)
            {
                CurrentObject.useGravity = true;
                CurrentObject = null;
                return;
            }
            Ray CameraRay = PlayerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if(Physics.Raycast(CameraRay, out RaycastHit HitInfo, PickupRange,PickupMask))
            {
                CurrentObject = HitInfo.rigidbody;
                CurrentObject.useGravity = false;
                if (CurrentObject.CompareTag("Trash"))
                {
                    soundinteract.Play();
                }
                else if(CurrentObject.CompareTag("red") || CurrentObject.CompareTag("green") || CurrentObject.CompareTag("white"))
                {
                    soundinteract2.Play();
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (CurrentObject)
        {
            Vector3 DirectionToPoint = PickupTarget.position - CurrentObject.position;
            float DistanceToPoint = DirectionToPoint.magnitude;

            CurrentObject.velocity = DirectionToPoint * 12f * DistanceToPoint;
        }
    }


}
