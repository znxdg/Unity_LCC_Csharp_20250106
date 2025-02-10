using UnityEngine;

namespace YuCheng
{
    /// <summary>
    ///  陣列 Array
    /// </summary>

    public class Class_6_2_Array : MonoBehaviour
    {
        #region 宣告一~三陣列
        // 一維陣列：用來儲存多筆相同類型的資料
        // 修飾詞 資料類型[] 陣列名稱;
        // 第一種：不指定值，通過 Unity 面板輸入
        public string[] cards;
        // 第二種：直接定義陣列的數量
        // 定義一個牌組1，可以放五張卡牌
        public string[] deck1 = new string[5];
        // 第三種：直接定義陣列的值
        public string[] deck2 = { "急凍鳥", "賭霞", "寶石海星" };

        // 二維陣列
        public string[,] inventory = { { "紅色藥水", "藍色藥水" }, { "炸彈", "金幣" } };

        // 三維陣列
        public string[,,] shop =
        {
            // 第一頁
            { { "小刀", "美工刀" }, { "武士刀", "屠龍刀" } },
            // 第二頁
            { { "精靈球", "高級球" }, {"大師球", "巢穴球"} }
        };
        #endregion

        private int[][] numbers = new int[2][];

        private int[][,] count = new int[2][,];

        private void Start()
        {
            #region 一維陣列
            // 存取一維陣列 Set、Get
            // 1. Get 取得陣列的資料
            // 陣列名稱[編號]
            Debug.Log($"<color=#f32>Cards 的第三張卡片：{cards[2]}</color>");
            // 超出陣列範圍，會導致錯誤
            // 錯誤會導致當機、閃退、不符合預期的結果或者不執行錯誤的程式片段

            // 2. Set 設定陣列的資料
            // 陣列名稱[編號] 指定 值;
            // 將寶石海星換成傑尼龜
            deck2[2] = "傑尼龜";
            Debug.Log($"<color=#f39>Deck2 的第三張卡片：{deck2[2]}</color>");
            #endregion

            #region 二維陣列與三維陣列
            // 存取二維陣列
            Debug.Log($"<color=#3f3>編號[0, 1]的道具：{inventory[0, 1]}</color>");
            // 設定金幣為好傷藥
            inventory[1, 1] = "好傷藥";
            Debug.Log($"<color=#3f3>編號[1, 1]的道具：{inventory[1, 1]}</color>");

            // 存取三維陣列
            // 取得屠龍刀
            Debug.Log($"<color=#f3d>第一頁第二排第二個：{shop[0, 1, 1]}</color>");
            // 設定高級球為超級球
            shop[1, 0, 1] = "超級球";
            Debug.Log($"<color=#f3d>第二頁第一排第二個：{shop[1, 0, 1]}</color>");
            #endregion

            #region 陣列長度與維度
            // 獲得陣列的長度或維度
            // 一維 ~ 多維陣列的長度： 陣列名稱.Length
            Debug.Log($"<color=#f93>一維 - 牌組 2 的長度：{deck2.Length}</color>");
            Debug.Log($"<color=#f93>二維 - 道具的長度：{inventory.Length}</color>");
            Debug.Log($"<color=#f93>三維 - 商品的長度：{shop.Length}</color>");
            // 陣列的維度：陣列名稱.Rank
            Debug.Log($"<color=#f93>一維 - 牌組 2 的維度：{deck2.Rank}</color>");
            Debug.Log($"<color=#f93>二維 - 道具的維度：{inventory.Rank}</color>");
            Debug.Log($"<color=#f93>三維 - 商品的維度：{shop.Rank}</color>");
            #endregion

            // 不規則陣列：基本練習
            numbers[0] = new int[] { 1, 3, 5 };
            numbers[1] = new int[] { 9, 8 };

            // 取得數字 3 與 9
            Debug.Log($"<color=#3ff>不規則陣列的數字 3 :{numbers[0][1]}</color>");
            Debug.Log($"<color=#3ff>不規則陣列的數字 9 :{numbers[1][0]}</color>");

            // 將 8 改成 6
            numbers[1][1] = 6;
            Debug.Log($"<color=#3ff>第二列的第二個:{numbers[1][1]}</color>");

            // 不規則陣列：包含多維陣列
            count[0] = new[,] { { 1, 2 }, { 3, 4 } };
            count[1] = new[,] { { 7, 2, 3 }, { 3, 4, 6 } };
            Debug.Log($"<color=#3ff>count 第二列的[0,0]:{count[1][0, 0]}</color>");

        }
    }
}
