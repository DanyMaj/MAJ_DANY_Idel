using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Runtime.InteropServices;
using NUnit.Framework.Constraints;

public class GoldManager : MonoBehaviour
{
    public float goldAmount;
    public int power;
    public int timeGold;
    public bool shouldGoldRiseWithTime;
    public int powerPrice;
    public int timePower;
    public int timePrice;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI powerPriceText;
    public TextMeshProUGUI timePowerText;
    public TextMeshProUGUI timePowerPriceText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timePower = 0;
        timeGold = 25;
        timePrice = 100;
        power = 0;
        powerPrice = 10;
        StartCoroutine(autoGold());
        
    }

    public void ChangeGold()
    {
        goldAmount += power+1;
    }


    public void LaunchCoroutine()
    {
  
        if (goldAmount >= timePrice)
        {
            shouldGoldRiseWithTime = true;
            goldAmount -= timePrice;
            timePrice = Mathf.CeilToInt(timePrice * 2.2f);
            timeGold = Mathf.CeilToInt(timeGold * 1.1f);
            timePower += 1;
        }
    }

    public void ChangePower()
    {
        if (goldAmount >= powerPrice)
        {
            goldAmount -= powerPrice;
            powerPrice = Mathf.CeilToInt(powerPrice * 2.2f);
            
            power += 1;
        }
    }

    public IEnumerator autoGold()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            if(shouldGoldRiseWithTime)
            {
                goldAmount += timeGold;
            }
        }
    }


    private string goldTextTemp;
    // Update is called once per frame
    void Update()
    {


        if(goldAmount>=1000)
        {
            goldTextTemp = ((float)goldAmount / 1000f).ToString("0.0K");
        }
        else
        {
            goldTextTemp = goldAmount.ToString("0");
        }

        if(goldAmount >= 1000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000f).ToString("0.0M");
        }

        if (goldAmount >= 1000000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000000f).ToString("0.0Md");
        }

        if (goldAmount >= 1000000000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000000000f).ToString("0.0Bn");
        }

        if (goldAmount >= 1000000000000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000000000000f).ToString("0.0Bd");
        }

        if (goldAmount >= 1000000000000000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000000000000000f).ToString("0.0Tn");
        }

        //if (goldAmount >= 1000000000000000000000)
        {
            //goldTextTemp = ((float)goldAmount / 1000000000000000000000f).ToString("0.0Td");
        }

        goldText.text = goldTextTemp;

        powerPriceText.text = powerPrice.ToString("0");
        powerText.text = power.ToString("0");
        timePowerText.text = timePower.ToString("0");
        timePowerPriceText.text = timePrice.ToString("0");
    }

}
