using UnityEngine;
using YuCheng.Tool;

namespace YuCheng.Class_15
{
    /// <summary>
    /// 泛型 Generics
    /// </summary>
    public class Class_15_Generics : MonoBehaviour
    {
        private void Awake()
        {
            int numberA = 7, numberB = 9;
            LogSystem.LogWithColor($"數字 A 與 B : {numberA} | {numberB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogWithColor($"數字 A 與 B : {numberA} | {numberB}", "#f93");

            char charA = '嗨', charB = '嘿';
            LogSystem.LogWithColor($"字元 A 與 B : {charA} | {charB}", "#f93");
            SwapChar(ref charA, ref charB);
            LogSystem.LogWithColor($"字元 A 與 B : {charA} | {charB}", "#f93");

            object objA = '嗨', objB = 7.7f;
            LogSystem.LogWithColor($"物件 A 與 B : {objA} | {objB}", "#f93");
            SwapObject(ref objA, ref objB);
            LogSystem.LogWithColor($"物件 A 與 B : {objA} | {objB}", "#f93");

        }
        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        // ref 前綴 為 同步變數
        public void SwapNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 字元對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapChar(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 物件對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapObject(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }

    }
}
