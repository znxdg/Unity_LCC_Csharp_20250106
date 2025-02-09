using UnityEngine;

namespace YuCheng
{
    public class Practices_5_Selection:MonoBehaviour
    {
        [SerializeField, Header("血量"), Range(0, 100)]
        private int hp;

        private void Update()
        {
            switch (hp)
            {
                case >= 80:
                    Debug.Log("<color=#f3f>血量安全</color>");
                    break;
                case >= 60:
                    Debug.Log("<color=#f3f>健康狀況有狀況</color>");
                    break;
                case >= 40:
                    Debug.Log("<color=#f3f>警告，快喝水</color>");
                    break;
                case >= 10:
                    Debug.Log("<color=#f3f>快死掉了</color>");
                    break;
                case 0:
                    Debug.Log("<color=#f3f>你已經死了</color>");
                    break;
            }
        }
    }
}
