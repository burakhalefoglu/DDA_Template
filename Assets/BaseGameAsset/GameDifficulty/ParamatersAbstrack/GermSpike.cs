using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Creator_Kit___FPS.Scenes.BurakÇalışma.GameDifficulty.ParamatersAbstrack
{
    interface IGermSpike
    {
        int GermSpikeDifficultyOne { get; set; }
        int GermSpikeDifficultyTen { get; set; }
        float GermSpikeAttack { get; set; }
        float GermSpikeHealth { get; set; }
        float GermSpikeWalkSpeed { get; set; }
    }
}
