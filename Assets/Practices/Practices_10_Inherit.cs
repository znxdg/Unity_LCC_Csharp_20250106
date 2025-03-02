using UnityEngine;
using YuCheng.Tool;

namespace YuCheng
{
    /// <summary>
    /// 練習_繼承
    /// </summary>
    public class Practices_10_Inherit : MonoBehaviour
    {
        private void Awake()
        {
            var redWater = new Water("補血藥水");
            var blueWater = new Water("補魔藥水");
            Equipment helmet = new Equipment("頭盔");
            redWater.Use();
            blueWater.Use(50);
            helmet.Use();
        }
    }

    public class Item
    {
        public string name;
        public Item(string _name) => name = _name;
        public virtual void Use()
        {
            LogSystem.LogWithColor($"{name} 道具，使用 Item 方法", "#f33");
        }
    }
    public class Water : Item
    {
        public Water(string _name) : base(_name)
        {
        }
        public void Use(int mp)
        {
            LogSystem.LogWithColor($"{name} 藥水，恢復 {mp} 魔力值", "#f33");
        }
    }
    public class Equipment : Item
    {
        public Equipment(string _name) : base(_name)
        {
        }
        public override void Use()
        {
            LogSystem.LogWithColor($"{name} 裝備，使用 Equipment 方法", "#f33");
        }
    }

}
