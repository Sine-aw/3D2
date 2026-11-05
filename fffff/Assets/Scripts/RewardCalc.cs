using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;

    public float expRate = 1.5f;

    [ContextMenu("a")]
    void Time()
    {
        int xmin = playSeconds / 60;
        int hour = xmin / 60;
        int min = xmin % 60;
        int sec = playSeconds % 60;
        Debug.Log("플레이 시간: " + hour + ":" + min + ":" + sec);
    }

    [ContextMenu("b")]
    void Gold()
    {
        int a = gold / members;
        int r = gold % members;
        Debug.Log("1인당 " + a + "G, 리더 보너스 " + r + "G");
    }

    [ContextMenu("c")]
    void Exp()
    {
        int gexp = kills * expPerKill;
        int fexp = gexp * (int)expRate;
        Debug.Log("경험치 " + fexp + "(기본 " + gexp + ")");

        int level = fexp / 100;
        int glvl = 1 + level;
        int rlvl = fexp % 100;
        int nlvl = 100 - rlvl;
        Debug.Log("Lv." + glvl + ", 다음 레벨까지 " + nlvl);
    }

    [ContextMenu("d")]
    void Average()
    {
        float aDam = totalDamage / members;
        Debug.Log("평균 데미지 " + aDam);
    }
}
