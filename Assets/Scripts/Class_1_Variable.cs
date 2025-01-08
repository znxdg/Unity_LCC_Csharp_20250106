//單行註解
/*多行註解
 * 第一行
 * 第二行
 */

// 引用 Unity 遊戲引擎的函式庫
using UnityEngine;

// 修飾詞 類別關鍵字(腳本) 類別名稱(腳本名稱)
public class Class_1_Variable:MonoBehaviour
{
    /*程式內的括號都是成對出現
     * 
     * 變數:會改變的數值，定義一個記憶體空間用來存放資訊
     * 變數語法:
     *  修飾詞 變數資料類型 變數名稱;
     *  資料類型: 告訴記憶體可以放入那些資料
     *  變數名稱:習慣用小寫開頭命名，規則與腳本名稱相同
     *  修飾詞：
     *      公開：允許其他類別存取,顯示在Unity屬性面板上  public
     *      私人：禁止其他類別存取，隱藏在Unity屬性面板上 private (預設)
     */
    public int coin = 500;
    public float style = 2.3f;
    private int leavel = 3;
}

//類別外，程式不寫這
