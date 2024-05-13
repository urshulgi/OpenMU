// <copyright file="UnlockSummonerAtLevel150.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlugIns.UnlockCharacterClass;

using System.Runtime.InteropServices;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Unlocks the Summoner character class as soon as the first character of an account reaches level 150.
/// </summary>
[PlugIn(nameof(UnlockSummonerAtLevel150), "Unlocks the Summoner character class as soon as the first character of an account reaches level 150.")]
[Guid("D25D109F-99BC-4816-B680-530332B417EC")]
public class UnlockSummonerAtLevel150 : UnlockCharacterAtLevelBase
{
    private const byte SummonerNumber = 20;

    /// <summary>
    /// Initializes a new instance of the <see cref="UnlockSummonerAtLevel150"/> class.
    /// </summary>
    public UnlockSummonerAtLevel150()
        : base(SummonerNumber, 150, "Summoner")
    {
    }
}