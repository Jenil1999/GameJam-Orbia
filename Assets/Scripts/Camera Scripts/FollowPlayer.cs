using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public float camPos;

    private void Start()
    {

    }


    private void Update()
    {
        transform.position = new Vector3(transform.position.x, Player.transform.position.y + camPos, transform.position.z);
    }

}
