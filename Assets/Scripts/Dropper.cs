using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    MeshRenderer myMR;
    Rigidbody myRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMR = GetComponent<MeshRenderer>();
        myRB = GetComponent<Rigidbody>();
        myRB.useGravity = false;
        myMR.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            myRB.useGravity = true;
            myMR.enabled = true;
        }
    }
}
