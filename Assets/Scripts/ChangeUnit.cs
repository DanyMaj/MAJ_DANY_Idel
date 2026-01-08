using UnityEngine;

public class ChangeUnit : MonoBehaviour
{
    public GoldManager myGoldManager;
    public TimeBuyButton myTimeBuyButton;
    private string goldTextTemp;
    private string goldTexttimePowerText;
    private string goldTextpowerTexttimePowerPriceText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myGoldManager.goldAmount >= 1000)
        {
            goldTextTemp = ((float)myGoldManager.goldAmount / 1000f).ToString("0.0K");
        }
        else
        {
            goldTextTemp = myGoldManager.goldAmount.ToString("0");
        }

        if (myGoldManager.goldAmount >= 1000000)
        {
            goldTextTemp = ((float)myGoldManager.goldAmount / 1000000f).ToString("0.0M");
        }

        if (myGoldManager.goldAmount >= 1000000000)
        {
            goldTextTemp = ((float)myGoldManager.goldAmount / 1000000000f).ToString("0.0Md");
        }

        if (myGoldManager.goldAmount >= 1000000000000)
        {
            goldTextTemp = ((float)myGoldManager.goldAmount / 1000000000000f).ToString("0.0Bn");
        }

        if (myGoldManager.goldAmount >= 1000000000000000)
        {
            goldTextTemp = ((float)myGoldManager.goldAmount / 1000000000000000f).ToString("0.0Bd");
        }

        if (myGoldManager.goldAmount >= 1000000000000000000)
        {
            goldTextTemp = ((float)myGoldManager.goldAmount / 1000000000000000000f).ToString("0.0Tn");
        }
    }
}
