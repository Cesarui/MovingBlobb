using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField]float speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveAround();
    }
    void MoveAround()
    {
        float xAxis = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yAxis = 0f;
        float zAxis = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xAxis, yAxis, zAxis);
    }

}
