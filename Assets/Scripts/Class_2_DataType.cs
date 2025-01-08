using UnityEngine;

// 三斜線是摘要(XML 語言)用來做簡短說明，可加在類別與變數上方
/// <summary>
/// 認識 C# 資料類型
/// </summary>
public class Class_2_DataType : MonoBehaviour
{
    /*變數語法：
     *  修飾詞 資料類型 變數名稱 指定 預設值;
     *四大常用資料類型：
     *  整數(int)：儲存沒有小數點的數值
     *  浮點數(float)：儲存有小數點的數值，數值須加上後綴 f
     *  字串(string)：儲存文字，必須用雙引號
     *  布林值(bool)：儲存正(true)與反(false)
     */
    public int count = 7;

    //float後綴的f 大小寫皆可
    public float moveSpeed = 3.5f;
    public float turnSpeed = 30.7F; 

    public string character = "小游飯";

    public bool isDead = false;
    public bool gameOver = true;

    public byte lv = 16;
    public uint coin = 9999;
    public long items = 3000;

    public string playerName = "小游";
    public char a = 'a';

    //public sbyte number = 128; //溢位
}
