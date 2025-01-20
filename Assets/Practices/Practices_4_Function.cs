using UnityEngine;

public class Practices_4_Function:MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"<color=red> {ReturnTrue()}</color>");
        Debug.Log($"<color=blue> {ReturnFalse()}</color>");
    }
    private bool ReturnTrue()
    {
        return true;
    }
    
    private bool ReturnFalse()
    {
        return false;
    }
}
