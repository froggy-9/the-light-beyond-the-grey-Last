using UnityEngine;

public class Manager : MonoBehaviour
{
    [field: SerializeField] public TouchReset touchReset { get; private set; }

    public static Manager Instance { set; private get; }
    private void Awake()
    {
        if(Instance ==null)
        {
            Instance = this;
        }
        Destroy(gameObject);
    }
}
