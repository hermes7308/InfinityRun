using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerRobot : MonoBehaviour
{
    [SerializeField] InputManager inputManager;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 newPosition = speed * Time.deltaTime * new Vector3(inputManager.inputVec.x, 0, inputManager.inputVec.y);
        transform.Translate(newPosition);
    }
}
