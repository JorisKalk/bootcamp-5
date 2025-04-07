using UnityEngine;

public class ActivatePlate : MonoBehaviour
{
    public bool isActived = false;

    [SerializeField] private GameObject target;
    [SerializeField] private bool shouldDestroy = true;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (isActived && shouldDestroy)
        {
            target.SetActive(false);
        }
        else if (isActived && !shouldDestroy)
        {
            target.SetActive(true);
        }
    }
}
