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
    void Start()
    {
        calculatingDifficulty = GetComponent<CalculatingDifficulty>();
        float WalkSpeed = calculatingDifficulty.CalculateWalkSpeed(PlayerPrefs.GetInt("DifficultyLevel"));
        PlayerPrefs.SetFloat("WalkSpeed", WalkSpeed);


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



        int CuteBacteriumCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteBacteriumIncreaseAmount, difficultyParametersCharLevelOne.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetInt("CuteBacterium_Density", CuteBacteriumCount);

        int CuteMushyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteMushyIncreaseAmount, difficultyParametersCharLevelOne.CuteMushyDifficultyOne);
        PlayerPrefs.SetInt("CuteMushy_Density", CuteMushyCount);

        int GermSpikeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), GermSpikeIncreaseAmount, difficultyParametersCharLevelOne.GermSpikeDifficultyOne);
        PlayerPrefs.SetInt("GermSpike_Density", GermSpikeCount);

        float AttackGermSpike_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("GermSpike_Health", AttackGermSpike_Health);
        PlayerPrefs.SetFloat("GermSpike_Attack", AttackGermSpike_Health);

        float AttackCuteBacterium_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("CuteBacterium_Health", AttackCuteBacterium_Health);
        PlayerPrefs.SetFloat("CuteBacterium_Attack", AttackCuteBacterium_Health);

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


        int CuteBacteriumCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteBacteriumIncreaseAmount, difficultyParametersCharLevelTwo.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetInt("CuteBacterium_Density", CuteBacteriumCount);

        int CuteMushyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteMushyIncreaseAmount, difficultyParametersCharLevelTwo.CuteMushyDifficultyOne);
        PlayerPrefs.SetInt("CuteMushy_Density", CuteMushyCount);

        int GermSpikeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), GermSpikeIncreaseAmount, difficultyParametersCharLevelTwo.GermSpikeDifficultyOne);
        PlayerPrefs.SetInt("GermSpike_Density", GermSpikeCount);

        int GermSlimeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), GermSlimeIncreaseAmount, difficultyParametersCharLevelTwo.GermSlimeDifficultyOne);
        PlayerPrefs.SetInt("GermSlime_Density", GermSlimeCount);

        float AttackGermSlime_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 2, 1);
        PlayerPrefs.SetFloat("GermSlime_Health", AttackGermSlime_Health);
        PlayerPrefs.SetFloat("GermSlime_Attack", AttackGermSlime_Health);


        float AttackGermSpike_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("GermSpike_Health", AttackGermSpike_Health);
        PlayerPrefs.SetFloat("GermSpike_Attack", AttackGermSpike_Health);


        float AttackCuteBacterium_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("CuteBacterium_Health", AttackCuteBacterium_Health);
        PlayerPrefs.SetFloat("CuteBacterium_Attack", AttackCuteBacterium_Health);
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



        int HelloKittyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), HelloKittyIncreaseAmount, difficultyParametersCharLevelThree.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetInt("HelloKitty_Density", HelloKittyCount);

        int EnemyTop_DensityCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), EnemyTop_DensityAmount, difficultyParametersCharLevelThree.CuteMushyDifficultyOne);
        PlayerPrefs.SetInt("EnemyTop_Density", EnemyTop_DensityCount);

        int CuteBabyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteBabyIncreaseAmount, difficultyParametersCharLevelThree.GermSpikeDifficultyOne);
        PlayerPrefs.SetInt("CuteBaby_Density", CuteBabyCount);

        int GermSlimeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), GermSlimeIncreaseAmount, difficultyParametersCharLevelThree.GermSlimeDifficultyOne);
        PlayerPrefs.SetInt("GermSlime_Density", GermSlimeCount);

        int CuteVirusCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteVirusIncreaseAmount, difficultyParametersCharLevelThree.CuteVirusDifficultyOne);
        PlayerPrefs.SetInt("Vırus_Density", CuteVirusCount);

        float AttackDensisity = calculatingDifficulty.CalculateAttackDensity(PlayerPrefs.GetInt("DifficultyLevel"));
        PlayerPrefs.SetFloat("Virus_Attack_Density", AttackDensisity);
        PlayerPrefs.SetFloat("GermSlime_Attack_Density", AttackDensisity);

        float AttackVirus = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 2, 1);
        PlayerPrefs.SetFloat("Virus_Health", AttackVirus);
        PlayerPrefs.SetFloat("Virus_Attack", AttackVirus);

        float AttackGermSlime_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 2, 1);
        PlayerPrefs.SetFloat("GermSlime_Health", AttackGermSlime_Health);
        PlayerPrefs.SetFloat("GermSlime_Attack", AttackGermSlime_Health);

        float AttackHelloKitty_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("HelloKitty_Health", AttackHelloKitty_Health);
        PlayerPrefs.SetFloat("HelloKitty_Attack", AttackHelloKitty_Health);

        float AttackEnemyTop_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("EnemyTop_Health", AttackEnemyTop_Health);
        PlayerPrefs.SetFloat("EnemyTop_Attack", AttackEnemyTop_Health);

        float AttackCuteBaby_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("CuteBaby_Health", AttackCuteBaby_Health);
        PlayerPrefs.SetFloat("CuteBaby_Attack", AttackCuteBaby_Health);


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



        int HelloKittyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), HelloKittyIncreaseAmount, difficultyParametersCharLevelFour.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetInt("HelloKitty_Density", HelloKittyCount);

        int EnemyTop_DensityCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), EnemyTop_DensityAmount, difficultyParametersCharLevelFour.CuteMushyDifficultyOne);
        PlayerPrefs.SetInt("EnemyTop_Density", EnemyTop_DensityCount);

        int CuteBabyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteBabyIncreaseAmount, difficultyParametersCharLevelFour.GermSpikeDifficultyOne);
        PlayerPrefs.SetInt("CuteBaby_Density", CuteBabyCount);

        int GermSlimeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), GermSlimeIncreaseAmount, difficultyParametersCharLevelFour.GermSlimeDifficultyOne);
        PlayerPrefs.SetInt("GermSlime_Density", GermSlimeCount);

        int CuteVirusCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteVirusIncreaseAmount, difficultyParametersCharLevelFour.CuteVirusDifficultyOne);
        PlayerPrefs.SetInt("Vırus_Density", CuteVirusCount);

        float AttackDensisity = calculatingDifficulty.CalculateAttackDensity(PlayerPrefs.GetInt("DifficultyLevel"));
        PlayerPrefs.SetFloat("Virus_Attack_Density", AttackDensisity);
        PlayerPrefs.SetFloat("GermSlime_Attack_Density", AttackDensisity);

        float AttackVirus = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 2, 1);
        PlayerPrefs.SetFloat("Virus_Health", AttackVirus);
        PlayerPrefs.SetFloat("Virus_Attack", AttackVirus);


        float AttackGermSlime_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 2, 1);
        PlayerPrefs.SetFloat("GermSlime_Health", AttackGermSlime_Health);
        PlayerPrefs.SetFloat("GermSlime_Attack", AttackGermSlime_Health);

        float AttackHelloKitty_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("HelloKitty_Health", AttackHelloKitty_Health);
        PlayerPrefs.SetFloat("HelloKitty_Attack", AttackHelloKitty_Health);

        float AttackEnemyTop_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("EnemyTop_Health", AttackEnemyTop_Health);
        PlayerPrefs.SetFloat("EnemyTop_Attack", AttackEnemyTop_Health);

        float AttackCuteBaby_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 2);
        PlayerPrefs.SetFloat("CuteBaby_Health", AttackCuteBaby_Health);
        PlayerPrefs.SetFloat("CuteBaby_Attack", AttackCuteBaby_Health);

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
            CuteVirusDifficultyTen = 17,

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



        int HelloKittyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), HelloKittyIncreaseAmount, difficultyParametersCharLevelFive.CuteBacteriumDifficultyOne);
        PlayerPrefs.SetInt("HelloKitty_Density", HelloKittyCount);

        int EnemyTop_DensityCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), EnemyTop_DensityAmount, difficultyParametersCharLevelFive.CuteMushyDifficultyOne);
        PlayerPrefs.SetInt("EnemyTop_Density", EnemyTop_DensityCount);

        int CuteBabyCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteBabyIncreaseAmount, difficultyParametersCharLevelFive.GermSpikeDifficultyOne);
        PlayerPrefs.SetInt("CuteBaby_Density", CuteBabyCount);

        int GermSlimeCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), GermSlimeIncreaseAmount, difficultyParametersCharLevelFive.GermSlimeDifficultyOne);
        PlayerPrefs.SetInt("GermSlime_Density", GermSlimeCount);

        int CuteVirusCount = calculatingDifficulty.CalculateEnemyCount(PlayerPrefs.GetInt("DifficultyLevel"), CuteVirusIncreaseAmount, difficultyParametersCharLevelFive.CuteVirusDifficultyOne);
        PlayerPrefs.SetInt("Vırus_Density", CuteVirusCount);

        float AttackDensisity = calculatingDifficulty.CalculateAttackDensity(PlayerPrefs.GetInt("DifficultyLevel"));
        PlayerPrefs.SetFloat("Virus_Attack_Density", AttackDensisity);
        PlayerPrefs.SetFloat("GermSlime_Attack_Density", AttackDensisity);

        float AttackVirus = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 2, 2);
        PlayerPrefs.SetFloat("Virus_Health", AttackVirus);
        PlayerPrefs.SetFloat("Virus_Attack", AttackVirus);

        float AttackGermSlime_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 2, 2);
        PlayerPrefs.SetFloat("GermSlime_Health", AttackGermSlime_Health);
        PlayerPrefs.SetFloat("GermSlime_Attack", AttackGermSlime_Health);

        float AttackHelloKitty_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 3);
        PlayerPrefs.SetFloat("HelloKitty_Health", AttackHelloKitty_Health);
        PlayerPrefs.SetFloat("HelloKitty_Attack", AttackHelloKitty_Health);

        float AttackEnemyTop_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 3);
        PlayerPrefs.SetFloat("EnemyTop_Health", AttackEnemyTop_Health);
        PlayerPrefs.SetFloat("EnemyTop_Attack", AttackEnemyTop_Health);

        float AttackCuteBaby_Health = calculatingDifficulty.CalculateAttackcount(PlayerPrefs.GetInt("DifficultyLevel"), 1, 3, 3);
        PlayerPrefs.SetFloat("CuteBaby_Health", AttackCuteBaby_Health);
        PlayerPrefs.SetFloat("CuteBaby_Attack", AttackCuteBaby_Health);
    }

    public void CalculateDifficultyLevel()
    {
        
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
