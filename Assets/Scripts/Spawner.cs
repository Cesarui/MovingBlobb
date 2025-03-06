using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject myProjectiles;

    public void ProjectileInstantiate()
    {
        Instantiate(myProjectiles);
    }
}
