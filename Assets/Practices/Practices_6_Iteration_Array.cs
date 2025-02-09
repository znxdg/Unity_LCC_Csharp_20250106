using UnityEngine;

namespace YuCheng
{
    public class Practices_6_Iteration_Array : MonoBehaviour
    {
        private string[,,] character =
        {
            { {"卡比獸","皮卡丘","耿鬼" },{"雷丘", "拉蒂亞斯","快龍" }},
            { {"嫩寶","藍寶","綠水靈"},{"木妖","菇菇寶貝","菇菇仔" }},
            { {"亞宿","阿姆姆","蓋倫"},{"艾希","艾克","凱特琳"}}
        };
        private void Start()
        {
            Debug.Log($"<color=#f39>取得皮卡丘：{character[0, 0, 1]}</color>");
            Debug.Log($"<color=#f39>取得菇菇寶貝：{character[1, 1, 1]}</color>");
            Debug.Log($"<color=#f39>取得蓋倫：{character[2, 0, 2]}</color>");
            Debug.Log($"<color=#f39>取得第二頁第一排第三個：{character[1, 0, 2]}</color>");

        }
    }
}
