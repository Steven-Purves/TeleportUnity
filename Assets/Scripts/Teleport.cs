using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {


    public Transform player;
    public Transform reciever;

   

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            float dot = Vector3.Dot(transform.forward, (player.position - transform.position).normalized);


            if (dot < 0f)
            {
                float rotationDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 portalToPlayer = player.position - transform.position;

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = reciever.position + positionOffset;
            
            }
        }
    }

}
