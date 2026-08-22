using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer = GetComponent<MeshRenderer>();

        myRigidbody.useGravity = false;
        myMeshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            myRigidbody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
}
