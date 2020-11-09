using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{

    DifficultyParameters difficultyParametersCharLevelOne;
    DifficultyParameters difficultyParametersCharLevelTwo;
    DifficultyParameters difficultyParametersCharLevelThree;
    DifficultyParameters difficultyParametersCharLevelFour;
    DifficultyParameters difficultyParametersCharLevelFive;

    CalculatingDifficulty calculatingDifficulty;
    AskingServerDifficultyLevel askingServerDifficultyLevel;
    void Start()
    {
        calculatingDifficulty = GetComponent<CalculatingDifficulty>();
        askingServerDifficultyLevel = GetComponent<AskingServerDifficultyLevel>();

    }
   
    

    void CharLevelOne()
    {
        difficultyParametersCharLevelOne = new DifficultyParameters()
        {
            CuteBacteriumDifficultyOne = 7,
            CuteBacteriumDifficultyTen = 21,

            CuteMushyDifficultyOne = 4,
            CuteMushyDifficultyTen = 8,

            GermSpikeDifficultyOne = 3,
            GermSpikeDifficultyTen = 24
        };


        float CuteBacteriumIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelOne.CuteBacteriumDifficultyOne,
                                                                                                difficultyParametersCharLevelOne.CuteBacteriumDifficultyTen);

        float CuteMushyIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelOne.CuteMushyDifficultyOne,
                                                                                               difficultyParametersCharLevelOne.CuteMushyDifficultyTen);


        float GermSpikeIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelOne.GermSpikeDifficultyOne,
                                                                                                           difficultyParametersCharLevelOne.GermSpikeDifficultyTen);



        int CuteBacteriumCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteBacteriumIncreaseAmount, difficultyParametersCharLevelOne.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetFloat("CuteBacterium_Density", CuteBacteriumCount);

        int CuteMushyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteMushyIncreaseAmount, difficultyParametersCharLevelOne.CuteMushyDifficultyOne);
        PlayerPrefs.SetFloat("CuteMushy_Density", CuteMushyCount);

        int GermSpikeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), GermSpikeIncreaseAmount, difficultyParametersCharLevelOne.GermSpikeDifficultyOne);
        PlayerPrefs.SetFloat("GermSpike_Density", GermSpikeCount);

    }

    void CharLeveTwo()
    {
        difficultyParametersCharLevelTwo = new DifficultyParameters()
        {
            CuteBacteriumDifficultyOne = 4,
            CuteBacteriumDifficultyTen = 21,

            CuteMushyDifficultyOne = 3,
            CuteMushyDifficultyTen = 6,

            GermSpikeDifficultyOne = 3,
            GermSpikeDifficultyTen = 18,

            GermSlimeDifficultyOne = 2,
            GermSlimeDifficultyTen = 15,

        };


        float CuteBacteriumIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelTwo.CuteBacteriumDifficultyOne,
                                                                                                difficultyParametersCharLevelTwo.CuteBacteriumDifficultyTen);

        float CuteMushyIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelTwo.CuteMushyDifficultyOne,
                                                                                               difficultyParametersCharLevelTwo.CuteMushyDifficultyTen);


        float GermSpikeIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelTwo.GermSpikeDifficultyOne,
                                                                                                           difficultyParametersCharLevelTwo.GermSpikeDifficultyTen);

        float GermSlimeIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelTwo.GermSlimeDifficultyOne,
                                                                                                   difficultyParametersCharLevelTwo.GermSlimeDifficultyTen);


        int CuteBacteriumCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteBacteriumIncreaseAmount, difficultyParametersCharLevelTwo.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetFloat("CuteBacterium_Density", CuteBacteriumCount);

        int CuteMushyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteMushyIncreaseAmount, difficultyParametersCharLevelTwo.CuteMushyDifficultyOne);
        PlayerPrefs.SetFloat("CuteMushy_Density", CuteMushyCount);

        int GermSpikeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), GermSpikeIncreaseAmount, difficultyParametersCharLevelTwo.GermSpikeDifficultyOne);
        PlayerPrefs.SetFloat("GermSpike_Density", GermSpikeCount);

        int GermSlimeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), GermSlimeIncreaseAmount, difficultyParametersCharLevelTwo.GermSlimeDifficultyOne);
        PlayerPrefs.SetFloat("GermSlime_Density", GermSlimeCount);

        int GermSlimeLevel = difficultyParametersCharLevelTwo.GermSlimeLevel;
        PlayerPrefs.SetFloat("GermSlime_Level", GermSlimeLevel);
    }

    void CharlevelThree()
    {

        difficultyParametersCharLevelThree = new DifficultyParameters()
        {
            CuteMushyDifficultyOne = 1,
            CuteMushyDifficultyTen = 3,

            CuteBacteriumDifficultyOne = 4,
            CuteBacteriumDifficultyTen = 9,

            GermSpikeDifficultyOne = 2,
            GermSpikeDifficultyTen = 14,

            GermSlimeDifficultyOne = 3,
            GermSlimeDifficultyTen = 17,

            CuteVirusDifficultyOne = 1,
            CuteVirusDifficultyTen = 14,

            GermSlimeLevel = 1,
            GermSlimeAttackFrequency = 5
        };


        float HelloKittyIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelThree.CuteBacteriumDifficultyOne,
                                                                                                difficultyParametersCharLevelThree.CuteBacteriumDifficultyTen);

        float EnemyTop_DensityAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelThree.CuteMushyDifficultyOne,
                                                                                               difficultyParametersCharLevelThree.CuteMushyDifficultyTen);


        float CuteBabyIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelThree.GermSpikeDifficultyOne,
                                                                                                           difficultyParametersCharLevelThree.GermSpikeDifficultyTen);

        float GermSlimeIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelThree.GermSlimeDifficultyOne,
                                                                                                   difficultyParametersCharLevelThree.GermSlimeDifficultyTen);

        float CuteVirusIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelThree.CuteVirusDifficultyOne,
                                                                                               difficultyParametersCharLevelThree.CuteVirusDifficultyTen);



        int HelloKittyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), HelloKittyIncreaseAmount, difficultyParametersCharLevelThree.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetFloat("HelloKitty_Density", HelloKittyCount);

        int EnemyTop_DensityCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), EnemyTop_DensityAmount, difficultyParametersCharLevelThree.CuteMushyDifficultyOne);
        PlayerPrefs.SetFloat("EnemyTop_Density", EnemyTop_DensityCount);

        int CuteBabyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteBabyIncreaseAmount, difficultyParametersCharLevelThree.GermSpikeDifficultyOne);
        PlayerPrefs.SetFloat("CuteBaby_Density", CuteBabyCount);

        int GermSlimeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), GermSlimeIncreaseAmount, difficultyParametersCharLevelThree.GermSlimeDifficultyOne);
        PlayerPrefs.SetFloat("GermSlime_Density", GermSlimeCount);

        int CuteVirusCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteVirusIncreaseAmount, difficultyParametersCharLevelThree.CuteVirusDifficultyOne);
        PlayerPrefs.SetFloat("Vırus_Density", CuteVirusCount);

        int GermSlimeLevel = difficultyParametersCharLevelThree.GermSlimeLevel;
        PlayerPrefs.SetFloat("GermSlime_Level", GermSlimeLevel);

        int CuteVirusLevel = difficultyParametersCharLevelThree.CuteVirusLevel;
        PlayerPrefs.SetFloat("Vırus_Level", CuteVirusLevel);
    }

    void CharLevelFour()
    {
        difficultyParametersCharLevelFour = new DifficultyParameters()
        {
            CuteMushyDifficultyOne = 1,
            CuteMushyDifficultyTen = 3,

            CuteBacteriumDifficultyOne = 5,
            CuteBacteriumDifficultyTen = 6,

            GermSpikeDifficultyOne = 3,
            GermSpikeDifficultyTen = 15,

            GermSlimeDifficultyOne = 3,
            GermSlimeDifficultyTen = 21,

            CuteVirusDifficultyOne = 1,
            CuteVirusDifficultyTen = 15,

            GermSlimeLevel = 2,
            CuteVirusLevel = 1,
           
            GermSlimeAttackFrequency = 5,
            CuteVirusAttackFrequency =5


        };


        float HelloKittyIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFour.CuteBacteriumDifficultyOne,
                                                                                                difficultyParametersCharLevelFour.CuteBacteriumDifficultyTen);

        float EnemyTop_DensityAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFour.CuteMushyDifficultyOne,
                                                                                                      difficultyParametersCharLevelFour.CuteMushyDifficultyTen);


        float CuteBabyIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFour.GermSpikeDifficultyOne,
                                                                                                         difficultyParametersCharLevelFour.GermSpikeDifficultyTen);

        float GermSlimeIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFour.GermSlimeDifficultyOne,
                                                                                                   difficultyParametersCharLevelFour.GermSlimeDifficultyTen);

        float CuteVirusIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFour.CuteVirusDifficultyOne,
                                                                                               difficultyParametersCharLevelFour.CuteVirusDifficultyTen);



        int HelloKittyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), HelloKittyIncreaseAmount, difficultyParametersCharLevelFour.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetFloat("HelloKitty_Density", HelloKittyCount);

        int EnemyTop_DensityCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), EnemyTop_DensityAmount, difficultyParametersCharLevelFour.CuteMushyDifficultyOne);
        PlayerPrefs.SetFloat("EnemyTop_Density", EnemyTop_DensityCount);

        int CuteBabyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteBabyIncreaseAmount, difficultyParametersCharLevelFour.GermSpikeDifficultyOne);
        PlayerPrefs.SetFloat("CuteBaby_Density", CuteBabyCount);

        int GermSlimeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), GermSlimeIncreaseAmount, difficultyParametersCharLevelFour.GermSlimeDifficultyOne);
        PlayerPrefs.SetFloat("GermSlime_Density", GermSlimeCount);

        int CuteVirusCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteVirusIncreaseAmount, difficultyParametersCharLevelFour.CuteVirusDifficultyOne);
        PlayerPrefs.SetFloat("Vırus_Density", CuteVirusCount);

        int GermSlimeLevel = difficultyParametersCharLevelFour.GermSlimeLevel;
        PlayerPrefs.SetFloat("GermSlime_Level", GermSlimeLevel);

        int CuteVirusLevel = difficultyParametersCharLevelFour.CuteVirusLevel;
        PlayerPrefs.SetFloat("Vırus_Level", CuteVirusLevel);
    }

    void CharLevelFive()
    {
        difficultyParametersCharLevelFive = new DifficultyParameters()
        {
            CuteMushyDifficultyOne = 1,
            CuteMushyDifficultyTen = 3,

            CuteBacteriumDifficultyOne = 4,
            CuteBacteriumDifficultyTen = 9,

            GermSpikeDifficultyOne = 2,
            GermSpikeDifficultyTen = 14,

            GermSlimeDifficultyOne = 3,
            GermSlimeDifficultyTen = 17,

            CuteVirusDifficultyOne = 1,
            CuteVirusDifficultyTen = 144,

            GermSlimeLevel = 2,
            CuteVirusLevel = 2,

            GermSlimeAttackFrequency = 5,
            CuteVirusAttackFrequency = 5

        };


        float HelloKittyIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFive.CuteBacteriumDifficultyOne,
                                                                                               difficultyParametersCharLevelFive.CuteBacteriumDifficultyTen);

        float EnemyTop_DensityAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFive.CuteMushyDifficultyOne,
                                                                                                         difficultyParametersCharLevelFive.CuteMushyDifficultyTen);

        float CuteBabyIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFive.GermSpikeDifficultyOne,
                                                                                                         difficultyParametersCharLevelFive.GermSpikeDifficultyTen);

        float GermSlimeIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFive.GermSlimeDifficultyOne,
                                                                                                   difficultyParametersCharLevelFive.GermSlimeDifficultyTen);

        float CuteVirusIncreaseAmount = calculatingDifficulty.CalculateEnemysIncreaseAmount(difficultyParametersCharLevelFive.CuteVirusDifficultyOne,
                                                                                               difficultyParametersCharLevelFive.CuteVirusDifficultyTen);



        int HelloKittyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), HelloKittyIncreaseAmount, difficultyParametersCharLevelFive.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetFloat("HelloKitty_Density", HelloKittyCount);

        int EnemyTop_DensityCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), EnemyTop_DensityAmount, difficultyParametersCharLevelFive.CuteMushyDifficultyOne);
        PlayerPrefs.SetFloat("EnemyTop_Density", EnemyTop_DensityCount);

        int CuteBabyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteBabyIncreaseAmount, difficultyParametersCharLevelFive.GermSpikeDifficultyOne);
        PlayerPrefs.SetFloat("CuteBaby_Density", CuteBabyCount);

        int GermSlimeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), GermSlimeIncreaseAmount, difficultyParametersCharLevelFive.GermSlimeDifficultyOne);
        PlayerPrefs.SetFloat("GermSlime_Density", GermSlimeCount);

        int CuteVirusCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetFloat("DifficultyLevel"), CuteVirusIncreaseAmount, difficultyParametersCharLevelFive.CuteVirusDifficultyOne);
        PlayerPrefs.SetFloat("Vırus_Density", CuteVirusCount);

        int GermSlimeLevel = difficultyParametersCharLevelFive.GermSlimeLevel;
        PlayerPrefs.SetFloat("GermSlime_Level", GermSlimeLevel);

        int CuteVirusLevel = difficultyParametersCharLevelFive.CuteVirusLevel;
        PlayerPrefs.SetFloat("Vırus_Level", CuteVirusLevel);
    }

    public void CalculateDifficultyLevel(int DifficultyLevel)
    {
        PlayerPrefs.SetFloat("DifficultyLevel", DifficultyLevel);

        Debug.Log("CalculateDifficultyLevel: Çalıştı...: " + PlayerPrefs.GetFloat("CharLevel"));

        switch (PlayerPrefs.GetFloat("CharLevel"))
        {

            case 1:
                CharLevelOne();
                break;

            case 2:
                CharLeveTwo();
                break;

            case 3:
                CharlevelThree();
                break;
            case 4:
                CharLevelFour();
                break;
            case 5:
                CharLevelFive();
                break;

        }
        PlayerPrefs.Save();
    }

   
}
