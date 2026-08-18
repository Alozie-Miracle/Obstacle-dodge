using UnityEngine;

public class ObjectGit : MonoBehaviour
{
    // collison is the player
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
