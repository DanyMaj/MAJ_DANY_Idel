using TMPro;
using UnityEngine;

public class TimeBuyButton : MonoBehaviour
{

    public GoldManager myGoldManager;
    public int timePrice;
    public int timePower;
    public int timeGoldRiseAmount;
    public TextMeshProUGUI timePowerText;
    public TextMeshProUGUI timePowerPriceText;


    public void LaunchCoroutine()
    {
        if ( myGoldManager.goldAmount >= timePrice)
        {
            myGoldManager.shouldGoldRiseWithTime = true;
            myGoldManager.goldAmount -= timePrice;
            timePrice = Mathf.CeilToInt(timePrice * 2.2f);
            myGoldManager.timeGold += timeGoldRiseAmount;
            timePower += 1;
        }
    }

    private void Update()
    {
        timePowerText.text = timePower.ToString("0");
        timePowerPriceText.text = timePrice.ToString("0");
    }
}
