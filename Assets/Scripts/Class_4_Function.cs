using System.Globalization;
using UnityEngine;
using static UnityEditor.Progress;

/// <summary>
/// 方法
/// 中文：方法、函式、函數、功能
/// 英文：function、method (Unity)
/// </summary>

public class Class_4_Function : MonoBehaviour
{
    // 框選要整理的程式 > Ctrl + K S > #region 快速完成程式碼片段
    private void Awake()
    {
        #region 方法基本語法與參數呼叫
        // 呼叫方法：方法沒有呼叫不會執行
        // 方法名稱();
        FirstFunction();
        FirstFunction();
        // 呼叫有參數的方法：小括號內要放數引數
        UseSkill("火球術", 30);
        UseSkill("冰封術", 50);
        // 呼叫有預設值參數的方法：可以不用填(選填式參數)
        SpawnEnemy();
        SpawnEnemy("史萊姆");

        Fire(700);
        Fire(800, "保齡球");
        // 有多個選擇性參數時的呼叫
        BuyItem();
        // 買紅水，30個【第一個為預設參數，第二個為自訂參數的寫法】
        BuyItem(count: 30);
        BuyItem("藍水");
        BuyItem("藍水", 100);
        #endregion

        #region 傳回方法呼叫
        /*呼叫 有傳回方法
         * 第一種：把結果放到區域變數內
         * 第二種：把傳回方法當作傳回類型使用
         */
        //第一種
        int number9 = Square(9);
        Debug.Log($"<color=#a33>9 的平方 {number9}</color>");
        //第二種
        Debug.Log($"<color=#a33>7 的平方 {Square(7)}</color>");
        #endregion

        #region 方法課間練習呼叫
        Debug.Log($"<color=#6f3>KID 的 BMI:{BMI(60, 168)}</color>");
        Debug.Log($"<color=#6f3>TEST_BMI:{BMI(80, 185)}</color>");
        #endregion

        #region 多載方法呼叫
        Move();
        Move(50.5f);
        #endregion
    }
    #region =方法基本語法與參數=

    /* 方法：
    * 包含一系列程式語言
    * 方法語法：
    * 修飾詞 傳回資料類型 方法名稱 (參數1, 參數2, ...,參數N) { 程式區塊 }
    * 方法命名習慣：Unity 習慣使用大寫開頭命名方法
    * void 無傳回：使用此方法不會有傳回資料
    */
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }

    // 參數語法：與區域變數相同 資料類型 參數名稱(習慣用小寫或者加底線開頭)
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>施放技能：{skill}</color>");
        Debug.Log($"<color=#f93>技能消耗：{cost} MP</color>");
    }
    private void SpawnEnemy(string enemy = "哥布林")
    {
        Debug.Log($"<color=#f33>施放技能：{enemy}</color>");
    }

    // 沒有預設值稱為：必要參數，有預設值稱為選擇性參數
    //選擇性參數要寫在右邊
    /// <summary>
    /// 發射物件方法
    /// </summary>
    /// <param name="speed">發射速度</param>
    /// <param name="fire">要發射的物件</param>
    private void Fire(int speed, string fire = "子彈")
    {
        Debug.Log($"<color=#66f>發射物件：{fire}，速度：{speed}</color>");
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="item">道具名稱</param>
    /// <param name="count">道具數量</param>
    private void BuyItem(string item = "紅水", int count = 50)
    {
        Debug.Log($"<color=#3f3>購買商品：{item}，數量：{count}</color>");
    }
    #endregion

    #region =傳回方法=
    /* 傳回方法：傳回類型不是void，呼叫該方法會獲得結果
 * 傳回方法必須在 {} 內使用 return 關鍵字將結果傳回
 */
    private int Square(int number)
    {
        return number * number;
    }
    private float SquareFloat(float number)
    {
        return number * number;
    }
    #endregion

    #region =方法課間練習=(BMI計算)
    /// <summary>
    /// BMI計算
    /// </summary>
    /// <param name="weight">體重(單位 kg)</param>
    /// <param name="high">身高(單位 cm)</param>
    /// <returns></returns>
    private float BMI(float weight, float cmHigh)
    {
        float mHigh = cmHigh / 100;  // 轉換身高單位 【cm > m】
        return weight / SquareFloat(mHigh);
    }
    #endregion

    #region =方法的多載(function overload)=
    // 方法名稱、類別、變數 不能完全重複
    // 零個參數
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        Debug.Log("<color=#19f>移動中</color>");
    }
    // 一個參數
    /// <summary>
    /// 移動方法並指定速度
    /// </summary>
    /// <param name="speed">移動速度</param>
    private void Move(float speed)
    {
        Debug.Log($"<color=#19f>移動中，速度:{speed}</color>");
    }
    #endregion
}
