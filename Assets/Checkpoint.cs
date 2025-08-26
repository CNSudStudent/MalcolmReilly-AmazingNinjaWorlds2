using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject background;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 newCheckpoint = transform.position;
        background.GetComponent<GameManager>().checkPoint = newCheckpoint;
    }
}
