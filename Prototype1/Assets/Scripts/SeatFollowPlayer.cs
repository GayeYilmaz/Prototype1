using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatFollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-0.25f, 2.12f, -0.29f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
