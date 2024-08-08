using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDetector : MonoBehaviour
{
    [SerializeField] Vector3 lastPosition;
    [SerializeField] Quaternion lastRotation;
    [SerializeField] float lastUpdatedTime;

    [SerializeField] Vector3 currentPosition;
    [SerializeField] Quaternion currentRotation;
    [SerializeField] float currentUpdatedTime;

    [SerializeField] float checkingTime = 1f;

    void Update()
    {
        currentPosition = transform.position;
        currentRotation = transform.rotation;
        currentUpdatedTime += Time.deltaTime;

        if (currentUpdatedTime - lastUpdatedTime < checkingTime)
        {
            return;
        }
        lastUpdatedTime = currentUpdatedTime;

        if (lastPosition == currentPosition && lastRotation == currentRotation)
        {
            return;
        }

        lastPosition = currentPosition;
        lastRotation = currentRotation;
    }

    private void OnEnable()
    {
        lastPosition = currentPosition = transform.position;
        lastRotation = currentRotation = transform.rotation;
        lastUpdatedTime = currentUpdatedTime = 0f;
    }

    public bool IsMoving()
    {
        return !(lastPosition == currentPosition && lastRotation == currentRotation);
    }
}
