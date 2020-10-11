using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Creator_Kit___FPS.Scenes.BurakÇalışma.GameDifficulty.ParamatersAbstrack
{
    interface ICalculate
    {

        float CalculateEnemysIncreaseAmount(float DifficultyOneCount, float DifficultyTenCount);
        int CalculateEnemyCount(float DifficultyLevel, float IncreaseAmount, int DifficultyOneParameter);
    }


}
