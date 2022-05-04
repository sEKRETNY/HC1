using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.position = GameObject.FindWithTag("Player").transform.position / 2;
    }
}