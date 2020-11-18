using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Creator_Kit___FPS.Scenes.BurakÇalışma.GameDifficulty.ParamatersAbstrack
{
    interface ICalculate
    {

        int CalculateEnemysIncreaseAmount(int DifficultyOneCount, int DifficultyTenCount);
        int CalculateEnemyCount(int DifficultyLevel, int IncreaseAmount, int DifficultyOneParameter);
    }


}
