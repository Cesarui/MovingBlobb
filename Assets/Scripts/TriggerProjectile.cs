using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject P1;
    [SerializeField] GameObject P2;
    [SerializeField] GameObject P3;
    [SerializeField] GameObject P4;
    [SerializeField] GameObject P5;
    [SerializeField] GameObject P6;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            P1.SetActive(true);
            P2.SetActive(true);
            P3.SetActive(true);
            P4.SetActive(true);
            P5.SetActive(true);
            P6.SetActive(true);
            Destroy(gameObject);
        }
    }
}
