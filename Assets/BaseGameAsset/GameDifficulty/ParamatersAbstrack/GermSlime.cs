using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Creator_Kit___FPS.Scenes.BurakÇalışma.GameDifficulty.ParamatersAbstrack
{
    interface IGermSlime
    {

        int GermSlimeDifficultyOne { get; set; }
        int GermSlimeDifficultyTen { get; set; }
        float GermSlimeAttack { get; set; }
        float GermSlimeHealth { get; set; }
        float GermSlimeAttackDensity { get; set; }
        float GermSlimeWalkSpeed { get; set; }
    }
}
