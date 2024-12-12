using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformMovement : MonoBehaviour
{
    private Vector3 startPosition;
    public float moveSpeed = 2f;
    public float moveRange = 2f;

    // Toggles for movement
    public bool moveX = true;
    public bool moveY = false;
    public bool moveZ = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float x = moveX ? Mathf.Sin(Time.time * moveSpeed) * moveRange : 0f;
        float y = moveY ? Mathf.Abs(Mathf.Sin(Time.time * moveSpeed)) * moveRange : 0f;
        float z = moveZ ? Mathf.Sin(Time.time * moveSpeed) * moveRange : 0f;

        transform.position = startPosition + new Vector3(x, y, z);
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         Transform playerRootTransform = other.transform.root;

    //         Debug.Log("Parenting Player to Platform");
    //         playerRootTransform.SetParent(transform);
    //     }
    // }

    // private void OnTriggerExit(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         Transform playerRootTransform = other.transform.root;

    //         Debug.Log("Unparenting Player from Platform");
    //         playerRootTransform.SetParent(null, true);
    //     }
    // }
}