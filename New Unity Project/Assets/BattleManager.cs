using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject fighterPrefab;
    public int teamSize = 3;
    public string[] fighterNames;
    public GameObject[] teamAFighters;
    public GameObject[] teamBFighters;


    // Start is called before the first frame update
    void Start()
    {
        //Create our teams and call out team generator function
        teamAFighters = CreateTeam(teamAFighters);
        teamBFighters = CreateTeam(teamBFighters);
        //Randomly assign two fighters to go head to head
        GameObject randomA = teamAFighters[Random.Range(0, teamSize)];
        GameObject randomB = teamBFighters[Random.Range(0, teamSize)];
        Battle(randomA, randomB);
    }

    public GameObject[] CreateTeam(GameObject[] incTeam)
    {
        //create team of fighters
        //spawn each fighter and add them to our team
        incTeam = new GameObject[teamSize]; //indexes = 0,1,2
        for (int i = 0; i < teamSize; i++)
        {
            //spawn the fighter (go = game object)
            GameObject go = Instantiate(fighterPrefab);
            //assign to team
            incTeam[i] = go;
            //pick a random name form our array and give it to our fighter also what the fuck
            go.GetComponent<Character>().UpdateName(fighterNames[Random.Range(0, fighterNames.Length)]);
        }
        //because the vairable we pass through is only a copy we need to send this info back
        //from the temp variable incTeam to our actual team variable
        return incTeam;
    }
    
    public void Battle(GameObject fighterA, GameObject fighterB)
    {
        //coin flip simulator (0=heads, 1=tails)
        int coinFlip = Random.Range(0, 2);
        //assign our stats to temporary variables so it's easier to write later
        Character fAStats = fighterA.GetComponent<Character>();
        Character fBStats = fighterB.GetComponent<Character>();
        //Based on our coinflip (replace this with giving the characters a speed stat
        //and compraing whos faster, might still need a coin flip for a tie)
        if(coinFlip == 0)
        {
            //difference in writing it out vs just making variables for it with fB/fAStats
            //fighterB.GetComponent<Character>().health -= fighterA.GetComponent<Character>().attack - fighterB.GetComponent<Character>().defense;

            fBStats.health -= fAStats.attack - fBStats.defense;
            Debug.Log("Fighter A attacks Fighter B!");
            Debug.Log("Fighter B's health is now: " + fBStats.health);
        }
        else
        {
            fAStats.health -= fBStats.attack - fAStats.defense;
            Debug.Log("Fighter B attacks Fighter A!");
            Debug.Log("Fighter A's health is now: " + fAStats.health);
        }
    }
}
