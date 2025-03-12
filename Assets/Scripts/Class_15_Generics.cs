﻿using UnityEngine;
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
            #region 不使用泛型
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
            #endregion

            bool boolA = true, boolB = false;
            LogSystem.LogWithColor($"A 與 B : {boolA} | {boolB}", "#9f9");
            Swap<bool>(ref boolA, ref boolB);
            LogSystem.LogWithColor($"A 與 B : {boolA} | {boolB}", "#9f9");

            byte byteA = 1, byteB = 9;
            LogSystem.LogWithColor($"A 與 B : {byteA} | {byteB}", "#9f9");
            Swap<byte>(ref byteA, ref byteB);
            LogSystem.LogWithColor($"A 與 B : {byteA} | {byteB}", "#9f9");

            var player1 = new DataPlayer<int>();
            player1.data = 99;
            player1.LogData(123);

            var player2 = new DataPlayer<string>();
            player2.data = "玩家二號";
            player2.LogData("哈囉");
        }
        #region 方法區域
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

        /// <summary>
        /// 使用泛型進行對調
        /// </summary>
        /// <typeparam name="T">要對調的資料類型</typeparam>
        /// <param name="a">第一個資料</param>
        /// <param name="b">第二個資料</param>
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

        private void Start()
        {
            var player = new Player();
            var enemy = new Enemy();
            var attackEvent = new AttackEvent<Player, Enemy>();
            attackEvent.Attack(player, enemy);

            var hp = new Hp();
            var attack = new Attack();
            hp.Increase(10.5f);
            attack.Increase(50);
            hp.Increase(3.75f);

            var checker = new CheckValue<Hp, float>();
            checker.Check(hp);
        }
    }

    #region 泛型類別
    public class DataPlayer<T>
    {
        public T data;

        public void LogData(T data)
        {
            LogSystem.LogWithColor(data, "#3ff");
        }
    }

    public class Player { }
    public class Enemy { }

    public class AttackEvent<T, U>
    {
        public void Attack(T attacker, U defender)
        {
            LogSystem.LogWithColor($"{attacker} 攻擊 {defender}", "#f3f");
        }
    }
    #endregion


    #region 泛型介面
    // 泛型介面
    public interface IStat<T>
    {
        public T value { get; set; }        // 該狀態的值
        public void Increase(T amount);     // 增加該狀態
    }

    public class Hp : IStat<float>
    {
        public float value { get; set; }
        public void Increase(float amount)
        {
            value += amount;
            LogSystem.LogWithColor($"血量:{value}", "#f3f");
        }
    }

    public class Attack : IStat<int>
    {
        public int value { get; set; }

        public void Increase(int amount)
        {
            value += amount;
            LogSystem.LogWithColor($"血量:{value}", "#f3f");
        }
    } 
    #endregion


    // 泛型約束：泛型 T 必須實作 IStat<U> 介面，才會執行該類別
    public class CheckValue<T, U> where T : IStat<U>
    {
        public void Check(T stat)
        {
            // 添加約束後可以使用 IStat<T> 成員
            LogSystem.LogWithColor($"狀態的值：{stat.value}", "#3d3");
        }
    }
}
