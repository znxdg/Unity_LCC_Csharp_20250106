﻿using UnityEngine;

namespace YuCheng
{
    /// <summary>
    /// 結構 struct
    /// </summary>
    public class Class_8_2_Struct : MonoBehaviour
    {
        private void Awake()
        {
            Class_8_2_PlayerData player1 = new Class_8_2_PlayerData(2, 30);
            Class_8_2_PlayerData player2 = new Class_8_2_PlayerData(5, 100);
        }
    }

}
