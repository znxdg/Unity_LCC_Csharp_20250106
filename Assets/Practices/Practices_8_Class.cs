using UnityEngine;

namespace YuCheng
{ 
    /// <summary>
    /// 練習類別
    /// </summary>
    public class Practices_8_Class : MonoBehaviour
    {
        private void Awake()
        {
            Practices_8_BOSS bossDeagon = new Practices_8_BOSS("龍獸", "龍之吐息", 999);
            Practices_8_BOSS bossPig = new Practices_8_BOSS("半獸人", "銀斧斬耀", 540);
            
            Debug.Log($"<color=#f93>{bossDeagon.name}, 招式：{bossDeagon.skill}</color>");
            Debug.Log($"<color=#f93>{bossPig.name}, 招式：{bossPig.skill}</color>");
        }
    }

    /// <summary>
    /// 大魔王類別
    /// </summary>
    public class Practices_8_BOSS
    {
        public string name;
        public string skill;
        public float hp;

        public Practices_8_BOSS(string _name, string _skill, float _hp)
        {
            name = _name;
            skill = _skill;
            hp = _hp;
        }
    }
}
