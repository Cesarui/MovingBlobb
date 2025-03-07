using UnityEngine;

public class SpinnyThing : MonoBehaviour
{
    [SerializeField] float speed = 50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = 0f;
        float yAxis = 1f * speed * Time.deltaTime;
        float zAxis = 0f;
        transform.Rotate(xAxis, yAxis, zAxis);
    }
}
