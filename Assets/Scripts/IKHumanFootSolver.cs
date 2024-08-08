using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKHumanFootSolver : MonoBehaviour
{
    [SerializeField] LayerMask terrainLayer = default;
    [SerializeField] Transform body = default;
    [SerializeField] IKHumanFootSolver otherFoot = default;
    [SerializeField] float speed = 1;
    [SerializeField] float stepDistance = 4;
    [SerializeField] float stepLength = 4;
    [SerializeField] float stepHeight = 1;
    [SerializeField] Vector3 footOffset = default;
    float footSpacing;
    Vector3 oldPosition, currentPosition, newPosition;
    Vector3 oldNormal, currentNormal, newNormal;
    float lerp;

    private void Start()
    {
        footSpacing = transform.localPosition.x;
        currentPosition = newPosition = oldPosition = transform.position;
        currentNormal = newNormal = oldNormal = transform.up;
        lerp = 1;
    }

    void Update()
    {
        // transform.position = currentPosition;
        // transform.up = currentNormal;

        // 골반정도 위치: body.position + (body.right * footSpacing)
        // Ray ray = new(body.position + (body.right * footSpacing), Vector3.down);
        // if (Physics.Raycast(ray, out RaycastHit info, 10, terrainLayer.value))
        // {
        // }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        // Gizmos.DrawSphere(newPosition, 0.2f);
    }

    public bool IsMoving()
    {
        return lerp < 1;
    }
}
