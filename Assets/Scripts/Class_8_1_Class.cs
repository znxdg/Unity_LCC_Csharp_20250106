using UnityEngine;

namespace YuCheng
{
    /// <summary>
    /// 類別 Class：
    /// 用來定義一個物件以及他所擁有的資料與功能(成員)
    /// </summary>
    public class Class_8_1_Class:MonoBehaviour
    {
        private void Awake()
        {
            // 實力化 NPC 並儲存在npcJack 變數內
            Class_8_1_NPC npcJack = new Class_8_1_NPC(); 
            Class_8_1_NPC npcYuCheng = new Class_8_1_NPC("YuCheng");

            npcJack.LogName();
            npcYuCheng.LogName();
        }
    }

}
