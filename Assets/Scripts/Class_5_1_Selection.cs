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
    public class Class_5_1_Selection : MonoBehaviour
    {
        [SerializeField, Header("是否開門")]
        bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        [SerializeField, Header("武器")]
        private string weapon;

        [SerializeField, Header("血量"), Range(0, 100)]
        private int hp;

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
            // 常用快捷鍵
            // 1. 格式化(排版) Ctrl + K D
            // 2. 程式碼片段 Ctrl + K S 選 region
            #region 判斷式 if
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
            else if (score >= 40)
            {
                Debug.Log("<color=#3f3>你可以補考 C#</color>");
            }
            else if (score >= 20)
            {
                Debug.Log("<color=#3f3>你可以補考，但是要做一個 C# 小專題</color>");
            }
            else
            {
                Debug.Log("<color=#3f3>你的 C# 課程被當了</color>");
            }
            #endregion

            #region 判斷式 switch
            // switch 判斷式
            // switch (要判斷的值) { 陳述式 }
            // 快速完成：switch + Tab * 2
            switch (weapon)
            {
                // 若不同case要輸出相同結果的，可直接疊加
                case "蝴蝶刀":
                case "瑞士刀":
                case "小刀":
                    Debug.Log("<color=#ff3>攻擊力：20</color>");
                    break;
                case "美工刀":
                    Debug.Log("<color=#ff3>攻擊力：5</color>");
                    break;
                case "斷鋼聖劍":
                    Debug.Log("<color=#ff3>攻擊力：999</color>");
                    break;
                default:
                    Debug.Log("<color=#ff3>這是不能使用的武器</color>");
                    break;

            }
            #endregion

            switch (hp)
            {
                case >= 80:
                    Debug.Log("<color=#ff3>血量安全</color>");
                    break;
                case >= 60:
                    Debug.Log("<color=#ff3>健康狀況有狀況</color>");
                    break;
                case >= 40:
                    Debug.Log("<color=#ff3>警告，快喝水</color>");
                    break;
                case >= 10:
                    Debug.Log("<color=#ff3>快死掉了</color>");
                    break;
                default:
                    Debug.Log("<color=#ff3>你已經死了</color>");
                    break;
            }
        }
    }
}
