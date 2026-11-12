using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;
    public int killCount = 3;

    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1;
        int exp = 0;
        int Rexp = 10000;

        exp = killCount * expPerKill;

        if (level < 5)
        {
            while (exp > Rexp)
            {
                exp = exp - Rexp;
                level++;
                Rexp = Rexp + 10000;

                Debug.Log("레벨업! Lv." + level + "(" + killCount + "마리째)");

                return;
            }
        }
        else
        {
            Debug.Log("최종 Lv." + level + ", 경험치 " + exp + "/" + Rexp);
        }

        if (level > 4 && exp > Rexp)
        {
            exp = Rexp;
        }
    }
}