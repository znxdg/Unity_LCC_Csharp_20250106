using UnityEngine;

/// <summary>
/// 課程3：運算子
/// 補充：Unity 欄位屬性、 Unity 事件
/// </summary>

public class Class_3_Operator : MonoBehaviour
{
    #region =基本欄位屬性= 
    // [標題(標題文字)]：在屬性面板上顯示標題文字
    [Header("等級")]
    public int lv = 1;
    // [提示(提示文字)]：在屬性面板，滑鼠停留在變數上時顯示
    [Tooltip("這是角色的移動速度，不建議超過 100。")]
    public float moveSpeed = 2.5f;
    // [範圍(最小值, 最大值)]：幫數值類型添加範圍(面板上改為滑桿)
    // 範圍不能使用在非數值類型上，會顯示"Use Range With..."
    [Range(1, 100)]
    public byte count = 10;
    [Range(1, 100)]
    public string weapon = "匕首";
     // 可通過一次性宣告多個變數，來讓所有同時宣告的變數都有相關效果
    [TextArea(2, 5)]
    public string itemDescription = "這裡是道具描述", memberDescription = "這裡是角色描述";

    // 多個欄位屬性
    [Header("血量")][Range(0, 999)]
    public int hp = 100;
    [Header("攻擊力"), Range(0, 100)]
    public float attack = 30.5f;
    // [在屬性面板中隱藏]：將公開變數隱藏
    [HideInInspector]
    public string password = "我是密碼";
    // [在屬性面板中顯示]：將私人變數顯示
    [SerializeField]
    private float mp = 500;
    #endregion
    //快捷鍵：快速搬移程式(Alt + 上下箭頭)
    /* 使用 Unity 事件
     * 1. 必須在腳本後面添加：MonoBehaviour (繼承)
     * 2. 使用關鍵字快速完成，例如：輸入 Awake 挑選要使用的事件按 Enter
     * >> 喚醒事件(Awake)：播放遊戲後會執行的第一個事件，只執行一次
     * >> 事件名稱是藍色的 (沒有變色不影響)
     */
    private void Awake()
    {
        #region =輸出訊息=
        // 將小括號內的訊息輸出到 Unity 的 Console 控制台面板
        // Shift + Ctrl + C 開啟控制台面板
        Debug.Log("Hello World！");                      // 輸出文字
        Debug.Log(hp);                                   // 輸出變數的值
        Debug.Log("攻擊力" + attack);                     // 字串與變數 
        Debug.Log($"血量: {hp} ； 攻擊力: {attack}");     // $字串格式

        Debug.Log("<b>粗體</b>");
        Debug.Log("<color=blue>藍色</color>");
        // 色碼：#紅紅綠綠藍藍，數值：0 ~ 9，a ~ f，越右邊顏色越亮 #000 黑 #fff 白
        Debug.Log("<color=#ff00ff>紫色</color>");
        Debug.Log("<color=#f0f>紫色</color>");
        #endregion

        #region =算數運算子=
        /* 運算子：
         * 1. 算術運算子
         * >> 加、減、乘、除、餘
         * >> + 、 - 、 * 、 / 、 %
         */
        Debug.Log("<color=#f93>--- 算數運算子 ---</color>");
        Debug.Log(10 + 3);  // 13
        Debug.Log(10 - 3);  // 7
        Debug.Log(10 * 3);  // 30
        Debug.Log(10 / 3);  // 3 非宣告float，則不會有小數點
        Debug.Log(10 % 3);  // 10/3 = 3 餘 1，輸出為 1

        Debug.Log("<color=#f93>--- 算數運算子:區域變數 ---</color>");
        float numberA = 10;
        float numberB = 3;

        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB); // 3.333
        Debug.Log(numberA % numberB);
        #endregion

        #region =邏輯運算子=
        Debug.Log("<color=#f93>--- 算數運算子:區域變數 ---</color>");
        // 比較運算子，使用後會得到布林值
        int numberC = 30, numberD = 79;

        Debug.Log(numberC > numberD);       // C 大於 D,     False
        Debug.Log(numberC < numberD);       // C 小於 D,     True
        Debug.Log(numberC >= numberD);      // C 大於等於 D,  False
        Debug.Log(numberC <= numberD);      // C 小於等於 D,  True
        Debug.Log(numberC == numberD);      // C 等於 D,      False
        Debug.Log(numberC != numberD);      // C 不等於 D,    True
        #endregion
    }
}
