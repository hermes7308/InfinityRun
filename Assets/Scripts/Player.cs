using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] InputManager inputManager;
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = speed * Time.deltaTime * new Vector3(inputManager.inputVec.x, 0, inputManager.inputVec.y);
        transform.Translate(newPosition);
    }
}
