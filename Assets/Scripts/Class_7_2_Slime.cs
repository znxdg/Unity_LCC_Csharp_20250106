﻿using UnityEngine;

namespace YuCheng
{
    /// <summary>
    /// 史萊姆
    /// </summary>
    public class Class_7_2_Slime : MonoBehaviour
    {
        // 非靜態成員是每個物件各別擁有
        public float hp = 100;

        // 靜態成員是該類別共同擁有
        public static float moveSpeed = 1.5f;
    }

}
