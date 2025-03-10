using UnityEngine;
using YuCheng.Tool;

namespace YuCheng.Class_15
{
    /// <summary>
    /// 介面物件:實作介面的物件
    /// </summary>
    public class Class_15_InterfaceObject
    {

    }

    // 介面的使用步驟
    // 1. 定義介面與介面成員
    // 2. 類別實作介面
    // 3. 實作介面成員

    // 步驟 1.
    // 帶有「使用」功能的介面，遊戲內可被使用的物品
    // 介面命名習慣會使用 I 當前綴
    public interface IUse
    {
        // 不用宣告方法主體，不用寫大括號
        public void Use();
    }

    public interface IDestory
    {
        public void Destory();
    }

    // 步驟 2.
    // C# 單一繼承，多重實作介面
    public class Weapon : IUse
    {
        // 步驟 3.
        public void Use()
        {
            LogSystem.LogWithColor("使用武器，施展武器技能", "#fa3");
        }
    }

    public class Potion : IUse, IDestory
    {
        public void Destory()
        {
            LogSystem.LogWithColor("藥水使用完畢，刪除", "#f11");
        }

        public void Use()
        {
            LogSystem.LogWithColor("使用藥水，恢復體力", "#fa3");
        }
    }

    public class Chest : IUse, IDestory
    {
        public void Destory()
        {
            LogSystem.LogWithColor("寶箱使用完畢，刪除", "#f11");
        }

        public void Use()
        {
            LogSystem.LogWithColor("使用寶箱，獲得隨機道具", "#fa3");
        }
    }
}
