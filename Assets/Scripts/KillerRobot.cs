using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class KillerRobot : MonoBehaviour
{
    [SerializeField] InputManager inputManager;
    [SerializeField] float speed;

    RigBuilder rigBuilder;

    void Awake()
    {
        rigBuilder = GetComponent<RigBuilder>();
    }

    void Update()
    {
        Vector3 forwardPosition = speed * Time.deltaTime * new Vector3(0, 0, inputManager.inputVec.y);
        transform.Translate(forwardPosition);

        Vector3 sidePosition = speed * Time.deltaTime * new Vector3(0, inputManager.inputVec.x * 10, 0);
        transform.Rotate(sidePosition);
    }
}
