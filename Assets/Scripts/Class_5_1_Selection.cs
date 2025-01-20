using UnityEngine;

/* 命名空間：
 * 將類別分類，類似倉庫的概念。不同倉庫可以有相同名稱類別。
 * 語法：namespace 命名空間名稱｛ 內容 ｝
 */
namespace YuCheng
{
    /// <summary>
    /// 選取陳述式 Selection Statement
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class Class_5_1_Selection:MonoBehaviour
    {
        [SerializeField, Header("是否開門")]
        bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;

        private void Awake()
        {
            if (true)
            {
                Debug.Log("當布林值為 True，會執行這裡");
            }
            if (false)
            {
                Debug.Log("當布林值為 False，不會執行這裡而且會有綠蚯蚓");
            }
        }

        // 更新事件：一秒鐘執行約 60 次 (60FPS) ，Unity 預設為 60 fps
        private void Update()
        {
            Debug.Log("<color=#79f>更新事件</color>");
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");
            }
            else
            {
                Debug.Log("<color=#f93>門關了</color>");
            }

            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜你的 C# 課程過了</color>");
            }
            else
            {
                Debug.Log("<color=#3f3>你的 C# 課程被當了</color>");
            }
        }
    }
}
