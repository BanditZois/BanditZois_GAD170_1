using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    // level stats

    public int level;

    public float curXP;

    public int reqXP;

    //character stats

    public float def;

    public float spd;

    public float atk;

    public float maxHP;

    public float curHP;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // the stat values
    public void InitStats(float maxHP = 50f, float def = 5f, float spd = 30f, float atk = 10f, int level = 0, int reqXP = 100, int curXP = 0)
    {

    }

    public void Interaction(float earnedExp)
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GainXP(10)
            return;
        }
    }

    public void GainXP(int gain)
    {
        //gaining xp
        //this is displaying text on the console
        curXP = gain;
        Debug.Log("XP Gained!" + gain);
        return;

    }

    public void LevelUp()
    {
        //where the actually leveling up code is
        if (curXP >= 100)
        {
            // += is adding and setting and = is just seeing to 0 since there's nothing to add
            IncreaseStats();
            level += 1;
            curXP = 0;
        }

    }

    public void IncreaseStats()
    {
        //increasing the stats
        {
            curHP += 10;
            def += 5;
            spd += 2;
            atk += 10;
        }

    }
}
