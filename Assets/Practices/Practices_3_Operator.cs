using UnityEngine;

public class Practices_3_Operator:MonoBehaviour
{
    private void Awake()
    {
        int answer = 6 / 2 * (1 + 2);
        Debug.Log($"<color=red> 6 / 2 * (1 + 2) = {answer}</color>");
    }
}
