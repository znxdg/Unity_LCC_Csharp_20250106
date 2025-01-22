using UnityEngine;

namespace YuCheng
{
    /// <summary>
    /// 列舉：enumeration，C# 內關鍵字為簡寫enum
    /// </summary>
    public class Class_5_2_Enumeration : MonoBehaviour
    {
        // 列舉：定義下拉選單的選項(通常都是單選)
        // 語法：
        // 修飾詞 關鍵字 enum 列舉名稱 { 列舉選項 }
        // 定義一個列舉，名稱叫做季節
        // 列舉都是數值，預設從 0 開始
        private enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        // 宣告變數，類型為季節列舉，預設值為夏天
        [SerializeField, Header("季節")]
        private Season season = Season.Summer;

        private void Awake()
        {
            // 取得列舉的值 (Get) 抓出值
            Debug.Log(season);
            // 取得列舉的整數值
            Debug.Log((int)season);
        }
    }
}
